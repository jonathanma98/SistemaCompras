using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class frmDetalleFactura : Form
    {
        public frmDetalleFactura()
        {
            InitializeComponent();
        }

        private void frmDetalleFactura_Load(object sender, EventArgs e)
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
            labelfechanacimiento.ForeColor = ThemeColor.PrimaryColor;
        }

        private void frmDetalleFactura_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
