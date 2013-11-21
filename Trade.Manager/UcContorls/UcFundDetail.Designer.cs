namespace Trade.Manager
{
    partial class UcFundDetail
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
            this.BeginRights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InOutMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleProfitLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoldProfitLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelayMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoldEmploy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndRights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiskRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.BeginRights,
            this.InOutMoney,
            this.SaleProfitLoss,
            this.HoldProfitLoss,
            this.Commission,
            this.DelayMoney,
            this.HoldEmploy,
            this.EndRights,
            this.RiskRate,
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
            this.SettleDate.Width = 90;
            // 
            // BeginRights
            // 
            this.BeginRights.DataPropertyName = "BeginRights";
            this.BeginRights.HeaderText = "期初权益";
            this.BeginRights.Name = "BeginRights";
            this.BeginRights.ReadOnly = true;
            this.BeginRights.Width = 90;
            // 
            // InOutMoney
            // 
            this.InOutMoney.DataPropertyName = "InOutMoney";
            this.InOutMoney.HeaderText = "出入金";
            this.InOutMoney.Name = "InOutMoney";
            this.InOutMoney.ReadOnly = true;
            this.InOutMoney.Width = 90;
            // 
            // SaleProfitLoss
            // 
            this.SaleProfitLoss.DataPropertyName = "SaleProfitLoss";
            this.SaleProfitLoss.HeaderText = "平仓盈亏";
            this.SaleProfitLoss.Name = "SaleProfitLoss";
            this.SaleProfitLoss.ReadOnly = true;
            this.SaleProfitLoss.Width = 90;
            // 
            // HoldProfitLoss
            // 
            this.HoldProfitLoss.DataPropertyName = "HoldProfitLoss";
            this.HoldProfitLoss.HeaderText = "持仓盈亏";
            this.HoldProfitLoss.Name = "HoldProfitLoss";
            this.HoldProfitLoss.ReadOnly = true;
            this.HoldProfitLoss.Width = 90;
            // 
            // Commission
            // 
            this.Commission.DataPropertyName = "Commission";
            this.Commission.HeaderText = "手续费";
            this.Commission.Name = "Commission";
            this.Commission.ReadOnly = true;
            this.Commission.Width = 90;
            // 
            // DelayMoney
            // 
            this.DelayMoney.DataPropertyName = "DelayMoney";
            this.DelayMoney.HeaderText = "延期费";
            this.DelayMoney.Name = "DelayMoney";
            this.DelayMoney.ReadOnly = true;
            this.DelayMoney.Width = 90;
            // 
            // HoldEmploy
            // 
            this.HoldEmploy.DataPropertyName = "HoldEmploy";
            this.HoldEmploy.HeaderText = "占用保证金";
            this.HoldEmploy.Name = "HoldEmploy";
            this.HoldEmploy.ReadOnly = true;
            this.HoldEmploy.Width = 120;
            // 
            // EndRights
            // 
            this.EndRights.DataPropertyName = "EndRights";
            this.EndRights.HeaderText = "期末权益";
            this.EndRights.Name = "EndRights";
            this.EndRights.ReadOnly = true;
            this.EndRights.Width = 90;
            // 
            // RiskRate
            // 
            this.RiskRate.DataPropertyName = "RiskRate";
            this.RiskRate.HeaderText = "风险率";
            this.RiskRate.Name = "RiskRate";
            this.RiskRate.ReadOnly = true;
            this.RiskRate.Width = 90;
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
            // UcFundDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMain);
            this.Name = "UcFundDetail";
            this.Controls.SetChildIndex(this.dgvMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridEx dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginRights;
        private System.Windows.Forms.DataGridViewTextBoxColumn InOutMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleProfitLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoldProfitLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commission;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelayMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoldEmploy;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndRights;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiskRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNo;
    }
}
