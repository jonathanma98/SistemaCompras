using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaUtilidades.Interfaces;
using CapaEntidades;

namespace CapaDatos
{
    public class csDatosObjetoProveedor : IGenerica<tbProductoProveedor>
    {
        public tbProductoProveedor consultarPorId(tbProductoProveedor entidad)
        {
            try
            {
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    entidad = contex.tbProductoProveedor.Where(x => 
                    x.idObjeto == entidad.idObjeto && x.idProveedor == entidad.idProveedor).FirstOrDefault();
                }
                return entidad;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool eliminar(tbProductoProveedor entidad)
        {
            throw new NotImplementedException();
        }

        public bool guarda(tbProductoProveedor entidad)
        {
            try
            {
                using (dbSistemaCompraEntities context = new dbSistemaCompraEntities())
                {
                    context.tbProductoProveedor.Add(entidad);
                    context.SaveChanges();
                }
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
            
        }

        public bool modificar(tbProductoProveedor entidad)
        {
            try
            {
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    contex.Entry<tbProductoProveedor>(entidad).State = System.Data.Entity.EntityState.Modified;
                    contex.Entry<tbObjeto>(entidad.tbObjeto).State = System.Data.Entity.EntityState.Modified;
                    contex.Entry<tbProveedor>(entidad.tbProveedor).State = System.Data.Entity.EntityState.Modified;
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<tbProductoProveedor> obtenerLista(int estado)
        {
            throw new NotImplementedException();
        }

        public List<tbProductoProveedor> obtenerListaId(string id)
        {
            using (var context = new dbSistemaCompraEntities())
            {
                return (from c in context.tbProductoProveedor
                        where c.idObjeto.Trim() == id.Trim()  
                        select c).ToList();
            }
        }
    }
}
