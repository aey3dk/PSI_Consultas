﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RepositorioContainer : DbContext
    {
        public RepositorioContainer()
            : base("name=RepositorioContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<Convenio> Convenio { get; set; }
        public virtual DbSet<Documento> Documento { get; set; }
        public virtual DbSet<Telefone> Telefone { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Sala> Sala { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }
        public virtual DbSet<Cobranca> Cobranca { get; set; }
        public virtual DbSet<Consulta> Consulta { get; set; }
        public virtual DbSet<Especialidade> Especialidade { get; set; }
    
        public virtual int sp_MScleanupmergepublisher()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_MScleanupmergepublisher");
        }
    
        public virtual int sp_MSrepl_startup()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_MSrepl_startup");
        }
    }
}
