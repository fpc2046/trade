using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Trade.ClientApp.BLLControls
{
    public partial class UCFunction8 : UserControl
    {
        public UCFunction8()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (App.CurrentApp != null && App.CurrentApp.Data != null)
            {
                DataTable dt = App.CurrentApp.Data.Commodity;
                if (dt != null && dt.Rows.Count > 0)
                {
                    this.cboCommodityName.DisplayMember = "CommodityName";
                    this.cboCommodityName.DataSource = dt;
                }
            }
        }

        private void cboCommodityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = this.cboCommodityName.DataSource as DataTable;
            if (this.cboCommodityName.SelectedIndex >= 0 && dt != null && dt.Rows.Count > this.cboCommodityName.SelectedIndex)
            {
                DataRow row = dt.Rows[this.cboCommodityName.SelectedIndex];
                DataTable dtnew = new DataTable();
                dtnew.Columns.AddRange(new DataColumn[]
                { 
                    new DataColumn("key1"),
                    new DataColumn("value1"),
                    new DataColumn("key2"),
                    new DataColumn("value2"),
                });
                dtnew.Rows.Add("商品代码", row["CommodityID"], "商品名称", row["CommodityName"]);
                dtnew.Rows.Add("商品状态", row["CommodityStatus"], "交易单位", row["TradingUnit"]);
                dtnew.Rows.Add("单笔最小可委托数量", row["DBZXKWTSL"], "单笔最大可委托数量", row["DBZDKWTSL"]);
                dtnew.Rows.Add("最大持仓量", row["ZDCCL"], "", "");
                dtnew.Rows.Add("手续费算法", row["SXFSF"], "手续费系数", FromatDouble(row["SXFXS"]));
                dtnew.Rows.Add("手续费收取方式", row["SXFSQFS"], "", "");
                dtnew.Rows.Add("保证金算法", row["BZJSF"], "建仓保证金系数", FromatDouble(row["JCBZJXS"]));
                dtnew.Rows.Add("延期费算法", row["YQFSF"], "", "");
                dtnew.Rows.Add("延期费率", "阶梯值", "", "延期费率");
                dtnew.Rows.Add("", "1至10天", "建仓保证金系数", FromatDouble(row["YQFL1_10"]));
                dtnew.Rows.Add("", "11至1000天", "建仓保证金系数", FromatDouble(row["YQFL11_1K"]));
                this.dataGridView1.DataSource = dtnew;
            }
        }

        private static string FromatDouble(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return "0";
            }
            double d = 0;
            double.TryParse(value.ToString(), out d);
            return d.ToString();
        }
    }
}
