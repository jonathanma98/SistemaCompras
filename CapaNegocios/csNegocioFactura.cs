using CapaEntidades;
using CapaUtilidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class csNegocioFactura : IGenerica<tbFactura>
    {
        csDatosFactura datos = new csDatosFactura();
        csDatosDetallesFactura dt = new csDatosDetallesFactura();
        csDatosControlDinero controlDiner = new csDatosControlDinero();
        List<tbControlDinero> listaControlDinero;
        List<tbFactura> listaFacura;
        List<tbDetalleFactura> listaDetaFac;
        public tbFactura consultarPorId(tbFactura entidad)
        {
            return datos.consultarPorId(entidad);
        }

        public bool eliminar(tbFactura entidad)
        {
            try
            {
               tbControlDinero cd = new tbControlDinero();
                cd = entidad.tbControlDinero.First();
                cd.Estado = false;
                entidad.Estado = false;
                if (controlDiner.eliminar(cd))
                {
                    return datos.eliminar(entidad);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool guarda(tbFactura entidad)
        {
            return datos.guarda(entidad);
        }

        public bool modificar(tbFactura entidad)
        {
            throw new NotImplementedException();
        }

        public List<tbFactura> obtenerLista(int estado)
        {
            return datos.obtenerLista(estado);
        }

        public List<tbFactura> obtenerListaId(string id)
        {
            return datos.obtenerListaId(id);
        }

        public bool GuardarFacura(tbFactura factura, List<tbDetalleFactura> listaDetalleFactura, List<tbProducto> listaProducto)
        {
            return datos.GuardarFacura(factura, listaDetalleFactura, listaProducto);
        }

        public bool ModificarFactura(tbFactura factura, List<tbDetalleFactura> listaDF, List<tbProducto> listaP)
        {
            
            listaDetaFac =dt.obtenerLista(1);
            foreach(tbDetalleFactura d in listaDetaFac)
            {
                //tbDetalleFactura detalleFactura = null;
                if (factura.IdFactura == d.IdFactura)
                {
                    tbDetalleFactura detalleFactura = (from c in listaDF
                                                       where c.Id == d.Id
                                                       select c).FirstOrDefault();
                    if(detalleFactura == null)
                    {
                        dt.eliminar(d);
                    }
                }
            }
            return datos.ModificarFactura(factura, listaDF, listaP);
        }
    }
}
