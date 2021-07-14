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
    public class NegocioProductos : IGenerica<tbProducto>
    {
        DatosProductos DProducto = new DatosProductos();
        public tbProducto consultarPorId(tbProducto entidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(tbProducto entidad)
        {
            return DProducto.eliminar(entidad);
        }

        public bool guarda(tbProducto entidad)
        {
            return DProducto.guarda(entidad);
        }

        public bool modificar(tbProducto entidad)
        {
            return DProducto.modificar(entidad);
        }

        public List<tbProducto> obtenerLista(int estado)
        {
            return DProducto.obtenerLista(estado);
        }

        public List<tbProducto> obtenerListaId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
