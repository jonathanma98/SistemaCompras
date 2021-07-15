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
            try
            {
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    entidad = contex.tbProveedor.Include("tbPersona").Where(x => 
                    x.Id == entidad.Id && x.Estado == true).FirstOrDefault();
                }
                return entidad;
            }
            catch (Exception e)
            {
                return null;
            }
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
            bool est = true;
            if (estado == 1)
            {
                est = true;
            }
            else if (estado == 2)
            {
                est = false;
            }

            using (var context = new dbSistemaCompraEntities())
            {
                return (from c in context.tbProveedor.Include("tbPersona")
                        where c.Estado == est
                        select c).ToList();
            }
        }

        public List<tbProveedor> obtenerListaId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
