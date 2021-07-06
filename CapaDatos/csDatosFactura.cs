using CapaEntidades;
using CapaUtilidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class csDatosFactura : IGenerica<tbFactura>
    {
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
            throw new NotImplementedException();
        }

        public bool modificar(tbFactura entidad)
        {
            throw new NotImplementedException();
        }

        public List<tbFactura> obtenerLista(int estado)
        {
            throw new NotImplementedException();
        }


        public List<tbFactura> obtenerListaId(string id)
        {
            using (var context = new dbSistemaCompraEntities())
            {
                return (from c in context.tbFactura
                        where c.IdFactura == id
                        select c).ToList();
            }
        }
    }
}
