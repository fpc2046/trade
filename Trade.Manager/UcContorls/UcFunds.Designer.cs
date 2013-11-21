namespace Trade.Manager
{
    partial class UcFunds
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
            this.SettleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangedMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelevanceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.SettleDate,
            this.No,
            this.ChangeMoney,
            this.ChangedMoney,
            this.RelevanceNo,
            this.CType,
            this.CTime,
            this.ID,
            this.UserNo});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowTemplate.Height = 20;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(788, 354);
            this.dgvMain.TabIndex = 1;
            // 
            // SettleDate
            // 
            this.SettleDate.DataPropertyName = "SettleDate";
            this.SettleDate.HeaderText = "结算日期";
            this.SettleDate.Name = "SettleDate";
            this.SettleDate.ReadOnly = true;
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            this.No.HeaderText = "流水号";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // ChangeMoney
            // 
            this.ChangeMoney.DataPropertyName = "ChangeMoney";
            this.ChangeMoney.HeaderText = "变动金额";
            this.ChangeMoney.Name = "ChangeMoney";
            this.ChangeMoney.ReadOnly = true;
            // 
            // ChangedMoney
            // 
            this.ChangedMoney.DataPropertyName = "ChangedMoney";
            this.ChangedMoney.HeaderText = "变后金额";
            this.ChangedMoney.Name = "ChangedMoney";
            this.ChangedMoney.ReadOnly = true;
            // 
            // RelevanceNo
            // 
            this.RelevanceNo.DataPropertyName = "RelevanceNo";
            this.RelevanceNo.HeaderText = "关联单号";
            this.RelevanceNo.Name = "RelevanceNo";
            this.RelevanceNo.ReadOnly = true;
            // 
            // CType
            // 
            this.CType.DataPropertyName = "CType";
            this.CType.HeaderText = "类型";
            this.CType.Name = "CType";
            this.CType.ReadOnly = true;
            // 
            // CTime
            // 
            this.CTime.DataPropertyName = "CTime";
            this.CTime.HeaderText = "时间";
            this.CTime.Name = "CTime";
            this.CTime.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // UserNo
            // 
            this.UserNo.DataPropertyName = "UserNo";
            this.UserNo.HeaderText = "交易账号";
            this.UserNo.Name = "UserNo";
            this.UserNo.ReadOnly = true;
            // 
            // UcFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMain);
            this.Name = "UcFunds";
            this.Controls.SetChildIndex(this.dgvMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridEx dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangedMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelevanceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNo;
    }
}
