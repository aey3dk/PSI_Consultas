using Domain.Entity;
using System;
using System.Configuration;
using System.Data.Entity;

namespace Domain.Persistence
{
    public class Conexao : DbContext
    {
        public Conexao() : base(ConfigurationManager.ConnectionStrings["Local"].ConnectionString) { }

        public DbSet<Paciente> Paciente { get; set; }
    }
}
