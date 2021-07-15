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
            //if (entidad.tbObjeto.tbProductoProveedor != null)
            //{
            //    tbProducto producto;
            //    producto = DProducto.consultarPorId(entidad);

            //    if (producto != null)
            //    {
            //        csDatosObjetoProveedor ObjProvee = new csDatosObjetoProveedor();
            //        List<tbProductoProveedor> listaObjProve;
            //        tbProductoProveedor PP = new tbProductoProveedor();

            //        listaObjProve = ObjProvee.obtenerListaId(entidad.tbObjeto.Codigo);
            //        if (listaObjProve != null)
            //        {
            //            foreach (tbProductoProveedor p in listaObjProve)
            //            {
            //                PP.id = p.id;
            //                PP.idObjeto = p.idObjeto;
            //                PP.idProveedor = p.idProveedor;
            //                PP.tbObjeto = p.tbObjeto;
            //                PP.tbProveedor = p.tbProveedor;
            //            }
            //            ObjProvee.modificar(PP);
            //        }
            //    }
            //}
            return DProducto.modificar(entidad);
        }

        public List<tbProducto> obtenerLista(int estado)
        {
            return DProducto.obtenerLista(estado);
        }

        public List<tbProducto> obtenerListaId(string id)
        {
            return DProducto.obtenerListaId(id);
        }
    }
}
