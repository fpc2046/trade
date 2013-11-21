using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Trade.ClientApp.Controls;
using System.Text.RegularExpressions;
using Trade.ClientApp.ClientService;

namespace Trade.ClientApp.BLLControls
{
    public partial class ChangePW : NoBorderFrom
    {
        public ChangePW()
        {
            InitializeComponent();
            if (App.Logo != null)
            {
                this.pictureBox1.Image = App.Logo.ToBitmap();
            }
        }

        private ClientSrv service = null;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (App.CurrentApp == null || App.CurrentApp.Session == null)
            {
                this.Close();
            }
            else
            {
                this.service = new ClientSrv();
                if (!string.IsNullOrEmpty(Program.ServiceUrl))
                {
                    this.service.Url = Program.ServiceUrl;
                }
                this.service.CookieContainer = App.CurrentApp.Session.Cookie;
            }
        }

        private void rdoLoginPD_CheckedChanged(object sender, EventArgs e)
        {
            this.txtOldPwd.Clear();
            this.txtNewPwd.Clear();
            this.txtNewPwdRe.Clear();
            this.txtOldPwd.Focus();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            this.picClose.Image = Properties.Resources.sysbtnClosebg_Hover;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            this.picClose.Image = Properties.Resources.sysbtnClosebg_nor;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            if (this.txtOldPwd.Text.Length == 0)
            {
                MessageBox.Show("密码修改失败：原密码为空！", "修改结果", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtOldPwd.Focus();
                return;
            }
            if (this.txtNewPwd.Text.Length == 0)
            {
                MessageBox.Show("密码修改失败：新密码为空！", "修改结果", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtNewPwd.Focus();
                return;
            }
            if (this.txtNewPwdRe.Text.Length == 0)
            {
                MessageBox.Show("密码修改失败：重复密码为空！", "修改结果", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtNewPwdRe.Focus();
                return;
            }
            if (!this.CheckPwd())
            {
                MessageBox.Show("密码修改失败：密码包含非法字符！", "修改结果", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtNewPwd.Focus();
                return;
            }

            if (this.txtNewPwd.Text != this.txtNewPwdRe.Text)
            {
                MessageBox.Show("密码修改信息：两次新密码输入不一致！", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtNewPwd.Focus();
                return;
            }

            if (this.txtNewPwd.Text.Length < 6 || this.txtNewPwd.Text.Length > 16)
            {
                MessageBox.Show("密码修改失败：请修改密码为6位至16位！", "修改结果", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtNewPwd.Focus();
                return;
            }

            string text = "ErrorOLD";
            string uname = App.CurrentApp.Session.UserName;
            if (this.rdoLoginPD.Checked)
            {
                try
                {
                    text = this.service.ChangedLoginWord(uname, this.txtOldPwd.Text, this.txtNewPwd.Text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("网格出错异常！请稍候再试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (string.IsNullOrEmpty(text))
            {
                App.CurrentApp.Session.PassWord = this.txtNewPwd.Text;
                text = "密码修改信息：成功！";
            }
            else if (text.Equals("ErrorOLD", StringComparison.CurrentCultureIgnoreCase))
            {
                text = "密码修改信息：失败！原因：原密码不正确！";
            }
            else
            {
                text = "密码修改信息：失败！" + text;
            }
            MessageBox.Show(text, "修改结果", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private bool CheckPwd()
        {
            string pattern = "^[\\@A-Za-z0-9\\-`=\\\\\\[\\];',./~!@#$%^&*()_+|{}:<>?\"]{1,1000}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(this.txtNewPwd.Text);
        }
        private static bool IsNumeric(string str)
        {
            bool result;
            try
            {
                if (str == null || str.Length == 0)
                {
                    result = false;
                    return result;
                }
                ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
                byte[] bytes = aSCIIEncoding.GetBytes(str);
                byte[] array = bytes;
                for (int i = 0; i < array.Length; i++)
                {
                    byte b = array[i];
                    if (b < 48 || b > 57)
                    {
                        result = false;
                        return result;
                    }
                }
            }
            catch (Exception arg_4B_0)
            {
                Exception exception = arg_4B_0;
                MessageBox.Show(exception.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                result = false;
                return result;
            }
            return true;
        }
        private static bool IsAlphabet(string str)
        {
            bool result;
            try
            {
                if (str == null || str.Length == 0)
                {
                    result = false;
                    return result;
                }
                ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
                byte[] bytes = aSCIIEncoding.GetBytes(str);
                byte[] array = bytes;
                for (int i = 0; i < array.Length; i++)
                {
                    byte b = array[i];
                    if (b < 65 || b > 122)
                    {
                        result = false;
                        return result;
                    }
                    if (b > 90 && b < 97)
                    {
                        result = false;
                        return result;
                    }
                }
            }
            catch (Exception arg_5A_0)
            {
                Exception exception = arg_5A_0;
                MessageBox.Show(exception.Message, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                result = false;
                return result;
            }
            return true;
        }


    }
}
