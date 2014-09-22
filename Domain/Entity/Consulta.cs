using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public enum StatusConsultaEnum
    {
        Marcada,
        EmAndamento,
        Cancelada
    }

    [Table("CONSULTA_CON")]
    public class Consulta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("CON_DATAHORA")]
        public DateTime DataHora { get; set; }

        [Column("CON_OBSEVACAO")]
        [MaxLength(400)]
        public String Observacao { get; set; }

        [Column("CON_STATUSCONSULTA")]
        public StatusConsultaEnum StatusConsulta { get; set; }
    }
}
