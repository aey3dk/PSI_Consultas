using Domain.Entity;
using Domain.Persistence;
using System;

namespace Domain.Repository
{
    public class BaseRepository
    {
        public void RecriarBaseDados()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    if (con.Database.Exists())
                    {
                        con.Database.Delete();
                        con.Database.Create();
                        con.Dispose();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + e.InnerException ?? " - " + e.InnerException.Message);
            }
        }

        public void PopularBaseDados()
        {
            try
            {
                var repositorio = new PacienteRepository();
                for (int i = 1; i <= 9; i++)
                {
                    var ind = i.ToString();
                    repositorio.Salvar(new Paciente
                    {
                        Codigo = i + 10,
                        Nome = "Paciente " + i + " gerado automaticamente.",
                        DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
                        CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                        Email = "paciente" + i + "@gmail.com"
                    });
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + e.InnerException ?? " - " + e.InnerException.Message);
            }
        }
    }
}
