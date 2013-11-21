using System;
using System.Windows.Forms;
using Trade.ClientApp.BLL;
using Trade.ClientApp.BLLControls;
using Trade.ClientApp.Controls;
using System.Drawing;
using System.Diagnostics;

namespace Trade.ClientApp.BLLControls
{
    public partial class UCTrade : UserControl
    {
        public UCTrade()
        {
            InitializeComponent();

            this.priceTable = new UCPriceTable();
            this.priceTable.PriceBlockDoubleClick += new Action<string, string, bool>(pricePanel_PriceBlockDoubleClick);
            this.pricePanel = new PricePanel();
            this.pricePanel.PriceBlockDoubleClick += new Action<string, string, bool>(pricePanel_PriceBlockDoubleClick);
            this.tableGroup = new UCTableGroup();
            this.tableGroup.BackColor = Color.White;

            this.priceDatas = new PriceData();
            this.priceListen = new PriceListenor(new Timer(), App.CurrentApp.Session);
            this.priceListen.PriceDatas = this.priceDatas;

            this.Dock = DockStyle.Fill;
        }




        private PriceListenor priceListen;
        private PriceData priceDatas;

        /// <summary>
        /// 水平
        /// </summary>
        private bool horizontalOrder = false;
        private SplitControl horizontalControl;
        private SplitControl verticalControl;
        private PricePanel pricePanel;
        private UCPriceTable priceTable;
        private UCTableGroup tableGroup;
        private Process calcProcess;
        private Process helpProcess;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (this.DesignMode)
            {
                return;
            }
            try
            {
                Form mainForm = this.FindForm();
                mainForm.KeyDown -= new KeyEventHandler(mainForm_KeyDown);
                mainForm.KeyDown += new KeyEventHandler(mainForm_KeyDown);
            }
            catch
            {
            }

            Timer t = new Timer();
            t.Interval = 50;
            t.Tick += (o, e2) =>
            {
                t.Stop();
                t.Dispose();
                this.OrderMainFream();
                this.priceDatas.InitRow();

                Timer t2 = new Timer();
                t2.Interval = 1500;
                t2.Tick += (o3, e3) =>
                {
                    t2.Stop();
                    this.priceDatas.EndInitRow();
                };
                t2.Start();

                this.priceListen.BeginGetPrice();
                this.priceTable.SetDataSource(this.priceDatas);
                this.pricePanel.SetDatasource(this.priceDatas);
            };
            t.Start();
        }


        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.IsDisposed || !this.Visible)
            {
                Form mainForm = sender as Form;
                if (mainForm != null)
                {
                    mainForm.KeyDown -= new KeyEventHandler(mainForm_KeyDown);
                }
                return;
            }
            if (e.KeyCode == Keys.F1)
            {
                this.tsbtnHelper_Click(this.tsbtnHelper, e);
            }
        }


        #region 布局

        private void OrderMainFream()
        {
            if (this.horizontalControl == null)
            {
                this.horizontalControl = new SplitControl()
                {
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    Orientation = Orientation.Vertical,
                    SplitterWidth = 6
                };

                this.verticalControl = new SplitControl()
                {
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    Orientation = Orientation.Horizontal,
                    SplitterWidth = 6
                };
            }

            this.panMain.SuspendLayout();
            this.horizontalControl.Parent = null;
            this.verticalControl.Parent = null;
            this.priceTable.Parent = null;
            this.pricePanel.Parent = null;
            this.tableGroup.Parent = null;
            if (this.horizontalOrder)
            {
                this.horizontalControl.Parent = this.verticalControl.Panel1;
                this.verticalControl.Parent = this.panMain;
                this.priceTable.Parent = this.horizontalControl.Panel1;
                this.pricePanel.Parent = this.horizontalControl.Panel2;
                this.tableGroup.Parent = this.verticalControl.Panel2;
            }
            else
            {

                this.verticalControl.Parent = this.horizontalControl.Panel1;
                this.horizontalControl.Parent = this.panMain;
                this.priceTable.Parent = this.verticalControl.Panel1;
                this.pricePanel.Parent = this.horizontalControl.Panel2;
                this.tableGroup.Parent = this.verticalControl.Panel2;
            }
            this.panMain.ResumeLayout(true);

            if (this.horizontalOrder)
            {
                this.horizontalControl.SplitterDistance = panMain.Width / 2;
                this.verticalControl.SplitterDistance = panMain.Height / 4;
            }
            else
            {
                this.verticalControl.SplitterDistance = panMain.Height / 4;
                this.horizontalControl.SplitterDistance = Math.Max(panMain.Width - 220, panMain.Width * 2 / 3);
            }
        }

        private void tsmiVerOrder_Click(object sender, EventArgs e)
        {
            this.horizontalOrder = false;
            this.OrderMainFream();
        }

        private void tsmiHorOrder_Click(object sender, EventArgs e)
        {
            this.horizontalOrder = true;
            this.OrderMainFream();
        }

        #endregion

        private void tsbtnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.calcProcess == null || this.calcProcess.HasExited)
                {
                    if (this.calcProcess == null)
                    {
                        this.calcProcess = new Process();
                        this.calcProcess.StartInfo.FileName = "calc";
                    }
                    this.calcProcess.Start();
                }
                else
                {
                    this.calcProcess.CloseMainWindow();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pricePanel_PriceBlockDoubleClick(string comName, string comID, bool isBuy)
        {
            if (!this.menuStrip1.Enabled)
            {
                return;
            }
            FormJianCang form = new FormJianCang(this.priceDatas, comID, isBuy);
            form.ShowDialog();
        }


        private void tsbtnJianCang_Click(object sender, EventArgs e)
        {
            FormJianCang form = new FormJianCang(this.priceDatas);
            form.ShowDialog();
        }

        private void tsbtnPingCang_Click(object sender, EventArgs e)
        {
            FormPingCang form = new FormPingCang(this.priceDatas);
            form.ShowDialog();
        }

        private void tsbtnYuJing_Click(object sender, EventArgs e)
        {
            FormYuJing form = new FormYuJing(this.priceDatas);
            form.ShowDialog();
        }

        private void tsbtnPeiZhi_Click(object sender, EventArgs e)
        {
            FormSetting form = new FormSetting();
            form.ShowDialog();
        }

        private void tsbtnlock_Click(object sender, EventArgs e)
        {
            UCSysLock uclock = new UCSysLock();
            uclock.Parent = this.tableGroup.Parent;
            uclock.BringToFront();
        }

        private void tsbtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnContSet_Click(object sender, EventArgs e)
        {
            this.contextMenuCon.Show(MousePosition);
        }


        private void tsbtnHelper_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.helpProcess == null || this.helpProcess.HasExited)
                {
                    if (this.helpProcess == null)
                    {
                        this.helpProcess = new Process();
                        this.helpProcess.StartInfo.FileName = "help_c.CHM";
                    }
                    this.helpProcess.Start();
                }
                else
                {
                    this.helpProcess.CloseMainWindow();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        internal void LockFream(bool isLock)
        {
            this.menuStrip1.Enabled = !isLock;
            this.toolStrip1.Enabled = !isLock;
        }

        private void contextMenuCon_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in this.contextMenuCon.Items)
            {
                if (item == e.ClickedItem)
                {
                    item.Image = Properties.Resources.checked_MI;
                }
                else
                {
                    item.Image = null;
                }
            }
        }


    }
}
