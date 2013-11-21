namespace Trade.Manager.Frms
{
    partial class FrmTradeAccountFundModify
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTradeAccount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nudQCQY = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDRCRQ = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDQKCJE = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudKYBZJ = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQCQY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDRCRQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDQKCJE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKYBZJ)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(387, 25);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(306, 25);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(98, 204);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(152, 21);
            this.txtID.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(66, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 30;
            this.label15.Text = "ID：";
            // 
            // txtTradeAccount
            // 
            this.txtTradeAccount.Location = new System.Drawing.Point(98, 26);
            this.txtTradeAccount.Name = "txtTradeAccount";
            this.txtTradeAccount.Size = new System.Drawing.Size(152, 21);
            this.txtTradeAccount.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 32;
            this.label13.Text = "交易帐号：";
            // 
            // nudQCQY
            // 
            this.nudQCQY.Location = new System.Drawing.Point(98, 63);
            this.nudQCQY.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudQCQY.Name = "nudQCQY";
            this.nudQCQY.Size = new System.Drawing.Size(96, 21);
            this.nudQCQY.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 34;
            this.label16.Text = "期初权益：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 34;
            this.label1.Text = "当日出入金：";
            // 
            // nudDRCRQ
            // 
            this.nudDRCRQ.Location = new System.Drawing.Point(98, 100);
            this.nudDRCRQ.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudDRCRQ.Name = "nudDRCRQ";
            this.nudDRCRQ.Size = new System.Drawing.Size(96, 21);
            this.nudDRCRQ.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "当前可出金额：";
            // 
            // nudDQKCJE
            // 
            this.nudDQKCJE.Location = new System.Drawing.Point(98, 137);
            this.nudDQKCJE.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudDQKCJE.Name = "nudDQKCJE";
            this.nudDQKCJE.Size = new System.Drawing.Size(96, 21);
            this.nudDQKCJE.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "可用保证金：";
            // 
            // nudKYBZJ
            // 
            this.nudKYBZJ.Location = new System.Drawing.Point(98, 174);
            this.nudKYBZJ.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudKYBZJ.Name = "nudKYBZJ";
            this.nudKYBZJ.Size = new System.Drawing.Size(96, 21);
            this.nudKYBZJ.TabIndex = 35;
            // 
            // FrmTradeAccountFundModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 301);
            this.Controls.Add(this.nudKYBZJ);
            this.Controls.Add(this.nudDQKCJE);
            this.Controls.Add(this.nudDRCRQ);
            this.Controls.Add(this.nudQCQY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTradeAccount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTradeAccountFundModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增/修改出入金操作";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQCQY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDRCRQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDQKCJE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKYBZJ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTradeAccount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudQCQY;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDRCRQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDQKCJE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudKYBZJ;
    }
}