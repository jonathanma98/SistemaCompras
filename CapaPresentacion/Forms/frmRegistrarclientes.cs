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
using CapaUtilidades;
using CapaNegocios;

namespace CapaPresentacion.Forms
{
    
    public partial class frmRegistrarclientes : Form
    {
        csClienteNegocio ClienteNegocio = new csClienteNegocio();
        List<tbCliente> listaClientes;
        public frmRegistrarclientes()
        {
            InitializeComponent();
            Inializar();
        }

        private void frmRegistrarclientes_Load(object sender, EventArgs e)
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

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Iniciamos los componente de los textos
        private void Inializar()
        {
            comboBoxtipocedula.DataSource = Enum.GetValues(typeof(csEnums.TipoID));
        }

        //Al seleccionar guardar
        private void buttonguardar_Click(object sender, EventArgs e)
        {
            if (validarDatos())//se validan los datos para no enviar datos null a la db
            {
                tbPersona persona = new tbPersona();
                tbCliente cliente = new tbCliente();

                persona.Id = maskedTextBoxcedula.Text.Trim();
                persona.TipoId = comboBoxtipocedula.SelectedIndex + 1;
                persona.Nombre = textnombre.Text;
                persona.Apellidos = textapellido1.Text;
                persona.Telefeno = maskedTextBoxtelefono.Text;
                persona.Correo = textemail.Text;

                cliente.Id = persona.Id;
                cliente.TipoId = persona.TipoId;

                cliente.Direccion = textdireccion.Text;
                cliente.Estado = true;

                cliente.tbPersona = persona;

                if (ClienteNegocio.guarda(cliente))
                {
                    MessageBox.Show("Se ingreso un cliente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarText();
                }
                else
                {
                    MessageBox.Show("Algo salio mal al ingresar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            textdireccion.Refresh();
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

        private void buttonconsultar_Click(object sender, EventArgs e)
        {
            dataGridViewClientes.Rows.Clear();
            dataGridViewClientes.Refresh();
            dataGridViewClientes.Visible = true;

            listaClientes = ClienteNegocio.obtenerLista(1);
            cargarDatos(listaClientes);
        }

        private void cargarDatos(List<tbCliente> listaClientes)
        {
            foreach (tbCliente cliente in listaClientes)
            {
                if (cliente.Estado == true)
                {
                    int nr = dataGridViewClientes.Rows.Add();
                    dataGridViewClientes.Rows[nr].Cells[0].Value = cliente.Id;
                    dataGridViewClientes.Rows[nr].Cells[1].Value = Enum.GetName(typeof(csEnums.TipoID), cliente.TipoId);
                    dataGridViewClientes.Rows[nr].Cells[2].Value = cliente.tbPersona.Nombre;
                    dataGridViewClientes.Rows[nr].Cells[3].Value = cliente.tbPersona.Apellidos;
                    dataGridViewClientes.Rows[nr].Cells[4].Value = cliente.tbPersona.Telefeno;
                    dataGridViewClientes.Rows[nr].Cells[5].Value = cliente.tbPersona.Correo;
                    dataGridViewClientes.Rows[nr].Cells[6].Value = cliente.Direccion;
                }
            }

        }
        private void pasarDatos(tbCliente seleCliente)
        {
            maskedTextBoxcedula.Text = seleCliente.Id.Trim();
            comboBoxtipocedula.Text = Enum.GetName(typeof(csEnums.TipoID), seleCliente.TipoId);
            textnombre.Text = seleCliente.tbPersona.Nombre;
            textapellido1.Text = seleCliente.tbPersona.Apellidos;
            maskedTextBoxtelefono.Text = seleCliente.tbPersona.Telefeno;
            textemail.Text = seleCliente.tbPersona.Correo;
            textdireccion.Text = seleCliente.Direccion;
        }

        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                string id = dataGridViewClientes.Rows[n].Cells[0].Value.ToString();

                tbCliente seleCliente;

                seleCliente = listaClientes.Where(x => x.Id.Trim() == id.Trim()).SingleOrDefault();
                pasarDatos(seleCliente);
            }
        }

        private void buttonmodificar_Click(object sender, EventArgs e)
        {
            if (validarDatos())//se validan los datos para no enviar datos null a la db
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea modificar el cliente" + textnombre.Text, "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    tbPersona persona = new tbPersona();
                    tbCliente cliente = new tbCliente();

                    persona.Id = maskedTextBoxcedula.Text.Trim();
                    persona.TipoId = comboBoxtipocedula.SelectedIndex + 1;
                    persona.Nombre = textnombre.Text.Trim();
                    persona.Apellidos = textapellido1.Text.Trim();
                    persona.Telefeno = maskedTextBoxtelefono.Text.Trim();
                    persona.Correo = textemail.Text.Trim();

                    cliente.Id = persona.Id;
                    cliente.TipoId = persona.TipoId;
                    cliente.Direccion = textdireccion.Text.Trim();
                    cliente.Estado = true;

                    cliente.tbPersona = persona;

                    if (ClienteNegocio.modificar(cliente))
                    {
                        MessageBox.Show("Se modifico un cliente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarText();
                    }
                    else
                    {
                        MessageBox.Show("Algo salio mal al modificar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea modificar el Cliente" + textnombre.Text, "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                tbCliente cliente = new tbCliente();
                cliente.Id = maskedTextBoxcedula.Text.Trim();
                cliente.Estado = false;
                if (ClienteNegocio.eliminar(cliente))
                {
                    MessageBox.Show("Se elimino un cliente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarText();
                }
                else
                {
                    MessageBox.Show("Algo salio mal al eliminar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmRegistrarclientes_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
