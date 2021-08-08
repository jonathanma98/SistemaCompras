using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using CapaUtilidades.Interfaces;

namespace CapaNegocios
{
    public class csNegocioControlDinero : IGenerica<tbControlDinero>
    {
        csDatosControlDinero DControlDinero = new csDatosControlDinero();
        public tbControlDinero consultarPorId(tbControlDinero entidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(tbControlDinero entidad)
        {
            return DControlDinero.eliminar(entidad);
        }

        public bool guarda(tbControlDinero entidad)
        {
            return DControlDinero.guarda(entidad);
        }

        public bool modificar(tbControlDinero entidad)
        {
            return DControlDinero.modificar(entidad);
        }

        public List<tbControlDinero> obtenerLista(int estado)
        {
            return DControlDinero.obtenerLista(estado);
        }

        public List<tbControlDinero> obtenerListaId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
