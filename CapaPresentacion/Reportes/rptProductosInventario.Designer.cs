
namespace CapaPresentacion.Reportes
{
    partial class rptProductosInventario
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
            this.tbEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SistemaCompraDataSet = new CapaPresentacion.Reportes.SistemaCompraDataSet();
            this.QUERYInventatarioPorFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbEmpresaTableAdapter = new CapaPresentacion.Reportes.SistemaCompraDataSetTableAdapters.tbEmpresaTableAdapter();
            this.QUERYInventatarioPorFechaTableAdapter = new CapaPresentacion.Reportes.SistemaCompraDataSetTableAdapters.QUERYInventatarioPorFechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaCompraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUERYInventatarioPorFechaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEmpresaBindingSource
            // 
            this.tbEmpresaBindingSource.DataMember = "tbEmpresa";
            this.tbEmpresaBindingSource.DataSource = this.SistemaCompraDataSet;
            // 
            // SistemaCompraDataSet
            // 
            this.SistemaCompraDataSet.DataSetName = "SistemaCompraDataSet";
            this.SistemaCompraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QUERYInventatarioPorFechaBindingSource
            // 
            this.QUERYInventatarioPorFechaBindingSource.DataMember = "QUERYInventatarioPorFecha";
            this.QUERYInventatarioPorFechaBindingSource.DataSource = this.SistemaCompraDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.monthCalendar2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 201);
            this.panel1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.icons8_búsqueda_16_1_;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(584, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 36);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta la fecha";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.monthCalendar1.Location = new System.Drawing.Point(21, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde la fecha";
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(301, 30);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 5;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDatosEmpresa";
            reportDataSource1.Value = this.tbEmpresaBindingSource;
            reportDataSource2.Name = "DataSetInventarioPorFecha";
            reportDataSource2.Value = this.QUERYInventatarioPorFechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.ProductosInventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 201);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1064, 371);
            this.reportViewer1.TabIndex = 1;
            // 
            // tbEmpresaTableAdapter
            // 
            this.tbEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // QUERYInventatarioPorFechaTableAdapter
            // 
            this.QUERYInventatarioPorFechaTableAdapter.ClearBeforeFill = true;
            // 
            // rptProductosInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 572);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "rptProductosInventario";
            this.Text = "rptProductosInventario";
            this.Load += new System.EventHandler(this.rptProductosInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaCompraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUERYInventatarioPorFechaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource tbEmpresaBindingSource;
        private SistemaCompraDataSet SistemaCompraDataSet;
        private System.Windows.Forms.BindingSource QUERYInventatarioPorFechaBindingSource;
        private SistemaCompraDataSetTableAdapters.tbEmpresaTableAdapter tbEmpresaTableAdapter;
        private SistemaCompraDataSetTableAdapters.QUERYInventatarioPorFechaTableAdapter QUERYInventatarioPorFechaTableAdapter;
    }
}