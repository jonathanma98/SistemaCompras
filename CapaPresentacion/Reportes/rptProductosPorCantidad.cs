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
    public partial class rptProductosPorCantidad : Form
    {
        public rptProductosPorCantidad()
        {
            InitializeComponent();
        }

        private void rptProductosPorCantidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemaCompraDataSet.tbEmpresa' Puede moverla o quitarla según sea necesario.
            this.tbEmpresaTableAdapter.Fill(this.SistemaCompraDataSet.tbEmpresa);
            // TODO: esta línea de código carga datos en la tabla 'SistemaCompraDataSet.QUERYProductosPorCantidad' Puede moverla o quitarla según sea necesario.
            this.QUERYProductosPorCantidadTableAdapter.Fill(this.SistemaCompraDataSet.QUERYProductosPorCantidad);

            this.reportViewer1.RefreshReport();
        }
    }
}
