using Domain.Entity;
using System.Configuration;
using System.Data.Entity;

namespace Domain.Persistence
{
    public class Conexao : DbContext
    {
        public Conexao() : base(ConfigurationManager.ConnectionStrings["Local"].ConnectionString) { }

        public DbSet<Paciente> Paciente { get; set; }

        public void RecriarBanco()
        {
            using (Conexao con = new Conexao())
            {
                if (con.Database.Exists())
                {
                    con.Database.Delete();
                }
            }
        }
    }
}
