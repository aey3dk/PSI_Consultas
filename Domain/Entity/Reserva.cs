using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("RESERVA_RES")]
    public class Reserva : BaseEntity
    {
        [Column("RES_DATAHORA")]
        public DateTime DataHora { get; set; }
    }
}
