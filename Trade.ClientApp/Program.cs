using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Trade.ClientApp
{
    static class Program
    {
        public static string ServiceUrl { get; private set; }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string str = BLL.Base64.Base64Code("http://s-88953.abc188.com/clientSrv.asmx");

            //StreamWriter w = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\TradeInterface.dat");
            //w.Write("TYxOTM");
            //w.Write(str);
            //w.Write("0aW9uU");
            //w.Flush();

            try
            {
                using (StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\TradeInterface.dat"))
                {
                    string fullText = reader.ReadToEnd().Trim();
                    Program.ServiceUrl = BLL.Base64.Base64Decode(fullText.Substring(6, fullText.Length - 12));
                }
            }
            catch (Exception ex)
            {
                ServiceUrl = Properties.Settings.Default.Trade_ClientApp_ClientService_ClientSrv;
                MessageBox.Show(ex.Message, "系统初始化异常");
            }

            App app = new App();
            app.Run();
        }
    }
}
