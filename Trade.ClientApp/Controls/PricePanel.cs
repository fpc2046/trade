using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using Trade.ClientApp.BLL;

namespace Trade.ClientApp.Controls
{
    public class PricePanel : FlowLayoutPanel
    {
        public PricePanel()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.Selectable | ControlStyles.UserMouse, true);
            this.priceControls = new Dictionary<string, PriceBlock>();
        }

        public event Action<string, string, bool> PriceBlockDoubleClick;

        private Dictionary<string, PriceBlock> priceControls;

        internal void SetDatasource(PriceData priceData)
        {
            priceData.RowAdded += new Action<DataRow>(priceData_RowAdded);
            priceData.RowUpdated += new Action<DataRow>(priceData_RowUpdated);
            foreach (DataRow row in priceData.HqTable.Rows)
            {
                this.AddPrice(row);
            }
        }

        private void priceData_RowUpdated(DataRow row)
        {
            this.UpdatePrice(row);
        }

        private void priceData_RowAdded(DataRow row)
        {
            this.AddPrice(row);
        }

        private void AddPrice(DataRow row)
        {
            string name = row["CommodityName"].ToString().Trim();
            if (!this.priceControls.ContainsKey(name))
            {
                PriceBlock block = new PriceBlock();
                block.MouseDoubleClick += new MouseEventHandler(block_MouseDoubleClick);
                this.Controls.Add(block);
                this.priceControls[name] = block;
                block.Update(row);
            }
            else
            {
                this.priceControls[name].Update(row);
            }
        }

        private void block_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.PriceBlockDoubleClick != null)
            {
                PriceBlock block = (PriceBlock)sender;
                this.PriceBlockDoubleClick(block.CommodityName, block.CommodityID, e.X > block.Width / 2);
            }
        }

        private void UpdatePrice(DataRow row)
        {
            string name = row["CommodityName"].ToString().Trim();
            if (this.priceControls.ContainsKey(name))
            {
                this.priceControls[name].Update(row);
            }
        }

        #region 设计器生成
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PricePanel
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResumeLayout(false);
        }
        #endregion
    }
}
