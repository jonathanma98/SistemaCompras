﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidades;
using CapaUtilidades;


namespace SistemaCompras
{
    public partial class frmVerFactura : Form
    {
        csNegocioFactura factura = new csNegocioFactura();

        List<tbFactura> datosFactura;

        private string datosDeFactura = "";
        public frmVerFactura()
        {
            InitializeComponent();
            SolicitarFactura();
        }

        private void SolicitarFactura()
        {
            listViewFactura.Items.Clear();
            listViewFactura.Refresh();

            datosFactura = factura.obtenerListaId("50555055520/07/2021");
            CargarFactura(datosFactura);
        }

        private void CargarFactura(List<tbFactura> datosFactura)
        {
            foreach (tbFactura fc in datosFactura)
            {
                labelfecha.Text = fc.FechaCompra.ToString();
                labelID.Text = fc.IdFactura;
                labelCliente.Text = fc.IdAsociada;
                labelTipo.Text = Enum.GetName(typeof(csEnums.Tipo), fc.Tipo);
                datosDeFactura = fc.Productos;
            }

            cargarDataDeFactura(datosDeFactura);
        }

        private void cargarDataDeFactura(string datos)
        {
            string[] txt;
            int cont = 0, cantidad =0, precio = 0, sub =0, iva=0, total=0;

            ListViewItem item = new ListViewItem();

            txt = datos.Split('}');
            foreach (string o in txt)
            {
                cont++;
                
                textBox1.Text += o + "\n";

                //switch (cont)
                //{
                //    case 1: listViewFactura.Items.Add(o);
                //        textBox1.Text += "--------()------- \n";
                //        break;

                //    case 2:
                //        item.SubItems.Add(o);
                //        cantidad = int.Parse(o);
                //        break;

                //    case 3:
                //        item.SubItems.Add(o);
                //        precio = int.Parse(o);
                //        break;

                //    case 4:
                //        iva = 0;

                //        iva = iva / 100;
                //        sub = (precio + iva) * cantidad;
                //        item.SubItems.Add(sub.ToString());

                //        sub = 0; iva = 0; precio = 0; cantidad = 0; cont = 0;
                //        break;
  
                //    default:
                //        item.SubItems.Add("Alguio salio mal con la cade de caracteres");
                //        break;
                //}

                if (cont == 1)
                {
                    item = listViewFactura.Items.Add(o);
                }
                if (cont == 2)
                {
                    item.SubItems.Add(o);
                    cantidad = int.Parse(o);
                }
                if (cont == 3)
                {
                    item.SubItems.Add(o);
                    precio = int.Parse(o);
                }
                if (cont == 4)
                {
                    item.SubItems.Add(o);
                    iva = 0;

                    iva = iva / 100;
                    sub = (precio + iva) * cantidad;
                    item.SubItems.Add(sub.ToString());
                    total += sub;
                    labelTotal.Text = total.ToString();
                    sub = 0; iva = 0; precio = 0; cantidad = 0; cont = 0;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listViewFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
