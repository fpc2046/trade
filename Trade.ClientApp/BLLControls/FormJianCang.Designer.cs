namespace Trade.ClientApp.BLLControls
{
    partial class FormJianCang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJianCang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDealer = new System.Windows.Forms.ComboBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.lblScope = new System.Windows.Forms.Label();
            this.nuHandNum = new System.Windows.Forms.NumericUpDown();
            this.cboCommodity = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gboMarker = new System.Windows.Forms.GroupBox();
            this.nuMaxMin = new System.Windows.Forms.NumericUpDown();
            this.chkAllowMaxMin = new System.Windows.Forms.CheckBox();
            this.lblbzjbl = new System.Windows.Forms.Label();
            this.rdoSell = new System.Windows.Forms.RadioButton();
            this.rdoBuy = new System.Windows.Forms.RadioButton();
            this.txtBuyOrSellPrice = new System.Windows.Forms.TextBox();
            this.chkBeforeSure = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblTiShi = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCencel = new System.Windows.Forms.Button();
            this.rdoBuy2 = new System.Windows.Forms.RadioButton();
            this.rdoSell2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cboEnableTime = new System.Windows.Forms.ComboBox();
            this.txtbuyPrice = new System.Windows.Forms.TextBox();
            this.txtsellPrice = new System.Windows.Forms.TextBox();
            this.nuThePrice = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lblbzjbl2 = new System.Windows.Forms.Label();
            this.chkZS = new System.Windows.Forms.CheckBox();
            this.chkZY = new System.Windows.Forms.CheckBox();
            this.nuZSValue = new System.Windows.Forms.NumericUpDown();
            this.nuZYValue = new System.Windows.Forms.NumericUpDown();
            this.lblZSMark = new System.Windows.Forms.Label();
            this.lblZYMark = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.gboThe = new System.Windows.Forms.GroupBox();
            this.gboLoading = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuHandNum)).BeginInit();
            this.gboMarker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuMaxMin)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuThePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuZSValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuZYValue)).BeginInit();
            this.gboThe.SuspendLayout();
            this.gboLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDealer);
            this.groupBox1.Controls.Add(this.btnMax);
            this.groupBox1.Controls.Add(this.lblScope);
            this.groupBox1.Controls.Add(this.nuHandNum);
            this.groupBox1.Controls.Add(this.cboCommodity);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboDealer
            // 
            this.cboDealer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDealer.FormattingEnabled = true;
            this.cboDealer.Location = new System.Drawing.Point(110, 114);
            this.cboDealer.Name = "cboDealer";
            this.cboDealer.Size = new System.Drawing.Size(221, 20);
            this.cboDealer.TabIndex = 9;
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(177, 84);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(45, 21);
            this.btnMax.TabIndex = 8;
            this.btnMax.Text = "最大";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // lblScope
            // 
            this.lblScope.AutoSize = true;
            this.lblScope.Location = new System.Drawing.Point(226, 88);
            this.lblScope.Name = "lblScope";
            this.lblScope.Size = new System.Drawing.Size(95, 12);
            this.lblScope.TabIndex = 7;
            this.lblScope.Text = "(可选范围：0-0)";
            // 
            // nuHandNum
            // 
            this.nuHandNum.Location = new System.Drawing.Point(110, 84);
            this.nuHandNum.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nuHandNum.Name = "nuHandNum";
            this.nuHandNum.Size = new System.Drawing.Size(62, 21);
            this.nuHandNum.TabIndex = 6;
            this.nuHandNum.ValueChanged += new System.EventHandler(this.nuHandNum_ValueChanged);
            // 
            // cboCommodity
            // 
            this.cboCommodity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCommodity.FormattingEnabled = true;
            this.cboCommodity.Location = new System.Drawing.Point(110, 54);
            this.cboCommodity.Name = "cboCommodity";
            this.cboCommodity.Size = new System.Drawing.Size(221, 20);
            this.cboCommodity.TabIndex = 5;
            this.cboCommodity.SelectedIndexChanged += new System.EventHandler(this.cboCommodity_SelectedIndexChanged);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "市价建仓单",
            "指价建仓单"});
            this.cboType.Location = new System.Drawing.Point(110, 24);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(221, 20);
            this.cboType.TabIndex = 4;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(25, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "交 易 商";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "手    数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "商    品";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "交易类型";
            // 
            // gboMarker
            // 
            this.gboMarker.Controls.Add(this.nuMaxMin);
            this.gboMarker.Controls.Add(this.chkAllowMaxMin);
            this.gboMarker.Controls.Add(this.lblbzjbl);
            this.gboMarker.Controls.Add(this.rdoSell);
            this.gboMarker.Controls.Add(this.rdoBuy);
            this.gboMarker.Controls.Add(this.txtBuyOrSellPrice);
            this.gboMarker.Location = new System.Drawing.Point(11, 167);
            this.gboMarker.Name = "gboMarker";
            this.gboMarker.Size = new System.Drawing.Size(373, 242);
            this.gboMarker.TabIndex = 1;
            this.gboMarker.TabStop = false;
            // 
            // nuMaxMin
            // 
            this.nuMaxMin.Location = new System.Drawing.Point(213, 167);
            this.nuMaxMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nuMaxMin.Name = "nuMaxMin";
            this.nuMaxMin.Size = new System.Drawing.Size(83, 21);
            this.nuMaxMin.TabIndex = 7;
            this.nuMaxMin.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // chkAllowMaxMin
            // 
            this.chkAllowMaxMin.AutoSize = true;
            this.chkAllowMaxMin.Checked = true;
            this.chkAllowMaxMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowMaxMin.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.chkAllowMaxMin.Location = new System.Drawing.Point(43, 129);
            this.chkAllowMaxMin.Name = "chkAllowMaxMin";
            this.chkAllowMaxMin.Size = new System.Drawing.Size(234, 19);
            this.chkAllowMaxMin.TabIndex = 4;
            this.chkAllowMaxMin.Text = "允许成交价和报价的最大点差";
            this.chkAllowMaxMin.UseVisualStyleBackColor = true;
            this.chkAllowMaxMin.CheckedChanged += new System.EventHandler(this.chkAllowMaxMin_CheckedChanged);
            // 
            // lblbzjbl
            // 
            this.lblbzjbl.AutoSize = true;
            this.lblbzjbl.ForeColor = System.Drawing.Color.Red;
            this.lblbzjbl.Location = new System.Drawing.Point(6, 108);
            this.lblbzjbl.Name = "lblbzjbl";
            this.lblbzjbl.Size = new System.Drawing.Size(317, 12);
            this.lblbzjbl.TabIndex = 3;
            this.lblbzjbl.Text = "当前建仓保证金比例0%，当前建仓所需占用保证金0.00元。";
            // 
            // rdoSell
            // 
            this.rdoSell.AutoSize = true;
            this.rdoSell.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.rdoSell.Location = new System.Drawing.Point(92, 31);
            this.rdoSell.Name = "rdoSell";
            this.rdoSell.Size = new System.Drawing.Size(41, 19);
            this.rdoSell.TabIndex = 1;
            this.rdoSell.Text = "卖";
            this.rdoSell.UseVisualStyleBackColor = true;
            // 
            // rdoBuy
            // 
            this.rdoBuy.AutoSize = true;
            this.rdoBuy.Checked = true;
            this.rdoBuy.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.rdoBuy.Location = new System.Drawing.Point(37, 31);
            this.rdoBuy.Name = "rdoBuy";
            this.rdoBuy.Size = new System.Drawing.Size(41, 19);
            this.rdoBuy.TabIndex = 0;
            this.rdoBuy.TabStop = true;
            this.rdoBuy.Text = "买";
            this.rdoBuy.UseVisualStyleBackColor = true;
            this.rdoBuy.CheckedChanged += new System.EventHandler(this.rdoBuy_CheckedChanged);
            // 
            // txtBuyOrSellPrice
            // 
            this.txtBuyOrSellPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            this.txtBuyOrSellPrice.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBuyOrSellPrice.Location = new System.Drawing.Point(19, 60);
            this.txtBuyOrSellPrice.Name = "txtBuyOrSellPrice";
            this.txtBuyOrSellPrice.ReadOnly = true;
            this.txtBuyOrSellPrice.Size = new System.Drawing.Size(339, 41);
            this.txtBuyOrSellPrice.TabIndex = 2;
            this.txtBuyOrSellPrice.Text = "0";
            this.txtBuyOrSellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkBeforeSure
            // 
            this.chkBeforeSure.AutoSize = true;
            this.chkBeforeSure.Checked = true;
            this.chkBeforeSure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBeforeSure.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.chkBeforeSure.Location = new System.Drawing.Point(12, 414);
            this.chkBeforeSure.Name = "chkBeforeSure";
            this.chkBeforeSure.Size = new System.Drawing.Size(106, 19);
            this.chkBeforeSure.TabIndex = 5;
            this.chkBeforeSure.Text = "下单前确认";
            this.chkBeforeSure.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblTiShi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(395, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblTiShi
            // 
            this.tslblTiShi.Name = "tslblTiShi";
            this.tslblTiShi.Size = new System.Drawing.Size(31, 17);
            this.tslblTiShi.Text = "提示";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(92, 438);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCencel
            // 
            this.btnCencel.Location = new System.Drawing.Point(227, 438);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(75, 23);
            this.btnCencel.TabIndex = 8;
            this.btnCencel.Text = "取消";
            this.btnCencel.UseVisualStyleBackColor = true;
            this.btnCencel.Click += new System.EventHandler(this.btnCencel_Click);
            // 
            // rdoBuy2
            // 
            this.rdoBuy2.AutoSize = true;
            this.rdoBuy2.Checked = true;
            this.rdoBuy2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.rdoBuy2.Location = new System.Drawing.Point(43, 16);
            this.rdoBuy2.Name = "rdoBuy2";
            this.rdoBuy2.Size = new System.Drawing.Size(41, 19);
            this.rdoBuy2.TabIndex = 2;
            this.rdoBuy2.TabStop = true;
            this.rdoBuy2.Text = "买";
            this.rdoBuy2.UseVisualStyleBackColor = true;
            this.rdoBuy2.CheckedChanged += new System.EventHandler(this.rdoBuy2_CheckedChanged);
            // 
            // rdoSell2
            // 
            this.rdoSell2.AutoSize = true;
            this.rdoSell2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.rdoSell2.Location = new System.Drawing.Point(98, 16);
            this.rdoSell2.Name = "rdoSell2";
            this.rdoSell2.Size = new System.Drawing.Size(41, 19);
            this.rdoSell2.TabIndex = 3;
            this.rdoSell2.Text = "卖";
            this.rdoSell2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(169, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "有效期";
            // 
            // cboEnableTime
            // 
            this.cboEnableTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEnableTime.FormattingEnabled = true;
            this.cboEnableTime.Items.AddRange(new object[] {
            "当日有效"});
            this.cboEnableTime.Location = new System.Drawing.Point(232, 15);
            this.cboEnableTime.Name = "cboEnableTime";
            this.cboEnableTime.Size = new System.Drawing.Size(99, 20);
            this.cboEnableTime.TabIndex = 10;
            // 
            // txtbuyPrice
            // 
            this.txtbuyPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            this.txtbuyPrice.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbuyPrice.ForeColor = System.Drawing.Color.Blue;
            this.txtbuyPrice.Location = new System.Drawing.Point(17, 46);
            this.txtbuyPrice.Name = "txtbuyPrice";
            this.txtbuyPrice.Size = new System.Drawing.Size(170, 41);
            this.txtbuyPrice.TabIndex = 11;
            this.txtbuyPrice.Text = "0";
            this.txtbuyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsellPrice
            // 
            this.txtsellPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(200)))), ((int)(((byte)(199)))));
            this.txtsellPrice.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtsellPrice.ForeColor = System.Drawing.Color.Red;
            this.txtsellPrice.Location = new System.Drawing.Point(186, 46);
            this.txtsellPrice.Name = "txtsellPrice";
            this.txtsellPrice.Size = new System.Drawing.Size(170, 41);
            this.txtsellPrice.TabIndex = 12;
            this.txtsellPrice.Text = "0";
            this.txtsellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nuThePrice
            // 
            this.nuThePrice.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nuThePrice.Location = new System.Drawing.Point(74, 99);
            this.nuThePrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nuThePrice.Name = "nuThePrice";
            this.nuThePrice.Size = new System.Drawing.Size(282, 44);
            this.nuThePrice.TabIndex = 13;
            this.nuThePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nuThePrice.ValueChanged += new System.EventHandler(this.nuThePrice_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(32, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "价格";
            // 
            // lblbzjbl2
            // 
            this.lblbzjbl2.AutoSize = true;
            this.lblbzjbl2.ForeColor = System.Drawing.Color.Red;
            this.lblbzjbl2.Location = new System.Drawing.Point(4, 149);
            this.lblbzjbl2.Name = "lblbzjbl2";
            this.lblbzjbl2.Size = new System.Drawing.Size(329, 12);
            this.lblbzjbl2.TabIndex = 15;
            this.lblbzjbl2.Text = "当前建仓保证金比例8%，当前建仓所需占用保证金338.24元。";
            // 
            // chkZS
            // 
            this.chkZS.AutoSize = true;
            this.chkZS.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.chkZS.Location = new System.Drawing.Point(21, 178);
            this.chkZS.Name = "chkZS";
            this.chkZS.Size = new System.Drawing.Size(58, 19);
            this.chkZS.TabIndex = 16;
            this.chkZS.Text = "止损";
            this.chkZS.UseVisualStyleBackColor = true;
            this.chkZS.CheckedChanged += new System.EventHandler(this.chkZS_CheckedChanged);
            // 
            // chkZY
            // 
            this.chkZY.AutoSize = true;
            this.chkZY.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.chkZY.Location = new System.Drawing.Point(21, 215);
            this.chkZY.Name = "chkZY";
            this.chkZY.Size = new System.Drawing.Size(58, 19);
            this.chkZY.TabIndex = 17;
            this.chkZY.Text = "止盈";
            this.chkZY.UseVisualStyleBackColor = true;
            this.chkZY.CheckedChanged += new System.EventHandler(this.chkZY_CheckedChanged);
            // 
            // nuZSValue
            // 
            this.nuZSValue.Enabled = false;
            this.nuZSValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nuZSValue.Location = new System.Drawing.Point(83, 174);
            this.nuZSValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nuZSValue.Name = "nuZSValue";
            this.nuZSValue.Size = new System.Drawing.Size(111, 26);
            this.nuZSValue.TabIndex = 18;
            this.nuZSValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nuZYValue
            // 
            this.nuZYValue.Enabled = false;
            this.nuZYValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nuZYValue.Location = new System.Drawing.Point(83, 211);
            this.nuZYValue.Name = "nuZYValue";
            this.nuZYValue.Size = new System.Drawing.Size(111, 26);
            this.nuZYValue.TabIndex = 19;
            this.nuZYValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblZSMark
            // 
            this.lblZSMark.AutoSize = true;
            this.lblZSMark.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblZSMark.Location = new System.Drawing.Point(209, 179);
            this.lblZSMark.Name = "lblZSMark";
            this.lblZSMark.Size = new System.Drawing.Size(17, 16);
            this.lblZSMark.TabIndex = 20;
            this.lblZSMark.Text = "<";
            // 
            // lblZYMark
            // 
            this.lblZYMark.AutoSize = true;
            this.lblZYMark.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblZYMark.Location = new System.Drawing.Point(209, 216);
            this.lblZYMark.Name = "lblZYMark";
            this.lblZYMark.Size = new System.Drawing.Size(17, 16);
            this.lblZYMark.TabIndex = 21;
            this.lblZYMark.Text = ">";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            this.textBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.ForeColor = System.Drawing.Color.Blue;
            this.textBox4.Location = new System.Drawing.Point(244, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(112, 26);
            this.textBox4.TabIndex = 22;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(202)))), ((int)(((byte)(238)))));
            this.textBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.ForeColor = System.Drawing.Color.Blue;
            this.textBox5.Location = new System.Drawing.Point(244, 211);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(112, 26);
            this.textBox5.TabIndex = 23;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gboThe
            // 
            this.gboThe.Controls.Add(this.textBox5);
            this.gboThe.Controls.Add(this.textBox4);
            this.gboThe.Controls.Add(this.lblZYMark);
            this.gboThe.Controls.Add(this.lblZSMark);
            this.gboThe.Controls.Add(this.nuZYValue);
            this.gboThe.Controls.Add(this.nuZSValue);
            this.gboThe.Controls.Add(this.chkZY);
            this.gboThe.Controls.Add(this.chkZS);
            this.gboThe.Controls.Add(this.lblbzjbl2);
            this.gboThe.Controls.Add(this.label8);
            this.gboThe.Controls.Add(this.nuThePrice);
            this.gboThe.Controls.Add(this.txtsellPrice);
            this.gboThe.Controls.Add(this.txtbuyPrice);
            this.gboThe.Controls.Add(this.cboEnableTime);
            this.gboThe.Controls.Add(this.label7);
            this.gboThe.Controls.Add(this.rdoSell2);
            this.gboThe.Controls.Add(this.rdoBuy2);
            this.gboThe.Location = new System.Drawing.Point(11, 167);
            this.gboThe.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.gboThe.Name = "gboThe";
            this.gboThe.Size = new System.Drawing.Size(373, 241);
            this.gboThe.TabIndex = 2;
            this.gboThe.TabStop = false;
            // 
            // gboLoading
            // 
            this.gboLoading.Controls.Add(this.label5);
            this.gboLoading.Controls.Add(this.pictureBox1);
            this.gboLoading.Location = new System.Drawing.Point(11, 167);
            this.gboLoading.Name = "gboLoading";
            this.gboLoading.Size = new System.Drawing.Size(373, 241);
            this.gboLoading.TabIndex = 24;
            this.gboLoading.TabStop = false;
            this.gboLoading.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "正在处理，请稍候．．．．．．";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trade.ClientApp.Properties.Resources.loading;
            this.pictureBox1.Location = new System.Drawing.Point(43, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormJianCang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 490);
            this.Controls.Add(this.btnCencel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chkBeforeSure);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboThe);
            this.Controls.Add(this.gboMarker);
            this.Controls.Add(this.gboLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormJianCang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "建仓单";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuHandNum)).EndInit();
            this.gboMarker.ResumeLayout(false);
            this.gboMarker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuMaxMin)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuThePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuZSValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuZYValue)).EndInit();
            this.gboThe.ResumeLayout(false);
            this.gboThe.PerformLayout();
            this.gboLoading.ResumeLayout(false);
            this.gboLoading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Label lblScope;
        private System.Windows.Forms.NumericUpDown nuHandNum;
        private System.Windows.Forms.ComboBox cboCommodity;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ComboBox cboDealer;
        private System.Windows.Forms.GroupBox gboMarker;
        private System.Windows.Forms.RadioButton rdoSell;
        private System.Windows.Forms.RadioButton rdoBuy;
        private System.Windows.Forms.NumericUpDown nuMaxMin;
        private System.Windows.Forms.CheckBox chkAllowMaxMin;
        private System.Windows.Forms.Label lblbzjbl;
        private System.Windows.Forms.TextBox txtBuyOrSellPrice;
        private System.Windows.Forms.CheckBox chkBeforeSure;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblTiShi;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCencel;
        private System.Windows.Forms.RadioButton rdoBuy2;
        private System.Windows.Forms.RadioButton rdoSell2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboEnableTime;
        private System.Windows.Forms.TextBox txtbuyPrice;
        private System.Windows.Forms.TextBox txtsellPrice;
        private System.Windows.Forms.NumericUpDown nuThePrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblbzjbl2;
        private System.Windows.Forms.CheckBox chkZS;
        private System.Windows.Forms.CheckBox chkZY;
        private System.Windows.Forms.NumericUpDown nuZSValue;
        private System.Windows.Forms.NumericUpDown nuZYValue;
        private System.Windows.Forms.Label lblZSMark;
        private System.Windows.Forms.Label lblZYMark;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox gboThe;
        private System.Windows.Forms.GroupBox gboLoading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}