using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaUtilidades.Interfaces;
using CapaEntidades;

namespace CapaDatos
{
    public class DatosProductos : IGenerica<tbProducto>
    {
        public tbProducto consultarPorId(tbProducto entidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(tbProducto entidad)
        {
            try
            {
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    contex.Entry<tbProducto>(entidad).State = System.Data.Entity.EntityState.Modified;
                    contex.Entry<tbObjeto>(entidad.tbObjeto).State = System.Data.Entity.EntityState.Modified;
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool guarda(tbProducto entidad)
        {
            try
            {
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    contex.tbProducto.Add(entidad);
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool modificar(tbProducto entidad)
        {
            try
            {
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    contex.Entry<tbProducto>(entidad).State = System.Data.Entity.EntityState.Modified;
                    contex.Entry<tbObjeto>(entidad.tbObjeto).State = System.Data.Entity.EntityState.Modified;
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<tbProducto> obtenerLista(int estado)
        {
            bool est = true;
            if (estado == 1)
            {
                est = true;
            }
            else if(estado == 2)
            {
                est = false;
            }
            using(var context = new dbSistemaCompraEntities())
            {
                return (from c in context.tbProducto.Include("tbObjeto")
                        where c.Estado == est
                        select c).ToList();
            }
        }

        public List<tbProducto> obtenerListaId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
