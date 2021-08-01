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

namespace CapaPresentacion
{
    public partial class frmRegistreAdmin : Form
    {
        csNegocioLogin login = new csNegocioLogin();
        public frmRegistreAdmin()
        {
            InitializeComponent();
            panel2.Width = 9;
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {

            if (verificarDatos())
            {
                tbAdmin admin = new tbAdmin();

                admin.id = txtId.Text;
                admin.Nombre = txtNombre.Text;
                admin.contraseña = csEncryp.GetSHA256(txtContreseña.Text);
                //MessageBox.Show(csEncryp.GetSHA256(txtContreseña.Text));
                admin.telefono = txtTelefono.Text;
                admin.correo = txtCorreo.Text;

                if (login.guarda(admin))
                {
                    MessageBox.Show("Se ingrese un nuevo usuario", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Close();
                }
                else
                {
                    MessageBox.Show("Algo selio mal al ingresa el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool verificarDatos()
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return false;
            }
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (txtContreseña.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContreseña.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            tbAdmin admin = new tbAdmin();

            admin.id = txtId.Text;
            admin.Nombre = txtNombre.Text;
            admin.contraseña = csEncryp.GetSHA256(txtContreseña.Text);
            //MessageBox.Show(csEncryp.GetSHA256(txtContreseña.Text));
            admin.telefono = txtTelefono.Text;
            admin.correo = txtCorreo.Text;

            if (login.modificar(admin))
            {
                MessageBox.Show("Se a modificado un usuario", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Close();
            }
            else
            {
                MessageBox.Show("Algo selio mal al modificar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            tbAdmin admin = new tbAdmin();

            admin.id = txtId.Text;
            admin.Nombre = txtNombre.Text;
            admin.contraseña = csEncryp.GetSHA256(txtContreseña.Text);
            admin.telefono = txtTelefono.Text;
            admin.correo = txtCorreo.Text;

            if (login.eliminar(admin))
            {
                MessageBox.Show("Se a eliminado un usuario", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Close();
            }
            else
            {
                MessageBox.Show("Algo selio mal al eliminar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostraPanel2_Click(object sender, EventArgs e)
        {
            if (panel2.Width < 10)
            {
                timer1.Start();
                MessageBox.Show("Hola");
            }
            else
            {
                timer2.Start();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel2.Width < 297)
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
                panel2.Width = 9;
                panel2.BackColor = Color.Transparent;
                timer2.Stop();
            }
        }
    }
}
