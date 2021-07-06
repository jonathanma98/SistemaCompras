using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCompras
{
    public partial class frmInicio : Form
    {

        private string contra="123", id="admin";
        int cont = 0;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cont++;

            if(cont == 100)
            {
                if(labelContra.Visible == true)
                {
                    labelContra.Visible = false;
                }
                if(labelId.Visible == true)
                {
                    labelId.Visible = false;
                }
                cont = 0;
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            cont++;

            if (cont == 100)
            {
                timer2.Stop();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if(id == txtId.Text && contra == txtContra.Text)
            {
                frmWelcome frm = new frmWelcome();
                frm.Show();

                this.Opacity = 0;
                timer2.Start();

            }
            else if(id!= txtId.Text)
            {
                labelId.Visible = true;
                timer1.Start();
            }
            else if (contra != txtContra.Text)
            {
                labelContra.Visible = true;
                timer1.Start();
            }

        }
    }
}
