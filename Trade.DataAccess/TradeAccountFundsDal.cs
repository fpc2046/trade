using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Trade.Model;

namespace Trade.DataAccess
{
    /// <summary>
    /// 出入金操作 交易帐号市场资金信息表
    /// </summary>
    public class TradeAccountFundsDal
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(TradeAccountFund model)
        {
            var strSql = new StringBuilder();
            strSql.Append("insert into TradeAccountFund(");
            strSql.Append("TradeAccount,QCQY,DRCRQ,DQKCJE,KYBZJ)");
            strSql.Append(" values (");
            strSql.Append("@TradeAccount,@QCQY,@DRCRQ,@DQKCJE,@KYBZJ)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@TradeAccount", SqlDbType.VarChar,50),
					new SqlParameter("@QCQY", SqlDbType.Decimal,9),
					new SqlParameter("@DRCRQ", SqlDbType.Decimal,9),
					new SqlParameter("@DQKCJE", SqlDbType.Decimal,9),
					new SqlParameter("@KYBZJ", SqlDbType.Decimal,9)};
            parameters[0].Value = model.TradeAccount;
            parameters[1].Value = model.QCQY;
            parameters[2].Value = model.DRCRQ;
            parameters[3].Value = model.DQKCJE;
            parameters[4].Value = model.KYBZJ;

            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            cmd.Parameters.AddRange(parameters);
            return db.ExecuteNonQuery(cmd);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(TradeAccountFund model)
        {
            var strSql = new StringBuilder();
            strSql.Append("update TradeAccountFund set ");
            strSql.Append("TradeAccount=@TradeAccount,");
            strSql.Append("QCQY=@QCQY,");
            strSql.Append("DRCRQ=@DRCRQ,");
            strSql.Append("DQKCJE=@DQKCJE,");
            strSql.Append("KYBZJ=@KYBZJ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@TradeAccount", SqlDbType.VarChar,50),
					new SqlParameter("@QCQY", SqlDbType.Decimal,9),
					new SqlParameter("@DRCRQ", SqlDbType.Decimal,9),
					new SqlParameter("@DQKCJE", SqlDbType.Decimal,9),
					new SqlParameter("@KYBZJ", SqlDbType.Decimal,9),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.TradeAccount;
            parameters[1].Value = model.QCQY;
            parameters[2].Value = model.DRCRQ;
            parameters[3].Value = model.DQKCJE;
            parameters[4].Value = model.KYBZJ;
            parameters[5].Value = model.ID;

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
            strSql.Append("delete from TradeAccountFund ");
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
            strSql.Append("delete from TradeAccountFund ");
            strSql.Append(" where ID in (" + dlist + ")  ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public List<TradeAccountFund> GetList(string strWhere, string filedOrder)
        {
            var strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(
                " ID,TradeAccount,QCQY,DRCRQ,DQKCJE,KYBZJ from TradeAccountFund ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            var list = new List<TradeAccountFund>();
            using (var dr = db.ExecuteReader(cmd))
            {
                while (dr.Read())
                {
                    var model = new TradeAccountFund();
                    if (dr["ID"] != null && dr["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dr["ID"].ToString());
                    }
                    if (dr["TradeAccount"] != null)
                    {
                        model.TradeAccount = dr["TradeAccount"].ToString();
                    }
                    if (dr["QCQY"] != null && dr["QCQY"].ToString() != "")
                    {
                        model.QCQY = decimal.Parse(dr["QCQY"].ToString());
                    }
                    if (dr["DRCRQ"] != null && dr["DRCRQ"].ToString() != "")
                    {
                        model.DRCRQ = decimal.Parse(dr["DRCRQ"].ToString());
                    }
                    if (dr["DQKCJE"] != null && dr["DQKCJE"].ToString() != "")
                    {
                        model.DQKCJE = decimal.Parse(dr["DQKCJE"].ToString());
                    }
                    if (dr["KYBZJ"] != null && dr["KYBZJ"].ToString() != "")
                    {
                        model.KYBZJ = decimal.Parse(dr["KYBZJ"].ToString());
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
            strSql.Append("delete from TradeAccountFund; ");
            var db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond(strSql.ToString());
            return db.ExecuteNonQuery(cmd) > 0;
        }
    }
}
