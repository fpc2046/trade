namespace Trade.Manager
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeals = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHolds = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFunds = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFundDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiFlows = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOps = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiAnnouncements = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBankAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.tabMain = new FarsiLibrary.Win.FATabStrip();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3,
            this.toolStripSeparator3,
            this.tsbtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiImport,
            this.tsmiSales,
            this.tsmiDeals,
            this.tsmiHolds,
            this.tsmiFunds,
            this.tsmiFundDetails});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(111, 22);
            this.toolStripSplitButton1.Text = "报表数据维护";
            // 
            // tsmiImport
            // 
            this.tsmiImport.Name = "tsmiImport";
            this.tsmiImport.Size = new System.Drawing.Size(152, 22);
            this.tsmiImport.Text = "数据导入";
            // 
            // tsmiSales
            // 
            this.tsmiSales.Name = "tsmiSales";
            this.tsmiSales.Size = new System.Drawing.Size(152, 22);
            this.tsmiSales.Text = "平仓明细";
            // 
            // tsmiDeals
            // 
            this.tsmiDeals.Name = "tsmiDeals";
            this.tsmiDeals.Size = new System.Drawing.Size(152, 22);
            this.tsmiDeals.Text = "成交明细";
            // 
            // tsmiHolds
            // 
            this.tsmiHolds.Name = "tsmiHolds";
            this.tsmiHolds.Size = new System.Drawing.Size(152, 22);
            this.tsmiHolds.Text = "持仓明细";
            // 
            // tsmiFunds
            // 
            this.tsmiFunds.Name = "tsmiFunds";
            this.tsmiFunds.Size = new System.Drawing.Size(152, 22);
            this.tsmiFunds.Text = "资金流水";
            // 
            // tsmiFundDetails
            // 
            this.tsmiFundDetails.Name = "tsmiFundDetails";
            this.tsmiFundDetails.Size = new System.Drawing.Size(152, 22);
            this.tsmiFundDetails.Text = "资金状态";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFlows,
            this.tsmiOps,
            this.tsmiBankAccount});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(123, 22);
            this.toolStripSplitButton2.Text = "出入金数据维护";
            // 
            // tsmiFlows
            // 
            this.tsmiFlows.Name = "tsmiFlows";
            this.tsmiFlows.Size = new System.Drawing.Size(152, 22);
            this.tsmiFlows.Text = "出入金流水";
            // 
            // tsmiOps
            // 
            this.tsmiOps.Name = "tsmiOps";
            this.tsmiOps.Size = new System.Drawing.Size(152, 22);
            this.tsmiOps.Text = "出入金操作";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAnnouncements});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(111, 22);
            this.toolStripSplitButton3.Text = "系统数据维护";
            // 
            // tsmiAnnouncements
            // 
            this.tsmiAnnouncements.Name = "tsmiAnnouncements";
            this.tsmiAnnouncements.Size = new System.Drawing.Size(152, 22);
            this.tsmiAnnouncements.Text = "公告表";
            // 
            // tsmiBankAccount
            // 
            this.tsmiBankAccount.Name = "tsmiBankAccount";
            this.tsmiBankAccount.Size = new System.Drawing.Size(152, 22);
            this.tsmiBankAccount.Text = "银行账号";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(51, 22);
            this.tsbtnExit.Text = "退出";
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tabMain.Location = new System.Drawing.Point(0, 25);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(784, 514);
            this.tabMain.TabIndex = 4;
            this.tabMain.Text = "faTabStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据维护工具";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem tsmiImport;
        private System.Windows.Forms.ToolStripMenuItem tsmiSales;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeals;
        private System.Windows.Forms.ToolStripMenuItem tsmiHolds;
        private System.Windows.Forms.ToolStripMenuItem tsmiFunds;
        private System.Windows.Forms.ToolStripMenuItem tsmiFundDetails;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlows;
        private System.Windows.Forms.ToolStripMenuItem tsmiOps;
        private System.Windows.Forms.ToolStripMenuItem tsmiBankAccount;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem tsmiAnnouncements;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private FarsiLibrary.Win.FATabStrip tabMain;
    }
}

