using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("PROFISSIONAL_PRO")]
    public class Profissional : PessoaFisica
    {
        [Column("PRO_NUMEROCONSELHO")]
        [Range(1, 999999999)]
        public Int32 NumeroConselho { get; set; }
    }
}
