using Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("CONSULTA_CON")]
    public class Consulta : BaseEntity
    {
        [Column("CON_DATAHORA")]
        public DateTime DataHora { get; set; }

        [Column("CON_OBSEVACAO")]
        [MaxLength(400)]
        public String Observacao { get; set; }

        [Column("CON_STATUS")]
        public StatusConsultaEnum Status { get; set; }
    }
}
