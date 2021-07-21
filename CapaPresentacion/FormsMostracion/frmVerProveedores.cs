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
using CapaPresentacion.Forms;

namespace CapaPresentacion.FormsMostracion
{
    public partial class frmVerProveedores : Form
    {
        NegocioProveedor NProveedores = new NegocioProveedor();
        frmProductos frmProducto = new frmProductos();

        public delegate void pasar(tbProveedor InfProveedor);
        public event pasar pasaProveedor;

        List<tbProveedor> listaProveedores;
        public frmVerProveedores()
        {
            InitializeComponent();
        }

        public void refreData()
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();

           listaProveedores = NProveedores.obtenerLista(1);
            cargarDatos(listaProveedores);
        }

        private void cargarDatos(List<tbProveedor> listaProveedores)
        {
            foreach (tbProveedor p in listaProveedores)
            {

                int nr = dataGridView.Rows.Add();
                dataGridView.Rows[nr].Cells[0].Value = p.tbPersona.Id;
                dataGridView.Rows[nr].Cells[1].Value = p.tbPersona.Nombre;
                dataGridView.Rows[nr].Cells[2].Value = p.Descripcion;
                dataGridView.Rows[nr].Cells[3].Value = p.tbPersona.Telefeno;

            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;// index seleccionado 
            if (n != -1)
            {
                string id = dataGridView.Rows[n].Cells[0].Value.ToString();//sacamos el codigo se la seleccion

                tbProveedor seleProveedor;//creamos un objeto para poder almacenar el producto

                seleProveedor = listaProveedores.Where(x => x.tbPersona.Id.Trim() == id.Trim()).SingleOrDefault();
                pasarDatos(seleProveedor);//enviamos el producto
            }
        }

        public void pasarDatos(tbProveedor seleProveedor)
        {
            pasaProveedor(seleProveedor);

            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelImage_Click(object sender, EventArgs e)
        {

        }
    }
}
