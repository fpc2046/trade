using System;
using System.Reflection;
using System.Windows.Forms;
using Trade.ClientApp.ClientService;

namespace Trade.ClientApp.BLL
{
    internal class ChannelLoginForm
    {
        public class LoginState
        {
            public LoginState(Form loginForm,
                object sender, EventArgs e,
                string userName, string pwd, string vcode, string evnironment)
            {
                this.LoginFrom = loginForm;
                this.Sender = sender;
                this.Args = e;

                this.Environment = evnironment;
                this.UserName = userName;
                this.Pwd = pwd;
            }

            public string UserName { get; set; }

            public string Pwd { get; set; }

            public EventArgs Args { get; set; }

            public Form LoginFrom { get; set; }

            public object Sender { get; set; }

            public string Environment { get; set; }
        }

        public ChannelLoginForm()
        {
            this.loginPlug = new LoginPlug();
            this.loginPlug.LoginCompleted += new Action<LoginResult, object>(loginPlug_LoginCompleted);
        }

        public event Action LoginSuccessed;

        private Timer tmrMonitorLogin;
        private IntPtr loginFromPtr;
        private LoginPlug loginPlug;

        internal void StartMonitorLogin()
        {
            if (this.tmrMonitorLogin == null)
            {
                this.tmrMonitorLogin = new Timer();
                this.tmrMonitorLogin.Interval = 1000;
                this.tmrMonitorLogin.Tick += new EventHandler(tmrMonitorLogin_Tick);
            }
            this.tmrMonitorLogin.Start();
        }

        private void EnableControls(bool isLoading, Form loginForm)
        {
            loginForm.Controls["buttonLogin"].Enabled = !isLoading;
            loginForm.GetType().GetMethod("EnableControls",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Default)
                .Invoke(loginForm, new object[] { !isLoading, "null" });
        }

        private void tmrMonitorLogin_Tick(object sender, EventArgs e)
        {
            Form loginForm = Application.OpenForms["LoginForm"];

            if (loginForm != null && loginForm.GetType().Name.Equals("LoginForm"))
            {
                if (loginForm.Handle == this.loginFromPtr)
                {
                    return;
                }

                this.loginFromPtr = loginForm.Handle;

                Button btnLogin = loginForm.Controls["buttonLogin"] as Button;

                MethodInfo method = loginForm.GetType().GetMethod("buttonLogin_Click",
                    BindingFlags.DeclaredOnly | BindingFlags.Default | BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                btnLogin.Click -= (EventHandler)Delegate.CreateDelegate(typeof(System.EventHandler), (object)loginForm, method);
                btnLogin.Click -= new EventHandler(btnLogin_Click);
                btnLogin.Click += new EventHandler(btnLogin_Click);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                Form loginForm = btn.FindForm();

                string userName = loginForm.Controls["userName"].Text;
                string pwd = loginForm.Controls["password"].Text;
                string vcode = loginForm.Controls["tbVerifyCode"].Text;
                string env = loginForm.Controls["cbEnvrionment"].Text;

                if (this.CheckInput(userName, pwd, vcode, env, loginForm))
                {
                    this.EnableControls(true, loginForm);
                    this.loginPlug.BeginLogin(userName, pwd, vcode, env,
                        new LoginState(loginForm, sender, e, userName, pwd, vcode, env));
                }
            }
            else
            {
                MessageBox.Show("系统文件已损坏,请重新安装");
            }
        }

        private bool CheckInput(string user, string pwd, string vcode, string envName, Form loginFrom)
        {
            if (string.IsNullOrEmpty((user ?? string.Empty).Trim()))
            {
                MessageBox.Show("请输入用户名！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginFrom.Controls["userName"].Focus();
                return false;
            }
            if (string.IsNullOrEmpty((pwd ?? string.Empty).Trim()))
            {
                MessageBox.Show("请输入密码！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginFrom.Controls["password"].Focus();
                return false;
            }
            if (string.IsNullOrEmpty((vcode ?? string.Empty).Trim()))
            {
                MessageBox.Show("请输入验证码！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginFrom.Controls["tbVerifyCode"].Focus();
                return false;
            }
            //if (envName != null && envName.Contains("模拟盘"))
            //{
            //    MessageBox.Show("登录失败！交易代码不存在！", "无法连接", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    loginFrom.Controls["cbEnvrionment"].Focus();
            //    return false;
            //}
            return true;
        }

        private void loginPlug_LoginCompleted(LoginResult result, object state)
        {
            LoginState loginStatus = (LoginState)state;
            App.CurrentApp.Session.Environment = loginStatus.Environment;
            if (loginStatus.LoginFrom == null || loginStatus.LoginFrom.IsDisposed)
            {
                return;
            }
            this.EnableControls(false, loginStatus.LoginFrom);
            switch (result.Result)
            {
                case LoginResultFlags.NullUser:
                    this.LoginOldTrade(loginStatus);
                    break;
                case LoginResultFlags.Success:
                    this.LoginNewTrade(loginStatus, result);
                    break;
                case LoginResultFlags.ErrorName:
                    MessageBox.Show("登录失败！交易代码不存在！", "无法连接", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case LoginResultFlags.ErrorPWD:
                    MessageBox.Show("登录失败！登录密码输入有误！", "无法连接", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case LoginResultFlags.ErrorCode:
                    MessageBox.Show("登录失败！验证码输入有误或已过期！", "无法连接", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case LoginResultFlags.ErrorNet:
                    MessageBox.Show("登录失败！\n请在\"网络设置\"中切换其他链路再尝试。", "无法连接", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case LoginResultFlags.ErrorService:
                    MessageBox.Show("登录失败！\n服务器发生内部错误。", "无法连接", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    //showError
                    MessageBox.Show(result.Result.ToString());
                    break;
            }
        }

        private void LoginOldTrade(LoginState loginStatus)
        {
            Form loginForm = loginStatus.LoginFrom;
            MethodInfo method = loginForm.GetType().GetMethod("buttonLogin_Click",
                BindingFlags.DeclaredOnly | BindingFlags.Default | BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            method.Invoke(loginForm, new object[] { loginStatus.Sender, loginStatus.Args });
        }

        private void LoginNewTrade(LoginState loginStatus, LoginResult result)
        {
            loginStatus.LoginFrom.DialogResult = DialogResult.Cancel;
            if (this.LoginSuccessed != null)
            {
                this.LoginSuccessed();
            }
        }
    }
}
