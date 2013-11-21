using System;
using System.Windows.Forms;
using Trade.Manager.localhost;

namespace Trade.Manager.Frms
{
    public partial class FrmFundFlowModify : Form
    {
        public FrmFundFlowModify()
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
                if (ws.AddFundFlow(Model) == 0)
                {
                    MessageBox.Show("保存失败,请稍后重试！", "提示");
                    DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            else
            {
                if (!ws.UpdateFundFlow(Model))
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
        public FundFlow Model;

        /// <summary>
        /// 
        /// </summary>
        private void SetValues()
        {
            if (Model != null)
            {
                txtID.Text = Model.ID.ToString();
                txtLoginName.Text = Model.LoginName;
                nudFlowID.Value= Model.FlowID;
                dtpHappenTime.Value = Model.HappenTime;
                txtBankName.Text = Model.BankName;
                nudOutFund.Value = Model.OutFund;
                nudInFund.Value = Model.InFund;
                cmbStatus.Text = Model.Status;
                txtRemark.Text = Model.Remark;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void GetValues()
        {
            if (Model == null)
                Model = new FundFlow();

            Model.ID = !string.IsNullOrEmpty(txtID.Text) ? int.Parse(txtID.Text) : 0;
            Model.LoginName = txtLoginName.Text;
            Model.FlowID = int.Parse(nudFlowID.Value.ToString());
            Model.HappenTime = dtpHappenTime.Value;
            Model.BankName = txtBankName.Text;
            Model.OutFund = nudOutFund.Value;
            Model.InFund = nudInFund.Value;
            Model.Status = cmbStatus.Text;
            Model.Remark = txtRemark.Text; 
        }
    }
}
