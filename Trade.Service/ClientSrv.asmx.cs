using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Services;
using Trade.DataAccess;
using Trade.Model;

namespace Trade.Service
{
    /// <summary>
    /// ClientSrv 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class ClientSrv : WebService
    {
        [WebMethod(EnableSession = true, Description = "测试")]
        public string HelloWorld()
        {
            LoginService service = new LoginService(this.Context);
            string loginError = service.CheckLoginError(true);
            if (!string.IsNullOrEmpty(loginError))
            {
                return loginError;
            }
            return "Hello World";
        }

        [WebMethod(EnableSession = true, Description = "登录验证")]
        public LoginResult Login(string name, string pwd, string vcode, string envName)
        {
            var service = new LoginService(this.Context);

            return service.Login(name, pwd, vcode, envName);
        }

        [WebMethod(EnableSession = true, Description = "修改登录密码")]
        public string ChangedLoginWord(string name, string oldpwd, string newpwd)
        {
            var service = new LoginService(Context);
            string loginError = service.CheckLoginError(true);
            if (!string.IsNullOrEmpty(loginError))
            {
                return loginError;
            }
            return service.ChangedUserPwd(name, oldpwd, newpwd);
        }

        [WebMethod(EnableSession = true, Description = "上传行情信息")]
        public string UpdatePrices(string[] prices)
        {
            RealPriceService realService = RealPriceService.Instance;
            return realService.UpdatePrice(prices);
            ;
        }

        [WebMethod(EnableSession = true, Description = "上传行情信息")]
        public string UpdatePrice(string prices)
        {
            RealPriceService realService = RealPriceService.Instance;
            return realService.UpdatePrice(prices);
        }

        [WebMethod(EnableSession = true, Description = "获取行情信息")]
        public QuoteCard GetPrice(int version)
        {
            //if (version == 0)
            //{
            //    LoginService service = new LoginService(this.Context);
            //    string loginError = service.CheckLoginError();
            //    if (!string.IsNullOrEmpty(loginError))
            //    {
            //        return new QuoteCard() { Error = loginError };
            //    }
            //}

            RealPriceService realService = RealPriceService.Instance;

            return realService.GetPrice(version);
        }

        [WebMethod(EnableSession = true, Description = "获取帐户信息")]
        public DataTable QueryAccounts(string loginName)
        {
            DataSelect select = new DataSelect();
            return select.QueryAccounts(loginName);
        }

        [WebMethod(EnableSession = true, Description = "获取商品信息")]
        public DataTable QueryCommoditys()
        {
            var select = new DataSelect();
            return select.QueryCommoditys();
        }

        [WebMethod(EnableSession = true, Description = "获取交易商信息")]
        public DataTable QueryDealers()
        {
            DataSelect select = new DataSelect();
            return select.QueryDealers();
        }

        [WebMethod(EnableSession = true, Description = "获取公告")]
        public DataTable QueryAnnouncements(string userName, bool queryOver, string caption, DateTime? start1,
                                            DateTime? end1, DateTime? start2, DateTime? end2)
        {
            var select = new DataSelect();
            return select.QueryAnnouncements(userName, queryOver, caption, start1, end1, start2, end2);
        }

        [WebMethod(EnableSession = true, Description = "出入金市场信息查询")]
        public DataSet QueryAccountFund(string loginName)
        {
            var select = new DataSelect();
            return select.QueryAccountFund(loginName);
        }

        [WebMethod(EnableSession = true, Description = "出入金流水查询")]
        public DataTable QueryFundFlow(string loginName, DateTime start, DateTime end)
        {
            DataSelect select = new DataSelect();
            return select.QueryFundFlow(loginName, start, end);
        }


        #region "sale"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public int AddSale(Sale model)
        {
            var dal = new SalesDal();
            return dal.Add(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public bool UpdateSale(Sale model)
        {
            var dal = new SalesDal();
            return dal.Update(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteSale(int id)
        {
            var dal = new SalesDal();
            return dal.Delete(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dlist"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteListSale(string dlist)
        {
            var dal = new SalesDal();
            return dal.DeleteList(dlist);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="filedOrder"></param>
        /// <returns></returns>
        [WebMethod]
        public List<Sale> GetListSale(string strWhere, string filedOrder)
        {
            var dal = new SalesDal();
            return dal.GetList(strWhere, filedOrder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool CleanSales()
        {
            var dal = new SalesDal();
            return dal.Clean();
        }

        #endregion

        #region "deal"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public int AddDeal(Deal model)
        {
            var dal = new DealsDal();
            return dal.Add(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public bool UpdateDeal(Deal model)
        {
            var dal = new DealsDal();
            return dal.Update(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteDeal(int id)
        {
            var dal = new DealsDal();
            return dal.Delete(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dlist"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteListDeal(string dlist)
        {
            var dal = new DealsDal();
            return dal.DeleteList(dlist);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="filedOrder"></param>
        /// <returns></returns>
        [WebMethod]
        public List<Deal> GetListDeal(string strWhere, string filedOrder)
        {
            var dal = new DealsDal();
            return dal.GetList(strWhere, filedOrder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool CleanDeals()
        {
            var dal = new DealsDal();
            return dal.Clean();
        }

        #endregion

        #region "hold"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public int AddHold(Hold model)
        {
            var dal = new HoldsDal();
            return dal.Add(model);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public bool UpdateHold(Hold model)
        {
            var dal = new HoldsDal();
            return dal.Update(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteHold(int id)
        {
            var dal = new HoldsDal();
            return dal.Delete(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dlist"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteListHold(string dlist)
        {
            var dal = new HoldsDal();
            return dal.DeleteList(dlist);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="filedOrder"></param>
        /// <returns></returns>
        [WebMethod]
        public List<Hold> GetListHold(string strWhere, string filedOrder)
        {
            var dal = new HoldsDal();
            return dal.GetList(strWhere, filedOrder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool CleanHolds()
        {
            var dal = new HoldsDal();
            return dal.Clean();
        }

        #endregion

        #region "fund"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public int AddFund(Fund model)
        {
            var dal = new FundsDal();
            return dal.Add(model);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public bool UpdateFund(Fund model)
        {
            var dal = new FundsDal();
            return dal.Update(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteFund(int ID)
        {
            var dal = new FundsDal();
            return dal.Delete(ID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IDlist"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteListFund(string IDlist)
        {
            var dal = new FundsDal();
            return dal.DeleteList(IDlist);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="filedOrder"></param>
        /// <returns></returns>
        [WebMethod]
        public List<Fund> GetListFund(string strWhere, string filedOrder)
        {
            var dal = new FundsDal();
            return dal.GetList(strWhere, filedOrder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool CleanFunds()
        {
            var dal = new FundsDal();
            return dal.Clean();
        }

        #endregion

        #region "fundetail"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public int AddFundDetail(FundDetail model)
        {
            var dal = new FundDetailsDal();
            return dal.Add(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public bool UpdateFundDetail(FundDetail model)
        {
            var dal = new FundDetailsDal();
            return dal.Update(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteFundDetail(int ID)
        {
            var dal = new FundDetailsDal();
            return dal.Delete(ID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IDlist"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteListFundDetail(string IDlist)
        {
            var dal = new FundDetailsDal();
            return dal.DeleteList(IDlist);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="filedOrder"></param>
        /// <returns></returns>
        [WebMethod]
        public List<FundDetail> GetListFundDetail(string strWhere, string filedOrder)
        {
            var dal = new FundDetailsDal();
            return dal.GetList(strWhere, filedOrder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool CleanFundDetail()
        {
            var dal = new FundDetailsDal();
            return dal.Clean();
        }

        #endregion

        #region "[FundFlows]"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public int AddFundFlow(FundFlow model)
        {
            var dal = new FundFlowsDal();
            return dal.Add(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public bool UpdateFundFlow(FundFlow model)
        {
            var dal = new FundFlowsDal();
            return dal.Update(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteFundFlow(int id)
        {
            var dal = new FundFlowsDal();
            return dal.Delete(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dlist"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteListFundFlow(string dlist)
        {
            var dal = new FundFlowsDal();
            return dal.DeleteList(dlist);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="filedOrder"></param>
        /// <returns></returns>
        [WebMethod]
        public List<FundFlow> GetListFundFlow(string strWhere, string filedOrder)
        {
            var dal = new FundFlowsDal();
            return dal.GetList(strWhere, filedOrder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool CleanFundFlows()
        {
            var dal = new FundFlowsDal();
            return dal.Clean();
        }

        #endregion

        #region "[Announcement]"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public int AddAnnouncement(Announcement model)
        {
            var dal = new AnnouncementsDal();
            return dal.Add(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public bool UpdateAnnouncement(Announcement model)
        {
            var dal = new AnnouncementsDal();
            return dal.Update(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteAnnouncement(int ID)
        {
            var dal = new AnnouncementsDal();
            return dal.Delete(ID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dlist"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteListAnnouncement(string dlist)
        {
            var dal = new AnnouncementsDal();
            return dal.DeleteList(dlist);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="filedOrder"></param>
        /// <returns></returns>
        [WebMethod]
        public List<Announcement> GetListAnnouncement(string strWhere, string filedOrder)
        {
            var dal = new AnnouncementsDal();
            return dal.GetList(strWhere, filedOrder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool CleanAnnouncements()
        {
            var dal = new AnnouncementsDal();
            return dal.Clean();
        }

        #endregion

        #region "[TradeAccountFund]"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public int AddTradeAccountFund(TradeAccountFund model)
        {
            var dal = new TradeAccountFundsDal();
            return dal.Add(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public bool UpdateTradeAccountFund(TradeAccountFund model)
        {
            var dal = new TradeAccountFundsDal();
            return dal.Update(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteTradeAccountFund(int id)
        {
            var dal = new TradeAccountFundsDal();
            return dal.Delete(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dlist"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteListTradeAccountFund(string dlist)
        {
            var dal = new TradeAccountFundsDal();
            return dal.DeleteList(dlist);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="filedOrder"></param>
        /// <returns></returns>
        [WebMethod]
        public List<TradeAccountFund> GetListTradeAccountFund(string strWhere, string filedOrder)
        {
            var dal = new TradeAccountFundsDal();
            return dal.GetList(strWhere, filedOrder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool CleanTradeAccountFunds()
        {
            var dal = new TradeAccountFundsDal();
            return dal.Clean();
        }

        #endregion

        #region "[BankAccountFound]"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public int AddBankAccountFound(BankAccountFound model)
        {
            var dal = new BankAccountFoundsDal();
            return dal.Add(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [WebMethod]
        public bool UpdateBankAccountFound(BankAccountFound model)
        {
            var dal = new BankAccountFoundsDal();
            return dal.Update(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteBankAccountFound(int id)
        {
            var dal = new BankAccountFoundsDal();
            return dal.Delete(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dlist"></param>
        /// <returns></returns>
        [WebMethod]
        public bool DeleteListBankAccountFound(string dlist)
        {
            var dal = new BankAccountFoundsDal();
            return dal.DeleteList(dlist);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strWhere"></param>
        /// <param name="filedOrder"></param>
        /// <returns></returns>
        [WebMethod]
        public List<BankAccountFound> GetListBankAccountFound(string strWhere, string filedOrder)
        {
            var dal = new BankAccountFoundsDal();
            return dal.GetList(strWhere, filedOrder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public bool CleanBankAccountFounds()
        {
            var dal = new BankAccountFoundsDal();
            return dal.Clean();
        }

        #endregion

    }
}
