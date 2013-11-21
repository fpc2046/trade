using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Trade.ClientApp.BLLControls
{
    public partial class UCSysLock : UserControl
    {
        public UCSysLock()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Application.DoEvents();
            if (App.CurrentApp.Session != null && App.CurrentApp.IndexFream != null)
            {
                App.CurrentApp.IndexFream.LockFream(true);
            }

        }

        private void btnUnLock_Click(object sender, EventArgs e)
        {
            if (App.CurrentApp.Session != null && App.CurrentApp.IndexFream != null)
            {
                if (this.txtPwd.Text == App.CurrentApp.Session.PassWord)
                {
                    App.CurrentApp.IndexFream.LockFream(false);
                    this.Dispose();
                }
                else
                {
                    this.lblTiShi.Text = "登录密码输入错误！";
                }
            }
            else
            {
                this.lblTiShi.Text = "系统异常,请重新登录！";
            }
        }


    }
}
