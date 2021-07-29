using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.FormsMostracion;

namespace CapaPresentacion.Reportes
{
    public partial class frmVentaClientePorId : Form
    {
        public frmVentaClientePorId()
        {
            InitializeComponent();
        }

        public String CedulaB { get; set; }

        private void frmVentaClientePorId_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemaCompraDataSet.tbEmpresa' Puede moverla o quitarla según sea necesario.
            this.tbEmpresaTableAdapter.Fill(this.SistemaCompraDataSet.tbEmpresa);
            // TODO: esta línea de código carga datos en la tabla 'SistemaCompraDataSet.QUERYVentasAClientePorId' Puede moverla o quitarla según sea necesario.
            this.QUERYVentasAClientePorIdTableAdapter.Fill(this.SistemaCompraDataSet.QUERYVentasAClientePorId, CedulaB);

            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            if (txtCliente.Text != string.Empty)
            {
                CedulaB = txtCliente.Text.Trim();

                this.tbEmpresaTableAdapter.Fill(this.SistemaCompraDataSet.tbEmpresa);
                // TODO: esta línea de código carga datos en la tabla 'SistemaCompraDataSet.QUERYVentasAClientePorId' Puede moverla o quitarla según sea necesario.
                this.QUERYVentasAClientePorIdTableAdapter.Fill(this.SistemaCompraDataSet.QUERYVentasAClientePorId, CedulaB);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Verifica que tengas seleccionado un cliente o que las fechas no sea inferiores a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frmCliene = new frmBuscarCliente();
            frmCliene.Show();
            frmCliene.refreData();

            frmCliene.pasaCliene += FrmCliene_pasaCliene;
        }

        private void FrmCliene_pasaCliene(CapaEntidades.tbCliente InfCliente)
        {
            txtCliente.Text = InfCliente.Id.Trim();
        }
    }
}
