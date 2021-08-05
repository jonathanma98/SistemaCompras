using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion.Forms
{
    public partial class frmPantallaPrincipal : Form
    {
        NegocioProductos NProducto = new NegocioProductos();
        NegocioProveedor NProveedor = new NegocioProveedor();
        csNegocioControlDinero NControlDiner = new csNegocioControlDinero();

        List<tbProducto> listaProducto;
        List<tbProveedor> listaProveedor;
        List<tbControlDinero> listaControlDiner;
        public frmPantallaPrincipal()
        {
            InitializeComponent();
            inializar();
        }

        private void inializar()
        {
            try
            {
                listaProducto = NProducto.obtenerLista(1);
                labelProductos.Text += " " + listaProducto.Count().ToString();

                listaProveedor = NProveedor.obtenerLista(1);
                labelProveedores.Text += " " + listaProveedor.Count().ToString();
            }
            catch (Exception ex)
            {

            }

            cargaControldinero();
        }

        private void cargaControldinero()
        {
            DateTime date = DateTime.Now;//fecha actual
            double ingreso = 0, gastos = 0;
            listaControlDiner = NControlDiner.obtenerLista(1);

            foreach(tbControlDinero cd in listaControlDiner)
            {
                if((date.Year == cd.Fecha.Year) && (date.Month == cd.Fecha.Month))
                {
                    if (cd.Tipo == 1)
                    {
                        ingreso += (double)cd.Monto;
                    }
                    if (cd.Tipo == 2)
                    {
                        gastos += (double)cd.Monto;
                    }
                }
            }

            labelGastos.Text += " " + gastos.ToString();
            labelIngresos.Text += " " + ingreso.ToString();
        }
    }
}
