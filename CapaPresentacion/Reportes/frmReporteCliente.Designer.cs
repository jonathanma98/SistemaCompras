
namespace CapaPresentacion.Reportes
{
    partial class frmReporteCliente
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
            this.reporteCliente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporteCliente
            // 
            this.reporteCliente.LocalReport.DisplayName = "reporteCliente";
            this.reporteCliente.Location = new System.Drawing.Point(0, 0);
            this.reporteCliente.Name = "ReportViewer";
            this.reporteCliente.ServerReport.BearerToken = null;
            this.reporteCliente.Size = new System.Drawing.Size(396, 246);
            this.reporteCliente.TabIndex = 0;
            // 
            // frmReporteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmReporteCliente";
            this.Text = "frmReporteCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporteCliente;
    }
}