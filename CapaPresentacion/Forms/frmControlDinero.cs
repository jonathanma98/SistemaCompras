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

        tbFactura factura = new tbFactura();
        tbProducto producto= new tbProducto();

        List<tbFactura> listaFactura;
        List<tbProducto> listaProductos;

        public frmControlDinero()
        {
            InitializeComponent();
            cargarGrafico();
        }

        private void cargarGrafico()
        {
            chartVentas.Series.Clear();
            DateTime mes = DateTime.Today;
            //pedimos la lista esta vendra solo del año y el mes actual
            listaFactura = NFactura.obtenerLista(mes.Month);
            //ordenamos la lista para recorrela por fecha y esta seguro que evaluamos los dias 
            var listaFacturaOrdenada = listaFactura.OrderBy(x => x.FechaCompra); 

            decimal monto = 0;
            int elementos = listaFacturaOrdenada.Count();
            Series serie = new Series();

            chartVentas.Palette = ChartColorPalette.Pastel;
            chartVentas.Titles.Add("Ventas por día durante el mes " + mes.Month + "-" + mes.Year);
            tbFactura f;
            for (int i = 1; i <= 30; i++)
            {
                if(elementos >= i)
                {
                    f = listaFacturaOrdenada.ElementAt(i - 1);
                    serie = chartVentas.Series.Add("Dia " + i.ToString());
                    serie.Label = f.FechaCompra.Day.ToString();
                    if ((f.FechaCompra.Day == i) && (f.FechaCompra.Month == mes.Month) && (f.FechaCompra.Year == mes.Year))
                    {
                        int di =i-1;
                        do
                        {
                            if(di<=elementos)
                            {
                                f = listaFacturaOrdenada.ElementAt(di - 1);
                                monto += f.Total;
                            }
                            di++;
                        }
                        while ((f.FechaCompra.Day == i)&&(elementos>=di));
                    }
                    serie.Points.Add((double)monto);
                    monto = 0;
                }
            }
        }

        private void donaProducto()
        {
            chartProductos.Series.Clear();
            chartProductos.Titles.Clear();
            DateTime mes = DateTime.Today;
            //pedimos la lista de productos activo
            listaProductos = NProducto.obtenerLista(1);
            //ordenamos la lista en cantidad
            var listaProductosOrdenada = listaProductos.OrderByDescending(x => x.Cantidad);

            Series serie = new Series();

            chartProductos.Palette = ChartColorPalette.Pastel;
            chartProductos.Titles.Add("Los 5 Productos que más tienes " + mes.Month + "-" + mes.Year);
            tbProducto p;
            for (int i=0; i <= 4; i++)
            {
                p = listaProductosOrdenada.ElementAt(i);
                serie.ChartType = SeriesChartType.Pyramid;
                serie = chartProductos.Series.Add(p.tbObjeto.Codigo);
                serie.Label = p.tbObjeto.Nombre;
                serie.Points.Add((int)p.Cantidad);
            }
        }

        private void btnEstadisInventario_Click(object sender, EventArgs e)
        {
            donaProducto();
        }
    }
}
