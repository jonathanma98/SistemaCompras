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
using CapaUtilidades;

namespace CapaPresentacion.FormsMostracion
{
    public partial class frmMostrarVentaProveedor : Form
    {
        NegocioProductos NProducto = new NegocioProductos();
        csNegocioObjetoProveedor NObjProvee = new csNegocioObjetoProveedor();
        NegocioProveedor NProveedor = new NegocioProveedor();

        tbProducto Producto = new tbProducto();
        tbProveedor proveedor = new tbProveedor();

        List<tbProductoProveedor> listaPP;
        List<tbProducto> listaProducto;
        public frmMostrarVentaProveedor()
        {
            InitializeComponent();
        }

        public void resiveDatos(string id)
        {

            int cantidadProductos = 0;
            proveedor.Id = id;
            listaPP = NObjProvee.obtenerLista(1);
            listaProducto = NProducto.obtenerLista(1);
            proveedor = NProveedor.consultarPorId(proveedor);

            if (listaPP != null)
            {

                foreach (tbProductoProveedor p in listaPP)
                {
                    if (p.idProveedor.Trim() == proveedor.Id.Trim())
                    {
                        cantidadProductos++;
                        Producto = (from c in listaProducto
                                    where c.tbObjeto.Proveedor == p.idProveedor
                                    select c).FirstOrDefault();

                        int nr = dataGridView.Rows.Add();
                        dataGridView.Rows[nr].Cells[0].Value = Producto.Codigo;
                        dataGridView.Rows[nr].Cells[1].Value = Producto.tbObjeto.Nombre;
                        dataGridView.Rows[nr].Cells[2].Value = Producto.Descripcion;
                    }
                }

                labelID.Text += " " + id;
                labelTitulo.Text += " " + proveedor.tbPersona.Nombre;
                labelNombre.Text += " " + proveedor.Descripcion;
                labelProductos.Text += " " + cantidadProductos.ToString();
            }
            else
            {
                MessageBox.Show("No existe relacion con proveedor", " Productos por Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
