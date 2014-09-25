using DAL.Generics;
using DAL.Model;
using System;

namespace DAL.Repository
{
    public class ProfissionalRepository : GenericRepository<Profissional, Int32> {

        public ProfissionalRepository() : base() { }

        public ProfissionalRepository(RepositorioContainer repositorio) : base(repositorio) { }
    }
}