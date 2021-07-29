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
    public partial class rptProductosPorCantidadDeVentas : Form
    {
        public rptProductosPorCantidadDeVentas()
        {
            InitializeComponent();
        }

        public DateTime fecha1 { get; set; }
        public DateTime fecha2 { get; set; }


        private void rptProductosPorCantidadDeVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemaCompraDataSet.tbEmpresa' Puede moverla o quitarla según sea necesario.
            this.tbEmpresaTableAdapter.Fill(this.SistemaCompraDataSet.tbEmpresa);
            // TODO: esta línea de código carga datos en la tabla 'SistemaCompraDataSet.QUERYProductosPorCantidadDeVentas' Puede moverla o quitarla según sea necesario.
            this.QUERYProductosPorCantidadDeVentasTableAdapter.Fill(this.SistemaCompraDataSet.QUERYProductosPorCantidadDeVentas, fecha1, fecha2);

            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            DateTime d1 = monthCalendar1.SelectionStart;
            DateTime d2 = monthCalendar2.SelectionStart;
            if ((d1 < date) && (d2 < date))
            {
                fecha1 = monthCalendar1.SelectionStart;
                fecha2 = monthCalendar2.SelectionStart;
                // TODO: esta línea de código carga datos en la tabla 'SistemaCompraDataSet.tbEmpresa' Puede moverla o quitarla según sea necesario.
                this.tbEmpresaTableAdapter.Fill(this.SistemaCompraDataSet.tbEmpresa);
                // TODO: esta línea de código carga datos en la tabla 'SistemaCompraDataSet.QUERYProductosPorCantidadDeVentas' Puede moverla o quitarla según sea necesario.
                this.QUERYProductosPorCantidadDeVentasTableAdapter.Fill(this.SistemaCompraDataSet.QUERYProductosPorCantidadDeVentas, fecha1, fecha2);

                this.reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Seleccione una fecha inferior a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
