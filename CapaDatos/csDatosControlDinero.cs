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
            throw new NotImplementedException();
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
                using (var context = new dbSistemaCompraEntities())
                {
                    return (from f in context.tbControlDinero
                            where f.Fecha.Month == estado && f.Fecha.Year == año.Year
                            select f).ToList();
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
