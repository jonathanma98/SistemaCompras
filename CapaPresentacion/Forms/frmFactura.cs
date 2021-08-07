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

        List<tbDetalleFactura> listaDF = new List<tbDetalleFactura>();
        List<tbProducto> listaP = new List<tbProducto>();
        List<tbProducto> listaProducto;
        public frmFactura()
        {
            InitializeComponent();
            cargarTxts();
            refreData();
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
        {
            panel2.Width = 7;
            checkCodigoP.Checked = true;
            //Cagamos los datos al abrir la venta
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
            if (dataGridViewProductos.Rows.Count >= 1)
            {
                IEnumerable<tbProducto> listaAux = new List<tbProducto>();

                if (txtBusProducto.Text != string.Empty && checkNombreP.Checked == true)
                {
                    listaAux = listaProducto.Where(x => x.tbObjeto.Nombre.Trim().ToUpper().Contains(txtBusProducto.Text.Trim().ToUpper())).ToList();
                }
                else if (txtBusProducto.Text != string.Empty && checkCodigoP.Checked == true)
                {
                    listaAux = listaProducto.Where(x => x.tbObjeto.Codigo.Trim().ToUpper().Contains(txtBusProducto.Text.Trim().ToUpper())).ToList();
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
                    SacarSubTotal();
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
                        SacarSubTotal();
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Erro " + E.Message + " te recomendamos seleccionar una casilla que contenga datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
        //se produce cuando se ingresa un dato repetido

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
            int imp = (int)dataGVDetalleFactura.Rows[nr].Cells[4].Value;//samos el total 
            dataGVDetalleFactura.Rows[nr].Cells[5].Value = 0;
            dataGVDetalleFactura.Rows[nr].Cells[6].Value = (((seleProducto.PrecioVenta + (seleProducto.PrecioVenta * imp) /100)) * cantida);

            SacarSubTotal();
        }

        private void SacarSubTotal()
        {
            foreach (DataGridViewRow row in dataGVDetalleFactura.Rows)
            {
                if (row.Cells["Id"].Value != null)
                {
                    int cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString());
                    decimal precio = (decimal)row.Cells[2].Value;
                    decimal imp = decimal.Parse(row.Cells[4].Value.ToString().Trim());
                    decimal desc = decimal.Parse(row.Cells[5].Value.ToString().Trim());

                    decimal valorImpu = (precio * Convert.ToInt32(imp) / 1000);

                    row.Cells[6].Value = ( ((precio + valorImpu) - Convert.ToInt32(desc)) * cantidad);
                }
            }
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


        private void dataGVDetalleFactura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SacarSubTotal();
        }


        private void buttonguardar_Click(object sender, EventArgs e)
        {

            if (validarDatos())
            {
                tbFactura factura = new tbFactura();
                tbControlDinero ControlDiner = new tbControlDinero();

                factura.IdFactura = LabelPara.Text.Trim() + labelIdFactura.Text.Trim();
                factura.NombreAsocie = labelANombreDe.Text.Trim();
                factura.Tipo = (cbTipoFactura.SelectedIndex + 1);//El indice empieza en 0 entoces se suma 1 (1=venta, 2=compra)
                factura.FechaCompra = dateTimeFactura.Value;
                factura.Total = decimal.Parse(labelTotalFactura.Text.Trim());
                factura.NombreAsocie = labelANombreDe.Text.Trim();
                factura.Estado = true;
                // la llave de tipo cliente o proveedor se saca por la eleccion del usuario
                if (LabelPara.Text == Enum.GetName(typeof(csEnums.FacturaPara), 1))//tipo cliente
                {
                    tbCliente cliente = new tbCliente();

                    cliente.Id = labelIdAsociado.Text.Trim();
                    factura.IdCliente = cliente.Id.Trim();
                    factura.TipoAsocie = (int)csEnums.FacturaPara.C;
                }
                if (LabelPara.Text == Enum.GetName(typeof(csEnums.FacturaPara), 2))//tipo proveedor
                {
                    tbProveedor proveedor = new tbProveedor();

                    proveedor.Id = labelIdAsociado.Text.Trim();
                    factura.IdProveedor = proveedor.Id.Trim();
                    factura.TipoAsocie = (int)csEnums.FacturaPara.P;
                }
                //control dinero debe registrar el todal de dicha factura
                ControlDiner.Id = dateTimeFactura.Value.ToString();
                ControlDiner.Factura = factura.IdFactura.Trim();/*Se debe verificar*/
                ControlDiner.Fecha = factura.FechaCompra;
                ControlDiner.Monto = factura.Total;
                ControlDiner.Tipo = factura.Tipo;
                ControlDiner.DetalleExtra = "Se realizado atravez de una factura. ";
                ControlDiner.Estado = true;

                factura.tbControlDinero.Add(ControlDiner);

                //Antes de llenar la lista se limpiar porque puede quedar rastros de una factura anterior 
                listaP.Clear();
                listaDF.Clear();
                int i = 0;
                foreach (DataGridViewRow row in dataGVDetalleFactura.Rows)//recorremos el data grid para detectar los prodcutos a vender
                {

                    if (row.Cells[0].Value != null)
                    {
                        tbDetalleFactura detalleFactura = new tbDetalleFactura();
                        tbProducto producto = new tbProducto();
                        detalleFactura.IdFactura = factura.IdFactura;
                        detalleFactura.IdProductos = row.Cells[0].Value.ToString();
                        row.Cells[1].Value.ToString();
                        detalleFactura.Precio = (decimal)row.Cells[2].Value;
                        detalleFactura.Cantiadad = int.Parse(row.Cells[3].Value.ToString().Trim());
                        detalleFactura.IVA = decimal.Parse(row.Cells[4].Value.ToString().Trim());
                        detalleFactura.Descuento = decimal.Parse(row.Cells[5].Value.ToString().Trim());
                        detalleFactura.Subtotal = (decimal)row.Cells[6].Value;

                        producto.Codigo = detalleFactura.IdProductos;
                        producto = NProducto.consultarPorId(producto);//Optenemos el producto correpondiendte a su id para modifica
                        //si es un tipo = 1 (quiere decir se vende por ello se rebaja la cantidad en el inventario)
                        if ((producto.Cantidad > detalleFactura.Cantiadad) && (factura.Tipo == 1))
                        {
                            producto.Cantidad -= detalleFactura.Cantiadad;
                        }
                        else if ((factura.Tipo == 1) && (producto.Cantidad < detalleFactura.Cantiadad))//para no tener cantidad -1
                        {
                            producto.Cantidad = 0;
                        }
                        else if (factura.Tipo == 2)// tipo 2 es una compra por ello el producto aumenta su cantidad
                        {
                            producto.Cantidad += detalleFactura.Cantiadad;
                        }
                        listaP.Insert(i, producto);
                        listaDF.Insert(i, detalleFactura);
                        i++;
                    }
                }

                if (NFactura.GuardarFacura(factura, listaDF, listaP))
                {

                    MessageBox.Show("Se ingreseo la factura ", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaDF.Clear();
                    listaP.Clear();
                    limpiar();
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

        private void limpiar()
        {
            dataGVDetalleFactura.Rows.Clear();
            dateTimeFactura.Value = DateTime.Now;
            labelANombreDe.Text = "?";
            labelIdAsociado.Text = "?";
            labelIdFactura.Text = "?";
            LabelPara.Text = "?";

            Refresh();
            buttonguardar.Refresh();
            dateTimeFactura.Refresh();
            labelANombreDe.Refresh();
            labelIdAsociado.Refresh();
            labelIdFactura.Refresh();
            LabelPara.Refresh();
            refreData();
            btnEliminar.Enabled = false;
            dateTimeFactura.Enabled = true;
            buttonguardar.Enabled = true;
            btnVerCliente.Enabled = true;
            btnVerProveedores.Enabled = true;
            btnManual.Enabled = true;
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

        private void frmFactura_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnVerListaFacuta_Click(object sender, EventArgs e)
        {
            frmListaFacturas lisFac = new frmListaFacturas();
            lisFac.Show();
            btnModificar.CausesValidation = true;
            lisFac.pasarFactura += LisFac_pasarFactura;
        }

        private void LisFac_pasarFactura(tbFactura InfFactura)
        {
            string idF = InfFactura.IdFactura.Trim();
            int caracteres = idF.Length;
            labelIdFactura.Text = idF.Remove(0, 1);
            labelANombreDe.Text = InfFactura.NombreAsocie;
            dateTimeFactura.Value = InfFactura.FechaCompra;
            cbTipoFactura.SelectedIndex = InfFactura.Tipo-1;

            if (InfFactura.IdCliente != null)
            {
                LabelPara.Text = Enum.GetName(typeof(csEnums.FacturaPara), 1);
                labelIdAsociado.Text = InfFactura.IdCliente.Trim();
            }
            if(InfFactura.IdProveedor != null)
            {
                LabelPara.Text = Enum.GetName(typeof(csEnums.FacturaPara), 2);
                labelIdAsociado.Text = InfFactura.IdProveedor.Trim();
            }
            dataGVDetalleFactura.Rows.Clear();
            dataGVDetalleFactura.Refresh();
            foreach(tbDetalleFactura df in InfFactura.tbDetalleFactura)
            {
                int nr = dataGVDetalleFactura.Rows.Add();
                dataGVDetalleFactura.Rows[nr].Cells[0].Value = df.IdProductos.Trim();
                dataGVDetalleFactura.Rows[nr].Cells[1].Value = "p ";
                dataGVDetalleFactura.Rows[nr].Cells[2].Value = df.Precio;
                dataGVDetalleFactura.Rows[nr].Cells[3].Value = df.Cantiadad;
                dataGVDetalleFactura.Rows[nr].Cells[4].Value = df.IVA;
                dataGVDetalleFactura.Rows[nr].Cells[5].Value = df.Descuento;
            }
            SacarSubTotal();
            btnEliminar.Enabled = true;
            dateTimeFactura.Enabled = false;
            buttonguardar.Enabled = false;
            btnVerCliente.Enabled = false;
            btnVerProveedores.Enabled = false;
            btnManual.Enabled = false;
            timer2.Start();
        }

        private void btnMostraPanel2_Click(object sender, EventArgs e)
        {
            if (panel2.Width < 8)
            {
                timer1.Start();
            }
            else
            {
                timer2.Start();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel2.Width < 405)
            {
                panel2.Width += 15;
            }
            else
            {
                panel2.BackColor = Color.Fuchsia;
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel2.Width > 10)
            {
                panel2.Width -= 15;
            }
            else
            {
                panel2.Width = 7;
                panel2.BackColor = Color.Transparent;
                timer2.Stop();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                tbFactura factura = new tbFactura();
                tbControlDinero ControlDiner = new tbControlDinero();

                factura.IdFactura = LabelPara.Text.Trim() + labelIdFactura.Text.Trim();
                factura.NombreAsocie = labelANombreDe.Text.Trim();
                factura.Tipo = (cbTipoFactura.SelectedIndex + 1);//El indice empieza en 0 entoces se suma 1 (1=venta, 2=compra)
                factura.FechaCompra = dateTimeFactura.Value;
                factura.Total = decimal.Parse(labelTotalFactura.Text.Trim());
                factura.NombreAsocie = labelANombreDe.Text.Trim();
                factura.Estado = true;
                // la llave de tipo cliente o proveedor se saca por la eleccion del usuario
                if (LabelPara.Text == Enum.GetName(typeof(csEnums.FacturaPara), 1))//tipo cliente
                {
                    tbCliente cliente = new tbCliente();

                    cliente.Id = labelIdAsociado.Text.Trim();
                    factura.IdCliente = cliente.Id.Trim();
                    factura.TipoAsocie = (int)csEnums.FacturaPara.C;
                }
                if (LabelPara.Text == Enum.GetName(typeof(csEnums.FacturaPara), 2))//tipo proveedor
                {
                    tbProveedor proveedor = new tbProveedor();

                    proveedor.Id = labelIdAsociado.Text.Trim();
                    factura.IdProveedor = proveedor.Id.Trim();
                    factura.TipoAsocie = (int)csEnums.FacturaPara.P;
                }
                //control dinero debe registrar el todal de dicha factura
                ControlDiner.Id = dateTimeFactura.Value.ToString();
                ControlDiner.Factura = factura.IdFactura.Trim();/*Se debe verificar*/
                ControlDiner.Fecha = factura.FechaCompra;
                ControlDiner.Monto = factura.Total;
                ControlDiner.Tipo = factura.Tipo;
                ControlDiner.DetalleExtra = "Se realizado atravez de una factura. ";
                ControlDiner.Estado = true;

                factura.tbControlDinero.Add(ControlDiner);

                //Antes de llenar la lista se limpiar porque puede quedar rastros de una factura anterior 
                listaP.Clear();
                listaDF.Clear();
                List<tbDetalleFactura> listIdDF = new List<tbDetalleFactura>();

                listIdDF = NDetalleFactura.obtenerLista(1);
                int i = 0;
                foreach (DataGridViewRow row in dataGVDetalleFactura.Rows)//recorremos el data grid para detectar los prodcutos a vender
                {

                    if (row.Cells[0].Value != null)
                    {
                        tbDetalleFactura detalleFactura = new tbDetalleFactura();
                        tbProducto producto = new tbProducto();
                        detalleFactura.IdFactura = factura.IdFactura;
                        detalleFactura.IdProductos = row.Cells[0].Value.ToString();

                        try
                        {
                            //Sacamos la ide dal detallefactura para que puede ser localizado en la bd
                            tbDetalleFactura df;
                            df = (from c in listIdDF
                                  where c.IdFactura == detalleFactura.IdFactura && c.IdProductos == detalleFactura.IdProductos
                                  select c).Single();
                            detalleFactura.Id = df.Id;
                        }
                        catch (Exception)
                        {
                            
                        }

                        row.Cells[1].Value.ToString();
                        detalleFactura.Precio = (decimal)row.Cells[2].Value;
                        detalleFactura.Cantiadad = int.Parse(row.Cells[3].Value.ToString().Trim());
                        detalleFactura.IVA = decimal.Parse(row.Cells[4].Value.ToString().Trim());
                        detalleFactura.Descuento = decimal.Parse(row.Cells[5].Value.ToString().Trim());
                        detalleFactura.Subtotal = (decimal)row.Cells[6].Value;
                        producto.Codigo = detalleFactura.IdProductos;
                        producto = NProducto.consultarPorId(producto);//Optenemos el producto correpondiendte a su id para modifica
                        //si es un tipo = 1 (quiere decir se vende por ello se rebaja la cantidad en el inventario)
                        if ((producto.Cantidad > detalleFactura.Cantiadad) && (factura.Tipo == 1))
                        {
                            producto.Cantidad -= detalleFactura.Cantiadad;
                        }
                        else if ((factura.Tipo == 1) && (producto.Cantidad < detalleFactura.Cantiadad))//para no tener cantidad -1
                        {
                            producto.Cantidad = 0;
                        }
                        else if (factura.Tipo == 2)// tipo 2 es una compra por ello el producto aumenta su cantidad
                        {
                            producto.Cantidad += detalleFactura.Cantiadad;
                        }
                        listaP.Insert(i, producto);
                        listaDF.Insert(i, detalleFactura);
                        i++;
                    }
                }

                if (NFactura.ModificarFactura(factura, listaDF, listaP))
                {

                    MessageBox.Show("Se ingreseo la factura ", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaDF.Clear();
                    listaP.Clear();
                    limpiar();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(labelIdFactura.Text != string.Empty)
            {
                tbFactura factura = new tbFactura();
                factura.IdFactura = LabelPara.Text.Trim() + labelIdFactura.Text.Trim();

                factura = NFactura.consultarPorId(factura);
                string idf = factura.IdFactura;

                DialogResult opc = MessageBox.Show("Esta segura que desea eliminar la factura con la ID: " + idf, "Opción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(opc == DialogResult.Yes)
                {
                    if (NFactura.eliminar(factura))
                    {
                        MessageBox.Show("Se elimino la factura " + idf, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se a podido eliminar la factura " + idf, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    idf = "";
                }
            }
            else
            {
                MessageBox.Show("No se indentifico la factura verifica que la factura tenga una id factua", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cbTipoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoFactura.SelectedIndex == 0)
            {
                pictureFlecha2.Visible = false;
                pictureFlecha1.Visible = true;
            }
            else
            {
                pictureFlecha1.Visible = false;
                pictureFlecha2.Visible = true;
            }
        }

        private void checkCodigoP_CheckedChanged(object sender, EventArgs e)
        {
            if(checkNombreP.Checked == true)
            {
                checkNombreP.Checked = false;
            }
        }

        private void checkNombreP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCodigoP.Checked == true)
            {
                checkCodigoP.Checked = false;
            }
        }

        private void txtBusProducto_KeyPress(object sender, KeyPressEventArgs e)
        {//evento para capturar codigos de barras
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    tbProducto seleProducto = new tbProducto();

                    if (txtBusProducto.Text != string.Empty)
                    {
                        seleProducto = listaProducto.Where(x => x.tbObjeto.Codigo.Trim().ToUpper().Contains(txtBusProducto.Text.Trim().ToUpper())).FirstOrDefault();
                        if (seleProducto == null)
                        {
                            seleProducto.Codigo = txtBusProducto.Text.Trim();
                            seleProducto = listaProducto.Where(x => x.Codigo.Trim() == seleProducto.Codigo.Trim()).SingleOrDefault();
                        }
                        pasarDatosPorKeyPress(seleProducto);
                        txtBusProducto.ResetText();
                    }
                }
            }
            catch (Exception)
            {

                txtBusProducto.ResetText();
                MessageBox.Show("Error, vuelve a intar si el error persiste comuniquese con el creador del software ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void pasarDatosPorKeyPress(tbProducto seleProducto)
        {

            if (seleProducto.Codigo != "")
            {
                if (!sabersiProductoEstaIngresadoParaAumentarcantidad(seleProducto))
                {
                    int nr = dataGVDetalleFactura.Rows.Add();
                    dataGVDetalleFactura.Rows[nr].Cells[0].Value = seleProducto.Codigo;
                    dataGVDetalleFactura.Rows[nr].Cells[1].Value = seleProducto.tbObjeto.Nombre;
                    dataGVDetalleFactura.Rows[nr].Cells[2].Value = seleProducto.PrecioVenta;
                    dataGVDetalleFactura.Rows[nr].Cells[3].Value = 1;
                    int cantida = (int)dataGVDetalleFactura.Rows[nr].Cells[3].Value;
                    dataGVDetalleFactura.Rows[nr].Cells[4].Value = 0;
                    int imp = (int)dataGVDetalleFactura.Rows[nr].Cells[4].Value;//sacamos el total 
                    dataGVDetalleFactura.Rows[nr].Cells[5].Value = 0;
                    dataGVDetalleFactura.Rows[nr].Cells[6].Value = (((seleProducto.PrecioVenta + (seleProducto.PrecioVenta * imp) / 100)) * cantida);
                }
                SacarSubTotal();

            }
            else
            {
                MessageBox.Show("No se encontro el producto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
