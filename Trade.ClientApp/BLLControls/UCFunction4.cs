using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Trade.ClientApp.BLLControls
{
    public partial class UCFunction4 : UserControl
    {
        public UCFunction4()
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

            this.cboJianPing.DataSource = new string[] { "全部显示", "建仓", "平仓" };

            this.cboBuyOrSell.DataSource = new string[] { "全部显示", "买入", "卖出" };

        }
    }
}
