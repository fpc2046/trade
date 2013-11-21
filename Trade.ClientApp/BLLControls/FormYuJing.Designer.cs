namespace Trade.ClientApp.BLLControls
{
    partial class FormYuJing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYuJing));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBaiFenBi = new System.Windows.Forms.Label();
            this.txtFaValue = new System.Windows.Forms.TextBox();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectVoice = new System.Windows.Forms.Button();
            this.txtVoiceFileName = new System.Windows.Forms.TextBox();
            this.chkVoice = new System.Windows.Forms.CheckBox();
            this.chkShowWindow = new System.Windows.Forms.CheckBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.opdFile = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTimeScope = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nuMaxRenum = new System.Windows.Forms.NumericUpDown();
            this.chkIsValid = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuMaxRenum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "预警类型:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "有效时段:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "至";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBaiFenBi);
            this.groupBox1.Controls.Add(this.txtFaValue);
            this.groupBox1.Controls.Add(this.cboFilter);
            this.groupBox1.Controls.Add(this.cboItem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(14, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(465, 104);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "预警条件设置";
            // 
            // lblBaiFenBi
            // 
            this.lblBaiFenBi.AutoSize = true;
            this.lblBaiFenBi.Location = new System.Drawing.Point(433, 68);
            this.lblBaiFenBi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaiFenBi.Name = "lblBaiFenBi";
            this.lblBaiFenBi.Size = new System.Drawing.Size(11, 12);
            this.lblBaiFenBi.TabIndex = 9;
            this.lblBaiFenBi.Text = "%";
            this.lblBaiFenBi.Visible = false;
            // 
            // txtFaValue
            // 
            this.txtFaValue.Location = new System.Drawing.Point(292, 63);
            this.txtFaValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtFaValue.Name = "txtFaValue";
            this.txtFaValue.Size = new System.Drawing.Size(137, 21);
            this.txtFaValue.TabIndex = 8;
            // 
            // cboFilter
            // 
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Location = new System.Drawing.Point(86, 64);
            this.cboFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(117, 20);
            this.cboFilter.TabIndex = 7;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // cboItem
            // 
            this.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(77, 28);
            this.cboItem.Margin = new System.Windows.Forms.Padding(2);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(185, 20);
            this.cboItem.TabIndex = 6;
            this.cboItem.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "阈值:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "预警条件:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "预警项:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelectVoice);
            this.groupBox2.Controls.Add(this.txtVoiceFileName);
            this.groupBox2.Controls.Add(this.chkVoice);
            this.groupBox2.Controls.Add(this.chkShowWindow);
            this.groupBox2.Location = new System.Drawing.Point(14, 171);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(465, 94);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "预警方式";
            // 
            // btnSelectVoice
            // 
            this.btnSelectVoice.Enabled = false;
            this.btnSelectVoice.Location = new System.Drawing.Point(365, 48);
            this.btnSelectVoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectVoice.Name = "btnSelectVoice";
            this.btnSelectVoice.Size = new System.Drawing.Size(37, 24);
            this.btnSelectVoice.TabIndex = 10;
            this.btnSelectVoice.Text = "...";
            this.btnSelectVoice.UseVisualStyleBackColor = true;
            this.btnSelectVoice.Click += new System.EventHandler(this.btnSelectVoice_Click);
            // 
            // txtVoiceFileName
            // 
            this.txtVoiceFileName.Enabled = false;
            this.txtVoiceFileName.Location = new System.Drawing.Point(97, 51);
            this.txtVoiceFileName.Margin = new System.Windows.Forms.Padding(2);
            this.txtVoiceFileName.Name = "txtVoiceFileName";
            this.txtVoiceFileName.Size = new System.Drawing.Size(259, 21);
            this.txtVoiceFileName.TabIndex = 9;
            // 
            // chkVoice
            // 
            this.chkVoice.AutoSize = true;
            this.chkVoice.Location = new System.Drawing.Point(29, 54);
            this.chkVoice.Margin = new System.Windows.Forms.Padding(2);
            this.chkVoice.Name = "chkVoice";
            this.chkVoice.Size = new System.Drawing.Size(72, 16);
            this.chkVoice.TabIndex = 1;
            this.chkVoice.Text = "发出声音";
            this.chkVoice.UseVisualStyleBackColor = true;
            this.chkVoice.CheckedChanged += new System.EventHandler(this.chkVoice_CheckedChanged);
            // 
            // chkShowWindow
            // 
            this.chkShowWindow.AutoSize = true;
            this.chkShowWindow.Checked = true;
            this.chkShowWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowWindow.Location = new System.Drawing.Point(29, 29);
            this.chkShowWindow.Margin = new System.Windows.Forms.Padding(2);
            this.chkShowWindow.Name = "chkShowWindow";
            this.chkShowWindow.Size = new System.Drawing.Size(72, 16);
            this.chkShowWindow.TabIndex = 0;
            this.chkShowWindow.Text = "弹出窗口";
            this.chkShowWindow.UseVisualStyleBackColor = true;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "行情预警",
            "风险预警",
            "当前权益预警",
            "可用保证金预警",
            "总浮动盈亏预警"});
            this.cboType.Location = new System.Drawing.Point(77, 24);
            this.cboType.Margin = new System.Windows.Forms.Padding(2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 20);
            this.cboType.TabIndex = 5;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(282, 24);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(78, 21);
            this.dtpStartTime.TabIndex = 6;
            this.dtpStartTime.Value = new System.DateTime(2013, 11, 14, 9, 0, 0, 0);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(391, 24);
            this.dtpEndTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(78, 21);
            this.dtpEndTime.TabIndex = 7;
            this.dtpEndTime.Value = new System.DateTime(2013, 11, 9, 18, 0, 0, 0);
            // 
            // opdFile
            // 
            this.opdFile.FileName = "openFileDialog1";
            this.opdFile.Filter = "*.wav|*.wav";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 293);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "在";
            // 
            // cboTimeScope
            // 
            this.cboTimeScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeScope.FormattingEnabled = true;
            this.cboTimeScope.Items.AddRange(new object[] {
            "10sec",
            "30sec",
            "60sec",
            "3min",
            "5min",
            "15min",
            "30min",
            "1hour"});
            this.cboTimeScope.Location = new System.Drawing.Point(49, 289);
            this.cboTimeScope.Margin = new System.Windows.Forms.Padding(2);
            this.cboTimeScope.Name = "cboTimeScope";
            this.cboTimeScope.Size = new System.Drawing.Size(96, 20);
            this.cboTimeScope.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 293);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "内最多重复次数:";
            // 
            // nuMaxRenum
            // 
            this.nuMaxRenum.Location = new System.Drawing.Point(259, 289);
            this.nuMaxRenum.Margin = new System.Windows.Forms.Padding(2);
            this.nuMaxRenum.Name = "nuMaxRenum";
            this.nuMaxRenum.Size = new System.Drawing.Size(102, 21);
            this.nuMaxRenum.TabIndex = 11;
            this.nuMaxRenum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkIsValid
            // 
            this.chkIsValid.AutoSize = true;
            this.chkIsValid.Checked = true;
            this.chkIsValid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsValid.Location = new System.Drawing.Point(371, 294);
            this.chkIsValid.Margin = new System.Windows.Forms.Padding(2);
            this.chkIsValid.Name = "chkIsValid";
            this.chkIsValid.Size = new System.Drawing.Size(72, 16);
            this.chkIsValid.TabIndex = 12;
            this.chkIsValid.Text = "是否有效";
            this.chkIsValid.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(149, 329);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(231, 329);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormYuJing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 367);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkIsValid);
            this.Controls.Add(this.nuMaxRenum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboTimeScope);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormYuJing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置预警";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuMaxRenum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFaValue;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Button btnSelectVoice;
        private System.Windows.Forms.TextBox txtVoiceFileName;
        private System.Windows.Forms.CheckBox chkVoice;
        private System.Windows.Forms.CheckBox chkShowWindow;
        private System.Windows.Forms.OpenFileDialog opdFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTimeScope;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nuMaxRenum;
        private System.Windows.Forms.CheckBox chkIsValid;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBaiFenBi;
    }
}