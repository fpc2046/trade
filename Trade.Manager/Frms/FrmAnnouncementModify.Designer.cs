namespace Trade.Manager.Frms
{
    partial class FrmAnnouncementModify
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
            this.nudSeriesNum = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpCreateTime = new System.Windows.Forms.DateTimePicker();
            this.dtpOvertime = new System.Windows.Forms.DateTimePicker();
            this.txtContentText = new System.Windows.Forms.TextBox();
            this.txtTheme = new System.Windows.Forms.TextBox();
            this.txtInstitution = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeriesNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(376, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(295, 21);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudSeriesNum);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dtpCreateTime);
            this.groupBox2.Controls.Add(this.dtpOvertime);
            this.groupBox2.Controls.Add(this.txtContentText);
            this.groupBox2.Controls.Add(this.txtTheme);
            this.groupBox2.Controls.Add(this.txtInstitution);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 294);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // nudSeriesNum
            // 
            this.nudSeriesNum.Location = new System.Drawing.Point(89, 20);
            this.nudSeriesNum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudSeriesNum.Name = "nudSeriesNum";
            this.nudSeriesNum.Size = new System.Drawing.Size(152, 21);
            this.nudSeriesNum.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 30;
            this.label16.Text = "主题：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(89, 144);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(152, 21);
            this.txtUserName.TabIndex = 29;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(310, 19);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(152, 21);
            this.txtID.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(276, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 28;
            this.label15.Text = "ID：";
            // 
            // dtpCreateTime
            // 
            this.dtpCreateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpCreateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreateTime.Location = new System.Drawing.Point(89, 80);
            this.dtpCreateTime.Name = "dtpCreateTime";
            this.dtpCreateTime.Size = new System.Drawing.Size(152, 21);
            this.dtpCreateTime.TabIndex = 24;
            // 
            // dtpOvertime
            // 
            this.dtpOvertime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpOvertime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOvertime.Location = new System.Drawing.Point(89, 112);
            this.dtpOvertime.Name = "dtpOvertime";
            this.dtpOvertime.Size = new System.Drawing.Size(152, 21);
            this.dtpOvertime.TabIndex = 24;
            // 
            // txtContentText
            // 
            this.txtContentText.Location = new System.Drawing.Point(89, 202);
            this.txtContentText.MaxLength = 10240;
            this.txtContentText.Multiline = true;
            this.txtContentText.Name = "txtContentText";
            this.txtContentText.Size = new System.Drawing.Size(362, 86);
            this.txtContentText.TabIndex = 16;
            // 
            // txtTheme
            // 
            this.txtTheme.Location = new System.Drawing.Point(89, 171);
            this.txtTheme.MaxLength = 300;
            this.txtTheme.Name = "txtTheme";
            this.txtTheme.Size = new System.Drawing.Size(362, 21);
            this.txtTheme.TabIndex = 16;
            // 
            // txtInstitution
            // 
            this.txtInstitution.Location = new System.Drawing.Point(89, 53);
            this.txtInstitution.MaxLength = 50;
            this.txtInstitution.Name = "txtInstitution";
            this.txtInstitution.Size = new System.Drawing.Size(152, 21);
            this.txtInstitution.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "交易帐号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "发布时间：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "过期时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "内容：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "机构：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "序号：";
            // 
            // FrmAnnouncementModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 354);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAnnouncementModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增/修改公告表";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeriesNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpOvertime;
        private System.Windows.Forms.TextBox txtInstitution;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DateTimePicker dtpCreateTime;
        private System.Windows.Forms.TextBox txtContentText;
        private System.Windows.Forms.TextBox txtTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSeriesNum;
    }
}