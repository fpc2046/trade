using System;
using System.Windows.Forms;
using Trade.Manager.Frms;
using Trade.Manager.localhost;

namespace Trade.Manager
{
    public partial class UcFundDetail : UcMaintenance
    {
        public UcFundDetail()
        {
            InitializeComponent();

            dgvMain.SelectionChanged += DgvMainSelectionChanged;
            btnAdd.Click += BtnAddClick;
            btnDel.Click += BtnDelClick;
            btnModify.Click += BtnModifyClick;
            btnRefresh.Click += BtnRefreshClick;
            dgvMain.CellMouseDoubleClick += DgvMainCellMouseDoubleClick;
            btnClear.Click += BtnClearClick;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BtnClearClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定清空该表数据?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var srv = new ReportSrv();
                srv.CleanFundDetail();
                DataBinding();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DgvMainCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnModifyClick(null, null);
        }

        private int _id;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DgvMainSelectionChanged(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count > 0)
            {
                _id = int.Parse(dgvMain.SelectedRows[0].Cells["ID"].Value.ToString());
            }
            else
            {
                _id = 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRefreshClick(object sender, EventArgs e)
        {
            DataBinding();
        }

        /// <summary>
        /// 
        /// </summary>
        private void DataBinding()
        {
            var srv = new ReportSrv();
            var dt = srv.GetListFundDetail("", "ID DESC");
            dgvMain.DataSource = dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddClick(object sender, EventArgs e)
        {
            var frm = new FrmFundDetailModify { Model = null, Text = "新增资金状况" };
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                DataBinding();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelClick(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count > 0)
            {
                string condition = "";
                foreach (DataGridViewRow row in dgvMain.SelectedRows)
                {
                    condition += row.Cells["ID"].Value + ",";
                }
                if (!string.IsNullOrEmpty(condition))
                {
                    condition = condition.Remove(condition.Length - 1, 1);
                    condition = string.Format("({0})", condition);
                    var ws = new ReportSrv().DeleteListFundDetail(condition);
                    if (ws)
                    {
                        DataBinding();
                        MessageBox.Show("删除成功！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("删除失败,请稍后重试！", "提示");
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifyClick(object sender, EventArgs e)
        {
            var model = GetModel();
            if (model == null)
            {
                MessageBox.Show("选中资料行才能修改.", "提示");
                return;
            }
            var frm = new FrmFundDetailModify { Model = model, Text = "修改资金状况" };
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                DataBinding();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private FundDetail GetModel()
        {
            if (_id == 0) return null;

            var list = dgvMain.DataSource as FundDetail[];
            if (list != null)
            {
                foreach (var sale in list)
                {
                    if (sale.ID == _id)
                    {
                        return sale;
                    }
                }
            }
            return null;
        }
    }
}
