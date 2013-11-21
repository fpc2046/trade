using System.Collections.Generic;

namespace Trade.Model
{
    public class LoginInfoMany
    {
        private Dictionary<string, LoginInfo> logindic = new Dictionary<string, LoginInfo>();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name"></param>
        /// <param name="info"></param>
        public void Login(string name, LoginInfo info)
        {
            lock (logindic)
            {
                logindic[name] = info;
            }
        }

        /// <summary>
        /// 获取用户是否有新的登录信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sessionid"></param>
        /// <returns></returns>
        public bool IsLogin(string name, string sessionid)
        {
            lock (logindic)
            {
                LoginInfo dicSession = null;
                if (this.logindic.TryGetValue(name, out dicSession))
                {
                    return dicSession.SessionID != sessionid;
                }
            }
            return false;
        }

        /// <summary>
        /// 获取全部登录用户
        /// </summary>
        /// <returns></returns>
        public LoginInfo[] GetAllUser()
        {
            lock (this.logindic)
            {
                var arrs = new LoginInfo[logindic.Values.Count];
                int index = 0;
                foreach (var info in logindic)
                {
                    arrs[index] = info.Value;
                    index++;
                }
                return arrs;
            }
        }
    }
}