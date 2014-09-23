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




        [Column("COB_IDRESERVA")]
        public Int64 IdReserva { get; set; }

        [ForeignKey("COB_IDRESERVA")]
        public virtual Reserva Reserva { get; set; }




        [Column("COB_IDCONSULTA")]
        public Int64 IdConsulta { get; set; }

        [ForeignKey("COB_IDCONSULTA")]
        public virtual Consulta Consulta { get; set; }
    }
}
