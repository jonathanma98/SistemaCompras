//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaEntidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbProducto
    {
        public int Codigo { get; set; }
        public byte[] Descripcion { get; set; }
        public int FormaMedida { get; set; }
        public string Medida { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        public virtual tbObjeto tbObjeto { get; set; }
    }
}
