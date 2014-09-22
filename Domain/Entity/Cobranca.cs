using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public enum StatusCobrancaEnum
    {
        Emaberto,
        EmNegociacao,
        Cancelada
    }

    [Table("COBRANCA_COB")]
    public class Cobranca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("COB_VALOR")]
        [Range(1, 999999999999999)]
        public Decimal Valor { get; set; }

        [Column("COB_STATUSCOBRANCA")]
        public StatusCobrancaEnum StatusCobranca { get; set; }
    }
}
