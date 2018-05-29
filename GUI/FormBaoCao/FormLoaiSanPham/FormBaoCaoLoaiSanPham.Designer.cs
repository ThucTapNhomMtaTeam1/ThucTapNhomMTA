namespace GUI.FormBaoCao.FormLoaiSanPham
{
    partial class FormBaoCaoLoaiSanPham
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetLoaiSanPham = new GUI.FormBaoCao.FormLoaiSanPham.DataSetLoaiSanPham();
            this.LoaiSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoaiSanPhamTableAdapter = new GUI.FormBaoCao.FormLoaiSanPham.DataSetLoaiSanPhamTableAdapters.LoaiSanPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetLoaiSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiSanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LoaiSanPhamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.FormBaoCao.FormLoaiSanPham.RptLoaiSanPham.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(772, 673);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetLoaiSanPham
            // 
            this.DataSetLoaiSanPham.DataSetName = "DataSetLoaiSanPham";
            this.DataSetLoaiSanPham.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LoaiSanPhamBindingSource
            // 
            this.LoaiSanPhamBindingSource.DataMember = "LoaiSanPham";
            this.LoaiSanPhamBindingSource.DataSource = this.DataSetLoaiSanPham;
            // 
            // LoaiSanPhamTableAdapter
            // 
            this.LoaiSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // FormBaoCaoLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 673);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormBaoCaoLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Loại Sản Phẩm";
            this.Load += new System.EventHandler(this.FormBaoCaoLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetLoaiSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoaiSanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LoaiSanPhamBindingSource;
        private DataSetLoaiSanPham DataSetLoaiSanPham;
        private DataSetLoaiSanPhamTableAdapters.LoaiSanPhamTableAdapter LoaiSanPhamTableAdapter;
    }
}