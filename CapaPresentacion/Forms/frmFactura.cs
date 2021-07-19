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
using CapaPresentacion.FormsMostracion;

namespace CapaPresentacion.Forms
{
    public partial class frmFactura : Form
    {
        csNegocioFactura NFactura = new csNegocioFactura();
        NegocioProductos NProducto = new NegocioProductos();

        ICollection<tbControlDinero> IcollControlDinero;

        List<tbProducto> listaProducto;
        public frmFactura()
        {
            InitializeComponent();
            cargarTxts();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        //Aplicamos los colores del tema actual
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Gainsboro;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            labeltitulo1.ForeColor = ThemeColor.SecondaryColor;
        }

        private void cargarTxts()
        {
            cbTipoFactura.DataSource = Enum.GetValues(typeof(csEnums.Tipo));
        }

        private void btnVerProveedores_Click(object sender, EventArgs e)
        {
            frmVerProveedores frmProveedor = new frmVerProveedores();

            frmProveedor.Show();
            frmProveedor.refreData();

            frmProveedor.pasaProveedor += FrmProveedor_pasaProveedor;
            LabelPara.Text = Enum.GetName(typeof(csEnums.FacturaPara), 2);
        }

        private void FrmProveedor_pasaProveedor(tbProveedor InfProveedor)
        {
            labelIdAsociado.Text = InfProveedor.Id.Trim();
            labelIdFactura.Text = labelIdAsociado.Text + dateTimeFactura.Value.ToString().Trim();
        }

        private void btnVerCliente_Click(object sender, EventArgs e)
        {

        }

        private void buttonconsultar_Click_1(object sender, EventArgs e)
        {
            refreData();
        }

        private void refreData()
        {
            dataGridViewProductos.Rows.Clear();
            dataGridViewProductos.Refresh();

            listaProducto = NProducto.obtenerLista(1);
            cargarDatos(listaProducto);
        }

        private void cargarDatos(List<tbProducto> listaProducto)
        {
            foreach (tbProducto p in listaProducto)
            {
                int nr = dataGridViewProductos.Rows.Add();
                dataGridViewProductos.Rows[nr].Cells[0].Value = p.Codigo;
                dataGridViewProductos.Rows[nr].Cells[1].Value = p.tbObjeto.Nombre;
                dataGridViewProductos.Rows[nr].Cells[2].Value = p.PrecioVenta;
                dataGridViewProductos.Rows[nr].Cells[3].Value = p.Cantidad;
                dataGridViewProductos.Rows[nr].Cells[4].Value = p.Medida;
            }
        }

        private void dataGVDetalleFactura_MouseClick(object sender, MouseEventArgs e)
        {
            //al darle click a un dato del dataGV se creara un menu de opciones
            ContextMenuStrip menu = new ContextMenuStrip();
            int posicion = dataGVDetalleFactura.HitTest(e.X, e.Y).RowIndex;

            if (posicion >= 0)//si la posicion es correcta se ingresa los items
            {
                menu.Items.Add("Eliminar lista").Name = "EliLis";
                menu.Items.Add("Editar cellda").Name = "EliCell";
            }

            menu.Show(dataGVDetalleFactura, new Point(e.X, e.Y));
            menu.ItemClicked += Menu_ItemClicked;//la opcion seleccionada por el usuario es enviada para ser evaludada
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())//deacuerdo al la opcion de ejecuta la accion
            {
                case "EliLis":
                    dataGVDetalleFactura.Rows.RemoveAt(dataGVDetalleFactura.CurrentRow.Index);
                    sumarSub();
                    break;
                case "EliCell":
                     dataGVDetalleFactura.CurrentCell.Value = "";
                   
                    break;

                default:
                    break;
            }
        }


        private void dataGridViewProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //saber que proveedor selecciono el cliente 
                int n = e.RowIndex;// index seleccionado 
                if (n != -1)
                {
                    string Codigo = dataGridViewProductos.Rows[n].Cells[0].Value.ToString();//sacamos el codigo se la seleccion

                    tbProducto seleProducto;//creamos un objeto para poder almacenar el producto

                    seleProducto = listaProducto.Where(x => x.Codigo.Trim() == Codigo.Trim()).SingleOrDefault();
                    pasarDatos(seleProducto);//enviamos el producto
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Erro " + E.Message + " te recomendamos seleccionar una casilla que contenga datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void pasarDatos(tbProducto seleProducto)
        {
            int nr = dataGVDetalleFactura.Rows.Add();
            dataGVDetalleFactura.Rows[nr].Cells[0].Value = seleProducto.tbObjeto.Nombre;
            dataGVDetalleFactura.Rows[nr].Cells[1].Value = seleProducto.PrecioVenta;
            dataGVDetalleFactura.Rows[nr].Cells[2].Value = 5;
            dataGVDetalleFactura.Rows[nr].Cells[3].Value = "0%";
            dataGVDetalleFactura.Rows[nr].Cells[4].Value = (seleProducto.PrecioVenta * 5);

            sumarSub();
        }

        private void sumarSub()
        {
            decimal Total = 0;

            foreach(DataGridViewRow row in dataGVDetalleFactura.Rows)
            {
                Total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
            }
            labelTotalFactura.Text = Total.ToString();
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {


        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                tbFactura factura = new tbFactura();
                tbControlDinero ControlDiner = new tbControlDinero();
                string detalleFactura = "";
                foreach (DataGridViewRow row in dataGVDetalleFactura.Rows)
                {
                    if (dataGVDetalleFactura.Rows.Count == 3)
                    {
                        detalleFactura += row.Cells[0].Value.ToString() + "}";
                        detalleFactura += row.Cells[1].Value.ToString() + "}";
                        detalleFactura += row.Cells[2].Value.ToString() + "}";
                        detalleFactura += row.Cells[3].Value.ToString() + "}";
                        detalleFactura += row.Cells[4].Value.ToString() + "}";
                    }
                }
                MessageBox.Show(detalleFactura);
                factura.Productos = detalleFactura.Trim();
                factura.IdFactura = labelIdFactura.Text.Trim();
                factura.Tipo = cbTipoFactura.SelectedIndex + 1;
                factura.FechaCompra = dateTimeFactura.Value;
                factura.Total = decimal.Parse(labelTotalFactura.Text.Trim());
                factura.Estado = true;
               
                if (LabelPara.Text == Enum.GetName(typeof(csEnums.FacturaPara), 2))
                {
                    tbProveedor proveedor = new tbProveedor();

                    proveedor.Id = labelIdAsociado.Text.Trim();
                    factura.IdProveedor = proveedor.Id.Trim();
                    factura.TipoAsocie = (int)csEnums.FacturaPara.P;
                }
                if (LabelPara.Text == Enum.GetName(typeof(csEnums.FacturaPara), 1))
                {
                    tbCliente cliente = new tbCliente();
                    cliente.Id = labelIdAsociado.Text.Trim();
                    factura.IdCliente = cliente.Id.Trim();
                    factura.TipoAsocie = (int)csEnums.FacturaPara.C;
                }

                ControlDiner.Id = "123456";
                ControlDiner.Factura = factura.IdFactura.Trim();
                ControlDiner.Fecha = factura.FechaCompra;
                ControlDiner.Monto = factura.Total;
                ControlDiner.Tipo = factura.Tipo;

                factura.tbControlDinero.Add(ControlDiner);

                if (NFactura.guarda(factura))
                {
                    MessageBox.Show("Se ingreseo la factura ", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se podo guardar la factura ", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("No se podo guardar la factura ", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarDatos()
        {
            if (labelIdFactura.Text == "?" && labelIdFactura.Text.Length >= 3)
            {
                MessageBox.Show("Ingrese un provedor para generar el codigo de la factura", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelIdFactura.Focus();
                return false;
            }
            if(labelIdAsociado.Text == "?" && labelIdAsociado.Text.Length >= 3)
            {
                MessageBox.Show("Ingresa una cedula para quien va la factura", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelIdAsociado.Focus();
                return false;
            }
            if(dataGridViewProductos.RowCount <= 1)
            {
                MessageBox.Show("Ingrese datos a la factura ", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelIdAsociado.Focus();
                return false;
            }
            if (dataGridViewProductos.RowCount >= 1)
            {
                int errores = 0, i =0;
                string precio, cantida, subtotal, messa = "Ingresa";
                foreach (DataGridViewRow row in dataGVDetalleFactura.Rows)
                {
                    if(dataGVDetalleFactura.Rows.Count == 3)
                    {
                        precio = row.Cells[1].Value.ToString();
                        cantida = row.Cells[2].Value.ToString();
                        subtotal = row.Cells[4].Value.ToString();
                        if (precio == string.Empty)
                        {
                            messa += " Precio en la posición " + i.ToString();
                            errores++;
                        }
                        if (cantida == string.Empty)
                        {
                            messa += " cantidad en la posición " + i.ToString();
                            errores++;
                        }
                        if (subtotal == string.Empty)
                        {
                            messa += "subtotal Precio en la posición " + i.ToString();
                            errores++;
                        }
                        i++;
                    }
                }
                if (errores > 0)
                {
                    MessageBox.Show(messa, " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
    }
}
