using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaUtilidades.Interfaces;

namespace CapaDatos
{
    public class DatosProveedor : IGenerica<tbProveedor>
    {
        public tbProveedor consultarPorId(tbProveedor entidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(tbProveedor entidad)
        {
            try
            {
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    contex.Entry<tbProveedor>(entidad).State = System.Data.Entity.EntityState.Modified;
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool guarda(tbProveedor entidad)
        {
            try
            {
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    contex.tbProveedor.Add(entidad);
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool modificar(tbProveedor entidad)
        {
            try
            {
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    contex.Entry<tbProveedor>(entidad).State = System.Data.Entity.EntityState.Modified;
                    contex.Entry<tbPersona>(entidad.tbPersona).State = System.Data.Entity.EntityState.Modified;
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<tbProveedor> obtenerLista(int estado)
        {
            int est = estado;

            using(var context = new dbSistemaCompraEntities())
            {
                return (from c in context.tbProveedor.Include("tbPersona")
                        where c.Estado == true
                        select c).ToList();
            }
        }

        public List<tbProveedor> obtenerListaId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
