using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CapaEntidades;
using CapaNegocios;
using CapaUtilidades;

namespace CapaPresentacion.Forms
{
    public partial class frmControlDinero : Form
    {
        csNegocioFactura NFactura = new csNegocioFactura();
        NegocioProductos NProducto = new NegocioProductos();
        csNegocioControlDinero NControlDinero = new csNegocioControlDinero();


        List<tbFactura> listaFactura;
        List<tbProducto> listaProductos;
        List<tbControlDinero> listaControlDinero;

        public frmControlDinero()
        {
            InitializeComponent();
            cargarGrafico();
            cargarDate();
        }

        private void cargarDate()
        {
            labelDate.Text = "";
            labelHora.Text = "";
            DateTime date = DateTime.Now;

            labelDate.Text = date.Date.ToString();
            labelDate.Text = date.ToLocalTime().ToString();

            cbTipo.DataSource = Enum.GetValues(typeof(csEnums.Tipo));
        }

        private void cargarGrafico()
        {
            chartVentas.Series.Clear();
            chartVentas.Titles.Clear();
            DateTime mes = DateTime.Now;
            //pedimos la lista esta vendra solo del año y el mes actual
            listaFactura = NFactura.obtenerLista(mes.Month);
            //ordenamos la lista 
            var listaFacturaOrdenada = listaFactura.OrderBy(x => x.FechaCompra);

            Series serie = new Series();
            chartVentas.Palette = ChartColorPalette.Pastel;
            chartVentas.Titles.Add("Ventas del mes actual");
            int i = 0;
           foreach(tbFactura p in listaFacturaOrdenada)
           {
                if((p.FechaCompra.Month == mes.Month) && (p.FechaCompra.Year == mes.Year) &&(p.Tipo == 1))//filtro para sacar ventas actuales
                {
                    serie = chartVentas.Series.Add(p.FechaCompra.ToString());
                    
                    serie.Label = "Dia:"+ p.FechaCompra.Day.ToString();

                    serie.Points.Add((double)p.Total, p.FechaCompra.Day);
                }
            }
            graficoControlDinero();
        }



        private void graficoControlDinero()
        {
            
            chartControlDinero.Titles.Clear();

            DateTime date = DateTime.Now;
            listaControlDinero = NControlDinero.obtenerLista(date.Month);
            var listaOrdenadaControlGasto = listaControlDinero.OrderBy(x => x.Fecha);

            chartControlDinero.Titles.Add("Ingresos y engresos " + date.Month + "-" + date.Year);
            decimal montoMas = 0, montoMenos =0;
            int i=0;
            foreach(tbControlDinero cd in listaOrdenadaControlGasto)
            {
                
                if (cd.Tipo == 1)
                {
                    montoMas = (decimal)cd.Monto;
                    chartControlDinero.Series["Ingreso"].Points.AddXY(cd.Fecha.Day, montoMas += montoMas);
                }
                if(cd.Tipo == 2)
                {
                    montoMenos = ((decimal)cd.Monto);
                    chartControlDinero.Series["Gastos"].Points.AddXY(cd.Fecha.Day, montoMenos += montoMenos);
                }
            }
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                DateTime dt = DateTime.Now;
                tbControlDinero controlDinero = new tbControlDinero();

                controlDinero.Fecha = dt.Date;
                controlDinero.Id = labelDate.Text + "/" + labelHora.Text;
                controlDinero.Tipo = cbTipo.SelectedIndex - 1;
                controlDinero.Monto = decimal.Parse(txtMonto.Text);
                controlDinero.DetalleExtra = txtDescripcion.Text.Trim();
                controlDinero.Estado = true;

                if (NControlDinero.guarda(controlDinero))
                {
                    MessageBox.Show("Se ingreso un monto", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrio un erro al ingresar el monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validarDatos()
        {
            if(txtMonto.Text == string.Empty)
            {
                MessageBox.Show("Ingresa un monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonto.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
           if(txtMonto.Text.Length > 1)
            {
                if(txtDescripcion.Text == string.Empty)
                {
                    DateTime dt = DateTime.Now;
                    txtDescripcion.Text = ("Se realizo el día " + dt.Day + "/" + dt.Month + "/" + dt.Year);
                }
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puedes ingresar precios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
    }
}
