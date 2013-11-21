namespace Trade.Manager.Frms
{
    partial class FrmDealModify
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDealNo = new System.Windows.Forms.TextBox();
            this.nudDealAmount = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbDirection = new System.Windows.Forms.ComboBox();
            this.dtpDealTime = new System.Windows.Forms.DateTimePicker();
            this.nudCommission = new System.Windows.Forms.NumericUpDown();
            this.nudDealMoney = new System.Windows.Forms.NumericUpDown();
            this.nudDealPrice = new System.Windows.Forms.NumericUpDown();
            this.txtGoods = new System.Windows.Forms.TextBox();
            this.dtpSettleDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDealAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDealMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDealPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(529, 25);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(448, 25);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtUserNo);
            this.groupBox2.Controls.Add(this.txtDealNo);
            this.groupBox2.Controls.Add(this.nudDealAmount);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cmbDirection);
            this.groupBox2.Controls.Add(this.dtpDealTime);
            this.groupBox2.Controls.Add(this.nudCommission);
            this.groupBox2.Controls.Add(this.nudDealMoney);
            this.groupBox2.Controls.Add(this.nudDealPrice);
            this.groupBox2.Controls.Add(this.txtGoods);
            this.groupBox2.Controls.Add(this.dtpSettleDate);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 360);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtDealNo
            // 
            this.txtDealNo.Location = new System.Drawing.Point(92, 55);
            this.txtDealNo.MaxLength = 50;
            this.txtDealNo.Name = "txtDealNo";
            this.txtDealNo.Size = new System.Drawing.Size(152, 21);
            this.txtDealNo.TabIndex = 32;
            // 
            // nudDealAmount
            // 
            this.nudDealAmount.Location = new System.Drawing.Point(92, 121);
            this.nudDealAmount.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudDealAmount.Name = "nudDealAmount";
            this.nudDealAmount.Size = new System.Drawing.Size(96, 21);
            this.nudDealAmount.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 30;
            this.label16.Text = "成交量：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(371, 50);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(152, 21);
            this.txtID.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(338, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 28;
            this.label15.Text = "ID：";
            // 
            // cmbDirection
            // 
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Items.AddRange(new object[] {
            "买",
            "卖"});
            this.cmbDirection.Location = new System.Drawing.Point(92, 286);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(152, 20);
            this.cmbDirection.TabIndex = 26;
            // 
            // dtpDealTime
            // 
            this.dtpDealTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpDealTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDealTime.Location = new System.Drawing.Point(92, 253);
            this.dtpDealTime.Name = "dtpDealTime";
            this.dtpDealTime.Size = new System.Drawing.Size(152, 21);
            this.dtpDealTime.TabIndex = 24;
            // 
            // nudCommission
            // 
            this.nudCommission.DecimalPlaces = 2;
            this.nudCommission.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudCommission.Location = new System.Drawing.Point(92, 220);
            this.nudCommission.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudCommission.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudCommission.Name = "nudCommission";
            this.nudCommission.Size = new System.Drawing.Size(96, 21);
            this.nudCommission.TabIndex = 20;
            // 
            // nudDealMoney
            // 
            this.nudDealMoney.DecimalPlaces = 2;
            this.nudDealMoney.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDealMoney.Location = new System.Drawing.Point(92, 187);
            this.nudDealMoney.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudDealMoney.Name = "nudDealMoney";
            this.nudDealMoney.Size = new System.Drawing.Size(96, 21);
            this.nudDealMoney.TabIndex = 19;
            // 
            // nudDealPrice
            // 
            this.nudDealPrice.DecimalPlaces = 2;
            this.nudDealPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDealPrice.Location = new System.Drawing.Point(92, 154);
            this.nudDealPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudDealPrice.Name = "nudDealPrice";
            this.nudDealPrice.Size = new System.Drawing.Size(96, 21);
            this.nudDealPrice.TabIndex = 18;
            // 
            // txtGoods
            // 
            this.txtGoods.Location = new System.Drawing.Point(92, 88);
            this.txtGoods.MaxLength = 50;
            this.txtGoods.Name = "txtGoods";
            this.txtGoods.Size = new System.Drawing.Size(152, 21);
            this.txtGoods.TabIndex = 16;
            // 
            // dtpSettleDate
            // 
            this.dtpSettleDate.CustomFormat = "yyyy-MM-dd";
            this.dtpSettleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSettleDate.Location = new System.Drawing.Point(92, 22);
            this.dtpSettleDate.Name = "dtpSettleDate";
            this.dtpSettleDate.Size = new System.Drawing.Size(152, 21);
            this.dtpSettleDate.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "买卖方向：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "成交时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "手续费：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "成交金额：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "成交价：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "成交单号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "结算日期：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(300, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 35;
            this.label17.Text = "交易账号：";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Location = new System.Drawing.Point(371, 20);
            this.txtUserNo.MaxLength = 50;
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(152, 21);
            this.txtUserNo.TabIndex = 34;
            // 
            // FrmDealModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDealModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增/修改成交明细";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDealAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDealMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDealPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudDealAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbDirection;
        private System.Windows.Forms.DateTimePicker dtpDealTime;
        private System.Windows.Forms.NumericUpDown nudCommission;
        private System.Windows.Forms.NumericUpDown nudDealMoney;
        private System.Windows.Forms.NumericUpDown nudDealPrice;
        private System.Windows.Forms.TextBox txtGoods;
        private System.Windows.Forms.DateTimePicker dtpSettleDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDealNo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUserNo;
    }
}