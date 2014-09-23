using DAL.Generics;
using Domain.Entity;
using System;

namespace DAL.Repository
{
    public class PessoaRepository : GenericDalEntity<Pessoa, Int32> { }
}