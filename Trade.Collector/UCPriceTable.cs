using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Trade.Collector
{
    public partial class UCPriceTable : UserControl
    {
        public UCPriceTable()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.dataGridView1.AutoGenerateColumns = false;
        }

        public void SetDataTable(DataTable dt)
        {
            this.dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
