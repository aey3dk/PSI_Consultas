using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public enum TipoSalaEnum
    {
        Reservada,
        Ocupada,
        SemReserva
    }

    [Table("SALA_SAL")]
    public class Sala
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("SAL_NUMERO")]
        [Range(1, 999999999999999)]
        public Int64 Numero { get; set; }

        [Column("CON_STATUSCONSULTA")]
        public TipoSalaEnum Tipo { get; set; }


    }
}
