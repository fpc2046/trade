using System;
using System.Data;
using System.Data.Common;
using System.Web;
using Trade.DataAccess;
using Trade.Model;

namespace Trade.Service
{
    internal class LoginService
    {
        private static object appInfoLock = new object();

        private string envName;
        private HttpContext httpContext;

        public LoginService(HttpContext httpContext)
        {
            // TODO: Complete member initialization
            this.httpContext = httpContext;
        }

        internal LoginResult Login(string name, string pwd, string vcode, string envName)
        {
            this.envName = envName;
            LoginResult result = new LoginResult();
            try
            {
                string address = this.httpContext.Request.IsLocal ? "127.0.0.1" : this.httpContext.Request.UserHostAddress;
                DateTime curTime = DateTime.Now;
                LoginResultFlags flags = this.CheckUserPwd(name, pwd, vcode, ref address, ref curTime);
                if (flags == LoginResultFlags.Success)
                {
                    string sessionID = this.httpContext.Session.SessionID;
                    LoginInfo newInfo = new LoginInfo(sessionID, DateTime.Now, name, address);
                    httpContext.Session[ApplicationKey.LoginInfo] = newInfo;
                    this.LoginToApplication(name, newInfo);
                    result.LastAddress = address;
                    result.LastTime = curTime.ToString("yyyy-MM-dd hh:mm:ss");
                }
                result.Result = flags;
            }
            catch
            {
                result.Result = LoginResultFlags.ErrorService;
            }
            return result;
        }

        internal void LoginToApplication(string name, LoginInfo newInfo)
        {
            LoginInfoMany many = this.httpContext.Application[ApplicationKey.LoginMany] as LoginInfoMany;
            if (many == null)
            {
                lock (appInfoLock)
                {
                    if (many == null)
                    {
                        many = new LoginInfoMany();
                        this.httpContext.Application[ApplicationKey.LoginMany] = many;
                    }
                }
            }
            many.Login(name, newInfo);
        }

        internal string ChangedUserPwd(string name, string oldPwd, string newPwd)
        {
            string sql = @"UPDATE [User]
   SET [PassWord] = @newPassWord
 WHERE [UserName] = @userName
 AND [PassWord] = @OldPassWord";
            DbHelper dbHelper = new DbHelper();
            DbCommand command = dbHelper.GetSqlStringCommond(sql);
            dbHelper.AddInParameter(command, "@userName", DbType.String, name);
            dbHelper.AddInParameter(command, "@OldPassWord", DbType.String, oldPwd);
            dbHelper.AddInParameter(command, "@newPassWord", DbType.String, newPwd);
            int num = dbHelper.ExecuteNonQuery(command);
            return num > 0 ? null : "ErrorOLD";
        }

        internal string CheckLoginError(bool checkManyLogin = false)
        {
            LoginInfo loginInfo = this.httpContext.Session[ApplicationKey.LoginInfo] as LoginInfo;
            LoginInfoMany loginMany = this.httpContext.Application[ApplicationKey.LoginMany] as LoginInfoMany;
            if (loginInfo == null)
            {
                return "请先登录";
            }

            if (checkManyLogin && loginMany != null)
            {
                bool isManyLogin = loginMany.IsLogin(loginInfo.UserName, this.httpContext.Session.SessionID);
                if (isManyLogin)
                {
                    return "账号已在别处登录";
                }
            }
            return null;
        }

        private LoginResultFlags CheckUserPwd(string name, string pwd, string vcode, ref string address, ref DateTime curTime)
        {
            DataTable dt = GetUserInfo(name);

            if (dt != null && dt.Rows.Count > 0)
            {
                int loginNum = Convert.ToInt32(dt.Rows[0]["LoginNum"]);
                int status = Convert.ToInt32(dt.Rows[0]["Status"]);
                string passWord = dt.Rows[0]["PassWord"].ToString();
                string lastAddress = dt.Rows[0]["LastAddress"].ToString();
                DateTime lastTime = TryToDateTime(dt.Rows[0]["LastLoginTime"]);

                if (this.envName.Contains("模拟盘"))
                {
                    return LoginResultFlags.ErrorName;
                }
                if (status != 0)
                {
                    return LoginResultFlags.ErrorName;
                }
                if (passWord != pwd)
                {
                    return LoginResultFlags.ErrorPWD;
                }

                UpdateUserInfo(name, address, curTime, loginNum);
                address = lastAddress;
                curTime = lastTime;

                return LoginResultFlags.Success;
            }
            return LoginResultFlags.NullUser;
        }

        private static DateTime TryToDateTime(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return DateTime.Now;
            }
            return Convert.ToDateTime(value);
        }

        private static DataTable GetUserInfo(string name)
        {
            string sql = "select T.ID,T.UserName,T.PassWord,T.LastAddress,T.LastLoginTime,T.LoginNum,T.Status from [User] T where T.UserName=@UserName";
            DbHelper dbHelper = new DbHelper();
            DbCommand command = dbHelper.GetSqlStringCommond(sql);
            dbHelper.AddInParameter(command, "@UserName", DbType.String, name);
            DataTable dt = dbHelper.ExecuteDataTable(command);
            return dt;
        }

        private static int UpdateUserInfo(string name, string lastAddress, DateTime lastTime, int loginNum)
        {
            string sql = "UPDATE [User] SET [LastAddress] = @address ,[LastLoginTime] = @LastTime ,[LoginNum] =@LoginNum WHERE [UserName]=@userName";
            DbHelper dbHelper = new DbHelper();
            DbCommand command = dbHelper.GetSqlStringCommond(sql);
            dbHelper.AddInParameter(command, "@userName", DbType.String, name);
            dbHelper.AddInParameter(command, "@address", DbType.String, lastAddress);
            dbHelper.AddInParameter(command, "@LastTime", DbType.DateTime, lastTime);
            dbHelper.AddInParameter(command, "@LoginNum", DbType.Int32, ++loginNum);
            return dbHelper.ExecuteNonQuery(command);
        }


    }
}