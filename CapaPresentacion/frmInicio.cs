using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion;
using CapaNegocios;
using CapaEntidades;
using CapaUtilidades;

namespace CapaPresentacion
{
    public partial class frmInicio : Form
    {

        private string contra, id;
        int cont = 0;

        List<tbAdmin> listaAdmin;

        public frmInicio()
        {
            InitializeComponent();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            cont++;

            if (cont == 100)
            {
                if (labelContra.Visible == true)
                {
                    labelContra.Visible = false;
                }
                if (labelId.Visible == true)
                {
                    labelId.Visible = false;
                }
                cont = 0;
                timer1.Stop();
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            cont++;

            if (cont == 100)
            {
                timer2.Stop();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmRegistreAdmin registro = new frmRegistreAdmin();

            registro.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtContra.PasswordChar == '*')
            {
                txtContra.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '*';
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            csNegocioLogin login = new csNegocioLogin();
            try
            {
                id = txtId.Text;
                listaAdmin = login.obtenerListaId(id);//enviamos el usuario id
                if (listaAdmin.Count != 0)
                {//evaluamos que el usario no venga vacio
                    foreach (tbAdmin dato in listaAdmin)
                    {
                        contra = dato.contraseña.Trim();
                    }

                    string passport = csEncryp.GetSHA256(txtContra.Text);
                    //evaluamos los datos para poder ingresar a los formulacios
                    if (id == txtId.Text && passport == contra)
                    {
                        //frmWelcome frm = new frmWelcome();
                        //frm.ShowDialog();
                        frmMenuPrincipal frm = new frmMenuPrincipal();
                        frm.Show();
                        this.Opacity = 0;
                        timer2.Start();

                    }
                    else if (contra != txtContra.Text)
                    {
                        labelContra.Visible = true;
                        timer1.Start();
                    }
                }
                else
                {
                    labelId.Visible = true;
                    timer1.Start();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
