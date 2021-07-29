
namespace CapaPresentacion.Reportes
{
    partial class frmVentaClientePorId
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
            this.QUERYVentasAClientePorIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbEmpresaTableAdapter = new CapaPresentacion.Reportes.SistemaCompraDataSetTableAdapters.tbEmpresaTableAdapter();
            this.QUERYVentasAClientePorIdTableAdapter = new CapaPresentacion.Reportes.SistemaCompraDataSetTableAdapters.QUERYVentasAClientePorIdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaCompraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUERYVentasAClientePorIdBindingSource)).BeginInit();
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
            // QUERYVentasAClientePorIdBindingSource
            // 
            this.QUERYVentasAClientePorIdBindingSource.DataMember = "QUERYVentasAClientePorId";
            this.QUERYVentasAClientePorIdBindingSource.DataSource = this.SistemaCompraDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 109);
            this.panel1.TabIndex = 0;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Gray;
            this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCliente.Image = global::CapaPresentacion.Properties.Resources.icons8_prismáticos_16_1_;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(305, 15);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(120, 23);
            this.btnCliente.TabIndex = 10;
            this.btnCliente.Text = "Buscar cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(141, 15);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(158, 20);
            this.txtCliente.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selecion Cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.icons8_búsqueda_16_1_;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(150, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(139, 39);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDatosEmpresa";
            reportDataSource1.Value = this.tbEmpresaBindingSource;
            reportDataSource2.Name = "DataSetVentaACienteId";
            reportDataSource2.Value = this.QUERYVentasAClientePorIdBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.VentasClientePorId.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 109);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 341);
            this.reportViewer1.TabIndex = 1;
            // 
            // tbEmpresaTableAdapter
            // 
            this.tbEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // QUERYVentasAClientePorIdTableAdapter
            // 
            this.QUERYVentasAClientePorIdTableAdapter.ClearBeforeFill = true;
            // 
            // frmVentaClientePorId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmVentaClientePorId";
            this.Text = "frmVentaClientePorId";
            this.Load += new System.EventHandler(this.frmVentaClientePorId_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaCompraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUERYVentasAClientePorIdBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbEmpresaBindingSource;
        private SistemaCompraDataSet SistemaCompraDataSet;
        private System.Windows.Forms.BindingSource QUERYVentasAClientePorIdBindingSource;
        private SistemaCompraDataSetTableAdapters.tbEmpresaTableAdapter tbEmpresaTableAdapter;
        private SistemaCompraDataSetTableAdapters.QUERYVentasAClientePorIdTableAdapter QUERYVentasAClientePorIdTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox txtCliente;
    }
}