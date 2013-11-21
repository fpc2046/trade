using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Trade.Manager.localhost;

namespace Trade.Manager.Frms
{
    public partial class FrmAnnouncementModify : Form
    {
        public FrmAnnouncementModify()
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
                if (ws.AddAnnouncement(Model) == 0)
                {
                    MessageBox.Show("保存失败,请稍后重试！", "提示");
                    DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            else
            {
                if (!ws.UpdateAnnouncement(Model))
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
        public Announcement Model;

        /// <summary>
        /// 
        /// </summary>
        private void SetValues()
        {
            if (Model != null)
            {
                nudSeriesNum.Value = Model.SeriesNum;
                txtInstitution.Text = Model.Institution;
                txtTheme.Text = Model.Theme;
                txtContentText.Text = Model.ContentText.Replace("\n","\r\n");
                dtpCreateTime.Value = Model.CreateTime;
                dtpOvertime.Value = Model.Overtime;
                txtUserName.Text = Model.UserName;
                txtID.Text = Model.ID.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void GetValues()
        {
            if (Model == null)
                Model = new Announcement();

            Model.SeriesNum = int.Parse(nudSeriesNum.Value.ToString());
            Model.Institution = txtInstitution.Text;
            Model.Theme = txtTheme.Text;
            Model.ContentText = txtContentText.Text;//.Replace("\n", "\r\n");
            Model.CreateTime = dtpCreateTime.Value;
            Model.Overtime = dtpOvertime.Value;
            Model.UserName = txtUserName.Text;
            Model.ID = !string.IsNullOrEmpty(txtID.Text) ? int.Parse(txtID.Text) : 0;
        }
    }
}
