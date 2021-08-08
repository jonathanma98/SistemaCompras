using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CapaEntidades;
using CapaNegocios;
using CapaUtilidades;

namespace CapaPresentacion.Forms
{
    public partial class frmControlDinero : Form
    {
        csNegocioFactura NFactura = new csNegocioFactura();
        NegocioProductos NProducto = new NegocioProductos();
        csNegocioControlDinero NControlDinero = new csNegocioControlDinero();


        List<tbFactura> listaFactura;
        List<tbProducto> listaProductos;
        List<tbControlDinero> listaControlDinero;

        public frmControlDinero()
        {
            InitializeComponent();
            cargarGrafico();
            cargarDate();
        }

        private void cargarDate()
        {
            labelDate.Text = "";
            labelHora.Text = "";
            DateTime date = DateTime.Now;

            labelDate.Text = date.Date.ToString();
            labelDate.Text = date.ToLocalTime().ToString();

            cbTipo.DataSource = Enum.GetValues(typeof(csEnums.Tipo));
        }

        private void cargarGrafico()
        {
            chartVentas.Series.Clear();
            chartVentas.Titles.Clear();
            DateTime mes = DateTime.Now;
            //pedimos la lista esta vendra solo del año y el mes actual
            listaFactura = NFactura.obtenerLista(1);
            //ordenamos la lista 
            var listaFacturaOrdenada = listaFactura.OrderBy(x => x.FechaCompra);

            Series serie = new Series();
            chartVentas.Palette = ChartColorPalette.Pastel;
            chartVentas.Titles.Add("Ventas del mes actual");
            int i = 0;
           foreach(tbFactura p in listaFacturaOrdenada)
           {
                if((p.FechaCompra.Month == mes.Month) && (p.FechaCompra.Year == mes.Year) &&(p.Tipo == 1))//filtro para sacar ventas actuales
                {
                    serie = chartVentas.Series.Add(p.FechaCompra.ToString());
                    
                    serie.Label = "Dia:"+ p.FechaCompra.Day.ToString();

                    serie.Points.Add((double)p.Total, p.FechaCompra.Day);
                }
            }
            graficoControlDinero();
        }



        private void graficoControlDinero()
        {
            
            chartControlDinero.Titles.Clear();

            DateTime date = DateTime.Now;
            listaControlDinero = NControlDinero.obtenerLista(1);
            var listaOrdenadaControlGasto = listaControlDinero.OrderBy(x => x.Fecha);

            chartControlDinero.Titles.Add("Ingresos y engresos " + date.Month + "-" + date.Year);
            decimal montoMas = 0, montoMenos =0;
            int i=0;
            foreach(tbControlDinero cd in listaOrdenadaControlGasto)
            {
                
                if (cd.Tipo == 1)
                {
                    montoMas = (decimal)cd.Monto;
                    chartControlDinero.Series["Ingreso"].Points.AddXY(cd.Fecha.Day, montoMas += montoMas);
                }
                if(cd.Tipo == 2)
                {
                    montoMenos = ((decimal)cd.Monto);
                    chartControlDinero.Series["Gastos"].Points.AddXY(cd.Fecha.Day, montoMenos += montoMenos);
                }
            }
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                DateTime dt = DateTime.Now;
                tbControlDinero controlDinero = new tbControlDinero();

                controlDinero.Fecha = dt.Date;
                controlDinero.Id = labelDate.Text + "/" + labelHora.Text;
                controlDinero.Tipo = cbTipo.SelectedIndex + 1;
                controlDinero.Monto = decimal.Parse(txtMonto.Text);
                controlDinero.DetalleExtra = txtDescripcion.Text.Trim();
                controlDinero.Estado = true;

                if (NControlDinero.guarda(controlDinero))
                {
                    MessageBox.Show("Se ingreso un monto", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limiarDatos();
                }
                else
                {
                    MessageBox.Show("Ocurrio un erro al ingresar el monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void limiarDatos()
        {
            cbTipo.Refresh();
            txtMonto.ResetText();
            txtDescripcion.ResetText();
            txtIdControlDinero.ResetText();
            txtFactura.ResetText();
            txtFecha.ResetText();
        }

        private bool validarDatos()
        {
            if(txtMonto.Text == string.Empty)
            {
                MessageBox.Show("Ingresa un monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonto.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
           if(txtMonto.Text.Length > 1)
            {
                if(txtDescripcion.Text == string.Empty)
                {
                    DateTime dt = DateTime.Now;
                    txtDescripcion.Text = ("Se realizo el día " + dt.Day + "/" + dt.Month + "/" + dt.Year);
                }
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puedes ingresar precios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void btnActualizarData_Click(object sender, EventArgs e)
        {
            cargarDataGVControlDinero();
            
        }

        private void cargarDataGVControlDinero()
        {
            try
            {
                listaControlDinero = NControlDinero.obtenerLista(1);
                dataGVControlDinero.Rows.Clear();
                dataGVControlDinero.Refresh();

                foreach (tbControlDinero cd in listaControlDinero)
                {
                    int nr = dataGVControlDinero.Rows.Add();
                    dataGVControlDinero.Rows[nr].Cells[0].Value = cd.Id;
                    dataGVControlDinero.Rows[nr].Cells[1].Value = cd.Fecha;
                    dataGVControlDinero.Rows[nr].Cells[2].Value = Enum.GetName(typeof(csEnums.Tipo), cd.Tipo);
                    dataGVControlDinero.Rows[nr].Cells[3].Value = cd.Monto;
                    dataGVControlDinero.Rows[nr].Cells[4].Value = cd.DetalleExtra;
                    dataGVControlDinero.Rows[nr].Cells[5].Value = cd.Factura;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTipo.SelectedIndex == 0)
            {
                pictureFlecha2.Visible = false;
                pictureFlecha1.Visible = true;
            }
            else
            {
                pictureFlecha1.Visible = false;
                pictureFlecha2.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGVControlDinero_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //saber que producto selecciono 
                int n = e.RowIndex;// index seleccionado 
                if (n != -1)
                {
                    string id = dataGVControlDinero.Rows[n].Cells[0].Value.ToString();//sacamos el id se la seleccion

                    tbControlDinero seleControlDinero;//creamos un objeto para poder almacenar el prducto

                    seleControlDinero = listaControlDinero.Where(x => x.Id.Trim() == id.Trim()).SingleOrDefault();

                    pasaDatos(seleControlDinero);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Erro " + E.Message + " te recomendamos seleccionar una casilla que contenga datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void pasaDatos(tbControlDinero seleControlDinero)
        {
            if(seleControlDinero.Factura == null)
            {
                txtMonto.Text = seleControlDinero.Monto.ToString();
                txtDescripcion.Text = seleControlDinero.DetalleExtra;
                cbTipo.SelectedIndex = (seleControlDinero.Tipo - 1);
                txtIdControlDinero.Text = seleControlDinero.Id.Trim();
                txtFactura.Text = seleControlDinero.Factura;
            }
            else
            {
                MessageBox.Show("No puedes moficar o eliminar si tinene una factura asociada " +
                    "para ello deberas ir a la sección de facturas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("Seguro que desea eliminar este registro", "Opción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opcion == DialogResult.Yes)
            {
                try
                {
                    tbControlDinero controlDinero = new tbControlDinero();

                    controlDinero = listaControlDinero.Where(x => x.Id.Trim() == txtIdControlDinero.Text.Trim()).FirstOrDefault();

                    controlDinero.Estado = false;

                    if (NControlDinero.eliminar(controlDinero))
                    {
                        MessageBox.Show("Se elimino un monto", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limiarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un erro al eliminar el monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Ocurrio un erro al eliminar el monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validarDatos() && (txtIdControlDinero.Text != string.Empty ))
            {
                try
                {
                    tbControlDinero controlDinero = new tbControlDinero();

                    controlDinero = listaControlDinero.Where(x => x.Id.Trim() == txtIdControlDinero.Text.Trim()).FirstOrDefault();

                    controlDinero.Tipo = cbTipo.SelectedIndex + 1;
                    controlDinero.Monto = decimal.Parse(txtMonto.Text);
                    controlDinero.DetalleExtra = txtDescripcion.Text.Trim();
                    controlDinero.Estado = true;

                    if (NControlDinero.modificar(controlDinero))
                    {
                        MessageBox.Show("Se modifico un monto", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limiarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un erro al modificar el monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Ocurrio un erro al modficar el monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
