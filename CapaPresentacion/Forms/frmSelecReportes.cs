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

namespace CapaPresentacion.Forms
{
    public partial class frmSelecReportes : Form
    {
        private int cont = 0;
        public frmSelecReportes()
        {
            InitializeComponent();
            iniciar();
        }
        
        private void iniciar()
        {
            panelIngresos.Visible = false;
            panelIngresos.Height = 0;

            panelProveedores.Visible = false;
            panelProveedores.Height = 0;

            panelClientes.Visible = false;
            panelClientes.Height = 0;

            panelProductos.Visible = false;
            panelProductos.Height = 0;
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn1PorFecha_Click(object sender, EventArgs e)
        {
            rptControlDineroPorFecha ControDineroF = new rptControlDineroPorFecha();
            ControDineroF.Show();
        }


        private void btn1PorId_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cont++;
            if(panelIngresos.Height <= 274)
            {
                panelIngresos.Visible = true;
                panelIngresos.Height += 8;
            }
            else if (cont >= 275)
            {
                
                timer1.Stop();
            }
        }

        //-------------------------------area proveedores

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            cont++;
            if (panelProveedores.Height <= 274)
            {
                panelProveedores.Visible = true;
                panelProveedores.Height += 8;
            }
            else if (cont >= 275)
            {

                timer2.Stop();
            }
        }


        private void btnCompraProveedores_Click(object sender, EventArgs e)
        {
            rptVentaProveedores ventaProveedores = new rptVentaProveedores();

            ventaProveedores.Show();
        }



        //--------------------area Clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void btnTotalCompraClientes_Click(object sender, EventArgs e)
        {
            try
            {
                rptVentaClientes ventasClientes = new rptVentaClientes();
                ventasClientes.Show();
            }
            catch (Exception E)
            {

                MessageBox.Show("Error " + E.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVentaID_Click(object sender, EventArgs e)
        {
            try
            {
                frmVentaClientePorId ClienteID = new frmVentaClientePorId();
                ClienteID.Show();
            }
            catch (Exception E)
            {

                MessageBox.Show("Error " + E.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            cont++;
            if (panelClientes.Height <= 274)
            {
                panelClientes.Visible = true;
                panelClientes.Height += 8;
            }
            else if (cont >= 275)
            {

                timer3.Stop();
            }
        }


        //--------------------------area productos 
        private void btnProductos_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            cont++;
            if (panelProductos.Height <= 274)
            {
                panelProductos.Visible = true;
                panelProductos.Height += 8;
            }
            else if (cont >= 275)
            {

                timer4.Stop();
            }
        }

        private void btnProductoFecha_Click(object sender, EventArgs e)
        {
            rptProductosInventario ProductosFecha = new rptProductosInventario();
            ProductosFecha.Show();
        }

        private void btnProductoCantidad_Click(object sender, EventArgs e)
        {
            rptProductosPorCantidad ProductosPorCantidad = new rptProductosPorCantidad();
            ProductosPorCantidad.Show();
        }

        private void btnProducCantidadVentas_Click(object sender, EventArgs e)
        {
            rptProductosPorCantidadDeVentas ProductosCantidaVenta = new rptProductosPorCantidadDeVentas();
            ProductosCantidaVenta.Show();
        }

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
        }

        private void frmSelecReportes_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
