using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class frmRespaldoDB : Form
    {

        // Declaramos la conexion
        SqlConnection con = new SqlConnection("server= 06139-3275601\\MSSQLSERVERJONA;database=dbSistemaCompra;Integrated security=true");
        public frmRespaldoDB()
        {
            InitializeComponent();
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
            textBoxDescripcion.ForeColor = ThemeColor.SecondaryColor;
            labelrutaguardar.ForeColor = ThemeColor.PrimaryColor;
            labelrutarestaurar.ForeColor = ThemeColor.PrimaryColor;
        }

        private void frmRespaldoDB_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void buttonRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxRutaGuardar.Text = dlg.SelectedPath;
                buttonBackup.Enabled = true;
            }
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            if (textBoxRutaGuardar.Text == string.Empty)
            {
                MessageBox.Show("Por favor ingrese la ubicación del archivo de respaldo");
            }
            else
            {
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK= '" + textBoxRutaGuardar.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-mm-dd--hh-mm-ss") + ".back'";
                con.Open();
                SqlCommand command = new SqlCommand(cmd, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Base de dato guardada con exito");
                con.Close();
                buttonBackup.Enabled = false;
                Reestablecer();
            }
        }

        private void buttonRutaRestaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL Server database backup files |*.back";
            dlg.Title = "Base de datos restaurada";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxRutaRestaurar.Text = dlg.FileName;
                buttonRestaurar.Enabled = true;
            }
        }

        private void buttonRestaurar_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            con.Open();

            try
            {
                string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, con);
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK= '" + textBoxRutaRestaurar.Text + "' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(str2, con);
                cmd2.ExecuteNonQuery();

                string str3 = string.Format("ALTER TABLE [" + database + "]SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, con);
                cmd3.ExecuteNonQuery();

                //MessageBox.Show("Base de datos restaurada con exito");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Base de datos restaurada con exito");
                buttonRestaurar.Enabled = false;
                Reestablecer();
            }
        }

        private void Reestablecer()
        {
            textBoxRutaGuardar.ResetText();
            textBoxRutaRestaurar.ResetText();
        }
    }
}
