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
    
    public partial class tbProductoProveedor
    {
        public int id { get; set; }
        public string idProveedor { get; set; }
        public int idObjeto { get; set; }
    
        public virtual tbObjeto tbObjeto { get; set; }
        public virtual tbProveedor tbProveedor { get; set; }
    }
}