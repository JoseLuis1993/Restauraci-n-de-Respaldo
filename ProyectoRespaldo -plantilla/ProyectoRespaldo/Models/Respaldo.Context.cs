﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoRespaldo.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RespaldosEntities : DbContext
    {
        public RespaldosEntities()
            : base("name=RespaldosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bitacora> Bitacora { get; set; }
        public virtual DbSet<Comando> Comando { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<maquina_virtual> maquina_virtual { get; set; }
        public virtual DbSet<politica> politica { get; set; }
        public virtual DbSet<servidor> servidor { get; set; }
    }
}
