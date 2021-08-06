using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaUtilidades.Interfaces;
using CapaEntidades;

namespace CapaDatos
{
    public class csDatosDetallesFactura : IGenerica<tbDetalleFactura>
    {
        public tbDetalleFactura consultarPorId(tbDetalleFactura entidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(tbDetalleFactura entidad)
        {
            try
            {
                using (dbSistemaCompraEntities context = new dbSistemaCompraEntities())
                {
                    context.Entry<tbDetalleFactura>(entidad).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool guarda(tbDetalleFactura entidad)
        {
            try
            {
                using(dbSistemaCompraEntities context = new dbSistemaCompraEntities())
                {
                    context.tbDetalleFactura.Add(entidad);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public bool modificar(tbDetalleFactura entidad)
        {
            throw new NotImplementedException();
        }

        public List<tbDetalleFactura> obtenerLista(int estado)
        {
            bool valo = true;
            if(estado == 2)
            {
                valo = false;
            }
            using (var context = new dbSistemaCompraEntities())
            {
                return (from c in context.tbDetalleFactura
                        where c.tbFactura.Estado == valo
                        select c).ToList();
            }
        }

        public List<tbDetalleFactura> obtenerListaId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
