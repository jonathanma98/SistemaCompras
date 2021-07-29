using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class rptVentaClientes : Form
    {
        public rptVentaClientes()
        {
            InitializeComponent();
        }

        private void rptVentaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemaCompraDataSet.tbEmpresa' Puede moverla o quitarla según sea necesario.
            this.tbEmpresaTableAdapter.Fill(this.SistemaCompraDataSet.tbEmpresa);
            // TODO: esta línea de código carga datos en la tabla 'SistemaCompraDataSet.QUERYTotalDeCompraDeClientes' Puede moverla o quitarla según sea necesario.
            this.QUERYTotalDeCompraDeClientesTableAdapter.Fill(this.SistemaCompraDataSet.QUERYTotalDeCompraDeClientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
