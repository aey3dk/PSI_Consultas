using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public enum TipoPlanoSaudeEnum
    {
        Basico,
        Intermediario,
        Completo
    }

    [Table("CONVENIO_COV")]
    public class Convenio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("COV_NOME")]
        [MaxLength(60)]
        public String Nome { get; set; }

        [Column("COV_TIPOPLANO")]
        [MaxLength(60)]
        public TipoPlanoSaudeEnum Tipoplano { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("COV_NUMEROCARTAO")]
        [MaxLength(20)]
        public Int64 NumeroCartao { get; set; }
    }
}
