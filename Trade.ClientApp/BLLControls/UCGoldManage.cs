using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Trade.ClientApp.Controls;
using Trade.ClientApp.ClientService;

namespace Trade.ClientApp.BLLControls
{
    public partial class UCGoldManage : UserControl
    {
        public UCGoldManage()
        {
            InitializeComponent();

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView3.AutoGenerateColumns = false;

            this.service = new ClientSrv();
            if (!string.IsNullOrEmpty(Program.ServiceUrl))
            {
                this.service.Url = Program.ServiceUrl;
            }
            this.service.QueryAccountFundCompleted += new QueryAccountFundCompletedEventHandler(service_QueryAccountFundCompleted);
            this.service.QueryFundFlowCompleted += new QueryFundFlowCompletedEventHandler(service_QueryFundFlowCompleted);
            this.Dock = DockStyle.Fill;

            this.InitInput();

            this.cboBank2.SelectedIndex = 0;
        }



        private int loadNum = 0;
        private ClientSrv service = null;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Application.DoEvents();

            if (App.CurrentApp.Session != null && this.loadNum++ == 0)
            {
                this.service.CookieContainer = App.CurrentApp.Session.Cookie;
                this.service.QueryAccountFundAsync(App.CurrentApp.Session.UserName, new object());
                this.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            InitInput();
        }

        private void InitInput()
        {
            this.cboType.SelectedIndex = 0;
            this.txtJiE.Text = "";
            this.cboBank.SelectedIndex = 0;
            this.txtPwd.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtPwd.Text))
            {
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double je = 0;
            if (string.IsNullOrEmpty(this.txtJiE.Text) || !double.TryParse(this.txtJiE.Text.Trim(), out je))
            {
                MessageBox.Show("请输正确金额！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string text = string.Format("《{0}》\n《{1}》\n金额:{2}", this.cboType.Text, this.cboBank.Text, je.ToString("C2"));
            if (MessageBox.Show(text, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("操作失败: 资金密码错误! [3030]", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtPwd2.Text))
            {
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("操作失败: 资金密码错误! [3030]", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_NP_Click(object sender, EventArgs e)
        {
            this.txtOldPwd.Text = "";
            this.txtNewPwd.Text = "";
            this.txtNewPwdRe.Text = "";
        }

        private void btnOK_NP_Click(object sender, EventArgs e)
        {
            if (this.txtOldPwd.Text.Length == 0)
            {
                MessageBox.Show("原始密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.txtNewPwd.Text.Length == 0)
            {
                MessageBox.Show("新始密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.txtNewPwdRe.Text.Length == 0)
            {
                MessageBox.Show("重复密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.txtNewPwd.Text != this.txtNewPwdRe.Text)
            {
                MessageBox.Show("两次新密码输入不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.txtNewPwd.Text.Length != 6)
            {
                MessageBox.Show("资金密码固定长度为6位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("原密码错误! [3030]", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQueryHis_Click(object sender, EventArgs e)
        {
            this.btnQueryHis.Enabled = false;
            this.service.QueryFundFlowAsync(App.CurrentApp.Session.UserName,
                this.dtpStart.Value.Date,
                this.dtpEnd.Value.Date.AddDays(1).AddSeconds(-1), new object());
        }


        private void service_QueryAccountFundCompleted(object sender, QueryAccountFundCompletedEventArgs e)
        {
            this.Enabled = true;
            if (e.Error == null && e.Result != null)
            {
                DataSet set = e.Result;
                this.dataGridView1.DataSource = set.Tables[0];
                this.dataGridView2.DataSource = set.Tables[1];
            }
        }

        private void service_QueryFundFlowCompleted(object sender, QueryFundFlowCompletedEventArgs e)
        {
            double chuTotal = 0;
            double ruTotal = 0;
            this.btnQueryHis.Enabled = true;
            if (e.Error == null && e.Result != null)
            {
                double c = 0, r = 0;
                foreach (DataRow row in e.Result.Rows)
                {
                    string ct = row["OutFund"] != null ? row["OutFund"].ToString() : null;
                    string rt = row["InFund"] != null ? row["InFund"].ToString() : null;
                    if (!string.IsNullOrEmpty(ct) && double.TryParse(ct, out c))
                    {
                        chuTotal += c;
                    }
                    if (!string.IsNullOrEmpty(rt) && double.TryParse(rt, out r))
                    {
                        ruTotal += r;
                    }
                    if (c == 0)
                    {
                        row["OutFund"] = DBNull.Value;
                    }
                    if (r == 0)
                    {
                        row["InFund"] = DBNull.Value;
                    }
                }
            }
            this.dataGridView3.DataSource = e.Error != null ? null : e.Result;
            this.lblChuCount.Text = string.Format("成功出金合计:共计 {0} 元", chuTotal.ToString("N2"));
            this.lblRuCount.Text = string.Format("成功入金合计:共计 {0} 元", ruTotal.ToString("N2"));
        }

        private void txtPwd_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("请输入数字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtJiE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("0123456789".IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                if (!(e.KeyChar == '.' && this.txtJiE.Text.IndexOf(e.KeyChar) < 0))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtJiE_Leave(object sender, EventArgs e)
        {
            double je = 0;
            if (double.TryParse(this.txtJiE.Text.Trim(), out je))
            {
                this.txtJiE.Text = je.ToString("N2");
            }
        }
    }
}
