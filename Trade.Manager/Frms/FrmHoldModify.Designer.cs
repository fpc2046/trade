namespace Trade.Manager.Frms
{
    partial class FrmHoldModify
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
            this.txtCreateNo = new System.Windows.Forms.TextBox();
            this.txtHoldNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHoldAmount = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbDirection = new System.Windows.Forms.ComboBox();
            this.dtpCreateTime = new System.Windows.Forms.DateTimePicker();
            this.nudDelayMoney = new System.Windows.Forms.NumericUpDown();
            this.nudHoldEmploy = new System.Windows.Forms.NumericUpDown();
            this.nudHoldBailRate = new System.Windows.Forms.NumericUpDown();
            this.nudHoldProfitLoss = new System.Windows.Forms.NumericUpDown();
            this.nudDealPrice = new System.Windows.Forms.NumericUpDown();
            this.nudBuyPrice = new System.Windows.Forms.NumericUpDown();
            this.nudHoldPrice = new System.Windows.Forms.NumericUpDown();
            this.txtGoods = new System.Windows.Forms.TextBox();
            this.dtpSettleDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldEmploy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldBailRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldProfitLoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDealPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldPrice)).BeginInit();
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
            this.groupBox2.Controls.Add(this.txtCreateNo);
            this.groupBox2.Controls.Add(this.txtHoldNo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudHoldAmount);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cmbDirection);
            this.groupBox2.Controls.Add(this.dtpCreateTime);
            this.groupBox2.Controls.Add(this.nudDelayMoney);
            this.groupBox2.Controls.Add(this.nudHoldEmploy);
            this.groupBox2.Controls.Add(this.nudHoldBailRate);
            this.groupBox2.Controls.Add(this.nudHoldProfitLoss);
            this.groupBox2.Controls.Add(this.nudDealPrice);
            this.groupBox2.Controls.Add(this.nudBuyPrice);
            this.groupBox2.Controls.Add(this.nudHoldPrice);
            this.groupBox2.Controls.Add(this.txtGoods);
            this.groupBox2.Controls.Add(this.dtpSettleDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 360);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // txtCreateNo
            // 
            this.txtCreateNo.Location = new System.Drawing.Point(382, 22);
            this.txtCreateNo.MaxLength = 50;
            this.txtCreateNo.Name = "txtCreateNo";
            this.txtCreateNo.Size = new System.Drawing.Size(152, 21);
            this.txtCreateNo.TabIndex = 34;
            // 
            // txtHoldNo
            // 
            this.txtHoldNo.Location = new System.Drawing.Point(113, 82);
            this.txtHoldNo.MaxLength = 50;
            this.txtHoldNo.Name = "txtHoldNo";
            this.txtHoldNo.Size = new System.Drawing.Size(152, 21);
            this.txtHoldNo.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 32;
            this.label2.Text = "商品：";
            // 
            // nudHoldAmount
            // 
            this.nudHoldAmount.Location = new System.Drawing.Point(113, 112);
            this.nudHoldAmount.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudHoldAmount.Name = "nudHoldAmount";
            this.nudHoldAmount.Size = new System.Drawing.Size(96, 21);
            this.nudHoldAmount.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(56, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 30;
            this.label16.Text = "持仓量：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(382, 113);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(152, 21);
            this.txtID.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(349, 117);
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
            this.cmbDirection.Location = new System.Drawing.Point(382, 84);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(152, 20);
            this.cmbDirection.TabIndex = 26;
            // 
            // dtpCreateTime
            // 
            this.dtpCreateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpCreateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreateTime.Location = new System.Drawing.Point(382, 54);
            this.dtpCreateTime.Name = "dtpCreateTime";
            this.dtpCreateTime.Size = new System.Drawing.Size(152, 21);
            this.dtpCreateTime.TabIndex = 24;
            // 
            // nudDelayMoney
            // 
            this.nudDelayMoney.DecimalPlaces = 2;
            this.nudDelayMoney.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDelayMoney.Location = new System.Drawing.Point(113, 322);
            this.nudDelayMoney.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudDelayMoney.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudDelayMoney.Name = "nudDelayMoney";
            this.nudDelayMoney.Size = new System.Drawing.Size(96, 21);
            this.nudDelayMoney.TabIndex = 20;
            // 
            // nudHoldEmploy
            // 
            this.nudHoldEmploy.DecimalPlaces = 2;
            this.nudHoldEmploy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudHoldEmploy.Location = new System.Drawing.Point(113, 292);
            this.nudHoldEmploy.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudHoldEmploy.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudHoldEmploy.Name = "nudHoldEmploy";
            this.nudHoldEmploy.Size = new System.Drawing.Size(96, 21);
            this.nudHoldEmploy.TabIndex = 20;
            // 
            // nudHoldBailRate
            // 
            this.nudHoldBailRate.DecimalPlaces = 2;
            this.nudHoldBailRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudHoldBailRate.Location = new System.Drawing.Point(113, 262);
            this.nudHoldBailRate.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudHoldBailRate.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudHoldBailRate.Name = "nudHoldBailRate";
            this.nudHoldBailRate.Size = new System.Drawing.Size(96, 21);
            this.nudHoldBailRate.TabIndex = 20;
            // 
            // nudHoldProfitLoss
            // 
            this.nudHoldProfitLoss.DecimalPlaces = 2;
            this.nudHoldProfitLoss.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudHoldProfitLoss.Location = new System.Drawing.Point(113, 232);
            this.nudHoldProfitLoss.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudHoldProfitLoss.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudHoldProfitLoss.Name = "nudHoldProfitLoss";
            this.nudHoldProfitLoss.Size = new System.Drawing.Size(96, 21);
            this.nudHoldProfitLoss.TabIndex = 20;
            // 
            // nudDealPrice
            // 
            this.nudDealPrice.DecimalPlaces = 2;
            this.nudDealPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDealPrice.Location = new System.Drawing.Point(113, 202);
            this.nudDealPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudDealPrice.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudDealPrice.Name = "nudDealPrice";
            this.nudDealPrice.Size = new System.Drawing.Size(96, 21);
            this.nudDealPrice.TabIndex = 20;
            // 
            // nudBuyPrice
            // 
            this.nudBuyPrice.DecimalPlaces = 2;
            this.nudBuyPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudBuyPrice.Location = new System.Drawing.Point(113, 172);
            this.nudBuyPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudBuyPrice.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudBuyPrice.Name = "nudBuyPrice";
            this.nudBuyPrice.Size = new System.Drawing.Size(96, 21);
            this.nudBuyPrice.TabIndex = 19;
            // 
            // nudHoldPrice
            // 
            this.nudHoldPrice.DecimalPlaces = 2;
            this.nudHoldPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudHoldPrice.Location = new System.Drawing.Point(113, 142);
            this.nudHoldPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudHoldPrice.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudHoldPrice.Name = "nudHoldPrice";
            this.nudHoldPrice.Size = new System.Drawing.Size(96, 21);
            this.nudHoldPrice.TabIndex = 18;
            // 
            // txtGoods
            // 
            this.txtGoods.Location = new System.Drawing.Point(113, 53);
            this.txtGoods.MaxLength = 50;
            this.txtGoods.Name = "txtGoods";
            this.txtGoods.Size = new System.Drawing.Size(152, 21);
            this.txtGoods.TabIndex = 16;
            // 
            // dtpSettleDate
            // 
            this.dtpSettleDate.CustomFormat = "yyyy-MM-dd";
            this.dtpSettleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSettleDate.Location = new System.Drawing.Point(113, 22);
            this.dtpSettleDate.Name = "dtpSettleDate";
            this.dtpSettleDate.Size = new System.Drawing.Size(152, 21);
            this.dtpSettleDate.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "延期费：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(313, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "买卖方向：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "占用保证金：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(313, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "建仓单号：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "建仓时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "持仓保证金比例：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "持仓盈亏：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "结算价：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "建仓价：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "持仓价：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "持仓单号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "结算日期：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(311, 151);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 36;
            this.label17.Text = "交易账号：";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Location = new System.Drawing.Point(382, 146);
            this.txtUserNo.MaxLength = 50;
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(152, 21);
            this.txtUserNo.TabIndex = 35;
            // 
            // FrmHoldModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmHoldModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增/修改持仓明细";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldEmploy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldBailRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldProfitLoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDealPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBuyPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudHoldAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbDirection;
        private System.Windows.Forms.DateTimePicker dtpCreateTime;
        private System.Windows.Forms.NumericUpDown nudDealPrice;
        private System.Windows.Forms.NumericUpDown nudBuyPrice;
        private System.Windows.Forms.NumericUpDown nudHoldPrice;
        private System.Windows.Forms.TextBox txtGoods;
        private System.Windows.Forms.DateTimePicker dtpSettleDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCreateNo;
        private System.Windows.Forms.TextBox txtHoldNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDelayMoney;
        private System.Windows.Forms.NumericUpDown nudHoldEmploy;
        private System.Windows.Forms.NumericUpDown nudHoldBailRate;
        private System.Windows.Forms.NumericUpDown nudHoldProfitLoss;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUserNo;
    }
}