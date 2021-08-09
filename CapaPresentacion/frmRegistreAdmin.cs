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
using CapaPresentacion.Forms;

namespace CapaPresentacion
{
    public partial class frmRegistreAdmin : Form
    {
        csNegocioLogin login = new csNegocioLogin();

        List<tbAdmin> listaAdmin;
        public frmRegistreAdmin()
        {
            InitializeComponent();
            panel2.Width = 9;
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            if ((verificarDatos()) && (validarContraEmpresa()))
            {
                tbAdmin admin = new tbAdmin();

                admin.id = txtId.Text;
                admin.Nombre = txtNombre.Text;
                admin.contraseña = csEncryp.GetSHA256(txtContreseña.Text.Trim());
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

        private bool validarContraEmpresa()
        {
            try
            {
                csNegocioEmpresa NEmpresa = new csNegocioEmpresa();
                List<tbEmpresa> listaEmpresa = new List<tbEmpresa>();
                string contra = "";
                listaEmpresa = NEmpresa.obtenerLista(1);
                foreach (tbEmpresa em in listaEmpresa)
                {
                    contra = em.contraseña;
                }
                if (contra.Trim() != "")
                {
                    string contraEmpre = Microsoft.VisualBasic.Interaction.InputBox("Ingresa la contraseña de la empresa", "verificación");

                    if (contra == csEncryp.GetSHA256(contraEmpre.Trim()))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrectar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos de la empresa", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmAjusteDatos frm = new frmAjusteDatos();
                    frm.Show();
                    frm.activarbtnRegistrar();
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontraron datos de la empresa", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmAjusteDatos frm = new frmAjusteDatos();
                frm.Show();
                frm.activarbtnRegistrar();
                return false;
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
                frmAjusteDatos frm = new frmAjusteDatos();
                frm.Show();
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
            try
            {
                if (verificarDatos())
                {
                    tbAdmin admin = new tbAdmin();

                    admin.id = txtId.Text;
                    admin.Nombre = txtNombre.Text;
                    admin.contraseña = csEncryp.GetSHA256(txtContreseña.Text.Trim());
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
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((validarContraEmpresa()))
                {
                    tbAdmin admin = new tbAdmin();

                    admin.id = txtId.Text;
                    admin.Nombre = txtNombre.Text;
                    admin.contraseña = csEncryp.GetSHA256(txtContreseña.Text.Trim());
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
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMostraPanel2_Click(object sender, EventArgs e)
        {
            if (panel2.Width < 10)
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
            if (panel2.Width < 297)
            {
                panel2.Width += 15;
            }
            else
            {
                panel2.BackColor = Color.Fuchsia;
                timer1.Stop();
                llenarLista();
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

        public void activarBTN()
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnVerListaFacuta_Click(object sender, EventArgs e)
        {
            llenarLista();
        }

        private void llenarLista()
        {
            try
            {
                listaAdmin = login.obtenerLista(1);
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                foreach (tbAdmin ad in listaAdmin)
                {
                    int nr = dataGridView1.Rows.Add();
                    dataGridView1.Rows[nr].Cells[0].Value = ad.id.Trim();
                    dataGridView1.Rows[nr].Cells[1].Value = ad.Nombre;
                    dataGridView1.Rows[nr].Cells[2].Value = ad.correo;
                    dataGridView1.Rows[nr].Cells[3].Value = ad.correo;
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //saber que proveedor selecciono el cliente 
                int n = e.RowIndex;// index seleccionado 
                if (n != -1)
                {
                    string id = dataGridView1.Rows[n].Cells[0].Value.ToString();//sacamos el codigo se la seleccion

                    tbAdmin seleAdmin;//creamos un objeto para poder almacenar el producto

                    seleAdmin = listaAdmin.Where(x => x.id.Trim() == id.Trim()).SingleOrDefault();
                    pasarDatos(seleAdmin);//enviamos el producto
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Erro " + E.Message + " te recomendamos seleccionar una casilla que contenga datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pasarDatos(tbAdmin seleAdmin)
        {
            txtId.Text = seleAdmin.id;
            txtNombre.Text = seleAdmin.Nombre;
            txtTelefono.Text = seleAdmin.telefono;
            txtCorreo.Text = seleAdmin.correo;

            timer2.Start();
        }
    }
}
