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
            try
            {
                using (dbSistemaCompraEntities context = new dbSistemaCompraEntities())
                {
                    context.tbFactura.Add(entidad);
                    context.SaveChanges();
                }
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool modificar(tbFactura entidad)
        {
            throw new NotImplementedException();
        }

        public List<tbFactura> obtenerLista(int estado)
        {
            using (var context = new dbSistemaCompraEntities())
            {
                return (from c in context.tbFactura
                        where c.Estado == true
                        select c).ToList();
            }
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
