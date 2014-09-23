using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("PACIENTE_PAC")]
    public class Paciente : PessoaFisica { }
}
