using System;
using System.Windows.Forms;
using Trade.Manager.localhost;

namespace Trade.Manager.Frms
{
    public partial class FrmFundDetailModify : Form
    {
        public FrmFundDetailModify()
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
        private void BtnCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConfirmClick(object sender, EventArgs e)
        {
            bool ismodify = Model != null;
            GetValues();
            var ws = new ReportSrv();
            if (!ismodify)
            {
                if (ws.AddFundDetail(Model) == 0)
                {
                    MessageBox.Show("保存失败,请稍后重试！", "提示");
                    DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            else
            {
                if (!ws.UpdateFundDetail(Model))
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
        public FundDetail Model;

        /// <summary>
        /// 
        /// </summary>
        private void SetValues()
        {
            if (Model != null)
            {
                dtpSettleDate.Value = Model.SettleDate;

                dtpSettleDate.Value = Model.SettleDate;
                nudBeginRights.Value = Model.BeginRights;
                nudInOutMoney.Value = Model.InOutMoney;
                nudSaleProfitLoss.Value = Model.SaleProfitLoss;
                nudHoldProfitLoss.Value = Model.HoldProfitLoss;
                nudCommission.Value = Model.Commission;
                nudDelayMoney.Value = Model.DelayMoney;
                nudHoldEmploy.Value = Model.HoldEmploy;
                nudEndRights.Value = Model.EndRights;
                txtRiskRate.Text = Model.RiskRate;
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
                Model = new FundDetail();

            Model.SettleDate = dtpSettleDate.Value;
            Model.BeginRights = nudBeginRights.Value;
            Model.InOutMoney = nudInOutMoney.Value;
            Model.SaleProfitLoss = nudSaleProfitLoss.Value;
            Model.HoldProfitLoss = nudHoldProfitLoss.Value;
            Model.Commission = nudCommission.Value;
            Model.DelayMoney = nudDelayMoney.Value;
            Model.HoldEmploy = nudHoldEmploy.Value;
            Model.EndRights = nudEndRights.Value;
            Model.RiskRate = txtRiskRate.Text;
            Model.ID = !string.IsNullOrEmpty(txtID.Text) ? int.Parse(txtID.Text) : 0;
            Model.UserNo = txtUserNo.Text;
        }
    }
}
