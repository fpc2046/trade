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
    /// 
    /// </summary>
    public class DealsDal
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Deal model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Deals(");
            strSql.Append("SettleDate,DealNo,Goods,DealAmount,DealPrice,DealMoney,Commission,DealTime,Direction,UserNo)");
            strSql.Append(" values (");
            strSql.Append(
                "@SettleDate,@DealNo,@Goods,@DealAmount,@DealPrice,@DealMoney,@Commission,@DealTime,@Direction,@UserNo)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters =
                {
                    new SqlParameter("@SettleDate", SqlDbType.DateTime),
                    new SqlParameter("@DealNo", SqlDbType.NVarChar, 50),
                    new SqlParameter("@Goods", SqlDbType.NVarChar, 50),
                    new SqlParameter("@DealAmount", SqlDbType.Int, 4),
                    new SqlParameter("@DealPrice", SqlDbType.Decimal, 9),
                    new SqlParameter("@DealMoney", SqlDbType.Decimal, 9),
                    new SqlParameter("@Commission", SqlDbType.Decimal, 9),
                    new SqlParameter("@DealTime", SqlDbType.DateTime),
                    new SqlParameter("@Direction", SqlDbType.NVarChar, 10),
                    new SqlParameter("@UserNo", SqlDbType.NVarChar, 50)
                };
            parameters[0].Value = model.SettleDate;
            parameters[1].Value = model.DealNo;
            parameters[2].Value = model.Goods;
            parameters[3].Value = model.DealAmount;
            parameters[4].Value = model.DealPrice;
            parameters[5].Value = model.DealMoney;
            parameters[6].Value = model.Commission;
            parameters[7].Value = model.DealTime;
            parameters[8].Value = model.Direction;
            parameters[9].Value = model.UserNo;

            DbHelper db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            cmd.Parameters.AddRange(parameters);
            return db.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Deal model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Deals set ");
            strSql.Append("SettleDate=@SettleDate,");
            strSql.Append("DealNo=@DealNo,");
            strSql.Append("Goods=@Goods,");
            strSql.Append("DealAmount=@DealAmount,");
            strSql.Append("DealPrice=@DealPrice,");
            strSql.Append("DealMoney=@DealMoney,");
            strSql.Append("Commission=@Commission,");
            strSql.Append("DealTime=@DealTime,");
            strSql.Append("Direction=@Direction");
            strSql.Append("UserNo=@UserNo");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters =
                {
                    new SqlParameter("@SettleDate", SqlDbType.DateTime),
                    new SqlParameter("@DealNo", SqlDbType.NVarChar, 50),
                    new SqlParameter("@Goods", SqlDbType.NVarChar, 50),
                    new SqlParameter("@DealAmount", SqlDbType.Int, 4),
                    new SqlParameter("@DealPrice", SqlDbType.Decimal, 9),
                    new SqlParameter("@DealMoney", SqlDbType.Decimal, 9),
                    new SqlParameter("@Commission", SqlDbType.Decimal, 9),
                    new SqlParameter("@DealTime", SqlDbType.DateTime),
                    new SqlParameter("@Direction", SqlDbType.NVarChar, 10),
                    new SqlParameter("@ID", SqlDbType.Int, 4),
                      new SqlParameter("@UserNo", SqlDbType.NVarChar, 50),
                };
            parameters[0].Value = model.SettleDate;
            parameters[1].Value = model.DealNo;
            parameters[2].Value = model.Goods;
            parameters[3].Value = model.DealAmount;
            parameters[4].Value = model.DealPrice;
            parameters[5].Value = model.DealMoney;
            parameters[6].Value = model.Commission;
            parameters[7].Value = model.DealTime;
            parameters[8].Value = model.Direction;
            parameters[9].Value = model.ID;
            parameters[10].Value = model.UserNo;

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
            strSql.Append("delete from Deals ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters =
                {
                    new SqlParameter("@ID", SqlDbType.Int, 4)
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
            strSql.Append("delete from Deals ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public List<Deal> GetList(string strWhere, string filedOrder)
        {
            var strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(
                " ID,SettleDate,DealNo,Goods,DealAmount,DealPrice,DealMoney,Commission,DealTime,Direction,UserNo ");
            strSql.Append(" FROM Deals ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            var list = new List<Deal>();
            using (var dr = db.ExecuteReader(cmd))
            {
                while (dr.Read())
                {
                    Deal model = new Deal();
                    if (dr["ID"] != null && dr["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dr["ID"].ToString());
                    }
                    if (dr["SettleDate"] != null && dr["SettleDate"].ToString() != "")
                    {
                        model.SettleDate = DateTime.Parse(dr["SettleDate"].ToString());
                    }
                    if (dr["DealNo"] != null)
                    {
                        model.DealNo = dr["DealNo"].ToString();
                    }
                    if (dr["Goods"] != null)
                    {
                        model.Goods = dr["Goods"].ToString();
                    }
                    if (dr["DealAmount"] != null && dr["DealAmount"].ToString() != "")
                    {
                        model.DealAmount = int.Parse(dr["DealAmount"].ToString());
                    }
                    if (dr["DealPrice"] != null && dr["DealPrice"].ToString() != "")
                    {
                        model.DealPrice = decimal.Parse(dr["DealPrice"].ToString());
                    }
                    if (dr["DealMoney"] != null && dr["DealMoney"].ToString() != "")
                    {
                        model.DealMoney = decimal.Parse(dr["DealMoney"].ToString());
                    }
                    if (dr["Commission"] != null && dr["Commission"].ToString() != "")
                    {
                        model.Commission = decimal.Parse(dr["Commission"].ToString());
                    }
                    if (dr["DealTime"] != null && dr["DealTime"].ToString() != "")
                    {
                        model.DealTime = DateTime.Parse(dr["DealTime"].ToString());
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
            strSql.Append("delete from Deals; ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }
    }
}
