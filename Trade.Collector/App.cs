using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;

namespace Trade.Collector
{
    internal class App : WindowsFormsApplicationBase
    {
        internal App()
        {
            this.mainWindow = new HQForm();
            this.IsSingleInstance = true;
        }

        private HQForm mainWindow;

        protected override bool OnStartup(StartupEventArgs eventArgs)
        {
            this.MainForm = this.mainWindow;
            return base.OnStartup(eventArgs);
        }





    }
}
