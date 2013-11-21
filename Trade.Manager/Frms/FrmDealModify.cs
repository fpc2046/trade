using System;
using System.Windows.Forms;
using Trade.Manager.localhost;

namespace Trade.Manager.Frms
{
    public partial class FrmDealModify : Form
    {
        public FrmDealModify()
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
                if (ws.AddDeal(Model) == 0)
                {
                    MessageBox.Show("保存失败,请稍后重试！", "提示");
                    DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            else
            {
                if (!ws.UpdateDeal(Model))
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
        public Deal Model;

        /// <summary>
        /// 
        /// </summary>
        private void SetValues()
        {
            if (Model != null)
            {
                dtpSettleDate.Value = Model.SettleDate;
                txtDealNo.Text = Model.DealNo;
                txtGoods.Text = Model.Goods;
                nudDealAmount.Value = Model.DealAmount;
                nudDealPrice.Value = Model.DealPrice;
                nudDealMoney.Value = Model.DealMoney;
                nudCommission.Value = Model.Commission;
                dtpDealTime.Value = Model.DealTime;
                cmbDirection.Text = Model.Direction;
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
                Model = new Deal();

            Model.SettleDate = dtpSettleDate.Value;
            Model.DealNo = txtDealNo.Text;
            Model.Goods = txtGoods.Text;
            Model.DealAmount = int.Parse(nudDealAmount.Value.ToString());
            Model.DealPrice = nudDealPrice.Value;
            Model.DealMoney = nudDealMoney.Value;
            Model.Commission = nudCommission.Value;
            Model.DealTime = dtpDealTime.Value;
            Model.Direction = cmbDirection.Text;
            Model.ID = !string.IsNullOrEmpty(txtID.Text) ? int.Parse(txtID.Text) : 0;
            Model.UserNo = txtUserNo.Text;
        }
    }
}
