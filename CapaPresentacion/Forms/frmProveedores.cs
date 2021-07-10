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
    public partial class frmProveedores : Form
    {

        NegocioProveedor NProveedor = new NegocioProveedor();

        List<tbProveedor> listaProveedor;
        public frmProveedores()
        {
            InitializeComponent();
            Inializar();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
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
        //Iniciamos los componente de los textos
        private void Inializar()
        {
            comboBoxtipocedula.DataSource = Enum.GetValues(typeof(csEnums.TipoID));
            comboBoxcalificacion.DataSource = csEnums.Calificacion();

        }

        //Al seleccionar guardar
        private void buttonguardar_Click(object sender, EventArgs e)
        {
            if (validarDatos())//se validan los datos para no enviar datos null a la db
            {
                tbPersona persona = new tbPersona();
                tbProveedor proveedor = new tbProveedor();

                persona.Id = maskedTextBoxcedula.Text.Trim();
                persona.TipoId = comboBoxtipocedula.SelectedIndex + 1;
                persona.Nombre = textnombre.Text;
                persona.Apellidos = textapellido1.Text;
                persona.Telefeno = maskedTextBoxtelefono.Text;
                persona.Correo = textemail.Text;

                proveedor.Id = persona.Id;
                proveedor.TipoId = persona.TipoId;

                proveedor.Descripcion = textBoxdescripcion.Text;
                proveedor.Calificacion = comboBoxcalificacion.SelectedIndex;
                proveedor.Estado = true;

                proveedor.tbPersona = persona;

                if (NProveedor.guarda(proveedor))
                {
                    MessageBox.Show("Se ingreso un proveedor", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarText();
                }
                else
                {
                    MessageBox.Show("Algo salio mal al ingresar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validarDatos()
        {
            if (maskedTextBoxcedula.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBoxcedula.Focus();
                return false;
            }
            if (comboBoxtipocedula.Text == string.Empty)
            {
                MessageBox.Show("Verifique el tipo de cedula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxtipocedula.Focus();
                return false;
            }
            if (textnombre.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textnombre.Focus();
                return false;
            }
            if (textapellido1.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textapellido1.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void limpiarText()//limpear los textos
        {
            maskedTextBoxcedula.Refresh();
            comboBoxtipocedula.Refresh();
            textnombre.Refresh();
            textapellido1.Refresh();
            maskedTextBoxtelefono.Refresh();
            textemail.Refresh();
            textBoxdescripcion.Refresh();
            comboBoxcalificacion.Refresh();
        }

        //al seleccionar un tipo de cedula se cambia la mascara
        private void comboBoxtipocedula_SelectedIndexChanged(object sender, EventArgs e)
        {
            mask(comboBoxtipocedula.SelectedIndex + 1);
        }

        private void mask(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 1:
                    maskedTextBoxcedula.Mask = "#-####-####";
                    break;
                case 2:
                    maskedTextBoxcedula.Mask = "#-###-#####";
                    break;
                case 3:
                    maskedTextBoxcedula.Mask = "##########";
                    break;
                case 4:
                    maskedTextBoxcedula.Mask = "############";
                    break;
                default:
                    break;
            }
        }

        private void comboBoxcalificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBoxcalificacion.SelectedIndex + 1)
            {
                case 1:
                    comboBoxcalificacion.BackColor = Color.Yellow;
                    break;
                case 2:
                    comboBoxcalificacion.BackColor = Color.NavajoWhite;
                    break;
                case 3:
                    comboBoxcalificacion.BackColor = Color.Green;
                    break;
                default: break;
            }
        }

        private void comboBoxtipocedula_Click(object sender, EventArgs e)
        {

        }

        private void buttonconsultar_Click(object sender, EventArgs e)
        {
            dataGridViewProveedor.Rows.Clear();
            dataGridViewProveedor.Refresh();
            dataGridViewProveedor.Visible = true;

            listaProveedor = NProveedor.obtenerLista(1);
            cargarDatos(listaProveedor);
        }

        private void cargarDatos(List<tbProveedor> listaProveedor)
        {
            foreach (tbProveedor Provee in listaProveedor)
            {
                if(Provee.Estado == true)
                {
                    int nr = dataGridViewProveedor.Rows.Add();
                    dataGridViewProveedor.Rows[nr].Cells[0].Value = Provee.Id;
                    dataGridViewProveedor.Rows[nr].Cells[1].Value = Enum.GetName(typeof(csEnums.TipoID), Provee.TipoId);
                    dataGridViewProveedor.Rows[nr].Cells[2].Value = Provee.tbPersona.Nombre;
                    dataGridViewProveedor.Rows[nr].Cells[3].Value = Provee.tbPersona.Apellidos;
                    dataGridViewProveedor.Rows[nr].Cells[4].Value = Provee.tbPersona.Telefeno;
                    dataGridViewProveedor.Rows[nr].Cells[5].Value = Provee.tbPersona.Correo;
                    dataGridViewProveedor.Rows[nr].Cells[6].Value = Provee.Descripcion;
                    dataGridViewProveedor.Rows[nr].Cells[7].Value = csEnums.Calificacion()[(int)Provee.Calificacion];
                }
            }
            
        }

        private void pasarDatos(tbProveedor seleProveedor)
        {
            maskedTextBoxcedula.Text = seleProveedor.Id;
            comboBoxtipocedula.Text  = Enum.GetName(typeof(csEnums.TipoID), seleProveedor.TipoId);
            textnombre.Text = seleProveedor.tbPersona.Nombre;
            textapellido1.Text = seleProveedor.tbPersona.Apellidos;
            maskedTextBoxtelefono.Text = seleProveedor.tbPersona.Telefeno;
            textemail.Text = seleProveedor.tbPersona.Correo;
            textBoxdescripcion.Text = seleProveedor.Descripcion;
            comboBoxcalificacion.SelectedItem = csEnums.Calificacion()[(int)seleProveedor.Calificacion];
        }

        private void dataGridViewProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                string id = dataGridViewProveedor.Rows[n].Cells[0].Value.ToString();

                tbProveedor seleProveedor;

                seleProveedor = listaProveedor.Where(x => x.Id.Trim() == id.Trim()).SingleOrDefault();
                pasarDatos(seleProveedor);
            }
        }

        private void buttonmodificar_Click(object sender, EventArgs e)
        {
            if (validarDatos())//se validan los datos para no enviar datos null a la db
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea modificar el proveedor" + textnombre.Text, "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    tbPersona persona = new tbPersona();
                    tbProveedor proveedor = new tbProveedor();

                    persona.Id = maskedTextBoxcedula.Text.Trim();
                    persona.TipoId = comboBoxtipocedula.SelectedIndex + 1;
                    persona.Nombre = textnombre.Text.Trim();
                    persona.Apellidos = textapellido1.Text.Trim();
                    persona.Telefeno = maskedTextBoxtelefono.Text.Trim();
                    persona.Correo = textemail.Text.Trim();

                    proveedor.Id = persona.Id;
                    proveedor.TipoId = persona.TipoId;

                    proveedor.Descripcion = textBoxdescripcion.Text.Trim();
                    proveedor.Calificacion = comboBoxcalificacion.SelectedIndex;
                    proveedor.Estado = true;
                    proveedor.tbPersona = persona;

                    if (NProveedor.modificar(proveedor))
                    {
                        MessageBox.Show("Se modifico un proveedor", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarText();
                    }
                    else
                    {
                        MessageBox.Show("Algo salio mal al modificar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea modificar el proveedor" + textnombre.Text, "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                tbProveedor proveedor = new tbProveedor();
                proveedor.Id = maskedTextBoxcedula.Text.Trim();
                proveedor.Estado = false;
                if (NProveedor.eliminar(proveedor))
                {
                    MessageBox.Show("Se modifico un proveedor", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarText();
                }
                else
                {
                    MessageBox.Show("Algo salio mal al modificar el proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
