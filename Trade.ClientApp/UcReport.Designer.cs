namespace Trade.ClientApp
{
    partial class UcReport
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
            this.components = new System.ComponentModel.Container();
            this.DealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradeDataSet = new Trade.ClientApp.tradeDataSet();
            this.SalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkFund = new System.Windows.Forms.CheckBox();
            this.chkFundDetail = new System.Windows.Forms.CheckBox();
            this.chkHold = new System.Windows.Forms.CheckBox();
            this.chkDelas = new System.Windows.Forms.CheckBox();
            this.chkSales = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalesTableAdapter = new Trade.ClientApp.tradeDataSetTableAdapters.SalesTableAdapter();
            this.DealsTableAdapter = new Trade.ClientApp.tradeDataSetTableAdapters.DealsTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DealsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DealsBindingSource
            // 
            this.DealsBindingSource.DataMember = "Deals";
            this.DealsBindingSource.DataSource = this.tradeDataSet;
            // 
            // tradeDataSet
            // 
            this.tradeDataSet.DataSetName = "tradeDataSet";
            this.tradeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalesBindingSource
            // 
            this.SalesBindingSource.DataMember = "Sales";
            this.SalesBindingSource.DataSource = this.tradeDataSet;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chkFund);
            this.panel1.Controls.Add(this.chkFundDetail);
            this.panel1.Controls.Add(this.chkHold);
            this.panel1.Controls.Add(this.chkDelas);
            this.panel1.Controls.Add(this.chkSales);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 65);
            this.panel1.TabIndex = 0;
            // 
            // chkFund
            // 
            this.chkFund.AutoSize = true;
            this.chkFund.Checked = true;
            this.chkFund.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFund.Location = new System.Drawing.Point(415, 38);
            this.chkFund.Name = "chkFund";
            this.chkFund.Size = new System.Drawing.Size(82, 18);
            this.chkFund.TabIndex = 10;
            this.chkFund.Text = "资金状况";
            this.chkFund.UseVisualStyleBackColor = true;
            // 
            // chkFundDetail
            // 
            this.chkFundDetail.AutoSize = true;
            this.chkFundDetail.Checked = true;
            this.chkFundDetail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFundDetail.Location = new System.Drawing.Point(315, 38);
            this.chkFundDetail.Name = "chkFundDetail";
            this.chkFundDetail.Size = new System.Drawing.Size(82, 18);
            this.chkFundDetail.TabIndex = 9;
            this.chkFundDetail.Text = "资金流水";
            this.chkFundDetail.UseVisualStyleBackColor = true;
            // 
            // chkHold
            // 
            this.chkHold.AutoSize = true;
            this.chkHold.Checked = true;
            this.chkHold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHold.Location = new System.Drawing.Point(215, 38);
            this.chkHold.Name = "chkHold";
            this.chkHold.Size = new System.Drawing.Size(82, 18);
            this.chkHold.TabIndex = 8;
            this.chkHold.Text = "持仓明细";
            this.chkHold.UseVisualStyleBackColor = true;
            // 
            // chkDelas
            // 
            this.chkDelas.AutoSize = true;
            this.chkDelas.Checked = true;
            this.chkDelas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDelas.Location = new System.Drawing.Point(115, 38);
            this.chkDelas.Name = "chkDelas";
            this.chkDelas.Size = new System.Drawing.Size(82, 18);
            this.chkDelas.TabIndex = 7;
            this.chkDelas.Text = "成交明细";
            this.chkDelas.UseVisualStyleBackColor = true;
            // 
            // chkSales
            // 
            this.chkSales.AutoSize = true;
            this.chkSales.Checked = true;
            this.chkSales.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSales.Location = new System.Drawing.Point(15, 38);
            this.chkSales.Name = "chkSales";
            this.chkSales.Size = new System.Drawing.Size(82, 18);
            this.chkSales.TabIndex = 6;
            this.chkSales.Text = "平仓明细";
            this.chkSales.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(559, 34);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(60, 25);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(559, 5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(60, 25);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.BtnQueryClick);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(370, 5);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(110, 23);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(91, 5);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(110, 23);
            this.dtpStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "结束日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始日期：";
            // 
            // SalesTableAdapter
            // 
            this.SalesTableAdapter.ClearBeforeFill = true;
            // 
            // DealsTableAdapter
            // 
            this.DealsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Trade.ClientApp.RptMain.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 65);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.Size = new System.Drawing.Size(1038, 444);
            this.reportViewer1.TabIndex = 1;
            // 
            // UcReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Name = "UcReport";
            this.Size = new System.Drawing.Size(1038, 509);
            ((System.ComponentModel.ISupportInitialize)(this.DealsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkFund;
        private System.Windows.Forms.CheckBox chkFundDetail;
        private System.Windows.Forms.CheckBox chkHold;
        private System.Windows.Forms.CheckBox chkDelas;
        private System.Windows.Forms.CheckBox chkSales;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private tradeDataSet tradeDataSet;
        private System.Windows.Forms.BindingSource SalesBindingSource;
        private tradeDataSetTableAdapters.SalesTableAdapter SalesTableAdapter;
        private System.Windows.Forms.BindingSource DealsBindingSource;
        private tradeDataSetTableAdapters.DealsTableAdapter DealsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
