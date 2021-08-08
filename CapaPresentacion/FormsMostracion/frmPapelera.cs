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
            listaProveedor = NegocioProveedor.obtenerLista(2);
            foreach (tbProveedor p in listaProveedor)
            {
                if (p.Estado == false)
                {
                    int nr = dataGVPapelera.Rows.Add();
                    dataGVPapelera.Rows[nr].Cells[0].Value = "Proveedor";
                    dataGVPapelera.Rows[nr].Cells[1].Value = p.Id;
                    dataGVPapelera.Rows[nr].Cells[2].Value = p.tbPersona.Nombre;
                    dataGVPapelera.Rows[nr].Cells[3].Value = p.tbPersona.Apellidos;
                    dataGVPapelera.Rows[nr].Cells[4].Value = "No contiene";
                    dataGVPapelera.Rows[nr].Cells[5].Value = "No contiene";
                    dataGVPapelera.Rows[nr].Cells[6].Value = "Tel " + p.tbPersona.Telefeno + "Dirección" + p.Descripcion;
                }
            }
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
            listaCD = NContolDinero.obtenerLista(2);
            var listaCDOrdenada = listaCD.OrderByDescending(x => x.Fecha);
            foreach (tbControlDinero c in listaCDOrdenada)
            {
                if (c.Estado == false && c.Factura == null)
                {
                    int nr = dataGVPapelera.Rows.Add();
                    dataGVPapelera.Rows[nr].Cells[0].Value = "Control Dinero";
                    dataGVPapelera.Rows[nr].Cells[1].Value = c.Id;
                    dataGVPapelera.Rows[nr].Cells[2].Value = c.Tipo;
                    dataGVPapelera.Rows[nr].Cells[3].Value = c.DetalleExtra;
                    dataGVPapelera.Rows[nr].Cells[4].Value = c.Monto;
                    dataGVPapelera.Rows[nr].Cells[5].Value = c.Fecha;
                    dataGVPapelera.Rows[nr].Cells[6].Value = "No contiene";
                }
            }
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

        private void dataGVPapelera_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //saber que producto selecciono 
                int n = e.RowIndex;// index seleccionado 
                if (n != -1)
                {
                    string tipo = dataGVPapelera.Rows[n].Cells[0].Value.ToString();
                    string Codigo = dataGVPapelera.Rows[n].Cells[1].Value.ToString();
                    string Nombre = dataGVPapelera.Rows[n].Cells[2].Value.ToString();
                    string Ap = dataGVPapelera.Rows[n].Cells[3].Value.ToString();

                    DialogResult Opc = MessageBox.Show("Desea recuperar los datos de \n Id " + Codigo +
                        "\n nombre: " + Nombre + "\n Apellido / detalle " + Ap, "Dato tipo "+tipo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if((Opc == DialogResult.Yes) && (tipo.Trim() == "Producto"))
                    {
                        tbProducto seleProducto;//creamos un objeto para poder almacenar el prducto
                        seleProducto = listaProducto.Where(x => x.Codigo.Trim() == Codigo.Trim()).SingleOrDefault();
                        seleProducto.Estado = true;
                        if (NProductos.modificar(seleProducto))
                        {
                            MessageBox.Show("Se restablecio los datos", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido restablecio los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if ((Opc == DialogResult.Yes) && (tipo.Trim() == "Cliente"))
                    {
                        tbCliente seleCliente;//creamos un objeto para poder almacenar el prducto
                        seleCliente = listaCliente.Where(x => x.Id.Trim() == Codigo.Trim()).SingleOrDefault();
                        seleCliente.Estado = true;
                        if (NCliente.modificar(seleCliente))
                        {
                            MessageBox.Show("Se restablecio los datos", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido restablecio los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if ((Opc == DialogResult.Yes) && (tipo.Trim() == "Proveedor"))
                    {
                        tbProveedor seleProveedor;
                        seleProveedor = listaProveedor.Where(x => x.Id.Trim() == Codigo.Trim()).SingleOrDefault();
                        seleProveedor.Estado = true;
                        if (NegocioProveedor.modificar(seleProveedor))
                        {
                            MessageBox.Show("Se restablecio los datos", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido restablecio los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if ((Opc == DialogResult.Yes) && (tipo.Trim() == "Factura"))
                    {
                        tbFactura seleFactura;//creamos un objeto para poder almacenar el prducto
                        seleFactura = listaFactura.Where(x => x.IdFactura.Trim() == Codigo.Trim()).SingleOrDefault();
                        seleFactura.Estado = true;
                        if (NFactura.modificar(seleFactura))
                        {
                            MessageBox.Show("Se restablecio los datos", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido restablecio los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if ((Opc == DialogResult.Yes) && (tipo.Trim() == "Control Dinero"))
                    {
                        tbControlDinero selecCD;
                        selecCD = listaCD.Where(x => x.Id.Trim() == Codigo.Trim()).SingleOrDefault();
                        selecCD.Estado = true;
                        if (NContolDinero.modificar(selecCD))
                        {
                            MessageBox.Show("Se restablecio los datos", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido restablecio los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Erro " + E.Message + " te recomendamos seleccionar una casilla que contenga datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
