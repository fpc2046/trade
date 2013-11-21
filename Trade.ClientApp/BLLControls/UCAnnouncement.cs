using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Trade.ClientApp.ClientService;

namespace Trade.ClientApp.BLLControls
{
    public partial class UCAnnouncement : UserControl
    {
        public UCAnnouncement()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            this.Dock = DockStyle.Fill;
            this.service = new ClientSrv();
            if (!string.IsNullOrEmpty(Program.ServiceUrl))
            {
                this.service.Url = Program.ServiceUrl;
            }
            this.service.CookieContainer = App.CurrentApp.Session.Cookie;
            this.service.QueryAnnouncementsCompleted += new QueryAnnouncementsCompletedEventHandler(service_QueryAnnouncementsCompleted);
        }


        private ClientSrv service = null;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Application.DoEvents();
            btnSubmit_Click(this.btnSubmit, e);
        }


        private void rdoYouXiao_CheckedChanged(object sender, EventArgs e)
        {
            this.lblGuoqi1.Visible = this.lblGuoqi2.Visible = this.rdoGuoQi.Checked;
            this.dtpBegin2.Visible = this.dtpEnd2.Visible = this.rdoGuoQi.Checked;
        }

        //重置
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.rdoYouXiao.Checked = true;
            this.dtpBegin1.Checked = this.dtpBegin2.Checked = false;
            this.dtpEnd1.Checked = this.dtpEnd2.Checked = false;
        }

        //提交
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.service.QueryAnnouncementsAsync(App.CurrentApp.Session.UserName,
                this.rdoGuoQi.Checked,
                this.txtCaption.Text.Trim(),
                this.dtpBegin1.Checked ? (DateTime?)this.dtpBegin1.Value.Date : null,
                this.dtpEnd1.Checked ? (DateTime?)this.dtpEnd1.Value.Date : null,
                this.dtpBegin2.Checked ? (DateTime?)this.dtpBegin2.Value.Date : null,
                this.dtpEnd2.Checked ? (DateTime?)this.dtpEnd2.Value.Date : null,
                new object());
        }


        private void service_QueryAnnouncementsCompleted(object sender, QueryAnnouncementsCompletedEventArgs e)
        {
            this.Enabled = true;
            if (e.Error != null)
            {
                return;
            }
            this.dataGridView1.DataSource = e.Result;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            DataRowView row = (DataRowView)this.dataGridView1.Rows[e.RowIndex].DataBoundItem;
            FormAnnouncementItem form = new FormAnnouncementItem(row);
            form.ShowDialog();
        }


    }
}
