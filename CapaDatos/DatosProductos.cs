using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaUtilidades.Interfaces;
using CapaEntidades;
using System.Threading;

namespace CapaDatos
{
    public class DatosProductos : IGenerica<tbProducto>
    {
        public tbProducto consultarPorId(tbProducto entidad)
        {
            using (var context = new dbSistemaCompraEntities())
            {
                return (from c in context.tbProducto.Include("tbObjeto")
                        where c.Codigo == entidad.Codigo
                        select c).FirstOrDefault();
            }
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
                tbProductoProveedor PP;//Objeto de la tabla
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    contex.Entry<tbProducto>(entidad).State = System.Data.Entity.EntityState.Modified;
                    contex.Entry<tbObjeto>(entidad.tbObjeto).State = System.Data.Entity.EntityState.Modified;

                    PP = (from c in contex.tbProductoProveedor//Al modificar el objeto se debe saber ya existe y tiene una coleccion en la tabla
                          where c.idObjeto == entidad.tbObjeto.Codigo//si el codigo del producto tiene una relacion se debe entoces se debe remover
                          select c).FirstOrDefault();//y al remover ingresar el nuevo producto

                    if (PP == null)
                    {
                        contex.tbProductoProveedor.AddRange(entidad.tbObjeto.tbProductoProveedor);//Si no existe una relacion de ingresa un nuevo
                    }
                    else
                    {
                        var IColle = contex.tbProductoProveedor.Where(x => x.id == PP.id);//para poder eliminar se debe saber su posicion 
                        contex.tbProductoProveedor.RemoveRange(IColle);//el retorno de su posicion se elimina
                        contex.tbProductoProveedor.AddRange(entidad.tbObjeto.tbProductoProveedor);//y se agrega la nueva pocision 
                    }
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
                try
                {
                    return (from c in context.tbProducto.Include("tbObjeto")
                            where c.Estado == est
                            select c).ToList();
                }
                catch (Exception)
                {

                    return null;
                }
            }
        }

        public List<tbProducto> obtenerListaId(string id)
        {
            using (var context = new dbSistemaCompraEntities())
            {
                return (from c in context.tbProducto.Include("tbObjeto")
                        where c.Codigo == id
                        select c).ToList();
            }
        }
    }
}
