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
    public partial class rptVentaProveedores : Form
    {
        public rptVentaProveedores()
        {
            InitializeComponent();
        }

        private void rptVentaProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SistemaCompraDataSet.QueryTotaldeCompraAAproveedores' Puede moverla o quitarla según sea necesario.
            this.QueryTotaldeCompraAAproveedoresTableAdapter.Fill(this.SistemaCompraDataSet.QueryTotaldeCompraAAproveedores);
            // TODO: esta línea de código carga datos en la tabla 'SistemaCompraDataSet.tbEmpresa' Puede moverla o quitarla según sea necesario.
            this.tbEmpresaTableAdapter.Fill(this.SistemaCompraDataSet.tbEmpresa);

            this.reportViewer1.RefreshReport();
        }
    }
}
