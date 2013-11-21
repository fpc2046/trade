namespace Trade.ClientApp.BLLControls
{
    partial class FormPingCang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPingCang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.lblScope = new System.Windows.Forms.Label();
            this.nuHandNum = new System.Windows.Forms.NumericUpDown();
            this.rdoSell = new System.Windows.Forms.RadioButton();
            this.rdoBuy = new System.Windows.Forms.RadioButton();
            this.cboCommodity = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nuAllowDao = new System.Windows.Forms.NumericUpDown();
            this.nuMinMax = new System.Windows.Forms.NumericUpDown();
            this.chkAllowDao = new System.Windows.Forms.CheckBox();
            this.chkMinMax = new System.Windows.Forms.CheckBox();
            this.txtTradePrice = new System.Windows.Forms.TextBox();
            this.btnCencel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblTiShi = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.gboLoading = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuHandNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuAllowDao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMinMax)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.gboLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMax);
            this.groupBox1.Controls.Add(this.lblScope);
            this.groupBox1.Controls.Add(this.nuHandNum);
            this.groupBox1.Controls.Add(this.rdoSell);
            this.groupBox1.Controls.Add(this.rdoBuy);
            this.groupBox1.Controls.Add(this.cboCommodity);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(163, 109);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(45, 21);
            this.btnMax.TabIndex = 11;
            this.btnMax.Text = "最大";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // lblScope
            // 
            this.lblScope.AutoSize = true;
            this.lblScope.Location = new System.Drawing.Point(212, 113);
            this.lblScope.Name = "lblScope";
            this.lblScope.Size = new System.Drawing.Size(95, 12);
            this.lblScope.TabIndex = 10;
            this.lblScope.Text = "(可选范围：0-0)";
            // 
            // nuHandNum
            // 
            this.nuHandNum.Location = new System.Drawing.Point(96, 109);
            this.nuHandNum.Name = "nuHandNum";
            this.nuHandNum.Size = new System.Drawing.Size(62, 21);
            this.nuHandNum.TabIndex = 9;
            // 
            // rdoSell
            // 
            this.rdoSell.AutoSize = true;
            this.rdoSell.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoSell.Location = new System.Drawing.Point(167, 81);
            this.rdoSell.Name = "rdoSell";
            this.rdoSell.Size = new System.Drawing.Size(55, 18);
            this.rdoSell.TabIndex = 7;
            this.rdoSell.TabStop = true;
            this.rdoSell.Text = "卖出";
            this.rdoSell.UseVisualStyleBackColor = true;
            // 
            // rdoBuy
            // 
            this.rdoBuy.AutoSize = true;
            this.rdoBuy.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoBuy.Location = new System.Drawing.Point(96, 81);
            this.rdoBuy.Name = "rdoBuy";
            this.rdoBuy.Size = new System.Drawing.Size(55, 18);
            this.rdoBuy.TabIndex = 6;
            this.rdoBuy.TabStop = true;
            this.rdoBuy.Text = "买入";
            this.rdoBuy.UseVisualStyleBackColor = true;
            // 
            // cboCommodity
            // 
            this.cboCommodity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCommodity.FormattingEnabled = true;
            this.cboCommodity.Location = new System.Drawing.Point(96, 49);
            this.cboCommodity.Name = "cboCommodity";
            this.cboCommodity.Size = new System.Drawing.Size(224, 20);
            this.cboCommodity.TabIndex = 5;
            this.cboCommodity.SelectedIndexChanged += new System.EventHandler(this.cboCommodity_SelectedIndexChanged);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "市价平仓单"});
            this.cboType.Location = new System.Drawing.Point(96, 19);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(224, 20);
            this.cboType.TabIndex = 4;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(39, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(39, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "方向";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(39, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nuAllowDao);
            this.groupBox2.Controls.Add(this.nuMinMax);
            this.groupBox2.Controls.Add(this.chkAllowDao);
            this.groupBox2.Controls.Add(this.chkMinMax);
            this.groupBox2.Controls.Add(this.txtTradePrice);
            this.groupBox2.Location = new System.Drawing.Point(19, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 208);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // nuAllowDao
            // 
            this.nuAllowDao.Enabled = false;
            this.nuAllowDao.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nuAllowDao.Location = new System.Drawing.Point(240, 126);
            this.nuAllowDao.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuAllowDao.Name = "nuAllowDao";
            this.nuAllowDao.Size = new System.Drawing.Size(80, 23);
            this.nuAllowDao.TabIndex = 11;
            this.nuAllowDao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nuMinMax
            // 
            this.nuMinMax.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nuMinMax.Location = new System.Drawing.Point(240, 84);
            this.nuMinMax.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nuMinMax.Name = "nuMinMax";
            this.nuMinMax.Size = new System.Drawing.Size(80, 23);
            this.nuMinMax.TabIndex = 10;
            this.nuMinMax.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // chkAllowDao
            // 
            this.chkAllowDao.AutoSize = true;
            this.chkAllowDao.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkAllowDao.Location = new System.Drawing.Point(16, 128);
            this.chkAllowDao.Name = "chkAllowDao";
            this.chkAllowDao.Size = new System.Drawing.Size(116, 18);
            this.chkAllowDao.TabIndex = 8;
            this.chkAllowDao.Text = "允许反手建仓";
            this.chkAllowDao.UseVisualStyleBackColor = true;
            this.chkAllowDao.CheckedChanged += new System.EventHandler(this.chkAllowDao_CheckedChanged);
            // 
            // chkMinMax
            // 
            this.chkMinMax.AutoSize = true;
            this.chkMinMax.Checked = true;
            this.chkMinMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMinMax.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkMinMax.Location = new System.Drawing.Point(16, 86);
            this.chkMinMax.Name = "chkMinMax";
            this.chkMinMax.Size = new System.Drawing.Size(206, 18);
            this.chkMinMax.TabIndex = 4;
            this.chkMinMax.Text = "允许成交价和报价最大点差";
            this.chkMinMax.UseVisualStyleBackColor = true;
            this.chkMinMax.CheckedChanged += new System.EventHandler(this.chkMinMax_CheckedChanged);
            // 
            // txtTradePrice
            // 
            this.txtTradePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            this.txtTradePrice.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTradePrice.ForeColor = System.Drawing.Color.Blue;
            this.txtTradePrice.Location = new System.Drawing.Point(8, 26);
            this.txtTradePrice.Name = "txtTradePrice";
            this.txtTradePrice.Size = new System.Drawing.Size(330, 41);
            this.txtTradePrice.TabIndex = 2;
            this.txtTradePrice.Text = "4228";
            this.txtTradePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCencel
            // 
            this.btnCencel.Location = new System.Drawing.Point(214, 399);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(75, 23);
            this.btnCencel.TabIndex = 12;
            this.btnCencel.Text = "取消";
            this.btnCencel.UseVisualStyleBackColor = true;
            this.btnCencel.Click += new System.EventHandler(this.btnCencel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(86, 399);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblTiShi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(384, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblTiShi
            // 
            this.tslblTiShi.Name = "tslblTiShi";
            this.tslblTiShi.Size = new System.Drawing.Size(55, 17);
            this.tslblTiShi.Text = "信息提示";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox3.Location = new System.Drawing.Point(22, 377);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(101, 18);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "下单前确认";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // gboLoading
            // 
            this.gboLoading.Controls.Add(this.label5);
            this.gboLoading.Controls.Add(this.pictureBox1);
            this.gboLoading.Location = new System.Drawing.Point(19, 163);
            this.gboLoading.Name = "gboLoading";
            this.gboLoading.Size = new System.Drawing.Size(343, 208);
            this.gboLoading.TabIndex = 13;
            this.gboLoading.TabStop = false;
            this.gboLoading.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "正在处理，请稍候．．．．．．";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trade.ClientApp.Properties.Resources.loading;
            this.pictureBox1.Location = new System.Drawing.Point(44, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormPingCang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 453);
            this.Controls.Add(this.btnCencel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gboLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPingCang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "平仓单";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuHandNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuAllowDao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMinMax)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gboLoading.ResumeLayout(false);
            this.gboLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCommodity;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoSell;
        private System.Windows.Forms.RadioButton rdoBuy;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Label lblScope;
        private System.Windows.Forms.NumericUpDown nuHandNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAllowDao;
        private System.Windows.Forms.CheckBox chkMinMax;
        private System.Windows.Forms.TextBox txtTradePrice;
        private System.Windows.Forms.NumericUpDown nuAllowDao;
        private System.Windows.Forms.NumericUpDown nuMinMax;
        private System.Windows.Forms.Button btnCencel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblTiShi;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox gboLoading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}