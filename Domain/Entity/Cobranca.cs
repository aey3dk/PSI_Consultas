using Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("COBRANCA_COB")]
    public class Cobranca : BaseEntity
    {
        [Column("COB_VALOR")]
        public Decimal Valor { get; set; }

        [Column("COB_STATUS")]
        public StatusCobrancaEnum Status { get; set; }
    }
}
