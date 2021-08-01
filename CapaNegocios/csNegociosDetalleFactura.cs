using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using CapaUtilidades.Interfaces;

namespace CapaNegocios
{
    public class csNegociosDetalleFactura : IGenerica<tbDetalleFactura>
    {
        csDatosDetallesFactura DDetalleFactur = new csDatosDetallesFactura();
        public tbDetalleFactura consultarPorId(tbDetalleFactura entidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(tbDetalleFactura entidad)
        {
            return DDetalleFactur.eliminar(entidad);
        }

        public bool guarda(tbDetalleFactura entidad)
        {
            return DDetalleFactur.guarda(entidad);
        }

        public bool modificar(tbDetalleFactura entidad)
        {
            throw new NotImplementedException();
        }

        public List<tbDetalleFactura> obtenerLista(int estado)
        {
            return DDetalleFactur.obtenerLista(estado);
        }

        public List<tbDetalleFactura> obtenerListaId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
