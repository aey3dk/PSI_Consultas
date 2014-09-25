using DAL.Generics;
using DAL.Model;
using System;

namespace DAL.Repository
{
    public class PacienteRepository : GenericRepository<Paciente, Int32>
    {
        public PacienteRepository() : base() { }

        public PacienteRepository(RepositorioContainer repositorio) : base(repositorio) { }
    }
}