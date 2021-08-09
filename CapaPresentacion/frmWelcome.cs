using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircularProgressBar;
using CapaPresentacion.Forms;

namespace CapaPresentacion
{
    public partial class frmWelcome : Form
    {
        int cont = 0;

        public frmWelcome()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cont += 1;
           
            if(cont > 200)
            {
                frmMenuPrincipal frm = new frmMenuPrincipal();
                frm.Show();
                timer1.Stop();
                Close();
            }
        }
    }
}
