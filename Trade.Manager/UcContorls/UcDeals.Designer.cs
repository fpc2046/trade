namespace Trade.Manager
{
    partial class UcDeals
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
            this.DealNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.DealNo,
            this.Goods,
            this.DealAmount,
            this.DealPrice,
            this.DealMoney,
            this.Commission,
            this.DealTime,
            this.Direction,
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
            // DealNo
            // 
            this.DealNo.DataPropertyName = "DealNo";
            this.DealNo.HeaderText = "成交单号";
            this.DealNo.Name = "DealNo";
            this.DealNo.ReadOnly = true;
            this.DealNo.Width = 90;
            // 
            // Goods
            // 
            this.Goods.DataPropertyName = "Goods";
            this.Goods.HeaderText = "商品";
            this.Goods.Name = "Goods";
            this.Goods.ReadOnly = true;
            // 
            // DealAmount
            // 
            this.DealAmount.DataPropertyName = "DealAmount";
            this.DealAmount.HeaderText = "成交量";
            this.DealAmount.Name = "DealAmount";
            this.DealAmount.ReadOnly = true;
            this.DealAmount.Width = 90;
            // 
            // DealPrice
            // 
            this.DealPrice.DataPropertyName = "DealPrice";
            this.DealPrice.HeaderText = "成交价";
            this.DealPrice.Name = "DealPrice";
            this.DealPrice.ReadOnly = true;
            this.DealPrice.Width = 90;
            // 
            // DealMoney
            // 
            this.DealMoney.DataPropertyName = "DealMoney";
            this.DealMoney.HeaderText = "成交金额";
            this.DealMoney.Name = "DealMoney";
            this.DealMoney.ReadOnly = true;
            this.DealMoney.Width = 90;
            // 
            // Commission
            // 
            this.Commission.DataPropertyName = "Commission";
            this.Commission.HeaderText = "手续费";
            this.Commission.Name = "Commission";
            this.Commission.ReadOnly = true;
            this.Commission.Width = 90;
            // 
            // DealTime
            // 
            this.DealTime.DataPropertyName = "DealTime";
            this.DealTime.HeaderText = "成交时间";
            this.DealTime.Name = "DealTime";
            this.DealTime.ReadOnly = true;
            // 
            // Direction
            // 
            this.Direction.DataPropertyName = "Direction";
            this.Direction.HeaderText = "买卖方向";
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
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
            // UcDeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMain);
            this.Name = "UcDeals";
            this.Controls.SetChildIndex(this.dgvMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridEx dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commission;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNo;
    }
}
