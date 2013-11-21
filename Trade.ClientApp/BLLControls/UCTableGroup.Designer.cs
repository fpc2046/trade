namespace Trade.ClientApp.BLLControls
{
    partial class UCTableGroup
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
            this.tableGroup = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.ucFunction21 = new Trade.ClientApp.BLLControls.UCFunction2();
            this.tableGroup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableGroup
            // 
            this.tableGroup.Controls.Add(this.tabPage1);
            this.tableGroup.Controls.Add(this.tabPage2);
            this.tableGroup.Controls.Add(this.tabPage3);
            this.tableGroup.Controls.Add(this.tabPage4);
            this.tableGroup.Controls.Add(this.tabPage5);
            this.tableGroup.Controls.Add(this.tabPage6);
            this.tableGroup.Controls.Add(this.tabPage7);
            this.tableGroup.Controls.Add(this.tabPage8);
            this.tableGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableGroup.Location = new System.Drawing.Point(0, 0);
            this.tableGroup.Name = "tableGroup";
            this.tableGroup.SelectedIndex = 0;
            this.tableGroup.Size = new System.Drawing.Size(567, 353);
            this.tableGroup.TabIndex = 0;
            this.tableGroup.SelectedIndexChanged += new System.EventHandler(this.tbcFunction_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucFunction21);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(559, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "F2概况";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(559, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "F3委托查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(559, 327);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "F4成交查询";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(559, 327);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "F5持仓明细";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(559, 327);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "F6持仓汇总";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(559, 327);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "F7账户信息";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(559, 327);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "F8商品信息";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(559, 327);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "F9预警信息";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // ucFunction21
            // 
            this.ucFunction21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFunction21.Location = new System.Drawing.Point(3, 3);
            this.ucFunction21.Name = "ucFunction21";
            this.ucFunction21.Size = new System.Drawing.Size(553, 321);
            this.ucFunction21.TabIndex = 0;
            // 
            // UCTableGroup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableGroup);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "UCTableGroup";
            this.Size = new System.Drawing.Size(567, 353);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.UCTableGroup_PreviewKeyDown);
            this.tableGroup.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tableGroup;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private UCFunction2 ucFunction21;
    }
}
