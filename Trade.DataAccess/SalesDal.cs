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
    public class SalesDal
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Sale model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sales(");
            strSql.Append(
                "SettleDate,SaleDate,Goods,SaleNo,SaleAmount,SalePrice,HoldPrice,SaleProfitLoss,SaleCommission,BuyNo,BuyPrice,BuyTime,SaleType,Direction,Operate,UserNo)");
            strSql.Append(" values (");
            strSql.Append(
                "@SettleDate,@SaleDate,@Goods,@SaleNo,@SaleAmount,@SalePrice,@HoldPrice,@SaleProfitLoss,@SaleCommission,@BuyNo,@BuyPrice,@BuyTime,@SaleType,@Direction,@Operate,@UserNo)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters =
                {
                    new SqlParameter("@SettleDate", SqlDbType.DateTime),
                    new SqlParameter("@SaleDate", SqlDbType.DateTime),
                    new SqlParameter("@Goods", SqlDbType.NVarChar, 50),
                    new SqlParameter("@SaleNo", SqlDbType.NVarChar, 50),
                    new SqlParameter("@SaleAmount", SqlDbType.Int, 4),
                    new SqlParameter("@SalePrice", SqlDbType.Decimal, 9),
                    new SqlParameter("@HoldPrice", SqlDbType.Decimal, 9),
                    new SqlParameter("@SaleProfitLoss", SqlDbType.Decimal, 9),
                    new SqlParameter("@SaleCommission", SqlDbType.Decimal, 9),
                    new SqlParameter("@BuyNo", SqlDbType.NVarChar, 50),
                    new SqlParameter("@BuyPrice", SqlDbType.Decimal, 9),
                    new SqlParameter("@BuyTime", SqlDbType.DateTime, 9),
                    new SqlParameter("@SaleType", SqlDbType.NVarChar, 10),
                    new SqlParameter("@Direction", SqlDbType.NVarChar, 10),
                    new SqlParameter("@Operate", SqlDbType.NVarChar, 10),
                    new SqlParameter("@UserNo", SqlDbType.NVarChar, 50)
                };
            parameters[0].Value = model.SettleDate;
            parameters[1].Value = model.SaleDate;
            parameters[2].Value = model.Goods;
            parameters[3].Value = model.SaleNo;
            parameters[4].Value = model.SaleAmount;
            parameters[5].Value = model.SalePrice;
            parameters[6].Value = model.HoldPrice;
            parameters[7].Value = model.SaleProfitLoss;
            parameters[8].Value = model.SaleCommission;
            parameters[9].Value = model.BuyNo;
            parameters[10].Value = model.BuyPrice;
            parameters[11].Value = model.BuyTime;
            parameters[12].Value = model.SaleType;
            parameters[13].Value = model.Direction;
            parameters[14].Value = model.Operate;
            parameters[15].Value = model.UserNo;

            DbHelper db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            cmd.Parameters.AddRange(parameters);
            return db.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Sale model)
        {
            var strSql = new StringBuilder();
            strSql.Append("update Sales set ");
            strSql.Append("SettleDate=@SettleDate,");
            strSql.Append("SaleDate=@SaleDate,");
            strSql.Append("Goods=@Goods,");
            strSql.Append("SaleNo=@SaleNo,");
            strSql.Append("SaleAmount=@SaleAmount,");
            strSql.Append("SalePrice=@SalePrice,");
            strSql.Append("HoldPrice=@HoldPrice,");
            strSql.Append("SaleProfitLoss=@SaleProfitLoss,");
            strSql.Append("SaleCommission=@SaleCommission,");
            strSql.Append("BuyNo=@BuyNo,");
            strSql.Append("BuyPrice=@BuyPrice,");
            strSql.Append("BuyTime=@BuyTime,");
            strSql.Append("SaleType=@SaleType,");
            strSql.Append("Direction=@Direction,");
            strSql.Append("Operate=@Operate,");
            strSql.Append("UserNo=@UserNo ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters =
                {
                    new SqlParameter("@SettleDate", SqlDbType.DateTime),
                    new SqlParameter("@SaleDate", SqlDbType.DateTime),
                    new SqlParameter("@Goods", SqlDbType.NVarChar, 50),
                    new SqlParameter("@SaleNo", SqlDbType.NVarChar, 50),
                    new SqlParameter("@SaleAmount", SqlDbType.Int, 4),
                    new SqlParameter("@SalePrice", SqlDbType.Decimal, 9),
                    new SqlParameter("@HoldPrice", SqlDbType.Decimal, 9),
                    new SqlParameter("@SaleProfitLoss", SqlDbType.Decimal, 9),
                    new SqlParameter("@SaleCommission", SqlDbType.Decimal, 9),
                    new SqlParameter("@BuyNo", SqlDbType.NVarChar, 50),
                    new SqlParameter("@BuyPrice", SqlDbType.Decimal, 9),
                    new SqlParameter("@BuyTime", SqlDbType.DateTime, 9),
                    new SqlParameter("@SaleType", SqlDbType.NVarChar, 10),
                    new SqlParameter("@Direction", SqlDbType.NVarChar, 10),
                    new SqlParameter("@Operate", SqlDbType.NVarChar, 10),
                    new SqlParameter("@ID", SqlDbType.Int, 4),
                    new SqlParameter("@UserNo", SqlDbType.NVarChar, 50)
                };
            parameters[0].Value = model.SettleDate;
            parameters[1].Value = model.SaleDate;
            parameters[2].Value = model.Goods;
            parameters[3].Value = model.SaleNo;
            parameters[4].Value = model.SaleAmount;
            parameters[5].Value = model.SalePrice;
            parameters[6].Value = model.HoldPrice;
            parameters[7].Value = model.SaleProfitLoss;
            parameters[8].Value = model.SaleCommission;
            parameters[9].Value = model.BuyNo;
            parameters[10].Value = model.BuyPrice;
            parameters[11].Value = model.BuyTime;
            parameters[12].Value = model.SaleType;
            parameters[13].Value = model.Direction;
            parameters[14].Value = model.Operate;
            parameters[15].Value = model.ID;
            parameters[16].Value = model.UserNo;

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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sales ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters =
                {
                    new SqlParameter("@ID", SqlDbType.Int, 4)
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
            strSql.Append("delete from Sales ");
            strSql.Append(" where ID in (" + dlist + ")  ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Clean()
        {
            var strSql = new StringBuilder();
            strSql.Append("delete from Sales; ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }

        ///// <summary>
        ///// 获得前几行数据
        ///// </summary>
        //public DataTable GetList(string strWhere, string filedOrder)
        //{
        //    var strSql = new StringBuilder();
        //    strSql.Append("select ");
        //    strSql.Append(
        //        " ID,SettleDate,SaleDate,Goods,SaleNo,SaleAmount,SalePrice,HoldPrice,SaleProfitLoss,SaleCommission,BuyNo,BuyPrice,BuyTime,SaleType,Direction,Operate ");
        //    strSql.Append(" FROM Sales ");
        //    if (strWhere.Trim() != "")
        //    {
        //        strSql.Append(" where " + strWhere);
        //    }
        //    strSql.Append(" order by " + filedOrder);
        //    var db = new DbHelper();
        //    DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
        //    return db.ExecuteDataTable(cmd);
        //}

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public List<Sale> GetList( string strWhere, string filedOrder)
        {
            var strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(
                " ID,SettleDate,SaleDate,Goods,SaleNo,SaleAmount,SalePrice,HoldPrice,SaleProfitLoss,SaleCommission,BuyNo,BuyPrice,BuyTime,SaleType,Direction,Operate,UserNo ");
            strSql.Append(" FROM Sales ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            var list = new List<Sale>();
            using (var dr = db.ExecuteReader(cmd))
            {
                while (dr.Read())
                {
                    var model = new Sale();
                    if (dr["ID"] != null && dr["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dr["ID"].ToString());
                    }
                    if (dr["SettleDate"] != null && dr["SettleDate"].ToString() != "")
                    {
                        model.SettleDate = DateTime.Parse(dr["SettleDate"].ToString());
                    }
                    if (dr["SaleDate"] != null && dr["SaleDate"].ToString() != "")
                    {
                        model.SaleDate = DateTime.Parse(dr["SaleDate"].ToString());
                    }
                    if (dr["Goods"] != null)
                    {
                        model.Goods = dr["Goods"].ToString();
                    }
                    if (dr["SaleNo"] != null)
                    {
                        model.SaleNo = dr["SaleNo"].ToString();
                    }
                    if (dr["SaleAmount"] != null && dr["SaleAmount"].ToString() != "")
                    {
                        model.SaleAmount = int.Parse(dr["SaleAmount"].ToString());
                    }
                    if (dr["SalePrice"] != null && dr["SalePrice"].ToString() != "")
                    {
                        model.SalePrice = decimal.Parse(dr["SalePrice"].ToString());
                    }
                    if (dr["HoldPrice"] != null && dr["HoldPrice"].ToString() != "")
                    {
                        model.HoldPrice = decimal.Parse(dr["HoldPrice"].ToString());
                    }
                    if (dr["SaleProfitLoss"] != null && dr["SaleProfitLoss"].ToString() != "")
                    {
                        model.SaleProfitLoss = decimal.Parse(dr["SaleProfitLoss"].ToString());
                    }
                    if (dr["SaleCommission"] != null && dr["SaleCommission"].ToString() != "")
                    {
                        model.SaleCommission = decimal.Parse(dr["SaleCommission"].ToString());
                    }
                    if (dr["BuyNo"] != null)
                    {
                        model.BuyNo = dr["BuyNo"].ToString();
                    }
                    if (dr["BuyPrice"] != null && dr["BuyPrice"].ToString() != "")
                    {
                        model.BuyPrice = decimal.Parse(dr["BuyPrice"].ToString());
                    }
                    if (dr["BuyTime"] != null && dr["BuyTime"].ToString() != "")
                    {
                        model.BuyTime = DateTime.Parse(dr["BuyTime"].ToString());
                    }
                    if (dr["SaleType"] != null)
                    {
                        model.SaleType = dr["SaleType"].ToString();
                    }
                    if (dr["Direction"] != null)
                    {
                        model.Direction = dr["Direction"].ToString();
                    }
                    if (dr["Operate"] != null)
                    {
                        model.Operate = dr["Operate"].ToString();
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
    }
}
