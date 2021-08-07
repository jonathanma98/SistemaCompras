using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;
using CapaUtilidades;

namespace CapaPresentacion.FormsMostracion
{
    public partial class frmPapelera : Form
    {
        NegocioProductos NProductos = new NegocioProductos();
        csClienteNegocio NCliente = new csClienteNegocio();
        NegocioProveedor NegocioProveedor = new NegocioProveedor();
        csNegocioFactura NFactura = new csNegocioFactura();
        csNegocioControlDinero NContolDinero = new csNegocioControlDinero();

        List<tbProducto> listaProducto;
        List<tbCliente> listaCliente;
        List<tbProveedor> listaProveedor;
        List<tbFactura> listaFactura;
        List<tbControlDinero> listaCD;
        public frmPapelera()
        {
            InitializeComponent();
        }

        private void cargarDatosProductos()
        {
            listaProducto = NProductos.obtenerLista(2);
            foreach(tbProducto p  in listaProducto)
            {
                if(p.Estado == false)
                {
                    int nr = dataGVPapelera.Rows.Add();
                    dataGVPapelera.Rows[nr].Cells[0].Value = "Producto";
                    dataGVPapelera.Rows[nr].Cells[1].Value = p.Codigo;
                    dataGVPapelera.Rows[nr].Cells[2].Value = p.tbObjeto.Nombre;
                    dataGVPapelera.Rows[nr].Cells[3].Value = p.Descripcion;
                    dataGVPapelera.Rows[nr].Cells[4].Value = "Precio " + p.PrecioVenta.ToString();
                    dataGVPapelera.Rows[nr].Cells[5].Value = "";
                    dataGVPapelera.Rows[nr].Cells[6].Value = "Proveedor " + p.tbObjeto.Proveedor;
                }
            }
        }


        private void cargarDatosCliente()
        {
           listaCliente = NCliente.obtenerLista(2);
            foreach (tbCliente c in listaCliente)
            {
                if (c.Estado == false)
                {
                    int nr = dataGVPapelera.Rows.Add();
                    dataGVPapelera.Rows[nr].Cells[0].Value = "Cliente";
                    dataGVPapelera.Rows[nr].Cells[1].Value = c.Id;
                    dataGVPapelera.Rows[nr].Cells[2].Value = c.tbPersona.Nombre;
                    dataGVPapelera.Rows[nr].Cells[3].Value = c.tbPersona.Apellidos;
                    dataGVPapelera.Rows[nr].Cells[4].Value = "No contiene";
                    dataGVPapelera.Rows[nr].Cells[5].Value = "No contiene";
                    dataGVPapelera.Rows[nr].Cells[6].Value = "Tel " + c.tbPersona.Telefeno + "Dirección" + c.Direccion;
                }
            }
        }

        private void cargarDatosProveedor()
        {

        }

        private void cargarDatosFactura()
        {
           
            listaFactura = NFactura.obtenerLista(2);
            foreach (tbFactura f in listaFactura)
            {
                if (f.Estado == false)
                {
                    int nr = dataGVPapelera.Rows.Add();
                    dataGVPapelera.Rows[nr].Cells[0].Value = "Factura";
                    dataGVPapelera.Rows[nr].Cells[1].Value = f.IdFactura;
                    dataGVPapelera.Rows[nr].Cells[2].Value =  "A nombre de: "+ f.NombreAsocie;
                    dataGVPapelera.Rows[nr].Cells[3].Value = f.DetalleExtra;
                    dataGVPapelera.Rows[nr].Cells[4].Value = f.Total;
                    dataGVPapelera.Rows[nr].Cells[5].Value = f.FechaCompra;
                    dataGVPapelera.Rows[nr].Cells[6].Value = "Fue un " + Enum.GetName(typeof(csEnums.Tipo), f.Tipo);
                }
            }
        }

        private void cargarDatosControlDinero()
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGVPapelera.Rows.Clear();
            dataGVPapelera.Refresh();

            if (checkProducto.Checked == true)
            {
                cargarDatosProductos();
            }
            if (checkCliente.Checked == true)
            {
                cargarDatosCliente();
            }
            if (checkProveedor.Checked == true)
            {
                cargarDatosProveedor();
            }
            if (checkFactura.Checked == true)
            {
                cargarDatosFactura();
            }
            if (checkControlD.Checked == true)
            {
                cargarDatosControlDinero();
            }
        }
    }
}
