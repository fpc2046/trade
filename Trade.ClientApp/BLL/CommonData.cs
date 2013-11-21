using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Trade.ClientApp.BLL
{
    public class CommonData
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        public DataTable Commodity { get; set; }
        /// <summary>
        /// 帐户信息
        /// </summary>
        public DataTable Account { get; set; }
        /// <summary>
        /// 交易商信息
        /// </summary>
        public DataTable Dealer { get; set; }
    }
}
