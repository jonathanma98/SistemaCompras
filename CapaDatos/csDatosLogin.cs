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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<tbAdmin> obtenerLista(int estado)
        {
            throw new NotImplementedException();
        }

        public List<tbAdmin> obtenerListaId(string id)
        {
            using (var context = new dbSistemaCompraEntities())
            {

                return (from c in context.tbAdmin
                        where c.id == id
                        select c).ToList();
            }
        }
    }
}
