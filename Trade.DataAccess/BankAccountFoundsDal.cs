using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Trade.Model;

namespace Trade.DataAccess
{
    public class BankAccountFoundsDal
    {

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(BankAccountFound model)
        {
            var strSql = new StringBuilder();
            strSql.Append("insert into BankAccountFound(");
            strSql.Append("LoginName,Account,BankName,AccountProperty,QCQY,DRCRJ,DQZDKCJE,ZTZJ)");
            strSql.Append(" values (");
            strSql.Append("@LoginName,@Account,@BankName,@AccountProperty,@QCQY,@DRCRJ,@DQZDKCJE,@ZTZJ)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@LoginName", SqlDbType.VarChar,50),
					new SqlParameter("@Account", SqlDbType.VarChar,50),
					new SqlParameter("@BankName", SqlDbType.VarChar,50),
					new SqlParameter("@AccountProperty", SqlDbType.VarChar,50),
					new SqlParameter("@QCQY", SqlDbType.Decimal,9),
					new SqlParameter("@DRCRJ", SqlDbType.Decimal,9),
					new SqlParameter("@DQZDKCJE", SqlDbType.Decimal,9),
					new SqlParameter("@ZTZJ", SqlDbType.Decimal,9)};
            parameters[0].Value = model.LoginName;
            parameters[1].Value = model.Account;
            parameters[2].Value = model.BankName;
            parameters[3].Value = model.AccountProperty;
            parameters[4].Value = model.QCQY;
            parameters[5].Value = model.DRCRJ;
            parameters[6].Value = model.DQZDKCJE;
            parameters[7].Value = model.ZTZJ;

            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            cmd.Parameters.AddRange(parameters);
            return db.ExecuteNonQuery(cmd);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(BankAccountFound model)
        {
            var strSql = new StringBuilder();
            strSql.Append("update BankAccountFound set ");
            strSql.Append("LoginName=@LoginName,");
            strSql.Append("Account=@Account,");
            strSql.Append("BankName=@BankName,");
            strSql.Append("AccountProperty=@AccountProperty,");
            strSql.Append("QCQY=@QCQY,");
            strSql.Append("DRCRJ=@DRCRJ,");
            strSql.Append("DQZDKCJE=@DQZDKCJE,");
            strSql.Append("ZTZJ=@ZTZJ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@LoginName", SqlDbType.VarChar,50),
					new SqlParameter("@Account", SqlDbType.VarChar,50),
					new SqlParameter("@BankName", SqlDbType.VarChar,50),
					new SqlParameter("@AccountProperty", SqlDbType.VarChar,50),
					new SqlParameter("@QCQY", SqlDbType.Decimal,9),
					new SqlParameter("@DRCRJ", SqlDbType.Decimal,9),
					new SqlParameter("@DQZDKCJE", SqlDbType.Decimal,9),
					new SqlParameter("@ZTZJ", SqlDbType.Decimal,9),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.LoginName;
            parameters[1].Value = model.Account;
            parameters[2].Value = model.BankName;
            parameters[3].Value = model.AccountProperty;
            parameters[4].Value = model.QCQY;
            parameters[5].Value = model.DRCRJ;
            parameters[6].Value = model.DQZDKCJE;
            parameters[7].Value = model.ZTZJ;
            parameters[8].Value = model.ID;

            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            cmd.Parameters.AddRange(parameters);
            return db.ExecuteNonQuery(cmd) > 0;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
        {

            var strSql = new StringBuilder();
            strSql.Append("delete from BankAccountFound ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            cmd.Parameters.AddRange(parameters);
            return db.ExecuteNonQuery(cmd) > 0;
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string dlist)
        {
            var strSql = new StringBuilder();
            strSql.Append("delete from BankAccountFound ");
            strSql.Append(" where ID in (" + dlist + ")  ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }


        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public List<BankAccountFound> GetList(string strWhere, string filedOrder)
        {
            var strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(
                " ID,LoginName,Account,BankName,AccountProperty,QCQY,DRCRJ,DQZDKCJE,ZTZJ from BankAccountFound ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            var list = new List<BankAccountFound>();
            using (var dr = db.ExecuteReader(cmd))
            {
                while (dr.Read())
                {
                    var model = new BankAccountFound();
                    if (dr["ID"] != null && dr["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dr["ID"].ToString());
                    }
                    if (dr["LoginName"] != null)
                    {
                        model.LoginName = dr["LoginName"].ToString();
                    }
                    if (dr["Account"] != null)
                    {
                        model.Account = dr["Account"].ToString();
                    }
                    if (dr["BankName"] != null)
                    {
                        model.BankName = dr["BankName"].ToString();
                    }
                    if (dr["AccountProperty"] != null)
                    {
                        model.AccountProperty = dr["AccountProperty"].ToString();
                    }
                    if (dr["QCQY"] != null && dr["QCQY"].ToString() != "")
                    {
                        model.QCQY = decimal.Parse(dr["QCQY"].ToString());
                    }
                    if (dr["DRCRJ"] != null && dr["DRCRJ"].ToString() != "")
                    {
                        model.DRCRJ = decimal.Parse(dr["DRCRJ"].ToString());
                    }
                    if (dr["DQZDKCJE"] != null && dr["DQZDKCJE"].ToString() != "")
                    {
                        model.DQZDKCJE = decimal.Parse(dr["DQZDKCJE"].ToString());
                    }
                    if (dr["ZTZJ"] != null && dr["ZTZJ"].ToString() != "")
                    {
                        model.ZTZJ = decimal.Parse(dr["ZTZJ"].ToString());
                    }
                    list.Add(model);
                }
            }
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Clean()
        {
            var strSql = new StringBuilder();
            strSql.Append("delete from BankAccountFound; ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }
    }
}
