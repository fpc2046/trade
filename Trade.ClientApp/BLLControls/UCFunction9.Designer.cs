namespace Trade.ClientApp.BLLControls
{
    partial class UCFunction9
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYJLX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYJX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYJTJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYJFS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYJYXSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSFYX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXDSJD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCFCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChanged = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTurn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 314);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "预警信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 21;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colYJLX,
            this.Column3,
            this.colYJX,
            this.colYJTJ,
            this.colYJFS,
            this.Column7,
            this.colYJYXSD,
            this.colSFYX,
            this.colXDSJD,
            this.colCFCS});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(464, 294);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 54;
            // 
            // colYJLX
            // 
            this.colYJLX.DataPropertyName = "YJLX";
            this.colYJLX.HeaderText = "预警类型";
            this.colYJLX.Name = "colYJLX";
            this.colYJLX.ReadOnly = true;
            this.colYJLX.Width = 78;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ZJZH";
            dataGridViewCellStyle1.NullValue = "贵金属帐号";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "资金帐号";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 78;
            // 
            // colYJX
            // 
            this.colYJX.DataPropertyName = "YJX";
            this.colYJX.HeaderText = "预警项";
            this.colYJX.Name = "colYJX";
            this.colYJX.ReadOnly = true;
            this.colYJX.Width = 66;
            // 
            // colYJTJ
            // 
            this.colYJTJ.DataPropertyName = "YJTJ";
            this.colYJTJ.HeaderText = "预警条件";
            this.colYJTJ.Name = "colYJTJ";
            this.colYJTJ.ReadOnly = true;
            this.colYJTJ.Width = 78;
            // 
            // colYJFS
            // 
            this.colYJFS.DataPropertyName = "YJFS";
            this.colYJFS.HeaderText = "预警方式";
            this.colYJFS.Name = "colYJFS";
            this.colYJFS.ReadOnly = true;
            this.colYJFS.Width = 78;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ZJCFSJ";
            this.Column7.HeaderText = "最近触发时间";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 102;
            // 
            // colYJYXSD
            // 
            this.colYJYXSD.DataPropertyName = "YJYXSD";
            this.colYJYXSD.HeaderText = "预警有效时段";
            this.colYJYXSD.Name = "colYJYXSD";
            this.colYJYXSD.ReadOnly = true;
            this.colYJYXSD.Width = 102;
            // 
            // colSFYX
            // 
            this.colSFYX.DataPropertyName = "SFYX";
            this.colSFYX.HeaderText = "是否有效";
            this.colSFYX.Name = "colSFYX";
            this.colSFYX.ReadOnly = true;
            this.colSFYX.Width = 78;
            // 
            // colXDSJD
            // 
            this.colXDSJD.DataPropertyName = "XDSJD";
            this.colXDSJD.HeaderText = "限定时间段";
            this.colXDSJD.Name = "colXDSJD";
            this.colXDSJD.ReadOnly = true;
            this.colXDSJD.Width = 90;
            // 
            // colCFCS
            // 
            this.colCFCS.DataPropertyName = "CFCS";
            this.colCFCS.HeaderText = "重复次数";
            this.colCFCS.Name = "colCFCS";
            this.colCFCS.ReadOnly = true;
            this.colCFCS.Width = 78;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.toolStripSeparator1,
            this.tsmiChanged,
            this.tsmiDelete,
            this.toolStripSeparator2,
            this.tsmiTurn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 126);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // tsmiChanged
            // 
            this.tsmiChanged.Name = "tsmiChanged";
            this.tsmiChanged.Size = new System.Drawing.Size(152, 22);
            this.tsmiChanged.Text = "修改";
            this.tsmiChanged.Click += new System.EventHandler(this.tsmiChanged_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(152, 22);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiTurn
            // 
            this.tsmiTurn.Name = "tsmiTurn";
            this.tsmiTurn.Size = new System.Drawing.Size(152, 22);
            this.tsmiTurn.Text = "启动/关闭";
            this.tsmiTurn.Click += new System.EventHandler(this.tsmiTurn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // UCFunction9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UCFunction9";
            this.Size = new System.Drawing.Size(470, 314);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYJLX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYJX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYJTJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYJFS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYJYXSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSFYX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXDSJD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCFCS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiChanged;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiTurn;
    }
}
