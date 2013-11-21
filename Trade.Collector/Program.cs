using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace Trade.Collector
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            App app = new App();
            app.Run(args);
        }
    }
}
