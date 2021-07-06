﻿using System;
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
    public partial class frmWelcome : Form
    {
        int cont = 0, i=0;

        private void imgLogo_Click(object sender, EventArgs e)
        {

        }

        public frmWelcome()
        {
            InitializeComponent();
            imgLogo.Visible = false;
            //imgLogo.Width = 0;
            imgLogo.Height = 0;
            circularProgressBar1.Visible = false;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            if (this.Opacity < 1) this.Opacity += 0.5;
            cont +=1;


            if (imgLogo.Visible == false)
            {
                imgLogo.Visible = true;
            }

            if (imgLogo.Height <= 212)
            {
                //imgLogo.Width += 10;
                imgLogo.Height += 12;
            }

            if(cont == 50)
            {
                timer2.Start();
            }
            else if (cont == 100)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity -= 0.6;

            i += 1;
            if (circularProgressBar1.Visible == false)
            {
                circularProgressBar1.Value = 0;
                circularProgressBar1.Visible = true;
                circularProgressBar1.Minimum =0;
                circularProgressBar1.Maximum = 100;
            }
            else if(circularProgressBar1.Value < 99)
            {
                circularProgressBar1.Value += 1;
                circularProgressBar1.Text = i.ToString();
            }
            if(i == 105)
            {
                this.Hide();
                frmVerFactura frm = new frmVerFactura();
                timer2.Stop();
                frm.Show();

                Close();
            }
        }
    }
}