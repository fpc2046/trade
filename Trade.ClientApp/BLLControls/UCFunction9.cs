using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Trade.ClientApp.BLLControls
{
    public partial class UCFunction9 : UserControl
    {
        public UCFunction9()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (App.CurrentApp != null && App.CurrentApp.YuJingInfo != null
                && App.CurrentApp.Data != null && App.CurrentApp.Data.Commodity != null)
            {
                foreach (DataRow row in App.CurrentApp.Data.Commodity.Rows)
                {
                    this.commpoDic[row["CommodityID"].ToString()] = row["CommodityName"].ToString();
                }

                this.dataGridView1.DataSource = App.CurrentApp.YuJingInfo.Table;
            }
        }

        private Dictionary<string, string> commpoDic = new Dictionary<string, string>();


        internal static string[] YJLXS = new string[] { "行情预警",
                                                       "风险预警",
                                                       "当前权益预警",
                                                       "可用保证金预警",
                                                       "总浮动盈亏预警" };

        internal static string[][] YJXS = new string[][] { 
                    new string[] { "风险值" },
                    new string[] { "当前权益" },
                    new string[] { "可用保证金" }, 
                    new string[] { "总浮动盈亏" } 
                };

        internal static string[] YJTJS1 = new string[] { "买价>", "买价=", "买价<", "卖价>", "卖价=", "卖价<" };
        internal static string[] YJTJS2 = new string[] { ">", "=", "<" };
        internal static string[] XDSJD = new string[] { "10sec", "30sec", "60sec", "3min", "5min", "15min", "30min", "1hour" };

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 0 || e.RowIndex < 0)
                {
                    return;
                }
                DataRowView view = this.dataGridView1.Rows[e.RowIndex].DataBoundItem as DataRowView;
                DataGridViewColumn column = this.dataGridView1.Columns[e.ColumnIndex];
                if (column == this.colYJLX)
                {
                    string value = e.Value.ToString();
                    int index = "01234".IndexOf((value + "0")[0]);
                    e.Value = YJLXS[index];
                }
                else if (column == this.colYJX)
                {
                    string value = view["YJX"].ToString();

                    if (this.commpoDic.ContainsKey(value))
                    {
                        e.Value = this.commpoDic[value];
                    }
                    else
                    {
                        int index = 0;
                        if (!int.TryParse(value, out index))
                        {
                            index = 0;
                        }
                        string value2 = view["YJLX"].ToString();
                        e.Value = YJXS["1234".IndexOf((value2 + "0")[0])][index];
                    }
                }
                else if (column == this.colYJTJ)
                {
                    string value = view["YJTJ"].ToString();
                    string value2 = view["YJLX"].ToString();
                    string value3 = view["YJFZ"].ToString();
                    string[] yjtjs = value2 == "0" ? YJTJS1 : YJTJS2;
                    int index = 0;
                    if (!int.TryParse(value, out index))
                    {
                        index = 0;
                    }
                    e.Value = yjtjs[index] + value3;
                }
                else if (column == this.colYJFS)
                {
                    string value = view["YJFS"].ToString() + "00";
                    e.Value = ((value[0] == '0' ? "弹出窗口" : "") + "/" + (value[1] == '0' ? "发出声音" : "")).Trim('/');
                }
                else if (column == this.colSFYX)
                {
                    string value = view["SFYX"].ToString();
                    e.Value = (value == "Y" ? "是" : "否");
                }
                else if (column == this.colXDSJD)
                {
                    string value = view["XDSJD"].ToString();
                    int index = 0;
                    if (!int.TryParse(value, out index))
                    {
                        index = 0;
                    }
                    e.Value = XDSJD[index];
                }
            }
            catch
            {
                //
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            bool isEnable = false;
            if (this.dataGridView1.CurrentRow != null && this.dataGridView1.CurrentRow.Selected)
            {
                DataRowView view = this.dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                if (view != null)
                {
                    this.contextMenuStrip1.Tag = view;
                    isEnable = true;
                }
            }
            this.tsmiChanged.Enabled = isEnable;
            this.tsmiDelete.Enabled = isEnable;
            this.tsmiTurn.Enabled = isEnable;
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.dataGridView1.CurrentRow == null || this.dataGridView1.CurrentRow.Index < 0)
            {
                return;
            }
            Rectangle rect = dataGridView1.GetRowDisplayRectangle(this.dataGridView1.CurrentRow.Index, true);
            if (!rect.Contains(e.Location))
            {
                this.dataGridView1.CurrentRow.Selected = false;
            }
            else
            {
                this.dataGridView1.CurrentRow.Selected = true;
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void tsmiChanged_Click(object sender, EventArgs e)
        {
            if (this.contextMenuStrip1.Tag != null)
            {
                DataRowView view = this.contextMenuStrip1.Tag as DataRowView;
                FormYuJing form = new FormYuJing(BLL.PriceData.Current, view);
                form.ShowDialog();
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView view = this.contextMenuStrip1.Tag as DataRowView;
            FormYuJing form = new FormYuJing(BLL.PriceData.Current, null);
            form.ShowDialog();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (this.contextMenuStrip1.Tag != null)
            {
                DataRowView view = this.contextMenuStrip1.Tag as DataRowView;
                App.CurrentApp.YuJingInfo.DeleteRow(view.Row);
            }
        }

        private void tsmiTurn_Click(object sender, EventArgs e)
        {
            if (this.contextMenuStrip1.Tag != null)
            {
                DataRowView view = this.contextMenuStrip1.Tag as DataRowView;
                if (view["SFYX"].ToString() == "Y")
                {
                    view["SFYX"] = "N";
                }
                else
                {
                    view["SFYX"] = "Y";
                }
                App.CurrentApp.YuJingInfo.UpdateRow(view.Row);
            }
        }
    }
}
