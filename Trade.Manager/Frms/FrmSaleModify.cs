using System;
using System.Windows.Forms;
using Trade.Manager.localhost;

namespace Trade.Manager
{
    public partial class FrmSaleModify : Form
    {
        public FrmSaleModify()
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
                if (ws.AddSale(Model) == 0)
                {
                    MessageBox.Show("保存失败,请稍后重试！", "提示");
                    DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            else
            {
                if (!ws.UpdateSale(Model))
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
        public Sale Model;

        /// <summary>
        /// 
        /// </summary>
        private void SetValues()
        {
            if (Model != null)
            {
                dtpSettleDate.Value = Model.SettleDate;
                dtpSaleDate.Value = Model.SaleDate;
                txtGoods.Text = Model.Goods;
                txtSaleNo.Text = Model.SaleNo;
                nudSaleAmount.Value = Model.SaleAmount;
                nudSalePrice.Value = Model.SalePrice;
                nudHoldPrice.Value = Model.HoldPrice;
                nudSaleProfitLoss.Value = Model.SaleProfitLoss;
                nudSaleCommission.Value = Model.SaleCommission;
                txtBuyNo.Text = Model.BuyNo;
                nudBuyPrice.Value = Model.BuyPrice;
                dtpBuyTime.Value = Model.BuyTime;
                cmbSaleType.Text = Model.SaleType;
                cmbDirection.Text = Model.Direction;
                cmbOperate.Text = Model.Operate;
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
                Model = new Sale();

            Model.SettleDate = dtpSettleDate.Value;
            Model.SaleDate = dtpSaleDate.Value;
            Model.Goods = txtGoods.Text;
            Model.SaleNo = txtSaleNo.Text;
            Model.SaleAmount = int.Parse(nudSaleAmount.Value.ToString());
            Model.SalePrice = nudSalePrice.Value;
            Model.HoldPrice = nudHoldPrice.Value;
            Model.SaleProfitLoss = nudSaleProfitLoss.Value;
            Model.SaleCommission = nudSaleCommission.Value;
            Model.BuyNo = txtBuyNo.Text;
            Model.BuyPrice = nudBuyPrice.Value;
            Model.BuyTime = dtpBuyTime.Value;
            Model.SaleType = cmbSaleType.Text;
            Model.Direction = cmbDirection.Text;
            Model.Operate = cmbOperate.Text;
            Model.ID = !string.IsNullOrEmpty(txtID.Text) ? int.Parse(txtID.Text) : 0;
            Model.UserNo = txtUserNo.Text;
        }
    }
}
