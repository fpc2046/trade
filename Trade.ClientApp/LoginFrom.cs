using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Trade.ClientApp.Controls;

namespace Trade.ClientApp
{
    public partial class LoginFrom : NoBorderFrom
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Assembly asbFrame = Assembly.LoadFile(Application.StartupPath + "\\SysFrame.exe");
            Assembly asbBizComm = Assembly.LoadFile(Application.StartupPath + "\\BizComm.dll");


            object obj = System.Activator.CreateInstance(asbBizComm.GetType("BizComm.BizCommCenter"));
            asbFrame.GetType("SysFrame.Program").GetField("g_cBizCommCenter").SetValue(null, obj);

            Type mainFream = asbFrame.GetType("SysFrame.Frame");
            object from = System.Activator.CreateInstance(mainFream, new object[] { new string[0] });
            mainFream.GetMethod("Show", new Type[0]).Invoke(from, new object[0]);

        }
    }
}
