using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Trade.Model;

namespace Trade.DataAccess
{
    public class FundDetailsDal
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(FundDetail model)
        {
            var strSql = new StringBuilder();
            strSql.Append("insert into FundDetail(");
            strSql.Append("SettleDate,BeginRights,InOutMoney,SaleProfitLoss,HoldProfitLoss,Commission,DelayMoney,HoldEmploy,EndRights,RiskRate,UserNo)");
            strSql.Append(" values (");
            strSql.Append("@SettleDate,@BeginRights,@InOutMoney,@SaleProfitLoss,@HoldProfitLoss,@Commission,@DelayMoney,@HoldEmploy,@EndRights,@RiskRate,@UserNo)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@SettleDate", SqlDbType.Date,3),
					new SqlParameter("@BeginRights", SqlDbType.Decimal,9),
					new SqlParameter("@InOutMoney", SqlDbType.Decimal,9),
					new SqlParameter("@SaleProfitLoss", SqlDbType.Decimal,9),
					new SqlParameter("@HoldProfitLoss", SqlDbType.Decimal,9),
					new SqlParameter("@Commission", SqlDbType.Decimal,9),
					new SqlParameter("@DelayMoney", SqlDbType.Decimal,9),
					new SqlParameter("@HoldEmploy", SqlDbType.Decimal,9),
					new SqlParameter("@EndRights", SqlDbType.Decimal,9),
					new SqlParameter("@RiskRate", SqlDbType.NVarChar,10),
                        new SqlParameter("@UserNo", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.SettleDate;
            parameters[1].Value = model.BeginRights;
            parameters[2].Value = model.InOutMoney;
            parameters[3].Value = model.SaleProfitLoss;
            parameters[4].Value = model.HoldProfitLoss;
            parameters[5].Value = model.Commission;
            parameters[6].Value = model.DelayMoney;
            parameters[7].Value = model.HoldEmploy;
            parameters[8].Value = model.EndRights;
            parameters[9].Value = model.RiskRate;
            parameters[10].Value = model.UserNo;

            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            cmd.Parameters.AddRange(parameters);
            return db.ExecuteNonQuery(cmd);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(FundDetail model)
        {
            var strSql = new StringBuilder();
            strSql.Append("update FundDetail set ");
            strSql.Append("SettleDate=@SettleDate,");
            strSql.Append("BeginRights=@BeginRights,");
            strSql.Append("InOutMoney=@InOutMoney,");
            strSql.Append("SaleProfitLoss=@SaleProfitLoss,");
            strSql.Append("HoldProfitLoss=@HoldProfitLoss,");
            strSql.Append("Commission=@Commission,");
            strSql.Append("DelayMoney=@DelayMoney,");
            strSql.Append("HoldEmploy=@HoldEmploy,");
            strSql.Append("EndRights=@EndRights,");
            strSql.Append("RiskRate=@RiskRate,");
            strSql.Append("UserNo=@UserNo");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@SettleDate", SqlDbType.Date,3),
					new SqlParameter("@BeginRights", SqlDbType.Decimal,9),
					new SqlParameter("@InOutMoney", SqlDbType.Decimal,9),
					new SqlParameter("@SaleProfitLoss", SqlDbType.Decimal,9),
					new SqlParameter("@HoldProfitLoss", SqlDbType.Decimal,9),
					new SqlParameter("@Commission", SqlDbType.Decimal,9),
					new SqlParameter("@DelayMoney", SqlDbType.Decimal,9),
					new SqlParameter("@HoldEmploy", SqlDbType.Decimal,9),
					new SqlParameter("@EndRights", SqlDbType.Decimal,9),
					new SqlParameter("@RiskRate", SqlDbType.NVarChar,10),
					new SqlParameter("@ID", SqlDbType.Int,4),
                                        new SqlParameter("@UserNo", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.SettleDate;
            parameters[1].Value = model.BeginRights;
            parameters[2].Value = model.InOutMoney;
            parameters[3].Value = model.SaleProfitLoss;
            parameters[4].Value = model.HoldProfitLoss;
            parameters[5].Value = model.Commission;
            parameters[6].Value = model.DelayMoney;
            parameters[7].Value = model.HoldEmploy;
            parameters[8].Value = model.EndRights;
            parameters[9].Value = model.RiskRate;
            parameters[10].Value = model.ID;
            parameters[11].Value = model.UserNo;

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

            var strSql = new StringBuilder();
            strSql.Append("delete from FundDetail ");
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
            var strSql = new StringBuilder();
            strSql.Append("delete from FundDetail ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public List<FundDetail> GetList(string strWhere, string filedOrder)
        {
            var strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(
                "ID,SettleDate,BeginRights,InOutMoney,SaleProfitLoss,HoldProfitLoss,Commission,DelayMoney,HoldEmploy,EndRights,RiskRate,UserNo  ");
            strSql.Append(" FROM FundDetail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            var list = new List<FundDetail>();
            using (var dr = db.ExecuteReader(cmd))
            {
                while (dr.Read())
                {
                    var model = new FundDetail();
                    if (dr["ID"] != null && dr["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dr["ID"].ToString());
                    }
                    if (dr["SettleDate"] != null && dr["SettleDate"].ToString() != "")
                    {
                        model.SettleDate = DateTime.Parse(dr["SettleDate"].ToString());
                    }
                    if (dr["BeginRights"] != null && dr["BeginRights"].ToString() != "")
                    {
                        model.BeginRights = decimal.Parse(dr["BeginRights"].ToString());
                    }
                    if (dr["InOutMoney"] != null && dr["InOutMoney"].ToString() != "")
                    {
                        model.InOutMoney = decimal.Parse(dr["InOutMoney"].ToString());
                    }
                    if (dr["SaleProfitLoss"] != null && dr["SaleProfitLoss"].ToString() != "")
                    {
                        model.SaleProfitLoss = decimal.Parse(dr["SaleProfitLoss"].ToString());
                    }
                    if (dr["HoldProfitLoss"] != null && dr["HoldProfitLoss"].ToString() != "")
                    {
                        model.HoldProfitLoss = decimal.Parse(dr["HoldProfitLoss"].ToString());
                    }
                    if (dr["Commission"] != null && dr["Commission"].ToString() != "")
                    {
                        model.Commission = decimal.Parse(dr["Commission"].ToString());
                    }
                    if (dr["DelayMoney"] != null && dr["DelayMoney"].ToString() != "")
                    {
                        model.DelayMoney = decimal.Parse(dr["DelayMoney"].ToString());
                    }
                    if (dr["HoldEmploy"] != null && dr["HoldEmploy"].ToString() != "")
                    {
                        model.HoldEmploy = decimal.Parse(dr["HoldEmploy"].ToString());
                    }
                    if (dr["EndRights"] != null && dr["EndRights"].ToString() != "")
                    {
                        model.EndRights = decimal.Parse(dr["EndRights"].ToString());
                    }
                    if (dr["RiskRate"] != null)
                    {
                        model.RiskRate = dr["RiskRate"].ToString();
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
            strSql.Append("delete from FundDetail; ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }
    }
}
