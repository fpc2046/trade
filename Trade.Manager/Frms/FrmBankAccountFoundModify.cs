using System;
using System.Windows.Forms;
using Trade.Manager.localhost;

namespace Trade.Manager.Frms
{
    public partial class FrmBankAccountFoundModify : Form
    {
        public FrmBankAccountFoundModify()
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
                if (ws.AddBankAccountFound(Model) == 0)
                {
                    MessageBox.Show("保存失败,请稍后重试！", "提示");
                    DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            else
            {
                if (!ws.UpdateBankAccountFound(Model))
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
        public BankAccountFound Model;

        /// <summary>
        /// 
        /// </summary>
        private void SetValues()
        {
            if (Model != null)
            {
                txtLoginName.Text = Model.LoginName;
                txtAccount.Text = Model.Account;
                txtBankName.Text = Model.BankName;
                txtAccountProperty.Text = Model.AccountProperty;
                nudQCQY.Value = Model.QCQY;
                nudDRCRJ.Value = Model.DRCRJ;
                nudDQZDKCJE.Value = Model.DQZDKCJE;
                nudZTZJ.Value = Model.ZTZJ;
                txtID.Text = Model.ID.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void GetValues()
        {
            if (Model == null)
                Model = new BankAccountFound();

            Model.LoginName =txtLoginName.Text;
            Model.Account = txtAccount.Text;
            Model.BankName = txtBankName.Text;
            Model.AccountProperty = txtAccountProperty.Text;
            Model.QCQY = nudQCQY.Value;
            Model.DRCRJ = nudDRCRJ.Value;
            Model.DQZDKCJE = nudDQZDKCJE.Value;
            Model.ZTZJ = nudZTZJ.Value;
            Model.ID = !string.IsNullOrEmpty(txtID.Text) ? int.Parse(txtID.Text) : 0;
        }
    }
}
