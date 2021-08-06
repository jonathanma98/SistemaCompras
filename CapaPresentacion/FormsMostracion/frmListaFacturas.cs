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
    public partial class frmListaFacturas : Form
    {
        csNegocioFactura NFactura = new csNegocioFactura();

        List<tbFactura> listaFacturas;


        //se declara un delegate para poder enviar la informacion a otro frm
        public delegate void pasar(tbFactura InfFactura);
        public event pasar pasarFactura; //el evento debe se publico
        public frmListaFacturas()
        {
            InitializeComponent();
            llamarListaFacura();
        }

        private void inicializar()
        {
            llamarListaFacura();
        }

        private void llamarListaFacura()
        {
            listaFacturas = NFactura.obtenerLista(1);

            cargarFacturas(listaFacturas);
        }

        private void cargarFacturas(List<tbFactura> listaFacturas)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            var listaFacturasOR = listaFacturas.OrderBy(x => x.FechaCompra);
            foreach(tbFactura f in listaFacturasOR)
            {
                int nr = dataGridView1.Rows.Add();
                dataGridView1.Rows[nr].Cells[0].Value = f.IdFactura;
                dataGridView1.Rows[nr].Cells[1].Value = f.FechaCompra;
                dataGridView1.Rows[nr].Cells[2].Value = f.NombreAsocie;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //saber que producto selecciono 
                int n = e.RowIndex;// index seleccionado 
                if (n != -1)
                {
                    string id = dataGridView1.Rows[n].Cells[0].Value.ToString();//sacamos el id se la seleccion

                    tbFactura selecFactura;//creamos un objeto para poder almacenar el prducto

                    selecFactura = listaFacturas.Where(x => x.IdFactura.Trim() == id.Trim()).SingleOrDefault();

                   pasarDatos(selecFactura);//enviamos el producto
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Erro " + E.Message + "\n te recomendamos seleccionar una casilla que contenga datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void pasarDatos(tbFactura selecFactura)
        {
            selecFactura = listaFacturas.Where(x => x.IdFactura == selecFactura.IdFactura).FirstOrDefault();

            labelID.Text = selecFactura.IdFactura;
            labelANombreDe.Text = selecFactura.NombreAsocie;
            labelfecha.Text = selecFactura.FechaCompra.ToString();
            if(selecFactura.IdCliente != null)
            {
                labelCliente.Text = selecFactura.IdCliente.Trim();
            }
            if(selecFactura.IdProveedor != null)
            {
                labelCliente.Text = selecFactura.IdProveedor.Trim();
            }
           
            labelTipo.Text = Enum.GetName(typeof(csEnums.Tipo), selecFactura.Tipo);

            dataGVDetalleFactura.Rows.Clear();
            dataGVDetalleFactura.Refresh();
            foreach(tbDetalleFactura dt in selecFactura.tbDetalleFactura)
            {
                int nr = dataGVDetalleFactura.Rows.Add();
                dataGVDetalleFactura.Rows[nr].Cells[0].Value = dt.IdFactura;
                dataGVDetalleFactura.Rows[nr].Cells[1].Value = "Producto";
                dataGVDetalleFactura.Rows[nr].Cells[2].Value = dt.Precio;
                dataGVDetalleFactura.Rows[nr].Cells[3].Value = dt.Cantiadad;
                dataGVDetalleFactura.Rows[nr].Cells[4].Value = dt.IVA;
                dataGVDetalleFactura.Rows[nr].Cells[5].Value = dt.Descuento;
                dataGVDetalleFactura.Rows[nr].Cells[6].Value = dt.Subtotal;
            }
        }

        private void btnEnviarDato_Click(object sender, EventArgs e)
        {
            string id = labelID.Text.Trim();
            tbFactura selecFactura;
            selecFactura = listaFacturas.Where(x => x.IdFactura.Trim() == id.Trim()).SingleOrDefault();
            pasarFactura(selecFactura);
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
