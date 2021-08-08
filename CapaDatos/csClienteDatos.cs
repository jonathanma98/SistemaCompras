using CapaEntidades;
using CapaUtilidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class csClienteDatos : IGenerica<tbCliente>
    {
        public tbCliente consultarPorId(tbCliente entidad)
        {
            try
            {
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    entidad = contex.tbCliente.Include("tbPersona").Where(x =>
                    x.Id == entidad.Id && x.Estado == true).FirstOrDefault();
                }
                return entidad;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool eliminar(tbCliente entidad)
        {
            try
            {
                //Interactura con nuestra BD, le indica que se va a eliminar un dato.
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    contex.Entry<tbCliente>(entidad).State = System.Data.Entity.EntityState.Modified;
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool guarda(tbCliente entidad)
        {
            try
            {
                //Interactura con nuestra BD, le indica que se va a guardar un dato.
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    contex.tbCliente.Add(entidad);
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool modificar(tbCliente entidad)
        {
            try
            {
                //nos comunicamos con nuestra DB y le indicamos modificar
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    contex.Entry<tbCliente>(entidad).State = System.Data.Entity.EntityState.Modified;
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

        public List<tbCliente> obtenerLista(int estado)
        {
            /*Interectuar con nuestra BD, le indica consultar los datos
            * enviados x el usuario y los devuelve si existen dentro de ella*/

            bool est = true;
            if (estado == 2)
            {
                est = false;
            }
            try
            {
                using (var context = new dbSistemaCompraEntities())
                {
                    //lenguaje linq para realizar querys a nuestra BD
                    return (from c in context.tbCliente.Include("tbPersona")
                            where c.Estado == est
                            select c).ToList();
                }
            }
            catch (Exception e)
            {
                List<tbCliente> lista = new List<tbCliente>();
                tbCliente cliente = new tbCliente();
                cliente.Id = "null";
                lista.Add(cliente);
                return lista;
            }
           
        }

        public List<tbCliente> obtenerListaId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
