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

        public enum FacturaPara
        {
            C = 1,
            P = 2
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
            miligramo = 1, gramo = 2, Kilogramo = 3, libra = 4, mililitro = 5, litro = 6, onza = 7
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
