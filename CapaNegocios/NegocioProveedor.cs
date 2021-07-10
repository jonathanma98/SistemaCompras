using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaUtilidades.Interfaces;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
    public class NegocioProveedor : IGenerica<tbProveedor>
    {
        DatosProveedor Dproveedor = new DatosProveedor();

        public tbProveedor consultarPorId(tbProveedor entidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(tbProveedor entidad)
        {
            return Dproveedor.eliminar(entidad);
        }

        public bool guarda(tbProveedor entidad)
        {
            return Dproveedor.guarda(entidad);
        }

        public bool modificar(tbProveedor entidad)
        {
            return Dproveedor.modificar(entidad);
        }

        public List<tbProveedor> obtenerLista(int estado)
        {
            return Dproveedor.obtenerLista(estado);
        }

        public List<tbProveedor> obtenerListaId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
