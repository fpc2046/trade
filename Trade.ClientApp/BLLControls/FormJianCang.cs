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
    public partial class FormJianCang : Form
    {
        public FormJianCang(PriceData priceDatas, string commodityID = null, bool isBuy = true)
        {
            InitializeComponent();
            this.Icon = App.Logo;
            this.defCommodityID = commodityID;
            this.isBuyDef = isBuy;
            if (priceDatas != null)
            {
                this.priceData = priceDatas;
                this.priceData.RowAdded += new Action<DataRow>(AllPriceData_RowUpdated);
                this.priceData.RowUpdated += new Action<DataRow>(AllPriceData_RowUpdated);
            }

            this.nuHandNum.GotFocus += new EventHandler(nuHandNum_GotFocus);
            this.nuMaxMin.GotFocus += new EventHandler(nuMaxMin_GotFocus);
        }



        #region 商品与行情信息
        private bool isBuyDef = true;
        private bool isGuaQi = true;

        private int maxNumHand = 0;
        private int minNumHand = 0;
        private double bailProportion = 0;
        private string CommodityName = "";
        private string CommodityID = "";

        private PriceData priceData;
        private string buyPriceText;
        private string sellPriceText;
        private double buyPrice;
        private double sellPrice;
        private double buyPriceFix;
        private double sellPriceFix;
        private double priceZoom;

        private double tradePrice;
        private double tradeNum;
        private string defCommodityID;
        private bool isBuy;

        #endregion


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (App.CurrentApp.Data != null)
            {
                DataTable dtDealer = App.CurrentApp.Data.Dealer;
                this.cboDealer.DisplayMember = "DealerName";
                this.cboDealer.ValueMember = "DealerCode";
                this.cboDealer.DataSource = dtDealer;

                DataTable dtCommodity = App.CurrentApp.Data.Commodity;
                this.cboCommodity.DisplayMember = "CommodityName";
                this.cboCommodity.ValueMember = "CommodityID";
                this.cboCommodity.DataSource = dtCommodity;
            }

            this.cboType.SelectedIndex = 0;
            this.cboEnableTime.SelectedIndex = 0;
            if (string.IsNullOrEmpty(this.defCommodityID))
            {
                this.cboCommodity.SelectedIndex = 0;
            }
            else
            {
                this.cboCommodity.SelectedValue = this.defCommodityID;
            }
            this.isGuaQi = false;
            this.ResetHQPriceData();
        }


        private void ResetHQPriceData()
        {
            this.buyPriceText = this.buyPriceText = string.Empty;
            this.buyPrice = this.sellPrice = this.buyPriceFix = this.sellPriceFix = 0;

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
                this.buyPriceText = (row["BuyPrice"] ?? "0").ToString();
                this.sellPriceText = (row["SellPrice"] ?? "0").ToString();


                if (double.TryParse(buyPriceText, out this.buyPrice))
                {
                    double move = this.buyPrice > 1000 ? 20 : 0.8;
                    this.buyPriceFix = this.buyPrice + move;
                }
                if (double.TryParse(sellPriceText, out this.sellPrice))
                {
                    double move = this.sellPrice > 1000 ? 20 : 0.8;
                    this.sellPriceFix = this.sellPrice - move;
                }

                this.SetHQTradePrice();
            }
        }


        //选择交易类型
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rdoBuy.Checked = this.rdoBuy2.Checked = this.isBuyDef;
            this.rdoSell.Checked = this.rdoSell2.Checked = !this.isBuyDef;
            (this.cboType.SelectedIndex == 1 ? this.gboThe : this.gboMarker).BringToFront();
            if (this.gboLoading.Visible)
            {
                this.gboLoading.BringToFront();
            }
            this.SetTradeType();
        }

        //选择商品
        private void cboCommodity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CommodityName = "";
            this.CommodityID = "";
            this.priceZoom = 1;
            this.bailProportion = 0;
            this.minNumHand = 0;
            this.maxNumHand = 0;
            DataRowView cRow = this.cboCommodity.SelectedItem as DataRowView;
            if (cRow != null)
            {
                this.CommodityName = cRow["CommodityName"].ToString();
                this.CommodityID = cRow["CommodityID"].ToString();
                this.priceZoom = TableFormat.ConvertToDouble(cRow["PriceZoom"], 1);
                this.bailProportion = TableFormat.ConvertToDouble(cRow["JCBZJXS"]);
                this.minNumHand = TableFormat.ConvertToInt(cRow["DBZXKWTSL"]);
                this.maxNumHand = TableFormat.ConvertToInt(cRow["DBZDKWTSL"]);
                this.lblScope.Text = string.Format("(可选范围：{0}-{1})", this.minNumHand, this.maxNumHand);
            }
            this.SetTradeCommodity();
        }

        private void nuHandNum_ValueChanged(object sender, EventArgs e)
        {
            this.tradeNum = (double)this.nuHandNum.Value;
            this.SetTradeCount();
        }

        private void nuThePrice_ValueChanged(object sender, EventArgs e)
        {
            if (this.nuThePrice.Value <= this.nuThePrice.Increment)
            {
                decimal value = (decimal)(this.rdoBuy2.Checked ? this.buyPriceFix : this.sellPriceFix);
                if (value > this.nuThePrice.Value)
                {
                    this.nuThePrice.Value = value;
                }
            }

            //...
            this.SetHQTradePrice();
        }

        private void rdoBuy_CheckedChanged(object sender, EventArgs e)
        {
            this.SetHQTradePrice();
        }

        private void rdoBuy2_CheckedChanged(object sender, EventArgs e)
        {
            this.lblZSMark.Text = this.rdoBuy2.Checked ? "<" : ">";
            this.lblZYMark.Text = this.rdoBuy2.Checked ? ">" : "<";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.nuHandNum.Value = this.maxNumHand;
        }

        private void chkAllowMaxMin_CheckedChanged(object sender, EventArgs e)
        {
            this.nuMaxMin.Enabled = this.chkAllowMaxMin.Checked;
        }

        private void nuMaxMin_GotFocus(object sender, EventArgs e)
        {
            this.tslblTiShi.Text = "提示：可设置点差范围最小0、最大100！";
        }

        private void nuHandNum_GotFocus(object sender, EventArgs e)
        {
            this.tslblTiShi.Text = string.Format("提示：交易手数{0}至{1}！", this.minNumHand, this.maxNumHand);
        }

        private void chkZS_CheckedChanged(object sender, EventArgs e)
        {
            this.nuZSValue.Enabled = chkZS.Checked;
        }

        private void chkZY_CheckedChanged(object sender, EventArgs e)
        {
            this.nuZYValue.Enabled = chkZY.Checked;
        }



        internal void SetTradeType()
        {
            this.SetHQTradePrice();
        }

        internal void SetTradeCommodity()
        {
            this.nuThePrice.DecimalPlaces = (int)Math.Ceiling(Math.Log10(this.priceZoom));
            this.nuThePrice.Increment = (decimal)(1d / (this.priceZoom == 0 ? 1 : this.priceZoom));
            this.nuZSValue.DecimalPlaces = this.nuZYValue.DecimalPlaces = this.nuThePrice.DecimalPlaces;
            this.nuZSValue.Increment = this.nuZYValue.Increment = this.nuThePrice.Increment;
            this.isGuaQi = true;
            this.nuHandNum.Value = this.minNumHand;
            this.isGuaQi = false;
            this.ResetHQPriceData();
        }


        //设置行情显示信息
        internal void SetHQTradePrice()
        {
            if (this.isGuaQi) return;


            string formatStr = string.Format("F{0}", (int)Math.Ceiling(Math.Log10(this.priceZoom)));
            this.txtBuyOrSellPrice.Text = (this.rdoBuy.Checked ? this.buyPrice : this.sellPrice).ToString(formatStr);
            this.txtbuyPrice.Text = this.sellPriceFix.ToString(formatStr);
            this.txtsellPrice.Text = this.buyPriceFix.ToString(formatStr);

            if (this.cboType.SelectedIndex == 0)
            {
                this.tradePrice = this.rdoBuy.Checked ? this.buyPrice : this.sellPrice;
            }
            else
            {
                this.tradePrice = (double)this.nuThePrice.Value;
            }
            this.SetTradeCount();
        }

        //设置交易量
        internal void SetTradeCount()
        {
            if (this.isGuaQi) return;
            string bzjblText = this.bailProportion.ToString("P0");

            string bzjText = (this.tradePrice * this.priceZoom * 0.12 * this.tradeNum).ToString();
            string text = string.Format("当前建仓保证金比例{0}，当前建仓所需占用保证金{1}元。", bzjblText, bzjText);
            this.lblbzjbl.Text = this.lblbzjbl2.Text = text;
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.gboLoading.Visible)
            {
                return;
            }

            this.tradeNum = (int)this.nuHandNum.Value;
            if (this.tradeNum > this.maxNumHand || this.tradeNum < this.minNumHand || this.tradeNum == 0)
            {
                string text = string.Format("请输入正确的交易手数交易手数量小{0}手、最大{1}手！", this.minNumHand, this.maxNumHand);
                MessageBoxEx.Show(text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.cboType.SelectedIndex == 0 && this.chkAllowMaxMin.Checked && (this.nuMaxMin.Value < 0 || this.nuMaxMin.Value > 100))
            {
                string text = string.Format("请填写正确点差。可设置点差范围最小0、最大100！");
                MessageBoxEx.Show(text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.tradePrice == 0)
            {
                MessageBoxEx.Show("价格不符合条件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.chkBeforeSure.Checked)
            {
                string tradeTypeText = ((this.cboType.SelectedIndex == 0 && this.rdoBuy.Checked) ||
                    (this.cboType.SelectedIndex == 1 && this.rdoBuy2.Checked) ? "建仓买入" : "建仓卖出");
                string text = string.Format("商品：{0}[{1}]\n商品价格：{2}   商品数量：{3}\n买卖方式：{4}\n\n确定下单吗？",
                    this.CommodityName, this.CommodityID, this.tradePrice, this.tradeNum, tradeTypeText);
                if (MessageBoxEx.Show(text, "订单信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.OK)
                {
                    return;
                }
            }

            this.gboLoading.Visible = true;
            this.gboLoading.BringToFront();

            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(this.OnTradeCompletedInvoke));

        }

        /// <summary>
        /// 下单
        /// </summary>
        /// <param name="state"></param>
        private void OnTradeCompletedInvoke(object state)
        {
            System.Threading.Thread.Sleep(500);
            this.BeginInvoke(new Action(this.OnTradeCompleted));
        }

        //交易下单完成
        private void OnTradeCompleted()
        {
            MessageBoxEx.Show("资金余额不足！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.gboLoading.Visible = false;
        }


        //关闭
        private void btnCencel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
