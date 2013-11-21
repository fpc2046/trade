using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Trade.ClientApp.BLLControls
{
    public partial class UCFunction3 : UserControl
    {
        public UCFunction3()
        {
            InitializeComponent();

            if (App.CurrentApp.Data.Commodity != null)
            {
                List<string> commoditys = new List<string>();
                commoditys.Add("全部商品");
                foreach (DataRow row in App.CurrentApp.Data.Commodity.Rows)
                {
                    commoditys.Add(row["CommodityName"].ToString());
                }
                this.cboShangPin.DataSource = commoditys;
            }

            this.cboType.DataSource = new string[] { "全部显示", "市价委托", "批价委托" };

            this.cboStatus.DataSource = new string[] { "全部显示", "已委托", "已成交", "已撤单" };

            this.cboBuyOrSell.DataSource = new string[] { "全部显示", "买入", "卖出" };

            this.cboJianPing.DataSource = new string[] { "全部显示", "建仓", "平仓" };
        }
    }
}
