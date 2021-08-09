
namespace CapaPresentacion.Reportes
{
    partial class rptControlDineroPorFecha
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.comboBoxTIpo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbEmpresaTableAdapter = new CapaPresentacion.Reportes.SistemaCompraDataSetTableAdapters.tbEmpresaTableAdapter();
            this.tbEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QueryControDineroPorFechaTableAdapter = new CapaPresentacion.Reportes.SistemaCompraDataSetTableAdapters.QueryControDineroPorFechaTableAdapter();
            this.QueryControDineroPorFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SistemaCompraDataSet = new CapaPresentacion.Reportes.SistemaCompraDataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryControDineroPorFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaCompraDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.monthCalendar1.Location = new System.Drawing.Point(9, 27);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(289, 27);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 1;
            // 
            // comboBoxTIpo
            // 
            this.comboBoxTIpo.FormattingEnabled = true;
            this.comboBoxTIpo.Location = new System.Drawing.Point(624, 56);
            this.comboBoxTIpo.Name = "comboBoxTIpo";
            this.comboBoxTIpo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTIpo.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.monthCalendar2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 196);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(621, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta la fecha";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.icons8_búsqueda_16_1_;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(661, 114);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde la fecha";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.QueryControDineroPorFechaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.tbEmpresaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.ControlDineroPorFecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 196);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 360);
            this.reportViewer1.TabIndex = 3;
            // 
            // tbEmpresaTableAdapter
            // 
            this.tbEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // tbEmpresaBindingSource
            // 
            this.tbEmpresaBindingSource.DataMember = "tbEmpresa";
            // 
            // QueryControDineroPorFechaTableAdapter
            // 
            this.QueryControDineroPorFechaTableAdapter.ClearBeforeFill = true;
            // 
            // QueryControDineroPorFechaBindingSource
            // 
            this.QueryControDineroPorFechaBindingSource.DataMember = "QueryControDineroPorFecha";
            // 
            // SistemaCompraDataSet
            // 
            this.SistemaCompraDataSet.DataSetName = "SistemaCompraDataSet";
            this.SistemaCompraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptControlDineroPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.comboBoxTIpo);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "rptControlDineroPorFecha";
            this.Text = "rptControlDineroPorFecha";
            this.Load += new System.EventHandler(this.rptControlDineroPorFecha_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryControDineroPorFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaCompraDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox comboBoxTIpo;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource QueryControDineroPorFechaBindingSource;
        private System.Windows.Forms.BindingSource tbEmpresaBindingSource;
        private SistemaCompraDataSetTableAdapters.tbEmpresaTableAdapter tbEmpresaTableAdapter;
        private SistemaCompraDataSetTableAdapters.QueryControDineroPorFechaTableAdapter QueryControDineroPorFechaTableAdapter;
        private SistemaCompraDataSet SistemaCompraDataSet;
    }
}