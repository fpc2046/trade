using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Trade.ClientApp.BLL;

namespace Trade.ClientApp.BLLControls
{
    public partial class UCPriceTable : UserControl
    {
        public UCPriceTable()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.dataGridView1.AutoGenerateColumns = false;
            this.gridRow = new Dictionary<string, DataGridViewRow>();
            this.cellStyles = new DataGridViewCellStyle[] 
            {
                null,
                new DataGridViewCellStyle(){ ForeColor= Color.Red },
                new DataGridViewCellStyle(){ ForeColor= Color.FromArgb(0,128,0) },
            };
        }
        public event Action<string, string, bool> PriceBlockDoubleClick;

        private DataGridViewCellStyle[] cellStyles;
        private Dictionary<string, DataGridViewRow> gridRow = new Dictionary<string, DataGridViewRow>();


        internal void SetDataSource(PriceData priceData)
        {
            priceData.RowUpdated += new Action<DataRow>(priceData_RowUpdated);
            priceData.RowAdded += new Action<DataRow>(priceData_RowAdded);
            this.dataGridView1.DataSource = priceData.HqTable;
        }

        private void priceData_RowAdded(DataRow row)
        {
            priceData_RowUpdated(row);
        }



        private void priceData_RowUpdated(DataRow row)
        {
            foreach (DataGridViewRow gridrow in this.dataGridView1.Rows)
            {
                string name = (gridrow.Cells["CommodityName"].Value ?? string.Empty).ToString();
                string namedata = row["CommodityName"].ToString();
                if (name == namedata)
                {
                    int imgKey = Math.Max(0, "ARG".IndexOf(row["ColImageID"].ToString()[0]));
                    if (gridrow.Index >= 0)
                    {
                        gridrow.Cells["SellPrice"].Style = this.cellStyles[imgKey];
                        gridrow.Cells["BuyPrice"].Style = this.cellStyles[imgKey];
                    }
                    break;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            DataRowView rView = row.DataBoundItem as DataRowView;

            if (rView != null)
            {
                if (this.dataGridView1.Columns[e.ColumnIndex] == this.SellPrice)
                {
                    OnPriceBlockDoubleClick(rView, false);
                }
                else if (this.dataGridView1.Columns[e.ColumnIndex] == this.BuyPrice)
                {
                    OnPriceBlockDoubleClick(rView, true);
                }
            }


        }

        private void OnPriceBlockDoubleClick(DataRowView rView, bool isbuy)
        {
            string name = (rView["CommodityName"] ?? string.Empty).ToString();
            string commID = (rView["CommodityID"] ?? string.Empty).ToString();
            if (this.PriceBlockDoubleClick != null)
            {
                this.PriceBlockDoubleClick(name, commID, isbuy);
            }
        }
    }
}
