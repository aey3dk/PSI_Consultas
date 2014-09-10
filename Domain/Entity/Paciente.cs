using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("PACIENTE_PAC")]
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PAC_CODIGO")]
        public Int32 Codigo { get; set; }

        [Column("PAC_DESCRICAO")]
        [StringLength(60)]
        public String Descricao { get; set; }

        [Column("PAC_DATANASCIMENTO")]
        public DateTime DataNascimento { get; set; }
    }
}
