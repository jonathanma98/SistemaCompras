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

            List<string> lis = new List<string>();
            LP = obtenerlis(LP);
            foreach (tbProveedor p in LP)
            {
                lis.Add(p.tbPersona.Nombre + " (" + p.Id + ")");
            }
            //con la lista de proveedores es convertida a lista string para ingresarla en el comboBox
            comboBoxProveedor.DataSource = lis;
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
                    objeto.Proveedor = labelIdProveedor.Text.Trim();

                    
                    if (objeto.Proveedor != null)//antes de guadar valida si el objeto esta asociado a un proveedor
                    {
                        tbProductoProveedor ProdProv = new tbProductoProveedor();
                        tbProveedor proveedor = new tbProveedor();
                        proveedor.Id = objeto.Proveedor;
                        proveedor = NProveedor.consultarPorId(proveedor);
                        

                        ProdProv.idObjeto = objeto.Codigo.Trim();
                        ProdProv.idProveedor = objeto.Proveedor.Trim();
                        ProdProv.tbObjeto = objeto;
                        ProdProv.tbProveedor = proveedor;

                        objeto.tbProductoProveedor.Add(ProdProv);
                        messa = "con su proveedor " + proveedor.Id;
                    }
                    producto.Codigo = objeto.Codigo;
                    producto.Descripcion = textBoxdescripcion.Text.Trim();
                    producto.PrecioVenta = int.Parse(textBoxvalorventa.Text);//se debe actualizar el int a decimal en la db
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
            if (mskcodigo.Text == string.Empty)
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
            mskcodigo.Refresh();
            textnombre.Refresh();
            textnombre.Refresh();
            comboBoxcategoria.Refresh();
            mskTamaño.Refresh();
            textvalorcompra.Refresh();
            textBoxvalorventa.Refresh();
            dateTimePickerfechacompra.Refresh();
            textexistencia.Refresh();
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
                    mskTamaño.Mask = "###Lt";
                    break;
                case 2:
                    mskTamaño.Mask = "###Kg";
                    break;
                case 3:
                    mskTamaño.Mask = "###Ml";
                    break;
                case 4:
                    mskTamaño.Mask = "#####";
                    break;
                default:
                    break;
            }
        }

        private void mskTamaño_TextChanged(object sender, EventArgs e)
        {

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
                dataGridViewProductos.Rows[nr].Cells[8].Value = p.FormaMedida;
                dataGridViewProductos.Rows[nr].Cells[9].Value = p.Medida;

            }
        }

        private void dataGridViewProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   //saber que proveedor selecciono el cliente 
            int n = e.RowIndex;// index seleccionado 
            if (n != -1)
            {
                string Codigo = dataGridViewProductos.Rows[n].Cells[0].Value.ToString();//sacamos el codigo se la seleccion

                tbProducto seleProducto;//creamos un objeto para poder almacenar el producto

                seleProducto = listaProducto.Where(x => x.Codigo.Trim() == Codigo.Trim()).SingleOrDefault();
                pasarDatos(seleProducto);//enviamos el producto
            }
        }

        private void pasarDatos(tbProducto seleProducto)
        {// cada uno de los compos en acomodado en su texto
            mskcodigo.Text = seleProducto.Codigo.Trim();
            textnombre.Text = seleProducto.tbObjeto.Nombre;
            textvalorcompra.Text = seleProducto.tbObjeto.Precio.ToString();
            textBoxvalorventa.Text = seleProducto.PrecioVenta.ToString();
            dateTimePickerfechacompra.Value = seleProducto.tbObjeto.FAdquirido.Value;
            comboBoxProveedor.Text = seleProducto.tbObjeto.Proveedor;
            labelIdProveedor.Text = seleProducto.tbObjeto.Proveedor.Trim();
            textBoxdescripcion.Text = seleProducto.Descripcion;
            comboBoxcategoria.Text = Enum.GetName(typeof(csEnums.FormaMedida), seleProducto.FormaMedida);
            mskTamaño.Text = seleProducto.Medida;
            textexistencia.Text = seleProducto.Cantidad.ToString();
        }

        private void buttonmodificar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea modificar el producto" + textnombre.Text, "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                    objeto.Proveedor = labelIdProveedor.Text.Trim();

                    if (objeto.Proveedor != null)//antes de guadar valida si el objeto esta asociado a un proveedor
                    {
                        tbProductoProveedor ProdProv = new tbProductoProveedor();
                        tbProveedor InfoProveedor = new tbProveedor();
                        InfoProveedor.Id = objeto.Proveedor;//gardamos la idea para restear el proveedor 

                        ProdProv.idObjeto = objeto.Codigo.Trim();
                        ProdProv.idProveedor = objeto.Proveedor.Trim();
                        ProdProv.tbObjeto = objeto;
                        ProdProv.tbProveedor = InfoProveedor;//deacuerdo con el proveedor se lo accinamos

                        objeto.tbProductoProveedor.Add(ProdProv);
                        messa = "con su proveedor" + InfoProveedor.Id;
                    }
                    producto.Codigo = objeto.Codigo;
                    producto.Descripcion = textBoxdescripcion.Text.Trim();
                    producto.PrecioVenta = int.Parse(textBoxvalorventa.Text);//se debe actualizar el int a decimal en la db
                    producto.FormaMedida = comboBoxcategoria.SelectedIndex + 1;
                    producto.Medida = mskTamaño.Text.Trim();
                    producto.Cantidad = int.Parse(textexistencia.Text.Trim());
                    producto.Estado = true;

                    producto.tbObjeto = objeto; 

                    if (NProducto.modificar(producto))
                    {
                        MessageBox.Show("Se modifico un producto " + messa, "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarText();
                    }
                    else
                    {
                        MessageBox.Show("Algo salio mal al modificar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            DialogResult result = MessageBox.Show("Esta seguro que desea modificar el producto" + textnombre.Text, "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Algo salio mal al modificar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void listViewProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {   //para poder sacar la id del proveedor se hacen dos validaciones en la que se pide el numero de iten de la lista
            //el campo que se encuente en la misma posicion se saca su id pero esto podria fallar si el usuario hace el evento pasarDatos
            //para ello es la segunda validacion donde se saca un array de lo que este donde del () de combobox que representa la id
            LP = obtenerlis(LP);
            if(comboBoxProveedor.Text != "")
            {
                int cont = 0, n = comboBoxProveedor.SelectedIndex;//para la primera validacion
                string txtcomprara = "", txtAlmacenarArray = "";
                foreach (tbProveedor p in LP)
                {
                    if (n == cont)
                    {
                        txtcomprara = p.tbPersona.Id;//las id que esten en la misma posicion de la LP
                    }
                    cont++;
                }
                int i = 0, vecesParentesis = 0;//para la segunda validacion
                bool capturaID = false;
                char[] txt = comboBoxProveedor.Text.ToArray();//traemos el txt para comprar la id
                while (txt[i] != ')')
                {
                    i++;
                    if (txt[i] == ')')
                    {
                        capturaID = false;
                    }
                    if (capturaID)
                    {
                        //la cadena de text del comboBox viene algo así: pedro (123425466)
                        txtAlmacenarArray += txt[i].ToString();//almacenamos la id que esta dentro ()
                    }
                    if (txt[i] == '(')
                    {
                        capturaID = true;
                        vecesParentesis++;
                    }
                }
                if (txtcomprara.Trim() == txtAlmacenarArray.Trim())
                {
                    labelIdProveedor.Text = txtcomprara;
                }
                else if (vecesParentesis >= 2)//por si la moscar la id tiene un carapter (
                {
                    labelIdProveedor.Text = txtAlmacenarArray;
                    MessageBox.Show("Algo salio mal al sacar la id del proveedor, verifica que la cedula NO contega coracteres extraños", "Identificar Cedula", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCantidaProductos_Click(object sender, EventArgs e)
        {
            if ((validarDatos()) && (comboBoxProveedor.Text != ""))
            {
                csNegocioObjetoProveedor NObjProvee = new csNegocioObjetoProveedor();
                int cantidadProductos = 0;
                string productos = "", id = labelIdProveedor.Text.Trim();
                listaPP = NObjProvee.obtenerLista(1);
                foreach (tbProductoProveedor p in listaPP)
                {
                    if (p.idProveedor.Trim() == id.Trim())
                    {
                        cantidadProductos ++;
                        productos += p.idObjeto.Trim() + "\n";
                    }
                }
                MessageBox.Show("Productos que has comprado a " + comboBoxProveedor + " es de " + cantidadProductos + 
                    " referente con su codigo: \n" + productos , " Productos por Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
}
