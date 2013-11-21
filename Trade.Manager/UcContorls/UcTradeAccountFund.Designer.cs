namespace Trade.Manager.UcContorls
{
    partial class UcTradeAccountFund
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
            this.TradeAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QCQY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRCRQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DQKCJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KYBZJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.TradeAccount,
            this.QCQY,
            this.DRCRQ,
            this.DQKCJE,
            this.KYBZJ});
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
            // TradeAccount
            // 
            this.TradeAccount.DataPropertyName = "TradeAccount";
            this.TradeAccount.HeaderText = "交易帐号";
            this.TradeAccount.Name = "TradeAccount";
            this.TradeAccount.ReadOnly = true;
            this.TradeAccount.Width = 90;
            // 
            // QCQY
            // 
            this.QCQY.DataPropertyName = "QCQY";
            this.QCQY.HeaderText = "期初权益";
            this.QCQY.Name = "QCQY";
            this.QCQY.ReadOnly = true;
            this.QCQY.Width = 90;
            // 
            // DRCRQ
            // 
            this.DRCRQ.DataPropertyName = "DRCRQ";
            this.DRCRQ.HeaderText = "当日出入金";
            this.DRCRQ.Name = "DRCRQ";
            this.DRCRQ.ReadOnly = true;
            this.DRCRQ.Width = 110;
            // 
            // DQKCJE
            // 
            this.DQKCJE.DataPropertyName = "DQKCJE";
            this.DQKCJE.HeaderText = "当前可出金额";
            this.DQKCJE.Name = "DQKCJE";
            this.DQKCJE.ReadOnly = true;
            this.DQKCJE.Width = 120;
            // 
            // KYBZJ
            // 
            this.KYBZJ.DataPropertyName = "KYBZJ";
            this.KYBZJ.HeaderText = "可用保证金";
            this.KYBZJ.Name = "KYBZJ";
            this.KYBZJ.ReadOnly = true;
            this.KYBZJ.Width = 90;
            // 
            // UcTradeAccountFund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMain);
            this.Name = "UcTradeAccountFund";
            this.Controls.SetChildIndex(this.dgvMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridEx dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradeAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn QCQY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRCRQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DQKCJE;
        private System.Windows.Forms.DataGridViewTextBoxColumn KYBZJ;
    }
}
