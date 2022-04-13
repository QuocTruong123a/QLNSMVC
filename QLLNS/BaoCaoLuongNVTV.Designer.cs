
namespace QLLNS
{
    partial class BaoCaoLuongNVTV
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.congLamViecNVCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.luongNVCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LuongNVCT = new QLLNS.LuongNVCT();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.congLamViecNVCTTableAdapter = new QLLNS.LuongNVCTTableAdapters.CongLamViecNVCTTableAdapter();
            this.luongNVTV = new QLLNS.LuongNVTV();
            this.congLamViecNVTVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.congLamViecNVTVTableAdapter = new QLLNS.LuongNVTVTableAdapters.CongLamViecNVTVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.congLamViecNVCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNVCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuongNVCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNVTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congLamViecNVTVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // congLamViecNVCTBindingSource
            // 
            this.congLamViecNVCTBindingSource.DataMember = "CongLamViecNVCT";
            this.congLamViecNVCTBindingSource.DataSource = this.luongNVCTBindingSource;
            // 
            // luongNVCTBindingSource
            // 
            this.luongNVCTBindingSource.DataSource = this.LuongNVCT;
            this.luongNVCTBindingSource.Position = 0;
            // 
            // LuongNVCT
            // 
            this.LuongNVCT.DataSetName = "LuongNVCT";
            this.LuongNVCT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox2.Location = new System.Drawing.Point(317, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(92, 24);
            this.comboBox2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Chọn Tháng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 22);
            this.textBox1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(727, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nhập năm";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(566, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Báo Cáo Lương";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.congLamViecNVTVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLLNS.BaoCaoLuongNVTV.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(826, 352);
            this.reportViewer1.TabIndex = 9;
            // 
            // congLamViecNVCTTableAdapter
            // 
            this.congLamViecNVCTTableAdapter.ClearBeforeFill = true;
            // 
            // luongNVTV
            // 
            this.luongNVTV.DataSetName = "LuongNVTV";
            this.luongNVTV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // congLamViecNVTVBindingSource
            // 
            this.congLamViecNVTVBindingSource.DataMember = "CongLamViecNVTV";
            this.congLamViecNVTVBindingSource.DataSource = this.luongNVTV;
            // 
            // congLamViecNVTVTableAdapter
            // 
            this.congLamViecNVTVTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoLuongNVTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BaoCaoLuongNVTV";
            this.Text = "BaoCaoLuongNVTV";
            this.Load += new System.EventHandler(this.BaoCaoLuongNVTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.congLamViecNVCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNVCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuongNVCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNVTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congLamViecNVTVBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource congLamViecNVCTBindingSource;
        private System.Windows.Forms.BindingSource luongNVCTBindingSource;
        private LuongNVCT LuongNVCT;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private LuongNVCTTableAdapters.CongLamViecNVCTTableAdapter congLamViecNVCTTableAdapter;
        private System.Windows.Forms.BindingSource congLamViecNVTVBindingSource;
        private LuongNVTV luongNVTV;
        private LuongNVTVTableAdapters.CongLamViecNVTVTableAdapter congLamViecNVTVTableAdapter;
    }
}