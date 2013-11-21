namespace Trade.Manager.Frms
{
    partial class FrmFundDetailModify
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpSettleDate = new System.Windows.Forms.DateTimePicker();
            this.nudSaleProfitLoss = new System.Windows.Forms.NumericUpDown();
            this.nudHoldProfitLoss = new System.Windows.Forms.NumericUpDown();
            this.nudCommission = new System.Windows.Forms.NumericUpDown();
            this.nudDelayMoney = new System.Windows.Forms.NumericUpDown();
            this.nudEndRights = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nudInOutMoney = new System.Windows.Forms.NumericUpDown();
            this.nudBeginRights = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.nudHoldEmploy = new System.Windows.Forms.NumericUpDown();
            this.txtRiskRate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaleProfitLoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldProfitLoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndRights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInOutMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeginRights)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldEmploy)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(509, 25);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(428, 25);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "结算日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "平仓盈亏 ：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "持仓盈亏：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "手续费：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "延期费：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "占用保证金：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "期末权益：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "风险率：";
            // 
            // dtpSettleDate
            // 
            this.dtpSettleDate.CustomFormat = "yyyy-MM-dd";
            this.dtpSettleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSettleDate.Location = new System.Drawing.Point(97, 22);
            this.dtpSettleDate.Name = "dtpSettleDate";
            this.dtpSettleDate.Size = new System.Drawing.Size(152, 21);
            this.dtpSettleDate.TabIndex = 14;
            // 
            // nudSaleProfitLoss
            // 
            this.nudSaleProfitLoss.DecimalPlaces = 2;
            this.nudSaleProfitLoss.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSaleProfitLoss.Location = new System.Drawing.Point(97, 118);
            this.nudSaleProfitLoss.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudSaleProfitLoss.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudSaleProfitLoss.Name = "nudSaleProfitLoss";
            this.nudSaleProfitLoss.Size = new System.Drawing.Size(96, 21);
            this.nudSaleProfitLoss.TabIndex = 18;
            // 
            // nudHoldProfitLoss
            // 
            this.nudHoldProfitLoss.DecimalPlaces = 2;
            this.nudHoldProfitLoss.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudHoldProfitLoss.Location = new System.Drawing.Point(97, 150);
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
            this.nudHoldProfitLoss.TabIndex = 18;
            // 
            // nudCommission
            // 
            this.nudCommission.DecimalPlaces = 2;
            this.nudCommission.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudCommission.Location = new System.Drawing.Point(97, 182);
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
            this.nudCommission.TabIndex = 18;
            // 
            // nudDelayMoney
            // 
            this.nudDelayMoney.DecimalPlaces = 2;
            this.nudDelayMoney.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudDelayMoney.Location = new System.Drawing.Point(97, 214);
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
            this.nudDelayMoney.TabIndex = 18;
            // 
            // nudEndRights
            // 
            this.nudEndRights.DecimalPlaces = 2;
            this.nudEndRights.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudEndRights.Location = new System.Drawing.Point(97, 278);
            this.nudEndRights.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudEndRights.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudEndRights.Name = "nudEndRights";
            this.nudEndRights.Size = new System.Drawing.Size(96, 21);
            this.nudEndRights.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(358, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 28;
            this.label15.Text = "ID：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(392, 53);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(152, 21);
            this.txtID.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 30;
            this.label16.Text = "出入金：";
            // 
            // nudInOutMoney
            // 
            this.nudInOutMoney.Location = new System.Drawing.Point(97, 86);
            this.nudInOutMoney.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudInOutMoney.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudInOutMoney.Name = "nudInOutMoney";
            this.nudInOutMoney.Size = new System.Drawing.Size(96, 21);
            this.nudInOutMoney.TabIndex = 31;
            // 
            // nudBeginRights
            // 
            this.nudBeginRights.Location = new System.Drawing.Point(97, 54);
            this.nudBeginRights.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudBeginRights.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudBeginRights.Name = "nudBeginRights";
            this.nudBeginRights.Size = new System.Drawing.Size(96, 21);
            this.nudBeginRights.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "期初权益：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRiskRate);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtUserNo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudBeginRights);
            this.groupBox2.Controls.Add(this.nudInOutMoney);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.nudEndRights);
            this.groupBox2.Controls.Add(this.nudHoldEmploy);
            this.groupBox2.Controls.Add(this.nudDelayMoney);
            this.groupBox2.Controls.Add(this.nudCommission);
            this.groupBox2.Controls.Add(this.nudHoldProfitLoss);
            this.groupBox2.Controls.Add(this.nudSaleProfitLoss);
            this.groupBox2.Controls.Add(this.dtpSettleDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 361);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(321, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 39;
            this.label17.Text = "交易账号：";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Location = new System.Drawing.Point(392, 20);
            this.txtUserNo.MaxLength = 50;
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(152, 21);
            this.txtUserNo.TabIndex = 38;
            // 
            // nudHoldEmploy
            // 
            this.nudHoldEmploy.DecimalPlaces = 2;
            this.nudHoldEmploy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudHoldEmploy.Location = new System.Drawing.Point(97, 246);
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
            this.nudHoldEmploy.TabIndex = 18;
            // 
            // txtRiskRate
            // 
            this.txtRiskRate.Location = new System.Drawing.Point(97, 313);
            this.txtRiskRate.Name = "txtRiskRate";
            this.txtRiskRate.Size = new System.Drawing.Size(96, 21);
            this.txtRiskRate.TabIndex = 40;
            // 
            // FrmFundDetailModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 421);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFundDetailModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增/修改资金状况";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSaleProfitLoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldProfitLoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCommission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndRights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInOutMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeginRights)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldEmploy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpSettleDate;
        private System.Windows.Forms.NumericUpDown nudSaleProfitLoss;
        private System.Windows.Forms.NumericUpDown nudHoldProfitLoss;
        private System.Windows.Forms.NumericUpDown nudCommission;
        private System.Windows.Forms.NumericUpDown nudDelayMoney;
        private System.Windows.Forms.NumericUpDown nudEndRights;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudInOutMoney;
        private System.Windows.Forms.NumericUpDown nudBeginRights;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudHoldEmploy;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.TextBox txtRiskRate;
    }
}