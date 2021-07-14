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

        List<tbProducto> listaProducto;
        List<tbProveedor> listaProveedor;
        public frmPantallaPrincipal()
        {
            InitializeComponent();
            inializar();
        }

        private void inializar()
        {
            listaProducto = NProducto.obtenerLista(1);
            labelProductos.Text += " " + listaProducto.Count().ToString();

            listaProveedor = NProveedor.obtenerLista(1);
            labelProveedores.Text += " " + listaProveedor.Count().ToString();

           
        }
    }
}
