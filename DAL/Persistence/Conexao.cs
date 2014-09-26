using Domain.Entity;
using System;
using System.Configuration;
using System.Data.Entity;

namespace DAL.Persistence
{
    [Obsolete("Classe obsoleta, substituída pela nova engenharia de comunicação com a base de dados")]
    public class Conexao : DbContext
    {
        public Conexao() : base(ConfigurationManager.ConnectionStrings["Local"].ConnectionString) { }
        public DbSet<Cobranca> Cobranca { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Convenio> Convenio { get; set; }
        public DbSet<Documento> Documento { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Profissional> Profissional { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<Sala> Sala { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
    }
}












