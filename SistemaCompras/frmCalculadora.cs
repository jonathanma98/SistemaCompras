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
    public partial class frmCalculadora : Form
    {

        public string txtScree;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private bool verificarOperadores()
        {
            int txt = Scree.Text.Length, retorno = 0;
            string valor = Scree.Text[txt - 1].ToString();
            switch (valor)
            {
                case "+":
                    label1.Text = "Imposible realizar esta operacion";
                    break;

                case "-":
                    label1.Text = "Imposible realizar esta operacion";
                    break;

                case "*":
                    label1.Text = "Imposible realizar esta operacion";
                    break;

                case "/":
                    label1.Text = "Imposible realizar esta operacion";
                    break;

                case ".":
                    label1.Text = "Imposible realizar esta operacion";
                    break;

                default:
                    retorno = 1;
                    break;
            }
            if(retorno == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void operador(string scree)
        {
            double resultado=0, m = 0, d = 0, s = 0, r = 0;
            int contador = 0;

            string t = scree;
            string[] operados, operadores;


            operados = scree.Split(' ', '*', '/', '+', '-');
            operadores = t.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
            foreach(string o in operados)
            {
                contador++;
            }
            foreach(string u in operadores)
            {
                label1.Text = u;
            }

            //for (int i=0; contador <= 0; i++)
            //{
            //    i++;

            //    string o = scree[i].ToString();
            //    //contar individual la cantidad de operadores
            //    if(scree[i] == '*')
            //    {
            //       resultado = double.Parse(o) * double.Parse(o);
            //    }
            //    if (scree[i] == '/')
            //    {
            //        resultado = double.Parse(o) / double.Parse(o);
            //    }
            //    if (scree[i] == '+')
            //    {
            //        resultado = double.Parse(o) + double.Parse(o);
            //        label1.Text += " ";
            //        label1.Text += o;
            //    }
            //    if (scree[i] == '-')
            //    {
            //        resultado = double.Parse(o) - double.Parse(o);
            //    }
            //}

            //for(int i=0; i <= contador; i++)
            //{
            //    scree[i].ToString();

            //   if(m >= 1)
            //    {
            //        while(m == 0)
            //        {
            //            if (scree[i].ToString() == "*")
            //            {

            //            }
            //        }
            //    }
            //}

            Scree.Text = resultado.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(Scree.Text != "0")
            {
                Scree.Text += "0";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (verificarOperadores())
            {
                Scree.Text += ".";
            }
        }


        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (verificarOperadores() && Scree.Text != string.Empty)
            {
                Scree.Text += "";
                operador(Scree.Text);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Scree.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Scree.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Scree.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Scree.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Scree.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Scree.Text += "6";
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (verificarOperadores())
            {
                Scree.Text += "+";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Scree.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Scree.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Scree.Text += "9";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (verificarOperadores())
            {
                Scree.Text += "-";
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (verificarOperadores())
            {
                Scree.Text += "*";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (verificarOperadores())
            {
                Scree.Text += "/";
            }
        }

        private void btnBorr_Click(object sender, EventArgs e)
        {
            if (Scree.Text != string.Empty)
            {
                Scree.Text = Scree.Text.Remove(Scree.Text.Length - 1);
            }

        }


    }
}

