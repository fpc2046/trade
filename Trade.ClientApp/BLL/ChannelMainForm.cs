using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;

namespace Trade.ClientApp.BLL
{
    internal class ChannelMainForm
    {
        private bool createHandel = false;
        private Form mainForm;
        private Control oldControl = null;
        private Control newControl = null;

        internal Form MainForm
        {
            get
            {
                if (this.mainForm == null || this.mainForm.IsDisposed)
                {
                    this.OnCreateMainFrom();
                }
                return mainForm;
            }
        }

        internal void Logout()
        {
            if (this.oldControl != null && !this.oldControl.IsDisposed)
            {
                this.oldControl.Visible = true;
            }
            if (this.newControl != null)
            {
                this.newControl.Dispose();
            }
        }

        internal void ShowIndexFream()
        {
            if (this.mainForm == null)
            {
                this.mainForm = new MainForm();
            }
            else
            {
                if (this.oldControl == null)
                {
                    this.oldControl = this.mainForm.Controls[0];
                    this.oldControl.Visible = false;
                }
                UCIndexFream index = new UCIndexFream();
                index.Dock = DockStyle.None;
                index.Location = new Point(7, 28);
                index.Size = new Size(this.mainForm.ClientSize.Width - 14, this.mainForm.ClientSize.Height - 36);
                index.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                this.mainForm.Controls.Add(index);
                index.BringToFront();
                this.newControl = index;
                App.CurrentApp.IndexFream = index;
            }
        }

        private void OnCreateMainFrom()
        {
            if (this.createHandel)
            {
                return;
            }
            this.createHandel = true;
            try
            {
                Assembly asbFrame = Assembly.LoadFile(Application.StartupPath + "\\TradeClientApp.dat");
                Assembly asbBizComm = Assembly.LoadFile(Application.StartupPath + "\\BizComm.dll");

                object obj = System.Activator.CreateInstance(asbBizComm.GetType("BizComm.BizCommCenter"));
                asbFrame.GetType("SysFrame.Program").GetField("g_cBizCommCenter").SetValue(null, obj);

                Type mainFream = asbFrame.GetType("SysFrame.Frame");
                this.mainForm = (Form)System.Activator.CreateInstance(mainFream, new object[] { new string[0] });
            }
            catch
            {
                MessageBox.Show("系统文件不存在或损坏,请重新安装");
            }
        }

    }
}
