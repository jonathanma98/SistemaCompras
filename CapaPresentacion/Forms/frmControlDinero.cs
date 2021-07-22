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

        tbFactura factura = new tbFactura();
        tbProducto producto= new tbProducto();

        List<tbFactura> listaFactura;
        List<tbProducto> listaProductos;
        List<tbControlDinero> listaControlDinero;

        public frmControlDinero()
        {
            InitializeComponent();
            cargarGrafico();
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
            donaProducto();
        }

        private void donaProducto()
        {

            chartProductos.Titles.Clear();
            DateTime mes = DateTime.Today;
            //pedimos la lista de productos activo
            listaProductos = NProducto.obtenerLista(1);
            //ordenamos la lista en cantidad
            var listaProductosOrdenada = listaProductos.OrderBy(x => x.Cantidad);
           
            chartProductos.Titles.Add("Los 5 Productos que más tienes");
            tbProducto p;
            for (int i=0; i <= 4; i++)
            {
                p = listaProductosOrdenada.ElementAt(i);
                if (i == 0)
                {
                    this.chartProductos.Series["P1"].Points.AddXY(p.Codigo, (double)p.Cantidad);
                }
                if (i == 1)
                {
                    this.chartProductos.Series["P2"].Points.AddXY(p.Codigo, (double)p.Cantidad);
                }
                if (i == 2)
                {
                    this.chartProductos.Series["P3"].Points.AddXY(p.Codigo, (double)p.Cantidad);
                }
                if (i == 3)
                {
                    this.chartProductos.Series["P4"].Points.AddXY(p.Codigo, (double)p.Cantidad);
                }
                if (i == 4)
                {
                    this.chartProductos.Series["P5"].Points.AddXY(p.Codigo, (double)p.Cantidad);
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
    }
}
