namespace Trade.ClientApp
{
    partial class UCIndexFream
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCIndexFream));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tmrSecond = new System.Windows.Forms.Timer(this.components);
            this.splitControl1 = new Trade.ClientApp.Controls.SplitControl();
            this.navigateTree = new Trade.ClientApp.UCNavigateTree();
            this.panelMain = new Trade.ClientApp.Controls.PanelControl();
            this.panLoginLoading = new System.Windows.Forms.Panel();
            this.lblLoadingStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panSplitButton = new System.Windows.Forms.Panel();
            this.lblTreeColl = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblTiShi = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblFullRect = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblSysStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblEnvName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblLoginUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbltime = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitControl1.Panel1.SuspendLayout();
            this.splitControl1.Panel2.SuspendLayout();
            this.splitControl1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panLoginLoading.SuspendLayout();
            this.panSplitButton.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "t_zy.bmp");
            this.imageList1.Images.SetKeyName(1, "t_jygl.bmp");
            this.imageList1.Images.SetKeyName(2, "t_gggl.bmp");
            this.imageList1.Images.SetKeyName(3, "t_bbgl.bmp");
            this.imageList1.Images.SetKeyName(4, "t_crjgl.bmp");
            this.imageList1.Images.SetKeyName(5, "t_hy.bmp");
            this.imageList1.Images.SetKeyName(6, "t_zx.bmp");
            this.imageList1.Images.SetKeyName(7, "t_xgmm.bmp");
            // 
            // tmrSecond
            // 
            this.tmrSecond.Interval = 500;
            this.tmrSecond.Tick += new System.EventHandler(this.tmrSecond_Tick);
            // 
            // splitControl1
            // 
            this.splitControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitControl1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitControl1.Location = new System.Drawing.Point(0, 0);
            this.splitControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitControl1.Name = "splitControl1";
            // 
            // splitControl1.Panel1
            // 
            this.splitControl1.Panel1.Controls.Add(this.navigateTree);
            // 
            // splitControl1.Panel2
            // 
            this.splitControl1.Panel2.Controls.Add(this.panelMain);
            this.splitControl1.Panel2.Controls.Add(this.panSplitButton);
            this.splitControl1.Panel2.Controls.Add(this.statusStrip1);
            this.splitControl1.Size = new System.Drawing.Size(841, 512);
            this.splitControl1.SplitterDistance = 184;
            this.splitControl1.SplitterWidth = 2;
            this.splitControl1.TabIndex = 0;
            // 
            // navigateTree
            // 
            this.navigateTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.navigateTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigateTree.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.navigateTree.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.navigateTree.ForeColor = System.Drawing.Color.White;
            this.navigateTree.ImageIndex = 0;
            this.navigateTree.ImageList = this.imageList1;
            this.navigateTree.Indent = 25;
            this.navigateTree.ItemHeight = 30;
            this.navigateTree.LineColor = System.Drawing.Color.White;
            this.navigateTree.Location = new System.Drawing.Point(0, 0);
            this.navigateTree.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.navigateTree.Name = "navigateTree";
            this.navigateTree.SelectedImageIndex = 0;
            this.navigateTree.Size = new System.Drawing.Size(182, 510);
            this.navigateTree.TabIndex = 0;
            this.navigateTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.navigateTree_NodeMouseClick);
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMain.Controls.Add(this.panLoginLoading);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(6, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(647, 510);
            this.panelMain.TabIndex = 3;
            // 
            // panLoginLoading
            // 
            this.panLoginLoading.AutoSize = true;
            this.panLoginLoading.BackColor = System.Drawing.Color.Transparent;
            this.panLoginLoading.Controls.Add(this.lblLoadingStatus);
            this.panLoginLoading.Controls.Add(this.progressBar1);
            this.panLoginLoading.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panLoginLoading.Location = new System.Drawing.Point(0, 466);
            this.panLoginLoading.Name = "panLoginLoading";
            this.panLoginLoading.Size = new System.Drawing.Size(643, 40);
            this.panLoginLoading.TabIndex = 0;
            // 
            // lblLoadingStatus
            // 
            this.lblLoadingStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblLoadingStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLoadingStatus.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoadingStatus.ForeColor = System.Drawing.Color.White;
            this.lblLoadingStatus.Location = new System.Drawing.Point(0, 0);
            this.lblLoadingStatus.Name = "lblLoadingStatus";
            this.lblLoadingStatus.Size = new System.Drawing.Size(643, 20);
            this.lblLoadingStatus.TabIndex = 1;
            this.lblLoadingStatus.Text = "正在加载系统信息...";
            this.lblLoadingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 20);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(643, 20);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            // 
            // panSplitButton
            // 
            this.panSplitButton.Controls.Add(this.lblTreeColl);
            this.panSplitButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSplitButton.Location = new System.Drawing.Point(0, 0);
            this.panSplitButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panSplitButton.Name = "panSplitButton";
            this.panSplitButton.Size = new System.Drawing.Size(6, 510);
            this.panSplitButton.TabIndex = 1;
            // 
            // lblTreeColl
            // 
            this.lblTreeColl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTreeColl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTreeColl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTreeColl.Image = global::Trade.ClientApp.Properties.Resources.left;
            this.lblTreeColl.Location = new System.Drawing.Point(0, 161);
            this.lblTreeColl.Margin = new System.Windows.Forms.Padding(0);
            this.lblTreeColl.Name = "lblTreeColl";
            this.lblTreeColl.Size = new System.Drawing.Size(6, 200);
            this.lblTreeColl.TabIndex = 0;
            this.lblTreeColl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTreeColl.Click += new System.EventHandler(this.treeLabel_Click);
            this.lblTreeColl.Paint += new System.Windows.Forms.PaintEventHandler(this.lblTreeColl_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblTiShi,
            this.tslblFullRect,
            this.tslblSysStatus,
            this.tslblEnvName,
            this.tslblLoginUser,
            this.tslblConnect,
            this.tslbltime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(653, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Visible = false;
            // 
            // tslblTiShi
            // 
            this.tslblTiShi.Name = "tslblTiShi";
            this.tslblTiShi.Size = new System.Drawing.Size(55, 17);
            this.tslblTiShi.Text = "信息提示";
            // 
            // tslblFullRect
            // 
            this.tslblFullRect.Name = "tslblFullRect";
            this.tslblFullRect.Size = new System.Drawing.Size(201, 17);
            this.tslblFullRect.Spring = true;
            // 
            // tslblSysStatus
            // 
            this.tslblSysStatus.Name = "tslblSysStatus";
            this.tslblSysStatus.Size = new System.Drawing.Size(115, 17);
            this.tslblSysStatus.Text = "系统状态：结算完成";
            // 
            // tslblEnvName
            // 
            this.tslblEnvName.Margin = new System.Windows.Forms.Padding(0, 3, 15, 2);
            this.tslblEnvName.Name = "tslblEnvName";
            this.tslblEnvName.Size = new System.Drawing.Size(55, 17);
            this.tslblEnvName.Text = "实盘环境";
            // 
            // tslblLoginUser
            // 
            this.tslblLoginUser.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.tslblLoginUser.Name = "tslblLoginUser";
            this.tslblLoginUser.Size = new System.Drawing.Size(88, 17);
            this.tslblLoginUser.Text = "登录用户:------";
            // 
            // tslblConnect
            // 
            this.tslblConnect.BackColor = System.Drawing.Color.Lime;
            this.tslblConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tslblConnect.Name = "tslblConnect";
            this.tslblConnect.Size = new System.Drawing.Size(31, 17);
            this.tslblConnect.Text = "连接";
            this.tslblConnect.Click += new System.EventHandler(this.tslblConnect_Click);
            // 
            // tslbltime
            // 
            this.tslbltime.Name = "tslbltime";
            this.tslbltime.Size = new System.Drawing.Size(73, 17);
            this.tslbltime.Text = "2013-11-10";
            // 
            // UCIndexFream
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.splitControl1);
            this.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "UCIndexFream";
            this.Size = new System.Drawing.Size(841, 512);
            this.splitControl1.Panel1.ResumeLayout(false);
            this.splitControl1.Panel2.ResumeLayout(false);
            this.splitControl1.Panel2.PerformLayout();
            this.splitControl1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panLoginLoading.ResumeLayout(false);
            this.panSplitButton.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.SplitControl splitControl1;
        private System.Windows.Forms.Panel panSplitButton;
        private UCNavigateTree navigateTree;
        private System.Windows.Forms.ImageList imageList1;
        private Controls.PanelControl panelMain;
        private System.Windows.Forms.Label lblTreeColl;
        private System.Windows.Forms.Timer tmrSecond;
        private System.Windows.Forms.Panel panLoginLoading;
        private System.Windows.Forms.Label lblLoadingStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblTiShi;
        private System.Windows.Forms.ToolStripStatusLabel tslblFullRect;
        private System.Windows.Forms.ToolStripStatusLabel tslblSysStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslblEnvName;
        private System.Windows.Forms.ToolStripStatusLabel tslblLoginUser;
        private System.Windows.Forms.ToolStripStatusLabel tslblConnect;
        private System.Windows.Forms.ToolStripStatusLabel tslbltime;
    }
}
