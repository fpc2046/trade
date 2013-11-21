using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.Collections.Generic;
using Trade.ClientApp.BLLControls;

namespace Trade.ClientApp
{
    public partial class UCIndexFream : UserControl
    {
        public UCIndexFream()
        {
            InitializeComponent();
            this.panelMain.BackgroundImage = App.MainBG;
            this.splitControl1.BorderStyle = BorderStyle.None;
        }

        private BLL.DataPlug dataPlug;

        private Control curPage;
        private UCTrade ucTrade;
        private UcReport ucReport;
        private string userName;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Application.DoEvents();
            this.userName = App.CurrentApp.Session.UserName;
            this.InitAppData();
            this.NavigateTreeLoad(this.userName);
            this.tmrSecond.Start();
        }



        private void SetCurPage(Control control)
        {
            if (this.curPage == control)
            {
                return;
            }
            bool isTradeTime = this.IsTradeTime();
            bool showTsitem = (control == this.ucTrade);
            this.tslblTiShi.Visible = showTsitem;
            this.tslblFullRect.Visible = showTsitem;
            this.tslbltime.Visible = showTsitem;
            if (showTsitem)
            {
                this.tslblSysStatus.Visible = !isTradeTime;
                this.tslblEnvName.Text = "实盘环境";
            }
            else
            {
                this.tslblSysStatus.Visible = false;
                this.tslblEnvName.Text = "交易环境：实盘环境";
            }
            if (App.CurrentApp.Session != null)
            {
                this.tslblLoginUser.Text = (showTsitem ? " 登录用户:" : "登录帐号") + App.CurrentApp.Session.UserName;
            }

            if (this.curPage != null &&
                (this.ucReport == this.curPage || this.ucTrade == this.curPage))
            {
                this.curPage.Visible = false;
            }
            else if (this.curPage != null)
            {
                this.curPage.Dispose();
                this.curPage = null;
            }
            this.curPage = control;
            control.Parent = this.panelMain;
            control.Visible = true;
            control.BringToFront();
            control.Focus();
        }

        private bool IsTradeTime()
        {
            DateTime time = DateTime.Now;
            if (time.DayOfWeek == DayOfWeek.Sunday || time.DayOfWeek == DayOfWeek.Saturday)
            {
                return false;
            }
            if (time.Hour >= 4 && time.Hour < 7)
            {
                return false;
            }
            return true;
        }

        private void tmrSecond_Tick(object sender, EventArgs e)
        {
            this.tslbltime.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
        }

        #region 初始化数据

        private void InitAppData()
        {
            if (this.dataPlug == null)
            {
                this.dataPlug = new BLL.DataPlug();
                this.dataPlug.ValueChanged += new Action<string>(dataPlug_ValueChanged);
            }
            this.dataPlug.BeginLoadData();
        }

        private void dataPlug_ValueChanged(string status)
        {
            this.lblLoadingStatus.Text = status;
            this.progressBar1.Maximum = this.dataPlug.MaxValue;
            this.progressBar1.Value = this.dataPlug.Value;

            if (this.dataPlug.Value >= this.dataPlug.MaxValue)
            {
                this.OnLoadDataCompled();
            }
        }

        private void OnLoadDataCompled()
        {
            this.panLoginLoading.Parent = null;
            this.panLoginLoading.Visible = false;
            this.statusStrip1.Visible = true;
            this.tslblLoginUser.Text = " 登录用户:" + App.CurrentApp.Session.UserName;



            string address = App.CurrentApp.Session.LastAddress;
            string lastTime = App.CurrentApp.Session.LastTime;
            if (!string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(lastTime) && address.Trim().Length > 0 && lastTime.Trim().Length > 0)
            {
                BLLControls.TaskbarNotifier taskBar = new BLLControls.TaskbarNotifier();
                taskBar.ShowNotifier(this, address, lastTime);
            }

            Application.DoEvents();

            if (this.ucTrade == null)
            {
                this.ucTrade = new UCTrade();
                this.SetCurPage(this.ucTrade);
            }
        }

        #endregion

        #region 导航树

        #region 折叠
        private void treeLabel_Click(object sender, EventArgs e)
        {
            this.splitControl1.Panel1Collapsed = !this.splitControl1.Panel1Collapsed;
            this.lblTreeColl.Image = this.splitControl1.Panel1Collapsed ? Properties.Resources.right : Properties.Resources.left;
        }

        private void lblTreeColl_Paint(object sender, PaintEventArgs e)
        {
            if (this.lblTreeColl.Image != null)
            {
                e.Graphics.DrawImage(this.lblTreeColl.Image, new Rectangle(-1, 0, this.lblTreeColl.Width + 1, this.lblTreeColl.Height));
            }
        }
        #endregion

        private void NavigateTreeLoad(string userName)
        {
            this.navigateTree.ShowNodeToolTips = true;
            this.navigateTree.Nodes.Clear();
            this.navigateTree.Nodes.Add(new TreeNode("主菜单", 0, 0));

            string tradeText = string.IsNullOrEmpty(userName) ? "单击进入交易系统登录界面" :
                "单击进入交易系统登录界面(交易系统版本：2.6.0.0[2.6.0.0])";
            this.navigateTree.Nodes.Add(new TreeNode("交易系统", 1, 1) { Name = "Trade", ToolTipText = tradeText });
            if (!string.IsNullOrEmpty(userName))
            {
                this.navigateTree.Nodes.Add(new TreeNode("公告系统", 2, 2) { Name = "Announcement", ToolTipText = "单击进入公告查询登录界面(公告系统版本：2.6.0.0)" });
                this.navigateTree.Nodes.Add(new TreeNode("报表系统", 3, 3) { Name = "Report", ToolTipText = "单击进入报表系统登录界面(报表系统版本：2.6.0.0)" });
                this.navigateTree.Nodes.Add(new TreeNode("出入金管理 ", 4, 4) { Name = "GoldManage", ToolTipText = "单击进入出入金管理系统登录界面(出入金管理版本：2.6.0.0)" });
                this.navigateTree.Nodes.Add(new TreeNode(userName + "欢迎您", 5, 5, new TreeNode[] 
                 { 
                    new TreeNode("注销", 6, 6){ Name = "Logout",ToolTipText="注销所有系统" },
                    new TreeNode("修改密码", 7, 7){ Name = "ChangePWD" ,ToolTipText="修改密码" },
                 }) { Name = "funTree", ToolTipText = userName + "功能树" });
            }
            this.navigateTree.ExpandAll();
        }

        private void navigateTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "Trade":
                    this.SetCurPage(this.ucTrade);
                    break;
                case "Announcement":
                    if (this.curPage == null || this.curPage.GetType() != typeof(UCAnnouncement))
                    {
                        this.SetCurPage(new UCAnnouncement());
                    }
                    break;
                case "GoldManage":
                    if (this.curPage == null || this.curPage.GetType() != typeof(UCGoldManage))
                    {
                        this.SetCurPage(new UCGoldManage());
                    }
                    break;
                case "Logout":
                    if (MessageBox.Show("您确定要注销所有系统吗？", "程序注销", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        App.CurrentApp.Logout();
                    }
                    break;
                case "ChangePWD":
                    ChangePW pw = new ChangePW();
                    pw.ShowDialog();
                    break;
                case "Report":
                    if (this.curPage == null || this.curPage.GetType() != typeof(UcReport))
                    {
                        if (this.ucReport == null || this.ucReport.IsDisposed)
                        {
                            this.ucReport = new UcReport()
                                                {
                                                    Dock = DockStyle.Fill,
                                                    _userNo = this.userName,
                                                    _userName = App.CurrentApp.Data.Account.Rows[0]["AccountName"].ToString()
                                                };
                        }
                        this.SetCurPage(this.ucReport);
                    }
                    break;
            }
        }


        #endregion


        internal void LockFream(bool isLock)
        {
            if (isLock)
            {
                this.SetCurPage(this.ucTrade);
            }
            if (this.navigateTree != null && this.ucTrade != null)
            {
                this.statusStrip1.Visible = !isLock;
                this.navigateTree.Enabled = !isLock;
                this.ucTrade.LockFream(isLock);
            }
        }

        private void tslblConnect_Click(object sender, EventArgs e)
        {
            if (this.ucTrade != null && !this.ucTrade.IsDisposed)
            {
                this.ucTrade.contextMenuCon.Show(MousePosition);
            }
        }

        //internal static Bitmap left
        //{
        //    get
        //    {
        //        Assembly asb = Assembly.LoadFile(Application.StartupPath + "\\SysFrame.exe");
        //        var vv = asb.GetType("SysFrame.Global")
        //            .GetField("Plugins", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public | BindingFlags.Instance).GetValue(null);
        //        //var v2 = vv.GetType().GetProperty("SysResourceManager",BindingFlags.NonPublic | BindingFlags.Static| BindingFlags.Instance)
        //        //    .GetValue(vv,null);

        //        dynamic dy = vv;

        //        object @object = dy.SysResourceManager.GetObject("TradeImg_InfoClose");
        //        return (Bitmap)@object;
        //    }
        //}



    }
}
