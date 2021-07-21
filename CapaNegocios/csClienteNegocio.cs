using CapaEntidades;
using CapaUtilidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaNegocios
{
    public class csClienteNegocio : IGenerica<tbCliente>
    {
        //creamos la innstancia de nuestra clase en datos
        csClienteDatos ClienteDatos = new csClienteDatos();
        public tbCliente consultarPorId(tbCliente entidad)
        {
            return ClienteDatos.consultarPorId(entidad);
        }

        public bool eliminar(tbCliente entidad)
        {
            return ClienteDatos.eliminar(entidad);
        }

        public bool guarda(tbCliente entidad)
        {
            return ClienteDatos.guarda(entidad);
        }

        public bool modificar(tbCliente entidad)
        {
            return ClienteDatos.modificar(entidad);
        }

        public List<tbCliente> obtenerLista(int estado)
        {
            return ClienteDatos.obtenerLista(estado);
        }

        public List<tbCliente> obtenerListaId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
