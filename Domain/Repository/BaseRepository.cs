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
    }
}
