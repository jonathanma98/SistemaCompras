﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Threading.Tasks;
    using CapaEntidades;
    
    public partial class dbSistemaCompraEntities : DbContext
    {
        public dbSistemaCompraEntities()
            : base("name=dbSistemaCompraEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbAdmin> tbAdmin { get; set; }
        public virtual DbSet<tbCliente> tbCliente { get; set; }
        public virtual DbSet<tbClienteFactura> tbClienteFactura { get; set; }
        public virtual DbSet<tbControlDinero> tbControlDinero { get; set; }
        public virtual DbSet<tbFactura> tbFactura { get; set; }
        public virtual DbSet<tbObjeto> tbObjeto { get; set; }
        public virtual DbSet<tbPersona> tbPersona { get; set; }
        public virtual DbSet<tbProducto> tbProducto { get; set; }
        public virtual DbSet<tbProductoProveedor> tbProductoProveedor { get; set; }
        public virtual DbSet<tbProveedor> tbProveedor { get; set; }
        public virtual DbSet<tbProveedorFactura> tbProveedorFactura { get; set; }
    }
}
