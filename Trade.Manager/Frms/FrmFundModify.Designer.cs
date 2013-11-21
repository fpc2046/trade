namespace Trade.Manager.Frms
{
    partial class FrmFundModify
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
            this.label17 = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.dtpCTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRelevanceNo = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.nudChangeMoney = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbCType = new System.Windows.Forms.ComboBox();
            this.nudChangedMoney = new System.Windows.Forms.NumericUpDown();
            this.dtpSettleDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangeMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangedMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(520, 25);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(439, 25);
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
            this.groupBox2.Controls.Add(this.dtpCTime);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtRelevanceNo);
            this.groupBox2.Controls.Add(this.txtNo);
            this.groupBox2.Controls.Add(this.nudChangeMoney);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cmbCType);
            this.groupBox2.Controls.Add(this.nudChangedMoney);
            this.groupBox2.Controls.Add(this.dtpSettleDate);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(607, 350);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(310, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 37;
            this.label17.Text = "交易账号：";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Location = new System.Drawing.Point(381, 22);
            this.txtUserNo.MaxLength = 50;
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(152, 21);
            this.txtUserNo.TabIndex = 36;
            // 
            // dtpCTime
            // 
            this.dtpCTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpCTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCTime.Location = new System.Drawing.Point(92, 273);
            this.dtpCTime.Name = "dtpCTime";
            this.dtpCTime.Size = new System.Drawing.Size(152, 21);
            this.dtpCTime.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "时间：";
            // 
            // txtRelevanceNo
            // 
            this.txtRelevanceNo.Location = new System.Drawing.Point(92, 190);
            this.txtRelevanceNo.Name = "txtRelevanceNo";
            this.txtRelevanceNo.Size = new System.Drawing.Size(152, 21);
            this.txtRelevanceNo.TabIndex = 33;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(92, 64);
            this.txtNo.MaxLength = 50;
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(152, 21);
            this.txtNo.TabIndex = 32;
            // 
            // nudChangeMoney
            // 
            this.nudChangeMoney.Location = new System.Drawing.Point(92, 106);
            this.nudChangeMoney.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudChangeMoney.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudChangeMoney.Name = "nudChangeMoney";
            this.nudChangeMoney.Size = new System.Drawing.Size(96, 21);
            this.nudChangeMoney.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 30;
            this.label16.Text = "变动金额：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(381, 60);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(152, 21);
            this.txtID.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(348, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 28;
            this.label15.Text = "ID：";
            // 
            // cmbCType
            // 
            this.cmbCType.FormattingEnabled = true;
            this.cmbCType.Items.AddRange(new object[] {
            "出金",
            "平仓亏损",
            "扣除手续费",
            "扣除延期费",
            "持仓盈利",
            "入金",
            "出金"});
            this.cmbCType.Location = new System.Drawing.Point(92, 232);
            this.cmbCType.Name = "cmbCType";
            this.cmbCType.Size = new System.Drawing.Size(152, 20);
            this.cmbCType.TabIndex = 26;
            // 
            // nudChangedMoney
            // 
            this.nudChangedMoney.DecimalPlaces = 2;
            this.nudChangedMoney.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudChangedMoney.Location = new System.Drawing.Point(92, 148);
            this.nudChangedMoney.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudChangedMoney.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudChangedMoney.Name = "nudChangedMoney";
            this.nudChangedMoney.Size = new System.Drawing.Size(96, 21);
            this.nudChangedMoney.TabIndex = 18;
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
            this.label13.Location = new System.Drawing.Point(47, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "类型：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "关联单号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "变后金额：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "流水号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "结算日期：";
            // 
            // FrmFundModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 410);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFundModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增/修改资金流水";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangeMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChangedMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.NumericUpDown nudChangeMoney;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbCType;
        private System.Windows.Forms.NumericUpDown nudChangedMoney;
        private System.Windows.Forms.DateTimePicker dtpSettleDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRelevanceNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUserNo;
    }
}