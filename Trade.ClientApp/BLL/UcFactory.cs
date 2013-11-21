using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Trade.ClientApp.BLL
{
    public class UcFactory
    {
        public string UcName { get; set; }

        public UserControl Create()
        {
            return (UserControl)System.Activator.CreateInstance(Type.GetType(UcName));
        }
    }
}
