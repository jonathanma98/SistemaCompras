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

        public tbFactura consultarPorId(tbFactura entidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(tbFactura entidad)
        {
            throw new NotImplementedException();
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
    }
}
