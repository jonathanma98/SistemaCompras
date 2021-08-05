using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaUtilidades.Interfaces;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocios
{
    public class csNegocioEmpresa : IGenerica<tbEmpresa>
    {
        csDatosEmpresa empresa = new csDatosEmpresa();
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
            return empresa.guarda(entidad);
        }

        public bool modificar(tbEmpresa entidad)
        {
            return empresa.modificar(entidad);
        }

        public List<tbEmpresa> obtenerLista(int estado)
        {
            return empresa.obtenerLista(estado);
        }

        public List<tbEmpresa> obtenerListaId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
