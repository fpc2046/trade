using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Trade.ClientApp.BLLControls
{
    public partial class UCFunction2 : UserControl
    {
        public UCFunction2()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView3.AutoGenerateColumns = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.DesignMode)
            {
                return;
            }

            DataTable dt = App.CurrentApp.Data.Account;
            if (dt != null)
            {
                this.dataGridView3.DataSource = dt;
            }
        }
    }
}
