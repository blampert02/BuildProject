﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RTCONSTRUCCIONES
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ConstructoraEntities : DbContext
    {
        public ConstructoraEntities()
            : base("name=ConstructoraEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Alquiler> Alquilers { get; set; }
        public DbSet<Cargo> Cargoes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetalleCompra> DetalleCompras { get; set; }
        public DbSet<DetalleEntrada> DetalleEntradas { get; set; }
        public DbSet<DetalleSalida> DetalleSalidas { get; set; }
        public DbSet<Empleado> Empleadoes { get; set; }
        public DbSet<Entrada_Inventario> Entrada_Inventario { get; set; }
        public DbSet<EntregaAlquiler> EntregaAlquilers { get; set; }
        public DbSet<Planilla> Planillas { get; set; }
        public DbSet<Producto> Productoes { get; set; }
        public DbSet<Proyecto> Proyectoes { get; set; }
        public DbSet<Salida_Inventario> Salida_Inventario { get; set; }
        public DbSet<TipoEmpleado> TipoEmpleadoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
