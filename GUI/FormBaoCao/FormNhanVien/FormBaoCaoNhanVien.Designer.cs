namespace GUI.FormBaoCao.FormNhanVien
{
    partial class FormBaoCaoNhanVien
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
            this.DataSetNhanVien = new GUI.FormBaoCao.FormNhanVien.DataSetNhanVien();
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NhanVienTableAdapter = new GUI.FormBaoCao.FormNhanVien.DataSetNhanVienTableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.FormBaoCao.FormNhanVien.RptNhanVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1262, 673);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetNhanVien
            // 
            this.DataSetNhanVien.DataSetName = "DataSetNhanVien";
            this.DataSetNhanVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            this.NhanVienBindingSource.DataSource = this.DataSetNhanVien;
            // 
            // NhanVienTableAdapter
            // 
            this.NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // FormBaoCaoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormBaoCaoNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Nhân Viên";
            this.Load += new System.EventHandler(this.FormBaoCaoNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private DataSetNhanVien DataSetNhanVien;
        private DataSetNhanVienTableAdapters.NhanVienTableAdapter NhanVienTableAdapter;
    }
}