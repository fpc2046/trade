using System;
using System.Windows.Forms;
using Trade.Manager.localhost;

namespace Trade.Manager.Frms
{
    public partial class FrmHoldModify : Form
    {
        public FrmHoldModify()
        {
            InitializeComponent();

            Load += FrmSalesModifyLoad;
            btnConfirm.Click += BtnConfirmClick;
            btnCancel.Click += BtnCancelClick;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BtnCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BtnConfirmClick(object sender, EventArgs e)
        {
            bool ismodify = Model != null;
            GetValues();
            var ws = new ReportSrv();
            if (!ismodify)
            {
                if (ws.AddHold(Model) == 0)
                {
                    MessageBox.Show("保存失败,请稍后重试！", "提示");
                    DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            else
            {
                if (!ws.UpdateHold(Model))
                {
                    MessageBox.Show("保存失败,请稍后重试！", "提示");
                    DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            DialogResult = DialogResult.Yes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSalesModifyLoad(object sender, EventArgs e)
        {
            //update
            if (Model != null)
            {
                SetValues();
            }
        }

        /// <summary>
        /// 系统打开类型
        /// </summary>
        public Enums.OpenTypes OpenType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Hold Model;

        /// <summary>
        /// 
        /// </summary>
        private void SetValues()
        {
            if (Model != null)
            {
                dtpSettleDate.Value = Model.SettleDate;
                txtGoods.Text = Model.Goods;
                txtHoldNo.Text = Model.HoldNo;
                nudHoldAmount.Value=Model.HoldAmount;
                nudHoldPrice.Value=Model.HoldPrice;
                nudBuyPrice.Value=Model.BuyPrice;
                nudDealPrice.Value=Model.DealPrice;
                nudHoldProfitLoss.Value=Model.HoldProfitLoss;
                nudHoldBailRate.Value=Model.HoldBailRate;
                nudHoldEmploy.Value=Model.HoldEmploy;
                nudDelayMoney.Value=Model.DelayMoney;
                dtpCreateTime.Value=Model.CreateTime;
                txtCreateNo.Text=Model.CreateNo;
                cmbDirection.Text=Model.Direction;
                txtID.Text = Model.ID.ToString();
                txtUserNo.Text = Model.UserNo;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void GetValues()
        {
            if (Model == null)
                Model = new Hold();

            Model.SettleDate = dtpSettleDate.Value;
            Model.Goods = txtGoods.Text;
            Model.HoldNo = txtHoldNo.Text;
            Model.HoldAmount = nudHoldAmount.Value;
            Model.HoldPrice = nudHoldPrice.Value;
            Model.BuyPrice = nudBuyPrice.Value;
            Model.DealPrice = nudDealPrice.Value;
            Model.HoldProfitLoss = nudHoldProfitLoss.Value;
            Model.HoldBailRate = nudHoldBailRate.Value;
            Model.HoldEmploy = nudHoldEmploy.Value;
            Model.DelayMoney = nudDelayMoney.Value;
            Model.CreateTime = dtpCreateTime.Value;
            Model.CreateNo = txtCreateNo.Text;
            Model.Direction = cmbDirection.Text;
            Model.ID = !string.IsNullOrEmpty(txtID.Text) ? int.Parse(txtID.Text) : 0;
            Model.UserNo = txtUserNo.Text;
        }
    }
}
