namespace Trade.Collector
{
    partial class HQForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtErrorCounte = new System.Windows.Forms.TextBox();
            this.txtUpCount = new System.Windows.Forms.TextBox();
            this.txtUpStatus = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.txtErrorTotal = new System.Windows.Forms.TextBox();
            this.txtUpCi = new System.Windows.Forms.TextBox();
            this.txtFreamStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrUpAll = new System.Windows.Forms.Timer(this.components);
            this.ucPriceTable1 = new Trade.Collector.UCPriceTable();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtErrorCounte);
            this.panel1.Controls.Add(this.txtUpCount);
            this.panel1.Controls.Add(this.txtUpStatus);
            this.panel1.Controls.Add(this.txtError);
            this.panel1.Controls.Add(this.txtErrorTotal);
            this.panel1.Controls.Add(this.txtUpCi);
            this.panel1.Controls.Add(this.txtFreamStatus);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 130);
            this.panel1.TabIndex = 0;
            // 
            // txtErrorCounte
            // 
            this.txtErrorCounte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtErrorCounte.Location = new System.Drawing.Point(333, 61);
            this.txtErrorCounte.Name = "txtErrorCounte";
            this.txtErrorCounte.ReadOnly = true;
            this.txtErrorCounte.Size = new System.Drawing.Size(156, 21);
            this.txtErrorCounte.TabIndex = 13;
            this.txtErrorCounte.Text = "0";
            // 
            // txtUpCount
            // 
            this.txtUpCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpCount.Location = new System.Drawing.Point(333, 38);
            this.txtUpCount.Name = "txtUpCount";
            this.txtUpCount.ReadOnly = true;
            this.txtUpCount.Size = new System.Drawing.Size(156, 21);
            this.txtUpCount.TabIndex = 12;
            this.txtUpCount.Text = "0";
            // 
            // txtUpStatus
            // 
            this.txtUpStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpStatus.Location = new System.Drawing.Point(333, 15);
            this.txtUpStatus.Name = "txtUpStatus";
            this.txtUpStatus.ReadOnly = true;
            this.txtUpStatus.Size = new System.Drawing.Size(156, 21);
            this.txtUpStatus.TabIndex = 11;
            // 
            // txtError
            // 
            this.txtError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtError.Location = new System.Drawing.Point(80, 87);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtError.Size = new System.Drawing.Size(409, 34);
            this.txtError.TabIndex = 10;
            // 
            // txtErrorTotal
            // 
            this.txtErrorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtErrorTotal.Location = new System.Drawing.Point(80, 62);
            this.txtErrorTotal.Name = "txtErrorTotal";
            this.txtErrorTotal.ReadOnly = true;
            this.txtErrorTotal.Size = new System.Drawing.Size(161, 21);
            this.txtErrorTotal.TabIndex = 9;
            this.txtErrorTotal.Text = "0";
            // 
            // txtUpCi
            // 
            this.txtUpCi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpCi.Location = new System.Drawing.Point(80, 39);
            this.txtUpCi.Name = "txtUpCi";
            this.txtUpCi.ReadOnly = true;
            this.txtUpCi.Size = new System.Drawing.Size(161, 21);
            this.txtUpCi.TabIndex = 8;
            this.txtUpCi.Text = "0";
            // 
            // txtFreamStatus
            // 
            this.txtFreamStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFreamStatus.Location = new System.Drawing.Point(80, 15);
            this.txtFreamStatus.Name = "txtFreamStatus";
            this.txtFreamStatus.ReadOnly = true;
            this.txtFreamStatus.Size = new System.Drawing.Size(161, 21);
            this.txtFreamStatus.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "上传行情条数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "上传次数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "错误信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "连续出错数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "出错数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "上传状态";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "行情状态";
            // 
            // tmrUpAll
            // 
            this.tmrUpAll.Interval = 1000;
            this.tmrUpAll.Tick += new System.EventHandler(this.tmrUpAll_Tick);
            // 
            // ucPriceTable1
            // 
            this.ucPriceTable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPriceTable1.Location = new System.Drawing.Point(0, 130);
            this.ucPriceTable1.Name = "ucPriceTable1";
            this.ucPriceTable1.Padding = new System.Windows.Forms.Padding(8, 28, 5, 5);
            this.ucPriceTable1.Size = new System.Drawing.Size(528, 220);
            this.ucPriceTable1.TabIndex = 1;
            // 
            // HQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 350);
            this.Controls.Add(this.ucPriceTable1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "HQForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "行情采集";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UCPriceTable ucPriceTable1;
        private System.Windows.Forms.Timer tmrUpAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtErrorCounte;
        private System.Windows.Forms.TextBox txtUpCount;
        private System.Windows.Forms.TextBox txtUpStatus;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.TextBox txtErrorTotal;
        private System.Windows.Forms.TextBox txtUpCi;
        private System.Windows.Forms.TextBox txtFreamStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;




    }
}

