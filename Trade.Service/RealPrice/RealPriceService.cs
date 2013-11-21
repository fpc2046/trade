using System.Collections.Generic;
using System.Threading;
using Trade.Model;
using Trade.Service.RealPrice;

namespace Trade.Service
{
    /// <summary>
    /// 实时行情服务
    /// </summary>
    public class RealPriceService
    {
        private static RealPriceService _instance;
        //行情服务单例
        public static RealPriceService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RealPriceService();
                }
                return _instance;
            }
        }

        private RealPriceService()
        {
            sendService = new PriceSendService();
            dataService = new PriceDataService();
            allPrice = new QuoteCard(new string[0], 1, true);
            lastPrice = new QuoteCard(new string[0], 1, false);
        }
        
        private readonly object upLock = new object();
        private int _version = 1;
        private PriceSendService sendService;
        private PriceDataService dataService;
        private QuoteCard allPrice;
        private QuoteCard lastPrice;

        internal string UpdatePrice(params string[] prices)
        {
            if (prices == null || prices.Length < 1)
            {
                return "行情数据不能为空";
            }

            QuoteCard allPrices = allPrice;

            Dictionary<string, string> newPric = new Dictionary<string, string>(prices.Length);

            if (allPrices != null && allPrices.Value != null)
            {
                foreach (string row in allPrices.Value)
                {
                    string name = GetName(row);
                    newPric[name] = row;
                }
            }
            foreach (string row in prices)
            {
                string name = GetName(row);
                newPric[name] = row;
            }

            //string[] newAllValues = newPric.Values.ToArray();
            var newAllValues = new string[newPric.Values.Count];
            int index = 0;
            foreach (var newpric in newPric.Values)
            {
                newAllValues[index] = newpric;
                index++;
            }

            lock (this.upLock)
            {
                int curVersion = Interlocked.Increment(ref _version);

                allPrice = new QuoteCard(newAllValues, curVersion, true);
                lastPrice = new QuoteCard(prices, curVersion, false);
            }

            SendToClient(lastPrice);
            return null;
        }

        internal QuoteCard GetPrice(int version)
        {
            if (version == 0)
            {
                return this.allPrice;
            }
            QuoteCard newLastPrice = this.lastPrice;

            if (newLastPrice.Version - version == 1)
            {
                return newLastPrice;
            }
            if (newLastPrice.Version == version)
            {
                return null;
            }
            return this.allPrice;
        }

        private string GetName(string rowText)
        {
            string[] cells = rowText.Split('@');
            return cells[7];
        }

        private void SendToClient(QuoteCard card)
        {
            this.sendService.SendToClient(card);
        }
    }
}