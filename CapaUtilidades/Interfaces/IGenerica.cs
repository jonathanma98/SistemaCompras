using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaUtilidades.Interfaces
{
    public interface IGenerica<E>
    {
        bool guarda(E entidad);
        bool modificar(E entidad);
        bool eliminar(E entidad);
        List<E> obtenerLista(int estado);

        List<E> obtenerListaId(string id);

        E consultarPorId(E entidad);
    }
}
