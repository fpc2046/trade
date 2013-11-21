using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Trade.Model;

namespace Trade.DataAccess
{
    public class FundsDal
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Fund model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Funds(");
            strSql.Append("SettleDate,No,ChangeMoney,ChangedMoney,RelevanceNo,CType,CTime,UserNo)");
            strSql.Append(" values (");
            strSql.Append("@SettleDate,@No,@ChangeMoney,@ChangedMoney,@RelevanceNo,@CType,@CTime,@UserNo)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@SettleDate", SqlDbType.Date,3),
					new SqlParameter("@No", SqlDbType.NVarChar,50),
					new SqlParameter("@ChangeMoney", SqlDbType.Decimal,9),
					new SqlParameter("@ChangedMoney", SqlDbType.Decimal,9),
					new SqlParameter("@RelevanceNo", SqlDbType.NVarChar,50),
					new SqlParameter("@CType", SqlDbType.NVarChar,50),
					new SqlParameter("@CTime", SqlDbType.DateTime),
                                        new SqlParameter("@UserNo", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.SettleDate;
            parameters[1].Value = model.No;
            parameters[2].Value = model.ChangeMoney;
            parameters[3].Value = model.ChangedMoney;
            parameters[4].Value = model.RelevanceNo;
            parameters[5].Value = model.CType;
            parameters[6].Value = model.CTime;
            parameters[7].Value = model.UserNo;

            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            cmd.Parameters.AddRange(parameters);
            return db.ExecuteNonQuery(cmd);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Fund model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Funds set ");
            strSql.Append("SettleDate=@SettleDate,");
            strSql.Append("No=@No,");
            strSql.Append("ChangeMoney=@ChangeMoney,");
            strSql.Append("ChangedMoney=@ChangedMoney,");
            strSql.Append("RelevanceNo=@RelevanceNo,");
            strSql.Append("CType=@CType,");
            strSql.Append("CTime=@CTime,");
            strSql.Append("UserNo=@UserNo");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@SettleDate", SqlDbType.Date,3),
					new SqlParameter("@No", SqlDbType.NVarChar,50),
					new SqlParameter("@ChangeMoney", SqlDbType.Decimal,9),
					new SqlParameter("@ChangedMoney", SqlDbType.Decimal,9),
					new SqlParameter("@RelevanceNo", SqlDbType.NVarChar,50),
					new SqlParameter("@CType", SqlDbType.NVarChar,50),
					new SqlParameter("@CTime", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4),
                                        	new SqlParameter("@UserNo", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.SettleDate;
            parameters[1].Value = model.No;
            parameters[2].Value = model.ChangeMoney;
            parameters[3].Value = model.ChangedMoney;
            parameters[4].Value = model.RelevanceNo;
            parameters[5].Value = model.CType;
            parameters[6].Value = model.CTime;
            parameters[7].Value = model.ID;
            parameters[8].Value = model.UserNo;

            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            cmd.Parameters.AddRange(parameters);
            return db.ExecuteNonQuery(cmd) > 0;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Funds ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            cmd.Parameters.AddRange(parameters);
            return db.ExecuteNonQuery(cmd) > 0;
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Funds ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }

        public List<Fund> GetList(string strWhere, string filedOrder)
        {
            var strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(
                "ID,SettleDate,No,ChangeMoney,ChangedMoney,RelevanceNo,CType,CTime,UserNo  ");
            strSql.Append(" FROM Funds ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            var list = new List<Fund>();
            using (var dr = db.ExecuteReader(cmd))
            {
                while (dr.Read())
                {
                    var model = new Fund();

                    if (dr["ID"] != null && dr["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dr["ID"].ToString());
                    }
                    if (dr["SettleDate"] != null && dr["SettleDate"].ToString() != "")
                    {
                        model.SettleDate = DateTime.Parse(dr["SettleDate"].ToString());
                    }
                    if (dr["No"] != null)
                    {
                        model.No = dr["No"].ToString();
                    }
                    if (dr["ChangeMoney"] != null && dr["ChangeMoney"].ToString() != "")
                    {
                        model.ChangeMoney = decimal.Parse(dr["ChangeMoney"].ToString());
                    }
                    if (dr["ChangedMoney"] != null && dr["ChangedMoney"].ToString() != "")
                    {
                        model.ChangedMoney = decimal.Parse(dr["ChangedMoney"].ToString());
                    }
                    if (dr["RelevanceNo"] != null)
                    {
                        model.RelevanceNo = dr["RelevanceNo"].ToString();
                    }
                    if (dr["CType"] != null)
                    {
                        model.CType = dr["CType"].ToString();
                    }
                    if (dr["CTime"] != null && dr["CTime"].ToString() != "")
                    {
                        model.CTime = DateTime.Parse(dr["CTime"].ToString());
                    }
                    if (dr["UserNo"] != null)
                    {
                        model.UserNo = dr["UserNo"].ToString();
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
            strSql.Append("delete from Funds;");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }
    }
}
