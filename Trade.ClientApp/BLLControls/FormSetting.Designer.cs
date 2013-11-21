namespace Trade.ClientApp.BLLControls
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetFont = new System.Windows.Forms.Button();
            this.btnSetFont = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nuFloatAlertWindowStayTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nuAutoLockTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSuccessShowDialog = new System.Windows.Forms.CheckBox();
            this.chkFailShowDialog = new System.Windows.Forms.CheckBox();
            this.chkShowDialog = new System.Windows.Forms.CheckBox();
            this.chkAutoLock = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fdgSet = new System.Windows.Forms.FontDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuFloatAlertWindowStayTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuAutoLockTime)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 278);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(325, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "其它设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnResetFont);
            this.groupBox1.Controls.Add(this.btnSetFont);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nuFloatAlertWindowStayTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nuAutoLockTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkSuccessShowDialog);
            this.groupBox1.Controls.Add(this.chkFailShowDialog);
            this.groupBox1.Controls.Add(this.chkShowDialog);
            this.groupBox1.Controls.Add(this.chkAutoLock);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(321, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnResetFont
            // 
            this.btnResetFont.Location = new System.Drawing.Point(89, 156);
            this.btnResetFont.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetFont.Name = "btnResetFont";
            this.btnResetFont.Size = new System.Drawing.Size(86, 23);
            this.btnResetFont.TabIndex = 10;
            this.btnResetFont.Text = "恢复默认字体";
            this.btnResetFont.UseVisualStyleBackColor = true;
            this.btnResetFont.Click += new System.EventHandler(this.btnResetFont_Click);
            // 
            // btnSetFont
            // 
            this.btnSetFont.Location = new System.Drawing.Point(8, 156);
            this.btnSetFont.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetFont.Name = "btnSetFont";
            this.btnSetFont.Size = new System.Drawing.Size(75, 23);
            this.btnSetFont.TabIndex = 9;
            this.btnSetFont.Text = "设置字体";
            this.btnSetFont.UseVisualStyleBackColor = true;
            this.btnSetFont.Click += new System.EventHandler(this.btnSetFont_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "秒";
            // 
            // nuFloatAlertWindowStayTime
            // 
            this.nuFloatAlertWindowStayTime.Location = new System.Drawing.Point(136, 128);
            this.nuFloatAlertWindowStayTime.Margin = new System.Windows.Forms.Padding(2);
            this.nuFloatAlertWindowStayTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nuFloatAlertWindowStayTime.Name = "nuFloatAlertWindowStayTime";
            this.nuFloatAlertWindowStayTime.Size = new System.Drawing.Size(56, 21);
            this.nuFloatAlertWindowStayTime.TabIndex = 7;
            this.nuFloatAlertWindowStayTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nuFloatAlertWindowStayTime.ValueChanged += new System.EventHandler(this.nuAutoLockTime_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "分钟";
            // 
            // nuAutoLockTime
            // 
            this.nuAutoLockTime.Location = new System.Drawing.Point(108, 22);
            this.nuAutoLockTime.Margin = new System.Windows.Forms.Padding(2);
            this.nuAutoLockTime.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nuAutoLockTime.Name = "nuAutoLockTime";
            this.nuAutoLockTime.Size = new System.Drawing.Size(56, 21);
            this.nuAutoLockTime.TabIndex = 5;
            this.nuAutoLockTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nuAutoLockTime.ValueChanged += new System.EventHandler(this.nuAutoLockTime_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "浮动提醒窗口停留时间";
            // 
            // chkSuccessShowDialog
            // 
            this.chkSuccessShowDialog.AutoSize = true;
            this.chkSuccessShowDialog.Checked = true;
            this.chkSuccessShowDialog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSuccessShowDialog.Location = new System.Drawing.Point(5, 105);
            this.chkSuccessShowDialog.Margin = new System.Windows.Forms.Padding(2);
            this.chkSuccessShowDialog.Name = "chkSuccessShowDialog";
            this.chkSuccessShowDialog.Size = new System.Drawing.Size(216, 16);
            this.chkSuccessShowDialog.TabIndex = 3;
            this.chkSuccessShowDialog.Text = "成交后是否弹出成交回报提示对话框";
            this.chkSuccessShowDialog.UseVisualStyleBackColor = true;
            // 
            // chkFailShowDialog
            // 
            this.chkFailShowDialog.AutoSize = true;
            this.chkFailShowDialog.Checked = true;
            this.chkFailShowDialog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFailShowDialog.Location = new System.Drawing.Point(5, 78);
            this.chkFailShowDialog.Margin = new System.Windows.Forms.Padding(2);
            this.chkFailShowDialog.Name = "chkFailShowDialog";
            this.chkFailShowDialog.Size = new System.Drawing.Size(156, 16);
            this.chkFailShowDialog.TabIndex = 2;
            this.chkFailShowDialog.Text = "是否使用对话框弹出错误";
            this.chkFailShowDialog.UseVisualStyleBackColor = true;
            // 
            // chkShowDialog
            // 
            this.chkShowDialog.AutoSize = true;
            this.chkShowDialog.Checked = true;
            this.chkShowDialog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowDialog.Location = new System.Drawing.Point(5, 51);
            this.chkShowDialog.Margin = new System.Windows.Forms.Padding(2);
            this.chkShowDialog.Name = "chkShowDialog";
            this.chkShowDialog.Size = new System.Drawing.Size(168, 16);
            this.chkShowDialog.TabIndex = 1;
            this.chkShowDialog.Text = "下单后是否弹出确认对话框";
            this.chkShowDialog.UseVisualStyleBackColor = true;
            // 
            // chkAutoLock
            // 
            this.chkAutoLock.AutoSize = true;
            this.chkAutoLock.Checked = true;
            this.chkAutoLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoLock.Location = new System.Drawing.Point(5, 24);
            this.chkAutoLock.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoLock.Name = "chkAutoLock";
            this.chkAutoLock.Size = new System.Drawing.Size(96, 16);
            this.chkAutoLock.TabIndex = 0;
            this.chkAutoLock.Text = "是否自动锁定";
            this.chkAutoLock.UseVisualStyleBackColor = true;
            this.chkAutoLock.CheckedChanged += new System.EventHandler(this.chkAutoLock_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(205, 286);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(55, 20);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(267, 286);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 20);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fdgSet
            // 
            this.fdgSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 313);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuFloatAlertWindowStayTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuAutoLockTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSuccessShowDialog;
        private System.Windows.Forms.CheckBox chkFailShowDialog;
        private System.Windows.Forms.CheckBox chkShowDialog;
        private System.Windows.Forms.CheckBox chkAutoLock;
        private System.Windows.Forms.NumericUpDown nuAutoLockTime;
        private System.Windows.Forms.Button btnResetFont;
        private System.Windows.Forms.Button btnSetFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nuFloatAlertWindowStayTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FontDialog fdgSet;
    }
}