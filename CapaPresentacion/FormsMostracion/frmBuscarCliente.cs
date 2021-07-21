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
    public partial class frmBuscarCliente : Form
    {
        csClienteNegocio NCliente = new csClienteNegocio();
        tbCliente Cliente = new tbCliente();
        //se declara un delegate para poder enviar la informacion a otro frm
        public delegate void pasar(tbCliente InfCliente);
        public event pasar pasaCliene; //el evento debe se publico

        List<tbCliente> listaCliente;
        public frmBuscarCliente()
        {
            InitializeComponent();
        }
        public void refreData()
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            listaCliente = NCliente.obtenerLista(1);
            cargarDatos(listaCliente);
        }

        private void cargarDatos(List<tbCliente> listaCliente)
        {
            foreach (tbCliente c in listaCliente)
            {

                int nr = dataGridView.Rows.Add();
                dataGridView.Rows[nr].Cells[0].Value = c.Id;
                dataGridView.Rows[nr].Cells[1].Value = c.tbPersona.Nombre;
                dataGridView.Rows[nr].Cells[2].Value = c.tbPersona.Apellidos;
                dataGridView.Rows[nr].Cells[3].Value = c.tbPersona.Telefeno;

            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;// index seleccionado 
            if (n != -1)
            {
                string id = dataGridView.Rows[n].Cells[0].Value.ToString();//sacamos el codigo se la seleccion

                tbCliente seleCliente;//creamos un objeto para poder almacenar el producto

                seleCliente = listaCliente.Where(x => x.tbPersona.Id.Trim() == id.Trim()).SingleOrDefault();
                pasarDatos(seleCliente);//enviamos el producto
            }
        }

        private void pasarDatos(tbCliente seleCliente)
        {
            try
            {
                pasaCliene(seleCliente);

                Close();
            }
            catch(Exception E)
            {
                MessageBox.Show("Ocurrio un error se debe a que " + E.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
