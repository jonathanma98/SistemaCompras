using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Reportes;

namespace CapaPresentacion
{
    public partial class frmMenuPrincipal : Form
    {
        //fields
        private Button CButton;
        private Panel CPanel;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private object o;

        //Constructor
        public frmMenuPrincipal()
        {
            InitializeComponent();
            random = new Random();
            openPrincipal(o);
        }

        //Metodos
        //Seleccionamos un color aleatorio para el tema de la lista de colores
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorLista.Count);
            //si el color ya a sido selecionado, selecionamos nuevamente para elejir uno diferente
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorLista.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorLista[index];
            return ColorTranslator.FromHtml(color);

        }

        //resaltamos el boton que se a echo clic 1-- seleccionamos un color aleatoriopara el tema es opcional 
        //2--Cambiar el color del fondo del boton
        //3--cambiamos el color fuente del boton 
        //4--cambiamos el tamañode fuente del boton
        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (CButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    CButton = (Button)btnsender;
                    CButton.BackColor = color;
                    CButton.ForeColor = Color.White;
                    CButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    paneltitulo.BackColor = color;
                    panellogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);//El valor debe de ser en decimales
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        //desactivamos el resaltado del boton - valores predeterminados
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Comic Sans MS", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        //creamos un metodo para abrir formularios en los panel de control
        private void OpenChildForm(Form childForm, object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnsender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelpantallahome.Controls.Add(childForm);
            this.panelpantallahome.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labeltitulo.Text = childForm.Text;
        }

        private void panelpantallahome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneltitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openPrincipal(object sender)
        {
            OpenChildForm(new Forms.frmPantallaPrincipal(), sender);
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmRegistrarclientes(), sender);
        }

        private void btnProveedores_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmProveedores(), sender);
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmProductos(), sender);
        }

        private void btnFactura_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmFactura(), sender);
        }

        private void btnDetalledefactura_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmControlDinero(), sender);
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmSelecReportes(), sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmPantallaPrincipal(), sender);
        }

        private void buttonbackup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmRespaldoDB(), sender);
        }

        private void btnPantaInicio_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmPantallaPrincipal(), sender);
        }
    }
}
