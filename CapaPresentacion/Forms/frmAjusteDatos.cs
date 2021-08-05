using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;
using CapaUtilidades;

namespace CapaPresentacion.Forms
{
    public partial class frmAjusteDatos : Form
    {
        csNegocioEmpresa NEmpresa = new csNegocioEmpresa();

        List<tbEmpresa> listaEmpresa;
        public frmAjusteDatos()
        {
            InitializeComponent();
            llamarLista();
        }


        private void frmAjusteDatos_Load(object sender, EventArgs e)
        {   //en el formulario se utiliza dos frm por ello dividimos la pantalla
            Size = new Size();
            panel4.Width = Size.Width/2;
            panel2.Width = Size.Width/2;
        }

        private void llamarLista()
        { //ya que solo se puede ingresar los datos de una empresa
            limpiar();
            listaEmpresa = NEmpresa.obtenerLista(1);
            cargarDatos(listaEmpresa);
        }

        private void cargarDatos(List<tbEmpresa> listaEmpresa)
        {   //cargamos los datos en los textbox
            if (listaEmpresa.Count != 0)
            {
                btnRegistrar.Enabled = false;
                int cont = 0;
                foreach (tbEmpresa em in listaEmpresa)
                {
                    cont++;
                    txtId.Text = em.id.ToString().Trim();
                    txtNombre.Text = em.Nombre;
                    txtCorreo.Text = em.Correo;
                    txtTelefono.Text = em.Telefono;
                    txtDireccion.Text = em.Ubicacion;
                }
                if (cont > 1)
                {
                    MessageBox.Show("Al parecer tienes más de un dato de empresas esto podria afectar el software", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                btnRegistrar.Enabled = true;
            }
            llamarFrm();//una vez cargados los datos llamamos el formulario de usuario en un label
        }

        private void llamarFrm()
        {
            frmRegistreAdmin f = new frmRegistreAdmin();

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.BringToFront();
            f.activarBTN();
            f.Show();
        }

        private void limpiar()
        {
            txtNombre.ResetText();
            txtCorreo.ResetText();
            txtTelefono.ResetText();
            txtDireccion.ResetText();
            txtContraseña.ResetText();
            txtId.ResetText();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        { // ya que los datos de la empresa se cargan al abrir el frm siempre se mantendra la id;
            bool validar = true;
            if (txtId.Text == string.Empty)
            {
                validar = false;
                MessageBox.Show("Al parecer ya tienes datos de la empresa.\n El software solo da soporte a una empresa por " +
                    "instalción sí desea controlar multiples datos de empresas como reportes, ingresos y  gastos, proveedores, cliente..." +
                    " en una sola intalación comunicate con el creador del software" +
                    " Nombre: Jonathan Montoya Argüello. \n correo jonamontoya@gmail.com", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (validacion() && validar)
            {
                tbEmpresa empresa = new tbEmpresa();

                empresa.Nombre = txtNombre.Text.Trim();
                empresa.Correo = txtCorreo.Text.Trim();
                empresa.Telefono = txtTelefono.Text.Trim();
                empresa.Ubicacion = txtDireccion.Text.Trim();
                string contra = csEncryp.GetSHA256(txtContraseña.Text.Trim());
                empresa.contraseña = contra.Trim();
                empresa.id = int.Parse(txtId.Text.Trim());

                if (NEmpresa.guarda(empresa))
                {
                    MessageBox.Show("Datos de la empresa capturados con éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Algo salio mal al ingresa los datos de la empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validacion()
        {
           
           if(txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Ingresa un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Ingresa un número de teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return false;
            }
            if (txtCorreo.Text == string.Empty)
            {
                MessageBox.Show("Ingresa un correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
                return false;
            }
            if (txtContraseña.Text == string.Empty)
            {
                MessageBox.Show("Ingresa una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
                return false;
            }
            else
            { 
                return true;
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                tbEmpresa empresa = new tbEmpresa();

                empresa.Nombre = txtNombre.Text.Trim();
                empresa.Correo = txtCorreo.Text.Trim();
                empresa.Telefono = txtTelefono.Text.Trim();
                empresa.Ubicacion = txtDireccion.Text.Trim();
                string contra = csEncryp.GetSHA256(txtContraseña.Text.Trim());
                empresa.contraseña = contra.Trim();
                empresa.id = int.Parse(txtId.Text.Trim());

                if (NEmpresa.modificar(empresa))
                {
                    MessageBox.Show("Datos de la empresa capturados con éxito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Algo salio mal al editar los datos de la empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {   //mostrar o ocultar la contraseña
            if(txtContraseña.PasswordChar == '*')
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
        }

    }
}
