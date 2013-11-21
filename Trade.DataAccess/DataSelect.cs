using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Trade.DataAccess
{
    public class DataSelect
    {
        private const string queryCommoditys = @"SELECT [ID]
      ,[CommodityName]
      ,[CommodityID]
      ,[CommodityStatus]
      ,[TradingUnit]
      ,[DBZXKWTSL]
      ,[DBZDKWTSL]
      ,[ZDCCL]
      ,[SXFSF]
      ,[SXFXS]
      ,[SXFSQFS]
      ,[BZJSF]
      ,[JCBZJXS]
      ,[YQFSF]
      ,[YQFL1_10]
      ,[YQFL11_1K]
      ,[Status]
      ,[PriceZoom]
  FROM [Commodity]
  WHERE STATUS=0 OR STATUS=NULL ORDER BY [ORDERID]";

        private const string queryAccounts = @"SELECT [ID]
      ,[AccountName]
      ,[LoginName]
      ,[QCQY]
      ,[DQQY]
      ,[DRCRJ]
      ,[FDYK]
      ,[DRPCYKHJ]
      ,[KYBZJ]
      ,[DRSXFHJ]
      ,[ZYBZJ]
      ,[SRYQF]
      ,[DJBZJ]
      ,[FXL]
      ,[DJSXF]
      ,[ZHZT]
  FROM [Account]
  WHERE LoginName=@loginName";

        private const string queryDealers = @"SELECT [ID]
      ,[DealerCode]
      ,[DealerName]
  FROM [Dealer]";

        private const string queryAnnouncements = @"SELECT [ID]
      ,[SeriesNum]
      ,[Institution]
      ,[Theme]
      ,[ContentText]
      ,[CreateTime]
      ,[Overtime]
      ,[UserName]
  FROM [Announcement] ";

        private const string queryTradeAccountFund = @"SELECT [ID]
      ,[TradeAccount]
      ,[QCQY]
      ,[DRCRQ]
      ,[DQKCJE]
      ,[KYBZJ]
  FROM [TradeAccountFund] WHERE [TradeAccount]=@loginName";

        private const string queryBankAccountFund = @"SELECT [ID]
      ,[LoginName]
      ,[Account]
      ,[BankName]
      ,[AccountProperty]
      ,[QCQY]
      ,[DRCRJ]
      ,[DQZDKCJE]
      ,[ZTZJ]
  FROM [BankAccountFound] WHERE [LoginName]=@loginName";

        private const string queryFundFlow = @"SELECT [ID]
      ,[LoginName]
      ,[FlowID]
      ,[HappenTime]
      ,[BankName]
      ,[OutFund]
      ,[InFund]
      ,[Status]
      ,[Remark]
  FROM [FundFlows] WHERE [LoginName]=@loginName AND [HAPPENTIME]>=@startTime AND [HAPPENTIME]< @endTime";

        public DataTable QueryCommoditys()
        {
            var db = new DbHelper();
            DbCommand command = db.GetSqlStringCommond(queryCommoditys);
            return ReName(db.ExecuteDataTable(command), "Commodity");
        }

        public DataTable QueryAccounts(string loginName)
        {
            var db = new DbHelper();
            DbCommand command = db.GetSqlStringCommond(queryAccounts);
            db.AddInParameter(command, "@loginName", DbType.String, loginName);
            return ReName(db.ExecuteDataTable(command), "Account");
        }

        public DataTable QueryDealers()
        {
            var db = new DbHelper();
            DbCommand command = db.GetSqlStringCommond(queryDealers);
            return ReName(db.ExecuteDataTable(command), "Dealer");
        }

        public DataTable QueryAnnouncements(string userName, bool queryOver, string caption, DateTime? start1,
                                            DateTime? end1, DateTime? start2, DateTime? end2)
        {
            var filter = new List<string> {"([UserName] = @UserName or [UserName] is NULL or [UserName] ='')"};

            if (queryOver)
            {
                filter.Add("getdate()>[Overtime]");
                if (start2.HasValue)
                {
                    filter.Add("[Overtime]>= @startb");
                }
                if (end2.HasValue)
                {
                    filter.Add("[Overtime] < @endb");
                }
            }
            else
            {
                filter.Add("getdate()<[Overtime]");
            }

            if (!string.IsNullOrEmpty(caption))
            {
                filter.Add("[Theme] like '%'+ @caption +'%'");
            }

            if (start1.HasValue)
            {
                filter.Add("[CreateTime]>= @starta");
            }
            if (end1.HasValue)
            {
                filter.Add("[CreateTime] < @enda");
            }

            string sql = string.Format("{0} WHERE {1}", queryAnnouncements, string.Join(" AND ", filter.ToArray()));
            var db = new DbHelper();
            DbCommand command = db.GetSqlStringCommond(sql);
            db.AddInParameter(command, "@UserName", DbType.String, userName);
            if (!string.IsNullOrEmpty(caption))
            {
                db.AddInParameter(command, "@caption", DbType.String, caption);
            }
            if (start1.HasValue)
            {
                db.AddInParameter(command, "@starta", DbType.DateTime, start1.Value.Date);
            }
            if (end1.HasValue)
            {
                db.AddInParameter(command, "@enda", DbType.DateTime, end1.Value.Date.AddDays(1));
            }
            if (queryOver)
            {
                if (start2.HasValue)
                {
                    db.AddInParameter(command, "@startb", DbType.DateTime, start2.Value.Date);
                }
                if (end2.HasValue)
                {
                    db.AddInParameter(command, "@endb", DbType.DateTime, end2.Value.AddDays(1));
                }
            }
            return ReName(db.ExecuteDataTable(command), "Announcement");
        }

        public DataTable QueryTradeAccountFund(string loginName)
        {
            var db = new DbHelper();
            var command = db.GetSqlStringCommond(queryTradeAccountFund);
            db.AddInParameter(command, "@loginName", DbType.String, loginName);
            return ReName(db.ExecuteDataTable(command), "TradeAccountFund");
        }

        public DataTable QueryBankAccountFund(string loginName)
        {
            var db = new DbHelper();
            DbCommand command = db.GetSqlStringCommond(queryBankAccountFund);
            db.AddInParameter(command, "@loginName", DbType.String, loginName);
            DataTable dt = ReName(db.ExecuteDataTable(command), "BankAccountFund");
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.NewRow();
                row["Account"] = "合计：";
                row["QCQY"] = dt.Compute("SUM(QCQY)", "1>0");
                row["DRCRJ"] = dt.Compute("SUM(DRCRJ)", "1>0");
                dt.Rows.Add(row);
            }
            return dt;
        }

        public DataSet QueryAccountFund(string loginName)
        {
            var set = new DataSet("accountFund");
            DataTable tableTrade = QueryTradeAccountFund(loginName);
            set.Tables.Add(tableTrade);
            DataTable tableBank = QueryBankAccountFund(loginName);
            set.Tables.Add(tableBank);
            return set;
        }

        public DataTable QueryFundFlow(string loginName, DateTime startTime, DateTime endTime)
        {
            startTime = startTime.Date;
            endTime = endTime.Date.AddDays(1);
            var db = new DbHelper();
            DbCommand command = db.GetSqlStringCommond(queryFundFlow);
            db.AddInParameter(command, "@loginName", DbType.String, loginName);
            db.AddInParameter(command, "@startTime", DbType.DateTime, startTime);
            db.AddInParameter(command, "@endTime", DbType.DateTime, endTime);
            return ReName(db.ExecuteDataTable(command), "FundFlow");
        }

        public DataTable ReName(DataTable dt, string tableName)
        {
            dt.TableName = tableName;
            return dt;
        }
    }
}
