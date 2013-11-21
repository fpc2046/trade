using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Trade.Model;

namespace Trade.DataAccess
{
    /// <summary>
    /// 出入金流水表
    /// </summary>
    public class FundFlowsDal
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FundFlow model)
        {
            var strSql = new StringBuilder();
            strSql.Append("insert into FundFlows(");
            strSql.Append("LoginName,FlowID,HappenTime,BankName,OutFund,InFund,Status,Remark)");
            strSql.Append(" values (");
            strSql.Append("@LoginName,@FlowID,@HappenTime,@BankName,@OutFund,@InFund,@Status,@Remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@LoginName", SqlDbType.VarChar,50),
					new SqlParameter("@FlowID", SqlDbType.Int,4),
					new SqlParameter("@HappenTime", SqlDbType.DateTime),
					new SqlParameter("@BankName", SqlDbType.VarChar,50),
					new SqlParameter("@OutFund", SqlDbType.Decimal,9),
					new SqlParameter("@InFund", SqlDbType.Decimal,9),
					new SqlParameter("@Status", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,100)};
            parameters[0].Value = model.LoginName;
            parameters[1].Value = model.FlowID;
            parameters[2].Value = model.HappenTime;
            parameters[3].Value = model.BankName;
            parameters[4].Value = model.OutFund;
            parameters[5].Value = model.InFund;
            parameters[6].Value = model.Status;
            parameters[7].Value = model.Remark;

            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            cmd.Parameters.AddRange(parameters);
            return db.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FundFlow model)
        {
            var strSql = new StringBuilder();
            strSql.Append("update FundFlows set ");
            strSql.Append("LoginName=@LoginName,");
            strSql.Append("FlowID=@FlowID,");
            strSql.Append("HappenTime=@HappenTime,");
            strSql.Append("BankName=@BankName,");
            strSql.Append("OutFund=@OutFund,");
            strSql.Append("InFund=@InFund,");
            strSql.Append("Status=@Status,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@LoginName", SqlDbType.VarChar,50),
					new SqlParameter("@FlowID", SqlDbType.Int,4),
					new SqlParameter("@HappenTime", SqlDbType.DateTime),
					new SqlParameter("@BankName", SqlDbType.VarChar,50),
					new SqlParameter("@OutFund", SqlDbType.Decimal,9),
					new SqlParameter("@InFund", SqlDbType.Decimal,9),
					new SqlParameter("@Status", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,100),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.LoginName;
            parameters[1].Value = model.FlowID;
            parameters[2].Value = model.HappenTime;
            parameters[3].Value = model.BankName;
            parameters[4].Value = model.OutFund;
            parameters[5].Value = model.InFund;
            parameters[6].Value = model.Status;
            parameters[7].Value = model.Remark;
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
            strSql.Append("delete from FundFlows ");
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
            strSql.Append("delete from FundFlows ");
            strSql.Append(" where ID in (" + dlist + ")  ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="filedOrder"></param>
        /// <returns></returns>
        public List<FundFlow> GetList(string strWhere, string filedOrder)
        {
            var strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(
                " ID,LoginName,FlowID,HappenTime,BankName,OutFund,InFund,Status,Remark from FundFlows  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            var list = new List<FundFlow>();
            using (var dr = db.ExecuteReader(cmd))
            {
                while (dr.Read())
                {
                    var model = new FundFlow();
                    if (dr["ID"] != null && dr["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dr["ID"].ToString());
                    }
                    if (dr["LoginName"] != null)
                    {
                        model.LoginName = dr["LoginName"].ToString();
                    }
                    if (dr["FlowID"] != null && dr["FlowID"].ToString() != "")
                    {
                        model.FlowID = int.Parse(dr["FlowID"].ToString());
                    }
                    if (dr["HappenTime"] != null && dr["HappenTime"].ToString() != "")
                    {
                        model.HappenTime = DateTime.Parse(dr["HappenTime"].ToString());
                    }
                    if (dr["BankName"] != null)
                    {
                        model.BankName = dr["BankName"].ToString();
                    }
                    if (dr["OutFund"] != null && dr["OutFund"].ToString() != "")
                    {
                        model.OutFund = decimal.Parse(dr["OutFund"].ToString());
                    }
                    if (dr["InFund"] != null && dr["InFund"].ToString() != "")
                    {
                        model.InFund = decimal.Parse(dr["InFund"].ToString());
                    }
                    if (dr["Status"] != null)
                    {
                        model.Status = dr["Status"].ToString();
                    }
                    if (dr["Remark"] != null)
                    {
                        model.Remark = dr["Remark"].ToString();
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
            strSql.Append("delete from FundFlows; ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }
    }
}
