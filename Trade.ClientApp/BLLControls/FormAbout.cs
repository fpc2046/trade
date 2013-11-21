using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trade.ClientApp.BLLControls
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            if (App.Logo != null)
            {
                this.pictureBox1.Image = App.Logo.ToBitmap();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
