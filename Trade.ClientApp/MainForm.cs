using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trade.ClientApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            LoginFrom loginFrm = new LoginFrom();
            loginFrm.ShowDialog();
        }
    }
}
