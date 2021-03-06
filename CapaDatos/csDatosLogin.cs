using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CapaUtilidades.Interfaces;
using CapaEntidades;

namespace CapaDatos
{
    public class csDatosLogin : IGenerica<tbAdmin>
    {
        public tbAdmin consultarPorId(tbAdmin entidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(tbAdmin entidad)
        {
            try
            {
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    contex.Entry<tbAdmin>(entidad).State = System.Data.Entity.EntityState.Deleted;
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool guarda(tbAdmin admin)
        {
            try
            {
                using (dbSistemaCompraEntities contex = new  dbSistemaCompraEntities())
                {
                    contex.tbAdmin.Add(admin);
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool modificar(tbAdmin entidad)
        {
            try
            {
                using (dbSistemaCompraEntities contex = new dbSistemaCompraEntities())
                {
                    contex.Entry<tbAdmin>(entidad).State = System.Data.Entity.EntityState.Modified;
                    contex.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<tbAdmin> obtenerLista(int estado)
        {
            int  op = estado;
            using (var context = new dbSistemaCompraEntities())
            {

                return (from c in context.tbAdmin
                        where c.id != ""
                        select c).ToList();
            }
        }

        public List<tbAdmin> obtenerListaId(string id)
        {
            using (var context = new dbSistemaCompraEntities())
            {
                try
                {
                    return (from c in context.tbAdmin
                            where c.id == id
                            select c).ToList();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
