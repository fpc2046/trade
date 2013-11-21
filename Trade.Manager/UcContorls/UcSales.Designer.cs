﻿namespace Trade.Manager
{
    partial class UcSales
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
            this.SettleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoldPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleProfitLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // btnDel
            // 
            this.btnDel.Click += new System.EventHandler(this.BtnDelClick);
            // 
            // btnModify
            // 
            this.btnModify.Click += new System.EventHandler(this.BtnModifyClick);
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
            this.SettleDate,
            this.SaleDate,
            this.Goods,
            this.SaleNo,
            this.SaleAmount,
            this.SalePrice,
            this.HoldPrice,
            this.SaleProfitLoss,
            this.SaleCommission,
            this.BuyNo,
            this.BuyPrice,
            this.BuyTime,
            this.SaleType,
            this.Direction,
            this.Operate,
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
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // SettleDate
            // 
            this.SettleDate.DataPropertyName = "SettleDate";
            this.SettleDate.HeaderText = "结算日期";
            this.SettleDate.Name = "SettleDate";
            this.SettleDate.ReadOnly = true;
            this.SettleDate.Width = 110;
            // 
            // SaleDate
            // 
            this.SaleDate.DataPropertyName = "SaleDate";
            this.SaleDate.HeaderText = "平仓时间";
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.ReadOnly = true;
            this.SaleDate.Width = 110;
            // 
            // Goods
            // 
            this.Goods.DataPropertyName = "Goods";
            this.Goods.HeaderText = "商品 ";
            this.Goods.Name = "Goods";
            this.Goods.ReadOnly = true;
            // 
            // SaleNo
            // 
            this.SaleNo.DataPropertyName = "SaleNo";
            this.SaleNo.HeaderText = "平仓单号";
            this.SaleNo.Name = "SaleNo";
            this.SaleNo.ReadOnly = true;
            // 
            // SaleAmount
            // 
            this.SaleAmount.DataPropertyName = "SaleAmount";
            this.SaleAmount.HeaderText = "平仓量";
            this.SaleAmount.Name = "SaleAmount";
            this.SaleAmount.ReadOnly = true;
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "平仓价";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            // 
            // HoldPrice
            // 
            this.HoldPrice.DataPropertyName = "HoldPrice";
            this.HoldPrice.HeaderText = "持仓价";
            this.HoldPrice.Name = "HoldPrice";
            this.HoldPrice.ReadOnly = true;
            // 
            // SaleProfitLoss
            // 
            this.SaleProfitLoss.DataPropertyName = "SaleProfitLoss";
            this.SaleProfitLoss.HeaderText = "平仓盈亏";
            this.SaleProfitLoss.Name = "SaleProfitLoss";
            this.SaleProfitLoss.ReadOnly = true;
            // 
            // SaleCommission
            // 
            this.SaleCommission.DataPropertyName = "SaleCommission";
            this.SaleCommission.HeaderText = "平仓手续费";
            this.SaleCommission.Name = "SaleCommission";
            this.SaleCommission.ReadOnly = true;
            // 
            // BuyNo
            // 
            this.BuyNo.DataPropertyName = "BuyNo";
            this.BuyNo.HeaderText = "建仓单号";
            this.BuyNo.Name = "BuyNo";
            this.BuyNo.ReadOnly = true;
            // 
            // BuyPrice
            // 
            this.BuyPrice.DataPropertyName = "BuyPrice";
            this.BuyPrice.HeaderText = "建仓价 ";
            this.BuyPrice.Name = "BuyPrice";
            this.BuyPrice.ReadOnly = true;
            // 
            // BuyTime
            // 
            this.BuyTime.DataPropertyName = "BuyTime";
            this.BuyTime.HeaderText = "建仓时间";
            this.BuyTime.Name = "BuyTime";
            this.BuyTime.ReadOnly = true;
            // 
            // SaleType
            // 
            this.SaleType.DataPropertyName = "SaleType";
            this.SaleType.HeaderText = "平仓类型";
            this.SaleType.Name = "SaleType";
            this.SaleType.ReadOnly = true;
            // 
            // Direction
            // 
            this.Direction.DataPropertyName = "Direction";
            this.Direction.HeaderText = "买卖方向 ";
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
            // 
            // Operate
            // 
            this.Operate.DataPropertyName = "Operate";
            this.Operate.HeaderText = "操作类型";
            this.Operate.Name = "Operate";
            this.Operate.ReadOnly = true;
            // 
            // UserNo
            // 
            this.UserNo.DataPropertyName = "UserNo";
            this.UserNo.HeaderText = "交易账号";
            this.UserNo.Name = "UserNo";
            this.UserNo.ReadOnly = true;
            // 
            // UcSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMain);
            this.Name = "UcSales";
            this.Controls.SetChildIndex(this.dgvMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridEx dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoldPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleProfitLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNo;
    }
}
