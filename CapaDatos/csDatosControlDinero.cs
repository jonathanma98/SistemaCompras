using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaUtilidades.Interfaces;
using CapaEntidades;

namespace CapaDatos
{
    public class csDatosControlDinero : IGenerica<tbControlDinero>
    {
        public tbControlDinero consultarPorId(tbControlDinero entidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(tbControlDinero entidad)
        {
            throw new NotImplementedException();
        }

        public bool guarda(tbControlDinero entidad)
        {
            try
            {
                using(dbSistemaCompraEntities context = new dbSistemaCompraEntities())
                {
                    context.tbControlDinero.Add(entidad);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public bool modificar(tbControlDinero entidad)
        {
            throw new NotImplementedException();
        }

        public List<tbControlDinero> obtenerLista(int estado)
        {
            DateTime año = DateTime.Now;
            try
            {
                if(estado == 1)
                {
                    using (var context = new dbSistemaCompraEntities())
                    {
                        return (from f in context.tbControlDinero
                                where f.Fecha.Month == año.Month && f.Fecha.Year == año.Year
                                select f).ToList();
                    }
                }
                else
                {
                    using (var context = new dbSistemaCompraEntities())
                    {
                        return (from f in context.tbControlDinero
                                where  f.Fecha.Year == año.Year
                                select f).ToList();
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<tbControlDinero> obtenerListaId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
