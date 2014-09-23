using DAL.Generics;
using Domain.Entity;
using System;

namespace DAL.Repository
{
    public class PacienteRepository : GenericRepository<Paciente, Int32> { }
}