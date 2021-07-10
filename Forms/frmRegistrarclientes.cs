using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCompras.Forms
{
    public partial class frmRegistrarclientes : Form
    {
        public frmRegistrarclientes()
        {
            InitializeComponent();
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
    }
}
