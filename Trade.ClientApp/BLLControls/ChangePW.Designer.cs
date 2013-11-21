namespace Trade.ClientApp.BLLControls
{
    partial class ChangePW
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
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginButton1 = new Trade.ClientApp.Controls.LoginButton();
            this.btnExit = new Trade.ClientApp.Controls.LoginButton();
            this.txtNewPwdRe = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoPhonePD = new System.Windows.Forms.RadioButton();
            this.rdoLoginPD = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Image = global::Trade.ClientApp.Properties.Resources.sysbtnClosebg_nor;
            this.picClose.Location = new System.Drawing.Point(245, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(42, 16);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.loginButton1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txtNewPwdRe);
            this.panel1.Controls.Add(this.txtNewPwd);
            this.panel1.Controls.Add(this.txtOldPwd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdoPhonePD);
            this.panel1.Controls.Add(this.rdoLoginPD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 171);
            this.panel1.TabIndex = 1;
            // 
            // loginButton1
            // 
            this.loginButton1.BackgroundImage = global::Trade.ClientApp.Properties.Resources.button_bg_write;
            this.loginButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton1.FlatAppearance.BorderSize = 0;
            this.loginButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton1.Location = new System.Drawing.Point(60, 136);
            this.loginButton1.Name = "loginButton1";
            this.loginButton1.Size = new System.Drawing.Size(63, 23);
            this.loginButton1.TabIndex = 9;
            this.loginButton1.Text = "确定";
            this.loginButton1.Click += new System.EventHandler(this.loginButton1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Trade.ClientApp.Properties.Resources.button_bg_write;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(169, 136);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtNewPwdRe
            // 
            this.txtNewPwdRe.Location = new System.Drawing.Point(132, 104);
            this.txtNewPwdRe.Name = "txtNewPwdRe";
            this.txtNewPwdRe.PasswordChar = '*';
            this.txtNewPwdRe.Size = new System.Drawing.Size(100, 21);
            this.txtNewPwdRe.TabIndex = 7;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(132, 77);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(100, 21);
            this.txtNewPwd.TabIndex = 6;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(132, 50);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(100, 21);
            this.txtOldPwd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "重复新密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "新密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "原密码：";
            // 
            // rdoPhonePD
            // 
            this.rdoPhonePD.AutoSize = true;
            this.rdoPhonePD.Location = new System.Drawing.Point(132, 26);
            this.rdoPhonePD.Name = "rdoPhonePD";
            this.rdoPhonePD.Size = new System.Drawing.Size(71, 16);
            this.rdoPhonePD.TabIndex = 1;
            this.rdoPhonePD.TabStop = true;
            this.rdoPhonePD.Text = "电话密码";
            this.rdoPhonePD.UseVisualStyleBackColor = true;
            // 
            // rdoLoginPD
            // 
            this.rdoLoginPD.AutoSize = true;
            this.rdoLoginPD.Checked = true;
            this.rdoLoginPD.Location = new System.Drawing.Point(40, 26);
            this.rdoLoginPD.Name = "rdoLoginPD";
            this.rdoLoginPD.Size = new System.Drawing.Size(71, 16);
            this.rdoLoginPD.TabIndex = 0;
            this.rdoLoginPD.TabStop = true;
            this.rdoLoginPD.Text = "登录密码";
            this.rdoLoginPD.UseVisualStyleBackColor = true;
            this.rdoLoginPD.CheckedChanged += new System.EventHandler(this.rdoLoginPD_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ChangePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trade.ClientApp.Properties.Resources.changePW_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(293, 198);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picClose);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ChangePW";
            this.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePW";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoPhonePD;
        private System.Windows.Forms.RadioButton rdoLoginPD;
        private System.Windows.Forms.TextBox txtNewPwdRe;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controls.LoginButton btnExit;
        private Controls.LoginButton loginButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}