using System;
using System.Windows.Forms;
using Trade.ClientApp.BLL;
using System.Drawing;

namespace Trade.ClientApp
{
    internal partial class App
    {
        public static App CurrentApp { get; private set; }

        public CommonData Data { get; set; }

        public Session Session { get; set; }

        public SettingInfo UserSetting { get; set; }

        public YUJingInfo YuJingInfo { get; set; }

        public UCIndexFream IndexFream { get; set; }

        public static Icon Logo { get; set; }

        public static Image MainBG { get; set; }

    }

    internal partial class App
    {
        private ChannelMainForm chaMainForm;
        private ChannelLoginForm chaLoginForm;

        internal App()
        {
            try
            {
                Logo = new Icon("Custom\\logo.ico");
                MainBG = Image.FromFile("Custom\\main.jpg");

            }
            catch
            {
            }
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            App.CurrentApp = this;
            this.Data = new CommonData();
            this.chaMainForm = new ChannelMainForm();
            this.chaLoginForm = new ChannelLoginForm();
            this.chaLoginForm.LoginSuccessed += new Action(chaLoginForm_LoginSuccessed);
        }

        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {

        }

        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
        }

        internal void Run()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            if (this.chaMainForm.MainForm != null)
            {
                this.chaLoginForm.StartMonitorLogin();
                Application.Run(this.chaMainForm.MainForm);
            }
        }

        private void chaLoginForm_LoginSuccessed()
        {
            this.chaMainForm.ShowIndexFream();
        }

        internal void Logout()
        {
            if (this.chaMainForm.MainForm != null)
            {
                this.chaLoginForm.StartMonitorLogin();
                this.chaMainForm.Logout();
            }
        }

    }
}
