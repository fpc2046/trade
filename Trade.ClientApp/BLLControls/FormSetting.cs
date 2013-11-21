using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Trade.ClientApp.Controls;
using Trade.ClientApp.BLL;

namespace Trade.ClientApp.BLLControls
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
            this.Icon = App.Logo;
        }

        private SettingInfo settingInfo;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (App.CurrentApp != null && App.CurrentApp.UserSetting != null)
            {
                this.ShowSetting(App.CurrentApp.UserSetting);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (App.CurrentApp == null || App.CurrentApp.UserSetting == null)
            {
                Application.DoEvents();

                MessageBoxEx.Show("读取用户配置出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }


        private void ShowSetting(SettingInfo info)
        {
            this.settingInfo = info;
            this.chkAutoLock.Checked = info.LockEnable;
            this.nuAutoLockTime.Value = info.LockTime;
            this.chkShowDialog.Checked = info.ShowDialog;
            this.chkFailShowDialog.Checked = info.FailShowDialog;
            this.chkSuccessShowDialog.Checked = info.SuccessShowDialog;
            this.nuFloatAlertWindowStayTime.Value = info.FloatAlertWindowStayTime;
        }

        private void SaveSetting()
        {
            List<string> setList = new List<string>();
            if (App.CurrentApp == null || App.CurrentApp.Session == null || this.settingInfo == null)
            {
                MessageBoxEx.Show("保存用户配置出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SettingInfo info = this.settingInfo;
            if (info.LockEnable != this.chkAutoLock.Checked ||
                info.LockTime != (int)this.nuAutoLockTime.Value)
            {
                setList.Add("锁定设置修改信息：");
            }
            info.LockEnable = this.chkAutoLock.Checked;
            info.LockTime = (int)this.nuAutoLockTime.Value;
            if (info.ShowDialog != this.chkShowDialog.Checked)
            {
                setList.Add("是否弹出下单确认框修改信息：");
            }
            info.ShowDialog = this.chkShowDialog.Checked;

            if (info.FailShowDialog != this.chkFailShowDialog.Checked)
            {
                setList.Add("是否使用对话框弹出错误修改信息：");
            }
            info.FailShowDialog = this.chkFailShowDialog.Checked;

            if (info.SuccessShowDialog != this.chkSuccessShowDialog.Checked)
            {
                setList.Add("成交后是否弹出成交回报提示对话框修改信息：");
            }
            info.SuccessShowDialog = this.chkSuccessShowDialog.Checked;
            if (info.FloatAlertWindowStayTime != (int)this.nuFloatAlertWindowStayTime.Value)
            {
                setList.Add("浮动提醒窗口停留时间按修改信息：");
            }
            info.FloatAlertWindowStayTime = (int)this.nuFloatAlertWindowStayTime.Value;
            if (setList.Count > 0)
            {
                string result = "成功！";
                try
                {
                    info.Save(App.CurrentApp.Session);
                }
                catch
                {
                    result = "失败！";
                }
                for (int i = 0; i < setList.Count; i++)
                {
                    setList[i] = setList[i] + result;
                }
                string text = string.Join("\n\n", setList.ToArray());

                MessageBox.Show(text, "修改结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void chkAutoLock_CheckedChanged(object sender, EventArgs e)
        {
            this.nuAutoLockTime.Enabled = this.chkAutoLock.Checked;
        }

        private void nuAutoLockTime_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown con = (NumericUpDown)sender;
            if (con.Value < 1 || con.Value > 60)
            {
                if (con.Value < 1)
                {
                    con.Value = 1;
                }
                else
                {
                    con.Value = 60;
                }
                MessageBoxEx.Show("数值超出范围！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSetFont_Click(object sender, EventArgs e)
        {
            if (this.fdgSet.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBoxEx.Show("重新登录后生效", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnResetFont_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("重新登录后生效", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            this.SaveSetting();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }







    }
}
