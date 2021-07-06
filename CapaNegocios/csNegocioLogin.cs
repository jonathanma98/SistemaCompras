using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using CapaUtilidades.Interfaces;

namespace CapaNegocios
{
    public class csNegocioLogin : IGenerica<tbAdmin>
    {
        csDatosLogin dato = new csDatosLogin();
        public tbAdmin consultarPorId(tbAdmin entidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(tbAdmin entidad)
        {
            throw new NotImplementedException();
        }

        public bool guarda(tbAdmin entidad)
        {
            return dato.guarda(entidad);
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
            
            return dato.obtenerListaId(id);
        }
    }
}
