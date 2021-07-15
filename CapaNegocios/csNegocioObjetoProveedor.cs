using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaUtilidades.Interfaces;
using CapaDatos;

namespace CapaNegocios
{
    public class csNegocioObjetoProveedor : IGenerica<tbProductoProveedor>
    {
        csDatosObjetoProveedor ObjProveedor = new csDatosObjetoProveedor();
        List<tbProductoProveedor> lisP = new List<tbProductoProveedor>();

        public tbProductoProveedor consultarPorId(tbProductoProveedor entidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(tbProductoProveedor entidad)
        {
            return ObjProveedor.eliminar(entidad);
        }

        public bool guarda(tbProductoProveedor entidad)
        {
            return ObjProveedor.guarda(entidad);
        }

        public bool modificar(tbProductoProveedor entidad)
        {
            tbProductoProveedor ObjProve;
            ObjProve = ObjProveedor.consultarPorId(entidad);
            if (ObjProve != null)
            {
                return ObjProveedor.modificar(entidad);
            }
            else
            {
                return ObjProveedor.guarda(entidad);
            }
        }

        public List<tbProductoProveedor> obtenerLista(int estado)
        {
            estado = 1;
            using(var context = new dbSistemaCompraEntities())
            {
                return (from c in context.tbProductoProveedor
                        where c.id >= 0
                        select c).ToList();
            }

        }

        public List<tbProductoProveedor> obtenerListaId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
