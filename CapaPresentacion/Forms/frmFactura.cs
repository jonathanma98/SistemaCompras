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
        csNegociosDetalleFactura NDetalleFactura = new csNegociosDetalleFactura();


        List<tbProducto> listaProducto;
        List<tbDetalleFactura> listaDF = new List<tbDetalleFactura>();
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
            panel2.ForeColor = ThemeColor.SecondaryColor;
        }

        private void cargarTxts()
        {    //Cagamos los datos al abrir la venta
            cbTipoFactura.DataSource = Enum.GetValues(typeof(csEnums.Tipo));
            labelIdFactura.Text = dateTimeFactura.Value.ToString().Trim();
        }
        //------------------------Mandamos apedir datos para ingresar la inf a la factura
        private void btnVerProveedores_Click(object sender, EventArgs e)//Buscamos Proveedor
        { 
            frmVerProveedores frmProveedor = new frmVerProveedores();
            frmProveedor.Show();
            frmProveedor.refreData();

            frmProveedor.pasaProveedor += FrmProveedor_pasaProveedor;
            
        }

        private void FrmProveedor_pasaProveedor(tbProveedor InfProveedor)
        {  //Resivimos los dos atraves de un delegado
            LabelPara.Text = Enum.GetName(typeof(csEnums.FacturaPara), 2);
            labelIdAsociado.Text = InfProveedor.Id.Trim();
            labelANombreDe.Text = InfProveedor.tbPersona.Nombre.Trim();
            labelIdFactura.Text = labelIdAsociado.Text + dateTimeFactura.Value.ToString().Trim();
        }

        private void btnVerCliente_Click(object sender, EventArgs e)//Buscamos un cliente
        {
            frmBuscarCliente frmCliene = new frmBuscarCliente();
            frmCliene.Show();
            frmCliene.refreData();

            frmCliene.pasaCliene += FrmCliene_pasaCliene;
        }

        private void FrmCliene_pasaCliene(tbCliente InfCliente)
        { //resivimos los datos atraves de un delegado
            LabelPara.Text = Enum.GetName(typeof(csEnums.FacturaPara), 1);
            labelIdAsociado.Text = InfCliente.Id.Trim();
            labelANombreDe.Text = InfCliente.tbPersona.Nombre.Trim();
            labelIdFactura.Text = labelIdAsociado.Text + dateTimeFactura.Value.ToString().Trim();
        }
        //en caso de que la factura valla para alguien no ingresado
        private void btnManual_Click(object sender, EventArgs e)
        {
            TextBox txto = new TextBox();
            DialogResult op = MessageBox.Show("Desea llenar los datos de la factura", "Ingresar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(op == DialogResult.Yes)
            {
                string Cedula;
                string NombreFactura = Microsoft.VisualBasic.Interaction.InputBox("Nombre para quien va la factura", "Datos factura");
                labelANombreDe.Text = NombreFactura.Trim();
                do
                {
                    Cedula = Microsoft.VisualBasic.Interaction.InputBox("Cedula para quien va la factura", "Datos factura");
                }
                while (Cedula.Length >= 4 && Cedula.Length <= 7);
                labelIdAsociado.Text = Cedula.Trim();
                labelIdFactura.Text = labelIdAsociado.Text + dateTimeFactura.Value.ToString().Trim();
            }
            if(op == DialogResult.No)
            {

            }
        }

        private void buttonconsultar_Click_1(object sender, EventArgs e)
        {
            refreData();
        }

        private void refreData()
        {
            
            listaProducto = NProducto.obtenerLista(1);
            cargarDatos(listaProducto);
        }


        private void cargarDatos(List<tbProducto> listaProducto)
        {
            dataGridViewProductos.Rows.Clear();
            dataGridViewProductos.Refresh();
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

        private void btnBuscaProducto_Click(object sender, EventArgs e)
        {   //Buscador de productos
            if(dataGridViewProductos.Rows.Count >= 1)
            {
                IEnumerable<tbProducto> listaAux = new List<tbProducto>();

                if (txtBusProducto.Text != string.Empty)
                {
                    listaAux = listaProducto.Where(x => x.tbObjeto.Nombre.Trim().ToUpper().Contains(txtBusProducto.Text.Trim().ToUpper())).ToList();
                }
                if (listaAux.Count() == 0 && txtBusProducto.Text == string.Empty)
                {
                    listaAux = listaProducto;
                }
                cargarDatos((List<tbProducto>)listaAux);
            }
            else
            {
                refreData();
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
                    SacarTotal();
                    break;
                case "EliCell":
                     dataGVDetalleFactura.CurrentCell.Value = "";
                   
                    break;

                default:
                    break;
            }
        }


        private void dataGridViewProductos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //saber que producto selecciono 
                int n = e.RowIndex;// index seleccionado 
                if (n != -1)
                {
                    string Codigo = dataGridViewProductos.Rows[n].Cells[0].Value.ToString();//sacamos el id se la seleccion

                    tbProducto seleProducto;//creamos un objeto para poder almacenar el prducto

                    seleProducto = listaProducto.Where(x => x.Codigo.Trim() == Codigo.Trim()).SingleOrDefault();

                    if (!sabersiProductoEstaIngresadoParaAumentarcantidad(seleProducto))
                    {
                        pasarDatos(seleProducto);//enviamos el producto
                    }
                    else
                    {
                        SacarTotal();
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Erro " + E.Message + " te recomendamos seleccionar una casilla que contenga datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        

        private bool sabersiProductoEstaIngresadoParaAumentarcantidad(tbProducto seleProducto)
        {
            bool comparar = false;
            foreach (DataGridViewRow row in dataGVDetalleFactura.Rows)
            {
                if (row.Cells["Id"].Value != null)
                {
                    comparar = seleProducto.Codigo.Trim() == row.Cells["Id"].Value.ToString().Trim();
                    if (comparar)
                    {
                        decimal cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                        cantidad += 1;
                        row.Cells["Cantidad"].Value = cantidad;
                        row.Cells[5].Value = (cantidad * seleProducto.PrecioVenta);
                        return comparar;
                    }
                }
            }
            return false;

        }


        private void pasarDatos(tbProducto seleProducto)
        {
            int nr = dataGVDetalleFactura.Rows.Add();
            dataGVDetalleFactura.Rows[nr].Cells[0].Value = seleProducto.Codigo;
            dataGVDetalleFactura.Rows[nr].Cells[1].Value = seleProducto.tbObjeto.Nombre;
            dataGVDetalleFactura.Rows[nr].Cells[2].Value = seleProducto.PrecioVenta;
            dataGVDetalleFactura.Rows[nr].Cells[3].Value = 1;
            int cantida = (int)dataGVDetalleFactura.Rows[nr].Cells[3].Value;
            dataGVDetalleFactura.Rows[nr].Cells[4].Value = 0;
            dataGVDetalleFactura.Rows[nr].Cells[5].Value = (seleProducto.PrecioVenta * cantida);

            SacarTotal();
        }

        private void SacarTotal()
        {
            decimal Total = 0;

            foreach (DataGridViewRow row in dataGVDetalleFactura.Rows)
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
                
                factura.IdFactura = LabelPara.Text.Trim() + labelIdFactura.Text.Trim();
                factura.NombreAsocie = labelANombreDe.Text.Trim();
                factura.Tipo = cbTipoFactura.SelectedIndex + 1;
                factura.FechaCompra = dateTimeFactura.Value;
                factura.Total = decimal.Parse(labelTotalFactura.Text.Trim());
                factura.NombreAsocie = labelANombreDe.Text.Trim();
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

                ControlDiner.Id = dateTimeFactura.Value.ToString();
                ControlDiner.Factura = factura.IdFactura.Trim();/*Se debe verificar*/
                ControlDiner.Fecha = factura.FechaCompra;
                ControlDiner.Monto = factura.Total;
                ControlDiner.Tipo = factura.Tipo;

                factura.tbControlDinero.Add(ControlDiner);

                
                List<tbDetalleFactura> listaDetalleFactura = new List<tbDetalleFactura>();
                int i=0;
                foreach (DataGridViewRow row in dataGVDetalleFactura.Rows)
                {

                    if (row.Cells[0].Value != null)
                    {
                        tbDetalleFactura detalleFactura = new tbDetalleFactura();
                        detalleFactura.IdFactura += factura.IdFactura;
                        detalleFactura.IdProductos = row.Cells[0].Value.ToString();
                        row.Cells[1].Value.ToString();
                        detalleFactura.Precio = (decimal)row.Cells[2].Value;
                        detalleFactura.Cantiadad = int.Parse(row.Cells[3].Value.ToString().Trim());
                        detalleFactura.IVA = decimal.Parse(row.Cells[4].Value.ToString().Trim());
                        detalleFactura.Subtotal = (decimal)row.Cells[5].Value;
                        detalleFactura.Descuento = 0;

                        listaDF.Insert(i,detalleFactura);
                        listaDetalleFactura.Add(listaDF[i]);
                        i++;
                    }
                }
                
                if (NFactura.GuardarFacura(factura, listaDF))
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
                string messa = "Ingresa";
                foreach (DataGridViewRow row in dataGVDetalleFactura.Rows)
                {
                    if(row.Cells[0].Value != null)
                    {
                        
                        if (row.Cells[1].Value == null)
                        {
                            messa += " Precio en la posición " + i.ToString();
                            errores++;
                        }
                        if (row.Cells[2].Value == null)
                        {
                            messa += " cantidad en la posición " + i.ToString();
                            errores++;
                        }
                        if (row.Cells[4].Value == null)
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

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
