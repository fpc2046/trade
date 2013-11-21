namespace Trade.Manager.UcContorls
{
    partial class UcBankAccountFound
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
            this.LoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountProperty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QCQY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRCRJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DQZDKCJE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZTZJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.LoginName,
            this.Account,
            this.BankName,
            this.AccountProperty,
            this.QCQY,
            this.DRCRJ,
            this.DQZDKCJE,
            this.ZTZJ});
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
            // LoginName
            // 
            this.LoginName.DataPropertyName = "LoginName";
            this.LoginName.HeaderText = "交易帐号";
            this.LoginName.Name = "LoginName";
            this.LoginName.ReadOnly = true;
            this.LoginName.Width = 90;
            // 
            // Account
            // 
            this.Account.DataPropertyName = "Account";
            this.Account.HeaderText = "银行帐号";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            this.Account.Width = 90;
            // 
            // BankName
            // 
            this.BankName.DataPropertyName = "BankName";
            this.BankName.HeaderText = "银行名称";
            this.BankName.Name = "BankName";
            this.BankName.ReadOnly = true;
            this.BankName.Width = 90;
            // 
            // AccountProperty
            // 
            this.AccountProperty.DataPropertyName = "AccountProperty";
            this.AccountProperty.HeaderText = "帐号属性";
            this.AccountProperty.Name = "AccountProperty";
            this.AccountProperty.ReadOnly = true;
            this.AccountProperty.Width = 90;
            // 
            // QCQY
            // 
            this.QCQY.DataPropertyName = "QCQY";
            this.QCQY.HeaderText = "期初权益";
            this.QCQY.Name = "QCQY";
            this.QCQY.ReadOnly = true;
            this.QCQY.Width = 90;
            // 
            // DRCRJ
            // 
            this.DRCRJ.DataPropertyName = "DRCRJ";
            this.DRCRJ.HeaderText = "当日可入金";
            this.DRCRJ.Name = "DRCRJ";
            this.DRCRJ.ReadOnly = true;
            this.DRCRJ.Width = 110;
            // 
            // DQZDKCJE
            // 
            this.DQZDKCJE.DataPropertyName = "DQZDKCJE";
            this.DQZDKCJE.HeaderText = "当日最大可出金额";
            this.DQZDKCJE.Name = "DQZDKCJE";
            this.DQZDKCJE.ReadOnly = true;
            this.DQZDKCJE.Width = 130;
            // 
            // ZTZJ
            // 
            this.ZTZJ.DataPropertyName = "ZTZJ";
            this.ZTZJ.HeaderText = "在途资金";
            this.ZTZJ.Name = "ZTZJ";
            this.ZTZJ.ReadOnly = true;
            this.ZTZJ.Width = 90;
            // 
            // UcBankAccountFound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMain);
            this.Name = "UcBankAccountFound";
            this.Controls.SetChildIndex(this.dgvMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridEx dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn QCQY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRCRJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DQZDKCJE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZTZJ;
    }
}
