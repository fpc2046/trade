using System;
using System.Collections.Generic;
using System.Text;
using Trade.ClientApp.ClientService;

namespace Trade.ClientApp.BLL
{
    public class DataPlug
    {
        public DataPlug()
        {
            this.tipArray = new string[] 
            { 
                "正在初始化",
                "正在加载商品信息",
                "正在加载帐户信息",
                "正在加载加易商信息",
                "正在加载预警信息",
                "完成",
            };

            this.service = new ClientSrv();
            if (!string.IsNullOrEmpty(Program.ServiceUrl))
            {
                this.service.Url = Program.ServiceUrl;
            }
            this.service.CookieContainer = App.CurrentApp.Session.Cookie;
            this.service.QueryCommoditysCompleted += new QueryCommoditysCompletedEventHandler(service_QueryCommoditysCompleted);
            this.service.QueryAccountsCompleted += new QueryAccountsCompletedEventHandler(service_QueryAccountsCompleted);
            this.service.QueryDealersCompleted += new QueryDealersCompletedEventHandler(service_QueryDealersCompleted);
        }



        private string userName;
        private string[] tipArray;
        private ClientSrv service = null;
        public int MaxValue { get; private set; }
        public int Value { get; private set; }

        public event Action<string> ValueChanged;

        private void OnDataCompleted()
        {
            this.Value = this.Value + 1;
            if (this.ValueChanged != null)
            {
                int index = Math.Max(0, Math.Min(this.Value, this.tipArray.Length - 1));
                this.ValueChanged(this.tipArray[index]);
            }
        }

        public void BeginLoadData()
        {
            if (App.CurrentApp.Session != null)
            {
                this.userName = App.CurrentApp.Session.UserName;
                App.CurrentApp.UserSetting = SettingInfo.Read(App.CurrentApp.Session);
                App.CurrentApp.YuJingInfo = YUJingInfo.Read(App.CurrentApp.Session);
                this.MaxValue = 4;
                this.Value = 0;
                this.OnDataCompleted();
                this.service.QueryCommoditysAsync(new object());
            }
        }

        private void service_QueryCommoditysCompleted(object sender, QueryCommoditysCompletedEventArgs e)
        {
            App.CurrentApp.Data.Commodity = e.Result;
            this.OnDataCompleted();
            this.service.QueryAccountsAsync(this.userName, new object());
        }

        private void service_QueryAccountsCompleted(object sender, QueryAccountsCompletedEventArgs e)
        {
            App.CurrentApp.Data.Account = e.Result;
            this.OnDataCompleted();
            this.service.QueryDealersAsync(new object());
        }

        private void service_QueryDealersCompleted(object sender, QueryDealersCompletedEventArgs e)
        {
            App.CurrentApp.Data.Dealer = e.Result;
            this.OnDataCompleted();
        }
    }
}
