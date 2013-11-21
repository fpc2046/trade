namespace Trade.Manager.UcContorls
{
    partial class UcAnnouncement
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
            this.dgvMain = new Trade.Manager.DataGridEx();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeriesNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Institution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Theme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Overtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SeriesNum,
            this.Institution,
            this.Theme,
            this.ContentText,
            this.CreateTime,
            this.Overtime,
            this.UserName});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowTemplate.Height = 20;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(788, 354);
            this.dgvMain.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // SeriesNum
            // 
            this.SeriesNum.DataPropertyName = "SeriesNum";
            this.SeriesNum.HeaderText = "序号";
            this.SeriesNum.Name = "SeriesNum";
            this.SeriesNum.ReadOnly = true;
            this.SeriesNum.Width = 60;
            // 
            // Institution
            // 
            this.Institution.DataPropertyName = "Institution";
            this.Institution.HeaderText = "机构";
            this.Institution.Name = "Institution";
            this.Institution.ReadOnly = true;
            this.Institution.Width = 80;
            // 
            // Theme
            // 
            this.Theme.DataPropertyName = "Theme";
            this.Theme.HeaderText = "主题";
            this.Theme.Name = "Theme";
            this.Theme.ReadOnly = true;
            this.Theme.Width = 110;
            // 
            // ContentText
            // 
            this.ContentText.DataPropertyName = "ContentText";
            this.ContentText.HeaderText = "内容";
            this.ContentText.Name = "ContentText";
            this.ContentText.ReadOnly = true;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "发布时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // Overtime
            // 
            this.Overtime.DataPropertyName = "Overtime";
            this.Overtime.HeaderText = "过期时间";
            this.Overtime.Name = "Overtime";
            this.Overtime.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "交易帐号";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // UcAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMain);
            this.Name = "UcAnnouncement";
            this.Controls.SetChildIndex(this.dgvMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridEx dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriesNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Institution;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentText;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Overtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
    }
}
