using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Trade.Collector
{
    internal class LoginPlug
    {
        public void StartMonitorLogin()
        {
            if (this.tmrLogin == null)
            {
                this.tmrLogin = new Timer();
                this.tmrLogin.Interval = 1000;
                this.tmrLogin.Tick += new EventHandler(tmrLogin_Tick);
            }
            this.tmrLogin.Start();
        }

        private int timeCount;
        private Timer tmrLogin;

        private void tmrLogin_Tick(object sender, EventArgs e)
        {
            Form loginForm = Application.OpenForms["LoginForm"];

            if (loginForm != null && loginForm.GetType().Name.Equals("LoginForm"))
            {
                loginForm.Controls["username"].Text = "172000000114433";
                loginForm.Controls["password"].Text = "463621";
                this.tmrLogin.Stop();
            }
            if (timeCount++ > 20)
            {
                this.tmrLogin.Stop();
            }
        }

    }
}
