
namespace CapaPresentacion.Reportes
{
    partial class rptVentaProveedores
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SistemaCompraDataSet = new CapaPresentacion.Reportes.SistemaCompraDataSet();
            this.QueryTotaldeCompraAAproveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QueryTotaldeCompraAAproveedoresTableAdapter = new CapaPresentacion.Reportes.SistemaCompraDataSetTableAdapters.QueryTotaldeCompraAAproveedoresTableAdapter();
            this.tbEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbEmpresaTableAdapter = new CapaPresentacion.Reportes.SistemaCompraDataSetTableAdapters.tbEmpresaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaCompraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryTotaldeCompraAAproveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TotalDeComprasDataSet";
            reportDataSource1.Value = this.QueryTotaldeCompraAAproveedoresBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tbEmpresaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.VentasPorProveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SistemaCompraDataSet
            // 
            this.SistemaCompraDataSet.DataSetName = "SistemaCompraDataSet";
            this.SistemaCompraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QueryTotaldeCompraAAproveedoresBindingSource
            // 
            this.QueryTotaldeCompraAAproveedoresBindingSource.DataMember = "QueryTotaldeCompraAAproveedores";
            this.QueryTotaldeCompraAAproveedoresBindingSource.DataSource = this.SistemaCompraDataSet;
            // 
            // QueryTotaldeCompraAAproveedoresTableAdapter
            // 
            this.QueryTotaldeCompraAAproveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tbEmpresaBindingSource
            // 
            this.tbEmpresaBindingSource.DataMember = "tbEmpresa";
            this.tbEmpresaBindingSource.DataSource = this.SistemaCompraDataSet;
            // 
            // tbEmpresaTableAdapter
            // 
            this.tbEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // rptVentaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptVentaProveedores";
            this.Load += new System.EventHandler(this.rptVentaProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SistemaCompraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryTotaldeCompraAAproveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource QueryTotaldeCompraAAproveedoresBindingSource;
        private SistemaCompraDataSet SistemaCompraDataSet;
        private System.Windows.Forms.BindingSource tbEmpresaBindingSource;
        private SistemaCompraDataSetTableAdapters.QueryTotaldeCompraAAproveedoresTableAdapter QueryTotaldeCompraAAproveedoresTableAdapter;
        private SistemaCompraDataSetTableAdapters.tbEmpresaTableAdapter tbEmpresaTableAdapter;
    }
}