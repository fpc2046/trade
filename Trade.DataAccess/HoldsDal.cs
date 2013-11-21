using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Trade.Model;

namespace Trade.DataAccess
{
    public class HoldsDal
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hold model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Holds(");
            strSql.Append("SettleDate,Goods,HoldNo,HoldAmount,HoldPrice,BuyPrice,DealPrice,HoldProfitLoss,HoldBailRate,HoldEmploy,DelayMoney,CreateTime,CreateNo,Direction,UserNo)");
            strSql.Append(" values (");
            strSql.Append("@SettleDate,@Goods,@HoldNo,@HoldAmount,@HoldPrice,@BuyPrice,@DealPrice,@HoldProfitLoss,@HoldBailRate,@HoldEmploy,@DelayMoney,@CreateTime,@CreateNo,@Direction,@UserNo)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@SettleDate", SqlDbType.Date,3),
					new SqlParameter("@Goods", SqlDbType.NVarChar,50),
					new SqlParameter("@HoldNo", SqlDbType.NVarChar,50),
					new SqlParameter("@HoldAmount", SqlDbType.Decimal,9),
					new SqlParameter("@HoldPrice", SqlDbType.Decimal,9),
					new SqlParameter("@BuyPrice", SqlDbType.Decimal,9),
					new SqlParameter("@DealPrice", SqlDbType.Decimal,9),
					new SqlParameter("@HoldProfitLoss", SqlDbType.Decimal,9),
					new SqlParameter("@HoldBailRate", SqlDbType.Decimal,9),
					new SqlParameter("@HoldEmploy", SqlDbType.Decimal,9),
					new SqlParameter("@DelayMoney", SqlDbType.Decimal,9),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@CreateNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Direction", SqlDbType.NVarChar,2),
                     new SqlParameter("@UserNo", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.SettleDate;
            parameters[1].Value = model.Goods;
            parameters[2].Value = model.HoldNo;
            parameters[3].Value = model.HoldAmount;
            parameters[4].Value = model.HoldPrice;
            parameters[5].Value = model.BuyPrice;
            parameters[6].Value = model.DealPrice;
            parameters[7].Value = model.HoldProfitLoss;
            parameters[8].Value = model.HoldBailRate;
            parameters[9].Value = model.HoldEmploy;
            parameters[10].Value = model.DelayMoney;
            parameters[11].Value = model.CreateTime;
            parameters[12].Value = model.CreateNo;
            parameters[13].Value = model.Direction;
            parameters[14].Value = model.UserNo;

            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            cmd.Parameters.AddRange(parameters);
            return db.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Hold model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Holds set ");
            strSql.Append("SettleDate=@SettleDate,");
            strSql.Append("Goods=@Goods,");
            strSql.Append("HoldNo=@HoldNo,");
            strSql.Append("HoldAmount=@HoldAmount,");
            strSql.Append("HoldPrice=@HoldPrice,");
            strSql.Append("BuyPrice=@BuyPrice,");
            strSql.Append("DealPrice=@DealPrice,");
            strSql.Append("HoldProfitLoss=@HoldProfitLoss,");
            strSql.Append("HoldBailRate=@HoldBailRate,");
            strSql.Append("HoldEmploy=@HoldEmploy,");
            strSql.Append("DelayMoney=@DelayMoney,");
            strSql.Append("CreateTime=@CreateTime,");
            strSql.Append("CreateNo=@CreateNo,");
            strSql.Append("Direction=@Direction,");
            strSql.Append("UserNo=@UserNo");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@SettleDate", SqlDbType.Date,3),
					new SqlParameter("@Goods", SqlDbType.NVarChar,50),
					new SqlParameter("@HoldNo", SqlDbType.NVarChar,50),
					new SqlParameter("@HoldAmount", SqlDbType.Decimal,9),
					new SqlParameter("@HoldPrice", SqlDbType.Decimal,9),
					new SqlParameter("@BuyPrice", SqlDbType.Decimal,9),
					new SqlParameter("@DealPrice", SqlDbType.Decimal,9),
					new SqlParameter("@HoldProfitLoss", SqlDbType.Decimal,9),
					new SqlParameter("@HoldBailRate", SqlDbType.Decimal,9),
					new SqlParameter("@HoldEmploy", SqlDbType.Decimal,9),
					new SqlParameter("@DelayMoney", SqlDbType.Decimal,9),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@CreateNo", SqlDbType.NVarChar,50),
					new SqlParameter("@Direction", SqlDbType.NVarChar,2),
					new SqlParameter("@ID", SqlDbType.Int,4),
                                        new SqlParameter("@UserNo", SqlDbType.NVarChar,50),};
            parameters[0].Value = model.SettleDate;
            parameters[1].Value = model.Goods;
            parameters[2].Value = model.HoldNo;
            parameters[3].Value = model.HoldAmount;
            parameters[4].Value = model.HoldPrice;
            parameters[5].Value = model.BuyPrice;
            parameters[6].Value = model.DealPrice;
            parameters[7].Value = model.HoldProfitLoss;
            parameters[8].Value = model.HoldBailRate;
            parameters[9].Value = model.HoldEmploy;
            parameters[10].Value = model.DelayMoney;
            parameters[11].Value = model.CreateTime;
            parameters[12].Value = model.CreateNo;
            parameters[13].Value = model.Direction;
            parameters[14].Value = model.ID;
            parameters[15].Value = model.UserNo;
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
            strSql.Append("delete from Holds ");
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
            strSql.Append("delete from Holds ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public List<Hold> GetList(string strWhere, string filedOrder)
        {
            var strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(
                "ID,SettleDate,Goods,HoldNo,HoldAmount,HoldPrice,BuyPrice,DealPrice,HoldProfitLoss,HoldBailRate,HoldEmploy,DelayMoney,CreateTime,CreateNo,Direction,UserNo ");
            strSql.Append(" FROM Holds ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            var list = new List<Hold>();
            using (var dr = db.ExecuteReader(cmd))
            {
                while (dr.Read())
                {
                    var model = new Hold();
                    if (dr["ID"] != null && dr["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dr["ID"].ToString());
                    }
                    if (dr["SettleDate"] != null && dr["SettleDate"].ToString() != "")
                    {
                        model.SettleDate = DateTime.Parse(dr["SettleDate"].ToString());
                    }
                    if (dr["Goods"] != null)
                    {
                        model.Goods = dr["Goods"].ToString();
                    }
                    if (dr["HoldNo"] != null)
                    {
                        model.HoldNo = dr["HoldNo"].ToString();
                    }
                    if (dr["HoldAmount"] != null && dr["HoldAmount"].ToString() != "")
                    {
                        model.HoldAmount = decimal.Parse(dr["HoldAmount"].ToString());
                    }
                    if (dr["HoldPrice"] != null && dr["HoldPrice"].ToString() != "")
                    {
                        model.HoldPrice = decimal.Parse(dr["HoldPrice"].ToString());
                    }
                    if (dr["BuyPrice"] != null && dr["BuyPrice"].ToString() != "")
                    {
                        model.BuyPrice = decimal.Parse(dr["BuyPrice"].ToString());
                    }
                    if (dr["DealPrice"] != null && dr["DealPrice"].ToString() != "")
                    {
                        model.DealPrice = decimal.Parse(dr["DealPrice"].ToString());
                    }
                    if (dr["HoldProfitLoss"] != null && dr["HoldProfitLoss"].ToString() != "")
                    {
                        model.HoldProfitLoss = decimal.Parse(dr["HoldProfitLoss"].ToString());
                    }
                    if (dr["HoldBailRate"] != null && dr["HoldBailRate"].ToString() != "")
                    {
                        model.HoldBailRate = decimal.Parse(dr["HoldBailRate"].ToString());
                    }
                    if (dr["HoldEmploy"] != null && dr["HoldEmploy"].ToString() != "")
                    {
                        model.HoldEmploy = decimal.Parse(dr["HoldEmploy"].ToString());
                    }
                    if (dr["DelayMoney"] != null && dr["DelayMoney"].ToString() != "")
                    {
                        model.DelayMoney = decimal.Parse(dr["DelayMoney"].ToString());
                    }
                    if (dr["CreateTime"] != null && dr["CreateTime"].ToString() != "")
                    {
                        model.CreateTime = DateTime.Parse(dr["CreateTime"].ToString());
                    }
                    if (dr["CreateNo"] != null)
                    {
                        model.CreateNo = dr["CreateNo"].ToString();
                    }
                    if (dr["Direction"] != null)
                    {
                        model.Direction = dr["Direction"].ToString();
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
            strSql.Append("delete from Holds; ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }
    }
}
