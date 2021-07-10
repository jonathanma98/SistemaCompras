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

namespace SistemaCompras
{
    public partial class frmRegistreAdmin : Form
    {
        csNegocioLogin login = new csNegocioLogin();
        public frmRegistreAdmin()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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
           if(txtId.Text == string.Empty)
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
    }
}
