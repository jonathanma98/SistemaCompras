using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaUtilidades
{
    public static class csEnums
    {
        public enum estado
        {
            Activo = 1,
            Inactivo = 2
        }
        public enum Tipo
        {
            Ingreso = 1,
            Gatos = 2
        }

        public enum TipoID
        {
            Cedula = 1,
            DIMEX = 2,
            Juridica = 3,
            Nite = 4
        }
        public enum FormaMedida
        {
            Lt = 1, Kg =2, Ml = 2
        }

        public static List<string> Calificacion()
        {
            List<string> calificacion = new List<string>();
            calificacion.Add("☆");
            calificacion.Add("☆☆");
            calificacion.Add("☆☆☆");

            return calificacion;
        }
    }
}
