using Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("CONVENIO_COV")]
    public class Convenio : BaseEntity
    {
        [Column("COV_NOME")]
        [MaxLength(60)]
        public String Nome { get; set; }

        [Column("COV_EMAIL")]
        [MaxLength(60)]
        public String Email { get; set; }

        [Column("COV_NUMEROCARTAO")]
        [MaxLength(20)]
        public Int64 NumeroCartao { get; set; }

        [Column("COV_TIPOPLANOSAUDE")]
        [MaxLength(60)]
        public TipoPlanoSaudeEnum TipoPlanoSaude { get; set; }
    }
}
