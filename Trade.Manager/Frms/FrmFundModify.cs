using System;
using System.Windows.Forms;
using Trade.Manager.localhost;

namespace Trade.Manager.Frms
{
    public partial class FrmFundModify : Form
    {
        public FrmFundModify()
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
                if (ws.AddFund(Model) == 0)
                {
                    MessageBox.Show("保存失败,请稍后重试！", "提示");
                    DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            else
            {
                if (!ws.UpdateFund(Model))
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
        public Fund Model;

        /// <summary>
        /// 
        /// </summary>
        private void SetValues()
        {
            if (Model != null)
            {
                dtpSettleDate.Value = Model.SettleDate;

                dtpSettleDate.Value = Model.SettleDate;
                txtNo.Text = Model.No;
                nudChangeMoney.Value = Model.ChangeMoney;
                nudChangedMoney.Value = Model.ChangedMoney;
                txtRelevanceNo.Text = Model.RelevanceNo;
                cmbCType.Text = Model.CType;
                dtpCTime.Value = Model.CTime;
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
                Model = new Fund();

            Model.SettleDate = dtpSettleDate.Value;
            Model.No = txtNo.Text;
            Model.ChangeMoney = nudChangeMoney.Value;
            Model.ChangedMoney = nudChangedMoney.Value;
            Model.RelevanceNo = txtRelevanceNo.Text;
            Model.CType = cmbCType.Text;
            Model.CTime = dtpCTime.Value;
            Model.ID = !string.IsNullOrEmpty(txtID.Text) ? int.Parse(txtID.Text) : 0; 
            Model.UserNo = txtUserNo.Text;
        }
    }
}
