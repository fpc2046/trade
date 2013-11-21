namespace Trade.ClientApp.BLLControls
{
    partial class UCSysLock
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUnLock = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblTiShi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::Trade.ClientApp.Properties.Resources.lock_bg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnUnLock);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.lblTiShi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 197);
            this.panel1.TabIndex = 0;
            // 
            // btnUnLock
            // 
            this.btnUnLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(220)))));
            this.btnUnLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnLock.ForeColor = System.Drawing.Color.White;
            this.btnUnLock.Image = global::Trade.ClientApp.Properties.Resources.lockbtn_icon;
            this.btnUnLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnLock.Location = new System.Drawing.Point(193, 134);
            this.btnUnLock.Name = "btnUnLock";
            this.btnUnLock.Size = new System.Drawing.Size(145, 23);
            this.btnUnLock.TabIndex = 3;
            this.btnUnLock.Text = "   解 除 锁 定";
            this.btnUnLock.UseVisualStyleBackColor = false;
            this.btnUnLock.Click += new System.EventHandler(this.btnUnLock_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(193, 82);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(145, 21);
            this.txtPwd.TabIndex = 2;
            // 
            // lblTiShi
            // 
            this.lblTiShi.AutoSize = true;
            this.lblTiShi.BackColor = System.Drawing.Color.Transparent;
            this.lblTiShi.Location = new System.Drawing.Point(344, 85);
            this.lblTiShi.Name = "lblTiShi";
            this.lblTiShi.Size = new System.Drawing.Size(89, 12);
            this.lblTiShi.TabIndex = 1;
            this.lblTiShi.Text = "请输入登录密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(132, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "密码:";
            // 
            // UCSysLock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Name = "UCSysLock";
            this.Size = new System.Drawing.Size(646, 261);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblTiShi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnLock;
    }
}
