using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Trade.ClientApp.ClientService;

namespace Trade.ClientApp.BLL
{
    internal class LoginPlug
    {
        public event Action<LoginResult, object> LoginCompleted;

        private ClientSrv service;
        public LoginPlug()
        {
            this.service = new ClientSrv();
            if (!string.IsNullOrEmpty(Program.ServiceUrl))
            {
                this.service.Url = Program.ServiceUrl;
            }
            this.service.LoginCompleted += new LoginCompletedEventHandler(service_LoginCompleted);

        }

        private string _userName, _pwd;



        internal void BeginLogin(string userName, string pwd, string vcode, string envName, object status)
        {
            this._userName = userName;
            this._pwd = pwd;

            this.service.CookieContainer = new System.Net.CookieContainer();
            this.service.LoginAsync(userName, pwd, vcode, envName, status);
        }


        private void service_LoginCompleted(object sender, LoginCompletedEventArgs e)
        {
            LoginResult result = new LoginResult() { Result = LoginResultFlags.ErrorNet };
            if (e.Error != null)
            {
                result.Result = LoginResultFlags.ErrorNet;
            }
            else if (e.Result == null)
            {
                result.Result = LoginResultFlags.ErrorService;
            }
            else
            {
                result = e.Result;
            }

            Session session = new Session(this._userName, this._pwd,
                result.LastTime, result.LastAddress, this.service.CookieContainer);
            App.CurrentApp.Session = session;
            if (this.LoginCompleted != null)
            {
                this.LoginCompleted(result, e.UserState);
            }
        }




    }
}
