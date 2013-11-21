using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Trade.ClientApp.BLL;
using Trade.ClientApp.Controls;

namespace Trade.ClientApp.BLLControls
{
    public partial class FormPingCang : Form
    {
        public FormPingCang(PriceData priceDatas, bool isBuy = true)
        {
            InitializeComponent();
            this.Icon = App.Logo;
            this.isBuyDef = isBuy;
            if (priceDatas != null)
            {
                this.priceData = priceDatas;
                this.priceData.RowAdded += new Action<DataRow>(AllPriceData_RowUpdated);
                this.priceData.RowUpdated += new Action<DataRow>(AllPriceData_RowUpdated);
            }
            this.nuHandNum.GotFocus += new EventHandler(nuHandNum_GotFocus);
            this.nuMinMax.GotFocus += new EventHandler(nuMinMax_GotFocus);
            this.nuAllowDao.GotFocus += new EventHandler(nuAllowDao_GotFocus);
            this.rdoBuy.Checked = isBuy;
            this.rdoSell.Checked = !isBuy;
        }


        #region 商品与行情信息
        private bool isBuyDef = true;
        private bool isGuaQi = true;

        private int maxNumHand = 0;
        private int minNumHand = 0;
        private double bailProportion = 0;

        private PriceData priceData;
        private string buyPriceText;
        private string sellPriceText;
        private double buyPrice;
        private double sellPrice;
        private double priceZoom;

        //private double tradePrice;
        private double tradeNum;

        #endregion

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (App.CurrentApp.Data != null)
            {
                DataTable dtCommodity = App.CurrentApp.Data.Commodity;
                this.cboCommodity.DisplayMember = "CommodityName";
                this.cboCommodity.ValueMember = "CommodityID";
                this.cboCommodity.DataSource = dtCommodity;
            }

            this.cboType.SelectedIndex = 0;
            this.cboCommodity.SelectedIndex = 0;

            this.isGuaQi = false;
            this.ResetHQPriceData();
        }

        private void ResetHQPriceData()
        {
            this.buyPrice = this.sellPrice = 0;
            this.buyPriceText = this.buyPriceText = string.Empty;

            if (this.isGuaQi) return;

            foreach (DataRow row in this.priceData.HqTable.Rows)
            {
                this.AllPriceData_RowUpdated(row);
            }
            this.SetHQTradePrice();
        }

        private void AllPriceData_RowUpdated(DataRow row)
        {
            if (string.Equals(row["CommodityID"], this.cboCommodity.SelectedValue))
            {
                OnHQPriceChanged(row);
            }
        }

        private void OnHQPriceChanged(DataRow row)
        {
            this.buyPriceText = (row["BuyPrice"] ?? "0").ToString();
            this.sellPriceText = (row["SellPrice"] ?? "0").ToString();
            double.TryParse(buyPriceText, out this.buyPrice);
            double.TryParse(sellPriceText, out sellPrice);

            this.SetHQTradePrice();
        }

        //设置交易量
        internal void SetTradeCount()
        {
            if (this.isGuaQi) return;

        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCommodity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.priceZoom = 1;
            this.bailProportion = 0;
            this.minNumHand = 0;
            this.maxNumHand = 0;
            DataRowView cRow = this.cboCommodity.SelectedItem as DataRowView;
            if (cRow != null)
            {
                this.priceZoom = TableFormat.ConvertToDouble(cRow["PriceZoom"], 1);
                this.bailProportion = TableFormat.ConvertToDouble(cRow["JCBZJXS"]);
                this.minNumHand = TableFormat.ConvertToInt(cRow["DBZXKWTSL"]);
                this.maxNumHand = TableFormat.ConvertToInt(cRow["DBZDKWTSL"]);
                this.lblScope.Text = string.Format("(可选范围：{0}-{1})", 0, 0);
            }
            this.SetTradeCommodity();
        }

        //设置行情显示信息
        internal void SetHQTradePrice()
        {
            if (this.isGuaQi) return;

            this.txtTradePrice.Text = this.rdoBuy.Checked ? this.buyPriceText : this.sellPriceText;

            this.SetTradeCount();
        }

        internal void SetTradeCommodity()
        {
            //this.nuThePrice.DecimalPlaces = (int)Math.Ceiling(Math.Log10(this.priceZoom));
            this.isGuaQi = true;
            this.nuHandNum.Value = 0;
            this.isGuaQi = false;
            this.ResetHQPriceData();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.nuHandNum.Value = 0;
        }

        private void chkMinMax_CheckedChanged(object sender, EventArgs e)
        {
            this.nuMinMax.Enabled = this.chkMinMax.Checked;
            if (this.nuMinMax.Enabled)
                this.nuMinMax.Focus();
        }

        private void chkAllowDao_CheckedChanged(object sender, EventArgs e)
        {
            this.nuAllowDao.Enabled = this.chkAllowDao.Checked;
            if (this.nuAllowDao.Enabled)
                this.nuAllowDao.Focus();
        }

        private void nuAllowDao_GotFocus(object sender, EventArgs e)
        {
            this.tslblTiShi.Text = string.Format("提示：反手建仓数量最小{0}、最大{1}！", this.minNumHand, this.maxNumHand);
        }

        private void nuMinMax_GotFocus(object sender, EventArgs e)
        {
            this.tslblTiShi.Text = "提示：可设置点差范围最小0、最大100！";
        }

        private void nuHandNum_GotFocus(object sender, EventArgs e)
        {
            this.tslblTiShi.Text = "提示：可平仓数量最小0手、最大0手！";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.tradeNum = (int)this.nuHandNum.Value;
            if (this.tradeNum == 0)
            {
                string text = string.Format("请输入正确的交易手数交易手数量小{0}手、最大{1}手！", 0, 0);
                MessageBoxEx.Show(text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (this.priceData != null)
            {
                this.priceData.RowAdded -= new Action<DataRow>(AllPriceData_RowUpdated);
                this.priceData.RowUpdated -= new Action<DataRow>(AllPriceData_RowUpdated);
            }
            base.OnClosed(e);
        }


    }
}
