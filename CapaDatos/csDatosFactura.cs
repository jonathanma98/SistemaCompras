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
            using (var context = new dbSistemaCompraEntities())
            {
                return (from c in context.tbFactura.Include("tbControlDinero")
                        where c.IdFactura == entidad.IdFactura && c.Estado == true
                        select c).FirstOrDefault();
            }
        }

        public bool eliminar(tbFactura entidad)
        {
            try
            {
                using(dbSistemaCompraEntities context = new dbSistemaCompraEntities())
                {
                    context.Entry<tbFactura>(entidad).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
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
            bool evaluar = true;
            if(estado == 2)
            {
                evaluar = false;
            }
            using (var context = new dbSistemaCompraEntities())
            {
                return (from c in context.tbFactura.Include("tbDetalleFactura")
                        where c.Estado == evaluar
                        select c).ToList();
            }
        }


        public List<tbFactura> obtenerListaId(string id)
        {
            using (var context = new dbSistemaCompraEntities())
            {
                return (from c in context.tbFactura
                        where c.IdFactura == id && c.Estado == true
                        select c).ToList();
            }
        }


        public bool ModificarFactura(tbFactura factura, List<tbDetalleFactura> listaDF, List<tbProducto> listaP)
        {
            try
            {
                using (dbSistemaCompraEntities context = new dbSistemaCompraEntities())
                {
                    tbFactura F = (from c in context.tbFactura
                                   where c.IdFactura == factura.IdFactura
                                   select c).FirstOrDefault();

                    F.Total = factura.Total;
                    F.Tipo = factura.Tipo;
                    context.Entry<tbFactura>(F).State = System.Data.Entity.EntityState.Modified;
                    tbControlDinero CD = new tbControlDinero();
                    foreach(tbControlDinero infCD in factura.tbControlDinero)
                    {
                        CD.Id = infCD.Id;
                    }
                    CD = (from c in context.tbControlDinero
                          where c.Id == CD.Id
                          select c).FirstOrDefault();

                    CD.Monto = factura.Total;
                   
                    context.Entry<tbControlDinero>(CD).State = System.Data.Entity.EntityState.Modified;

                    foreach (tbDetalleFactura lis in  listaDF)//agregamos los detalles de la factura 
                    {
                        if(lis.Id > 0)
                        {
                            context.Entry<tbDetalleFactura>(lis).State = System.Data.Entity.EntityState.Modified;
                        }
                        else
                        {
                            context.tbDetalleFactura.Add(lis);
                        }
                        
                    }
                    foreach (tbProducto lisp in listaP)//Modificamos los producto en su cantidad 
                    {
                        context.Entry<tbProducto>(lisp).State = System.Data.Entity.EntityState.Modified;
                    }
                    context.SaveChanges();

                }
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }


        public bool GuardarFacura(tbFactura factura, List<tbDetalleFactura> listaDetalleFactura, List<tbProducto> listaProductos)
        {
            try
            {
                using (dbSistemaCompraEntities context = new dbSistemaCompraEntities())
                {
                    context.tbFactura.Add(factura);//se agrega la factura

                    foreach(tbDetalleFactura lis in listaDetalleFactura)//agregamos los detalles de la factura 
                    {
                        context.tbDetalleFactura.Add(lis);
                    }
                    foreach(tbProducto lisp in listaProductos)//Modificamos los producto en su cantidad 
                    {
                        context.Entry<tbProducto>(lisp).State = System.Data.Entity.EntityState.Modified;
                        context.Entry<tbObjeto>(lisp.tbObjeto).State = System.Data.Entity.EntityState.Modified;
                    }
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }
        
    }
}
