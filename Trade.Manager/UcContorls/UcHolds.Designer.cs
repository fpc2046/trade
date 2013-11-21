namespace Trade.Manager
{
    partial class UcHolds
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
            this.Goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoldNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoldAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoldPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoldProfitLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoldBailRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoldEmploy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelayMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Goods,
            this.HoldNo,
            this.HoldAmount,
            this.HoldPrice,
            this.BuyPrice,
            this.DealPrice,
            this.HoldProfitLoss,
            this.HoldBailRate,
            this.HoldEmploy,
            this.DelayMoney,
            this.CreateTime,
            this.CreateNo,
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
            // Goods
            // 
            this.Goods.DataPropertyName = "Goods";
            this.Goods.HeaderText = "商品";
            this.Goods.Name = "Goods";
            this.Goods.ReadOnly = true;
            // 
            // HoldNo
            // 
            this.HoldNo.DataPropertyName = "HoldNo";
            this.HoldNo.HeaderText = "持仓单号";
            this.HoldNo.Name = "HoldNo";
            this.HoldNo.ReadOnly = true;
            // 
            // HoldAmount
            // 
            this.HoldAmount.DataPropertyName = "HoldAmount";
            this.HoldAmount.HeaderText = "持仓量";
            this.HoldAmount.Name = "HoldAmount";
            this.HoldAmount.ReadOnly = true;
            // 
            // HoldPrice
            // 
            this.HoldPrice.DataPropertyName = "HoldPrice";
            this.HoldPrice.HeaderText = "持仓价";
            this.HoldPrice.Name = "HoldPrice";
            this.HoldPrice.ReadOnly = true;
            // 
            // BuyPrice
            // 
            this.BuyPrice.DataPropertyName = "BuyPrice";
            this.BuyPrice.HeaderText = "建仓价";
            this.BuyPrice.Name = "BuyPrice";
            this.BuyPrice.ReadOnly = true;
            // 
            // DealPrice
            // 
            this.DealPrice.DataPropertyName = "DealPrice";
            this.DealPrice.HeaderText = "结算价";
            this.DealPrice.Name = "DealPrice";
            this.DealPrice.ReadOnly = true;
            // 
            // HoldProfitLoss
            // 
            this.HoldProfitLoss.DataPropertyName = "HoldProfitLoss";
            this.HoldProfitLoss.HeaderText = "持仓盈亏";
            this.HoldProfitLoss.Name = "HoldProfitLoss";
            this.HoldProfitLoss.ReadOnly = true;
            // 
            // HoldBailRate
            // 
            this.HoldBailRate.DataPropertyName = "HoldBailRate";
            this.HoldBailRate.HeaderText = "持仓保证金比例";
            this.HoldBailRate.Name = "HoldBailRate";
            this.HoldBailRate.ReadOnly = true;
            this.HoldBailRate.Width = 120;
            // 
            // HoldEmploy
            // 
            this.HoldEmploy.DataPropertyName = "HoldEmploy";
            this.HoldEmploy.HeaderText = "用保证金";
            this.HoldEmploy.Name = "HoldEmploy";
            this.HoldEmploy.ReadOnly = true;
            this.HoldEmploy.Width = 110;
            // 
            // DelayMoney
            // 
            this.DelayMoney.DataPropertyName = "DelayMoney";
            this.DelayMoney.HeaderText = "延期费";
            this.DelayMoney.Name = "DelayMoney";
            this.DelayMoney.ReadOnly = true;
            this.DelayMoney.Width = 80;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "建仓时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // CreateNo
            // 
            this.CreateNo.DataPropertyName = "CreateNo";
            this.CreateNo.HeaderText = "建仓单号";
            this.CreateNo.Name = "CreateNo";
            this.CreateNo.ReadOnly = true;
            this.CreateNo.Width = 90;
            // 
            // Direction
            // 
            this.Direction.DataPropertyName = "Direction";
            this.Direction.HeaderText = "买卖方向";
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
            this.Direction.Width = 90;
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
            // UcHolds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMain);
            this.Name = "UcHolds";
            this.Controls.SetChildIndex(this.dgvMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridEx dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoldNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoldAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoldPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoldProfitLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoldBailRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoldEmploy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelayMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNo;
    }
}
