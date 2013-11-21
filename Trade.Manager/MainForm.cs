using System.Collections.Generic;
using System.Windows.Forms;
using FarsiLibrary.Win;
using Trade.Manager.UcContorls;

namespace Trade.Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            tabMain.TabStripItemClosing += TabMainTabStripItemClosing;
            tsmiDeals.Click += ItemClick;
            tsmiAnnouncements.Click += ItemClick;
            tsmiFlows.Click += ItemClick;
            tsmiFundDetails.Click += ItemClick;
            tsmiFunds.Click += ItemClick;
            tsmiHolds.Click += ItemClick;
            tsmiImport.Click += ItemClick;
            tsmiOps.Click += ItemClick;
            tsmiSales.Click += ItemClick;
            tsmiBankAccount.Click += ItemClick;
            tsbtnExit.Click += TsbtnExitClick;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TsbtnExitClick(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("确认退出系统？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        void ItemClick(object sender, System.EventArgs e)
        {
            var clickitem = sender as ToolStripItem;
            if (clickitem != null)
            {
                var key = clickitem.Text;
                switch (key)
                {
                    case "平仓明细":
                        {
                            if (!_openList.Contains(key))
                            {
                                var uc = new UcSales { Dock = DockStyle.Fill };
                                var item = new FATabStripItem(key, uc) { Text = key };
                                tabMain.Items.Add(item);
                                _openList.Add(key);
                                tabMain.SelectedItem = item;
                            }
                            else
                            {
                                SelectItem(key);
                            }
                        }
                        break;
                    case "成交明细":
                        {
                            if (!_openList.Contains(key))
                            {
                                var uc = new UcDeals { Dock = DockStyle.Fill };
                                var item = new FATabStripItem(key, uc) { Text = key };
                                tabMain.Items.Add(item);
                                _openList.Add(key);
                                tabMain.SelectedItem = item;
                            }
                            else
                            {
                                SelectItem(key);
                            }
                        }
                        break;
                    case "持仓明细":
                        {
                            if (!_openList.Contains(key))
                            {
                                var uc = new UcHolds { Dock = DockStyle.Fill };
                                var item = new FATabStripItem(key, uc) { Text = key };
                                tabMain.Items.Add(item);
                                _openList.Add(key);
                                tabMain.SelectedItem = item;
                            }
                            else
                            {
                                SelectItem(key);
                            }
                        }
                        break;
                    case "资金流水":
                        {
                            if (!_openList.Contains(key))
                            {
                                var uc = new UcFunds { Dock = DockStyle.Fill };
                                var item = new FATabStripItem(key, uc) { Text = key };
                                tabMain.Items.Add(item);
                                _openList.Add(key);
                                tabMain.SelectedItem = item;
                            }
                            else
                            {
                                SelectItem(key);
                            }
                        }
                        break;
                    case "资金状态":
                        {
                            if (!_openList.Contains(key))
                            {
                                var uc = new UcFundDetail { Dock = DockStyle.Fill };
                                var item = new FATabStripItem(key, uc) { Text = key };
                                tabMain.Items.Add(item);
                                _openList.Add(key);
                                tabMain.SelectedItem = item;
                            }
                            else
                            {
                                SelectItem(key);
                            }
                        }
                        break;
             
                    case "数据导入":
                        {
                            if (!_openList.Contains(key))
                            {
                                var uc = new UcImport { Dock = DockStyle.Fill };
                                var item = new FATabStripItem(key, uc) { Text = key };
                                tabMain.Items.Add(item);
                                _openList.Add(key);
                                tabMain.SelectedItem = item;
                            }
                            else
                            {
                                SelectItem(key);
                            }
                        }
                        break;
                    case "公告表":
                        {
                            if (!_openList.Contains(key))
                            {
                                var uc = new UcAnnouncement { Dock = DockStyle.Fill };
                                var item = new FATabStripItem(key, uc) { Text = key };
                                tabMain.Items.Add(item);
                                _openList.Add(key);
                                tabMain.SelectedItem = item;
                            }
                            else
                            {
                                SelectItem(key);
                            }
                        }
                        break;
                    case "出入金流水":
                        {
                            if (!_openList.Contains(key))
                            {
                                var uc = new UcFundFlows { Dock = DockStyle.Fill };
                                var item = new FATabStripItem(key, uc) { Text = key };
                                tabMain.Items.Add(item);
                                _openList.Add(key);
                                tabMain.SelectedItem = item;
                            }
                            else
                            {
                                SelectItem(key);
                            }
                        }
                        break;
                    case "出入金操作":
                        {
                            if (!_openList.Contains(key))
                            {
                                var uc = new UcTradeAccountFund { Dock = DockStyle.Fill };
                                var item = new FATabStripItem(key, uc) { Text = key };
                                tabMain.Items.Add(item);
                                _openList.Add(key);
                                tabMain.SelectedItem = item;
                            }
                            else
                            {
                                SelectItem(key);
                            }
                        }
                        break;
                    case "银行账号":
                        {
                            if (!_openList.Contains(key))
                            {
                                var uc = new UcBankAccountFound { Dock = DockStyle.Fill };
                                var item = new FATabStripItem(key, uc) { Text = key };
                                tabMain.Items.Add(item);
                                _openList.Add(key);
                                tabMain.SelectedItem = item;
                            }
                            else
                            {
                                SelectItem(key);
                            }
                        }
                        break;
                }
            }
        }


        void TabMainTabStripItemClosing(TabStripItemClosingEventArgs e)
        {
             if (_openList.Contains(e.Item.Text))
            {
                _openList.Remove(e.Item.Text);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private readonly List<string> _openList = new List<string>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var key = e.ClickedItem.Text;
            switch (key)
            {
                case "平仓":
                    {
                        if (!_openList.Contains(key))
                        {
                            var uc = new UcSales {Dock = DockStyle.Fill};
                            var item = new FATabStripItem(key, uc) {Text = key};
                            tabMain.Items.Add(item);
                            _openList.Add(key);
                            tabMain.SelectedItem = item;
                        }
                        else
                        {
                            SelectItem(key);
                        }
                    }
                    break;
                case "成交":
                    {
                        if (!_openList.Contains(key))
                        {
                            var uc = new UcDeals {Dock = DockStyle.Fill};
                            var item = new FATabStripItem(key, uc) {Text = key};
                            tabMain.Items.Add(item);
                            _openList.Add(key);
                            tabMain.SelectedItem = item;
                        }
                        else
                        {
                            SelectItem(key);
                        }
                    }
                    break;
                case "持仓":
                    {
                        if (!_openList.Contains(key))
                        {
                            var uc = new UcHolds {Dock = DockStyle.Fill};
                            var item = new FATabStripItem(key, uc) {Text = key};
                            tabMain.Items.Add(item);
                            _openList.Add(key);
                            tabMain.SelectedItem = item;
                        }
                        else
                        {
                            SelectItem(key);
                        }
                    }
                    break;
                case "资金流水":
                    {
                        if (!_openList.Contains(key))
                        {
                            var uc = new UcFunds {Dock = DockStyle.Fill};
                            var item = new FATabStripItem(key, uc) {Text = key};
                            tabMain.Items.Add(item);
                            _openList.Add(key);
                            tabMain.SelectedItem = item;
                        }
                        else
                        {
                            SelectItem(key);
                        }
                    }
                    break;
                case "资金状态":
                    {
                        if (!_openList.Contains(key))
                        {
                            var uc = new UcFundDetail {Dock = DockStyle.Fill};
                            var item = new FATabStripItem(key, uc) {Text = key};
                            tabMain.Items.Add(item);
                            _openList.Add(key);
                            tabMain.SelectedItem = item;
                        }
                        else
                        {
                            SelectItem(key);
                        }
                    }
                    break;
                case "退出":
                    {
                        if (MessageBox.Show("确认退出系统？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            Close();
                    }
                    break;
                case "数据导入":
                    {
                        if (!_openList.Contains(key))
                        {
                            var uc = new UcImport { Dock = DockStyle.Fill };
                            var item = new FATabStripItem(key, uc) { Text = key };
                            tabMain.Items.Add(item);
                            _openList.Add(key);
                            tabMain.SelectedItem = item;
                        }
                        else
                        {
                            SelectItem(key);
                        }
                    }
                    break;
                case "公告表":
                    {
                        if (!_openList.Contains(key))
                        {
                            var uc = new UcAnnouncement { Dock = DockStyle.Fill };
                            var item = new FATabStripItem(key, uc) { Text = key };
                            tabMain.Items.Add(item);
                            _openList.Add(key);
                            tabMain.SelectedItem = item;
                        }
                        else
                        {
                            SelectItem(key);
                        }
                    }
                    break;
                case "出入金流水":
                    {
                        if (!_openList.Contains(key))
                        {
                            var uc = new UcFundFlows { Dock = DockStyle.Fill };
                            var item = new FATabStripItem(key, uc) { Text = key };
                            tabMain.Items.Add(item);
                            _openList.Add(key);
                            tabMain.SelectedItem = item;
                        }
                        else
                        {
                            SelectItem(key);
                        }
                    }
                    break;
                case "出入金操作":
                    {
                        if (!_openList.Contains(key))
                        {
                            var uc = new UcTradeAccountFund { Dock = DockStyle.Fill };
                            var item = new FATabStripItem(key, uc) { Text = key };
                            tabMain.Items.Add(item);
                            _openList.Add(key);
                            tabMain.SelectedItem = item;
                        }
                        else
                        {
                            SelectItem(key);
                        }
                    }
                    break;
                case "银行帐号":
                    {
                        if (!_openList.Contains(key))
                        {
                            var uc = new UcBankAccountFound { Dock = DockStyle.Fill };
                            var item = new FATabStripItem(key, uc) { Text = key };
                            tabMain.Items.Add(item);
                            _openList.Add(key);
                            tabMain.SelectedItem = item;
                        }
                        else
                        {
                            SelectItem(key);
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        private void SelectItem(string key)
        {
            foreach (FATabStripItem item in tabMain.Items)
            {
                if (item.Text == key)
                    tabMain.SelectedItem = item;
            }
        }
    }
}
