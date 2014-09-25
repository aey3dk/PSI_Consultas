using DAL.Generics;
using DAL.Model;
using System;

namespace DAL.Repository
{
    public class ConsultaRepository : GenericRepository<Consulta, Int32>
    {
        public ConsultaRepository() : base() { }

        public ConsultaRepository(RepositorioContainer repositorio) : base(repositorio) { }
    }
}