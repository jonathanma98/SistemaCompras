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
    public partial class frmProductos : Form
    {

        NegocioProductos NProducto = new NegocioProductos();
        csNegocioObjetoProveedor NObjProveedor = new csNegocioObjetoProveedor();
        NegocioProveedor NProveedor = new NegocioProveedor();

        List<tbProducto> listaProducto;
        List<tbProveedor> LP;
        List<tbProductoProveedor> listaPP;
        public frmProductos()
        {
            InitializeComponent();
            Inializar();
        }

        private void frmProductos_Load(object sender, EventArgs e)
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
            labelnav.ForeColor = ThemeColor.PrimaryColor;
        }

        private void Inializar()
        {
            comboBoxcategoria.DataSource = Enum.GetValues(typeof(csEnums.FormaMedida));
        }

        private List<tbProveedor> obtenerlis(List<tbProveedor> lis)//Retorna la lista de Proveedores
        {
            lis = NProveedor.obtenerLista(1);
            return lis;
        }

        private void labelnombre_Click(object sender, EventArgs e)
        {

        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            if (validarDatos())//se validan los datos para no enviar datos null a la db
            {
                try
                {
                    tbProducto producto = new tbProducto();
                    tbObjeto objeto = new tbObjeto();

                    string messa = "";

                    objeto.Codigo = mskcodigo.Text.Trim();
                    objeto.Nombre = textnombre.Text.Trim();
                    objeto.Precio = decimal.Parse(textvalorcompra.Text);
                    objeto.FAdquirido = dateTimePickerfechacompra.Value;
                    objeto.Proveedor = textBoxProveedor.Text.Trim();


                    if (textBoxProveedor.Text != "")//antes de guadar valida si el objeto esta asociado a un proveedor
                    {
                        tbProductoProveedor ProdProv = new tbProductoProveedor();
                        tbProveedor proveedor = new tbProveedor();
                        proveedor.Id = objeto.Proveedor;
                        proveedor = NProveedor.consultarPorId(proveedor);
                        

                        ProdProv.idObjeto = objeto.Codigo.Trim();
                        ProdProv.idProveedor = objeto.Proveedor.Trim();

                        objeto.tbProductoProveedor.Add(ProdProv);
                        messa = "con su proveedor " + proveedor.Id;
                    }
                    producto.Codigo = objeto.Codigo;
                    producto.Descripcion = textBoxdescripcion.Text.Trim();
                    producto.PrecioVenta = decimal.Parse(textBoxvalorventa.Text);//se debe actualizar el int a decimal en la db
                    producto.FormaMedida = comboBoxcategoria.SelectedIndex + 1;
                    producto.Medida = mskTamaño.Text.Trim();
                    producto.Cantidad = int.Parse(textexistencia.Text.Trim());
                    producto.Estado = true;

                    producto.tbObjeto = objeto;
                   
                    if (NProducto.guarda(producto))
                    {
                        MessageBox.Show("Se ingreso un producto " + messa, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarText();
                    }
                    else
                    {
                        MessageBox.Show("Algo salio mal al ingresar el producto " + messa, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show("Error al guardar el producto, se debe a que: " + E.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validarDatos()
        {
            string[] txt = mskcodigo.Text.Split(' ', '_', '-');
            string txtCodigo = "";
            foreach (string t in txt) 
            {
                txtCodigo += t;
            }
            if (txtCodigo == string.Empty)
            {
                MessageBox.Show("Ingrese una codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskcodigo.Focus();
                return false;
            }
            if (textnombre.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textnombre.Focus();
                return false;
            }
            if (comboBoxcategoria.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una forma de medida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxcategoria.Focus();
                return false;
            }
            if (mskTamaño.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un tamaño", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskTamaño.Focus();
                return false;
            }
            if (textvalorcompra.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un valorcompra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textvalorcompra.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void limpiarText()//limpear los textos
        {
            mskcodigo.ResetText();
            textnombre.ResetText();
            textnombre.ResetText();
            comboBoxcategoria.ResetText();
            mskTamaño.ResetText();
            textvalorcompra.ResetText();
            textBoxvalorventa.ResetText();
            dateTimePickerfechacompra.ResetText();
            textexistencia.ResetText();
        }

        private void comboBoxcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            mask(comboBoxcategoria.SelectedIndex + 1);//se le envia el index para modificar la mascara
        }

        private void mask(int p)
        {
            switch (p)
            {
                case 1:
                    mskTamaño.Mask = "###ml";
                    break;
                case 2:
                    mskTamaño.Mask = "###.g";
                    break;
                case 3:
                    mskTamaño.Mask = "###Kg";
                    break;
                case 4:
                    mskTamaño.Mask = "###lb";
                    break;
                case 5:
                    mskTamaño.Mask = "###ml";
                    break;
                case 6:
                    mskTamaño.Mask = "###.l";
                    break;
                case 7:
                    mskTamaño.Mask = "###oz";
                    break;
                default:
                    break;
            }
        }

        private void mskTamaño_TextChanged(object sender, EventArgs e)
        {
            string mskText = "";
            
            mskText = mskTamaño.Text;
            mskTamaño.Mask.Insert(mskTamaño.Mask.Length,"#");
            
        }

        private void textvalorcompra_KeyPress(object sender, KeyPressEventArgs e)
        {  //para solo capturar datos numericos 
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puedes ingresar precios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        private void buttonconsultar_Click(object sender, EventArgs e)
        {
            refreData();//refrescar la dataGridView
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
                dataGridViewProductos.Rows[nr].Cells[2].Value = p.tbObjeto.Precio;
                dataGridViewProductos.Rows[nr].Cells[3].Value = p.PrecioVenta;
                dataGridViewProductos.Rows[nr].Cells[4].Value = p.tbObjeto.Proveedor;
                dataGridViewProductos.Rows[nr].Cells[5].Value = p.tbObjeto.FAdquirido;
                dataGridViewProductos.Rows[nr].Cells[6].Value = p.Descripcion;
                dataGridViewProductos.Rows[nr].Cells[7].Value = p.Cantidad;
                dataGridViewProductos.Rows[nr].Cells[8].Value = Enum.GetName(typeof(csEnums.FormaMedida),p.FormaMedida);
                dataGridViewProductos.Rows[nr].Cells[9].Value = p.Medida;

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
            catch(Exception E)
            {
                MessageBox.Show("Erro " + E.Message + " te recomendamos seleccionar una casilla que contenga datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void pasarDatos(tbProducto seleProducto)
        {// cada uno de los compos en acomodado en su texto
            mskcodigo.Text = seleProducto.Codigo.Trim();
            textnombre.Text = seleProducto.tbObjeto.Nombre;
            textvalorcompra.Text = seleProducto.tbObjeto.Precio.ToString();
            textBoxvalorventa.Text = seleProducto.PrecioVenta.ToString();
            dateTimePickerfechacompra.Value = seleProducto.tbObjeto.FAdquirido.Value;
            textBoxProveedor.Text = seleProducto.tbObjeto.Proveedor.Trim();
            textBoxdescripcion.Text = seleProducto.Descripcion;
            comboBoxcategoria.Text = Enum.GetName(typeof(csEnums.FormaMedida), seleProducto.FormaMedida);
            mskTamaño.Text = seleProducto.Medida;
            textexistencia.Text = seleProducto.Cantidad.ToString();
        }

        private void buttonmodificar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que desea modificar el producto? " + textnombre.Text, "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if ((validarDatos()) && (result == DialogResult.Yes))//se validan los datos para no enviar datos null a la db
            {
                
                try
                {
                    tbProducto producto = new tbProducto();
                    tbObjeto objeto = new tbObjeto();

                    string messa = "";

                    objeto.Codigo = mskcodigo.Text.Trim();
                    objeto.Nombre = textnombre.Text.Trim();
                    objeto.Precio = decimal.Parse(textvalorcompra.Text);
                    objeto.FAdquirido = dateTimePickerfechacompra.Value;
                    objeto.Proveedor = textBoxProveedor.Text.Trim();

                    if (textBoxProveedor.Text != "")//antes de guadar valida si el objeto esta asociado a un proveedor
                    {
                        tbProductoProveedor ProdProv = new tbProductoProveedor();
                        tbProveedor InfoProveedor = new tbProveedor();
                        InfoProveedor.Id = objeto.Proveedor;//gardamos la idea para restear el proveedor 

                        ProdProv.idObjeto = objeto.Codigo.Trim();
                        ProdProv.idProveedor = objeto.Proveedor.Trim();
                        ProdProv.tbObjeto = objeto;
                        ProdProv.tbProveedor = InfoProveedor;//deacuerdo con el proveedor se lo accinamos

                        objeto.tbProductoProveedor.Add(ProdProv);
                        messa = "con su proveedor " + InfoProveedor.Id;
                    }
                    producto.Codigo = objeto.Codigo;
                    producto.Descripcion = textBoxdescripcion.Text.Trim();
                    producto.PrecioVenta = decimal.Parse(textBoxvalorventa.Text);//se debe actualizar el int a decimal en la db
                    producto.FormaMedida = comboBoxcategoria.SelectedIndex + 1;
                    producto.Medida = mskTamaño.Text.Trim();
                    producto.Cantidad = int.Parse(textexistencia.Text.Trim());
                    producto.Estado = true;

                    producto.tbObjeto = objeto; 

                    if (NProducto.modificar(producto))
                    {
                        MessageBox.Show("Se modifico un producto " + messa, "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarText();
                    }
                    else
                    {
                        MessageBox.Show("Algo salió mal al modificar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show("Error al modificar el producto, se debe a que: " + E.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
            }
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el producto? " + textnombre.Text, "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if ((validarDatos()) && (result == DialogResult.Yes))//se validan los datos para no enviar datos null a la db
            {// para eliminar logico se almacena todos los datos y se cambia unicamente el estado a false
                string Codigo = mskcodigo.Text.Trim();
                tbProducto seleProducto;
                seleProducto = listaProducto.Where(x => x.Codigo.Trim() == Codigo.Trim()).SingleOrDefault();

                seleProducto.Estado = false;
                if (NProducto.eliminar(seleProducto))
                {
                    MessageBox.Show("Se modifico un producto", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarText();
                }
                else
                {
                    MessageBox.Show("Algo salió mal al modificar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void listViewProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCantidaProductos_Click(object sender, EventArgs e)
        {
            try
            {
                if ((validarDatos()) && (textBoxProveedor.Text != ""))
                {
                    frmMostrarVentaProveedor frmVentaProve = new frmMostrarVentaProveedor();

                    frmVentaProve.Show();
                    frmVentaProve.resiveDatos(textBoxProveedor.Text.Trim());
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Erro " + E.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnSeleProveedor_Click(object sender, EventArgs e)
        {
            frmVerProveedores frmProveedor = new frmVerProveedores();

            frmProveedor.Show();
            frmProveedor.refreData();

            frmProveedor.pasaProveedor += FrmProveedor_pasaProveedor;
        }

        private void FrmProveedor_pasaProveedor(tbProveedor InfProveedor)
        {
            textBoxProveedor.Text = InfProveedor.Id.Trim();
        }

        private void textBoxProveedor_TextChanged(object sender, EventArgs e)
        {
            //ver o ver el buttom para ver la lista de proveedores
            if(textBoxProveedor.Text != "")
            {
                btnCantidaProductos.Visible = true;
            }
            if(textBoxProveedor.Text.Length <= 1)
            {
                btnCantidaProductos.Visible = true;
            }
        }

        private void frmProductos_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void textexistencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxvalorventa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textvalorcompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (dataGridViewProductos.Rows.Count >= 1)
                    {
                        IEnumerable<tbProducto> listaAux = new List<tbProducto>();

                        if (mskcodigo.Text != string.Empty)
                        {
                            listaAux = listaProducto.Where(x => x.tbObjeto.Codigo.Trim().ToUpper().Contains(mskcodigo.Text.Trim().ToUpper())).ToList();
                        }
                        if (listaAux.Count() == 0 && mskcodigo.Text == string.Empty)
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
            }
            catch (Exception)
            {

                MessageBox.Show("Error, vuelve a intar si el error persiste comuniquese con el creador del software ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
