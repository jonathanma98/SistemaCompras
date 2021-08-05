using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaUtilidades.Interfaces;

namespace CapaDatos
{
    public class csDatosEmpresa : IGenerica<tbEmpresa>
    {
        public tbEmpresa consultarPorId(tbEmpresa entidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(tbEmpresa entidad)
        {
            throw new NotImplementedException();
        }

        public bool guarda(tbEmpresa entidad)
        {
            try
            {
                using (dbSistemaCompraEntities context = new dbSistemaCompraEntities())
                {
                    context.tbEmpresa.Add(entidad);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public bool modificar(tbEmpresa entidad)
        {
            try
            {
                using (dbSistemaCompraEntities context = new dbSistemaCompraEntities())
                {
                    context.Entry<tbEmpresa>(entidad).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public List<tbEmpresa> obtenerLista(int estado)
        {
            bool op = true;
            if (estado == 2)
            {
                op = false;
            }
            using (var context = new dbSistemaCompraEntities())
            {
                return (from c in context.tbEmpresa
                        where c.id >= 1
                        select c).ToList();
            }
        }

        public List<tbEmpresa> obtenerListaId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
