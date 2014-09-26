using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Obsolete("Classe obsoleta, substituída pela nova engenharia de comunicação com a base de dados")]
    [Table("RESERVA_RES")]
    public class Reserva : BaseEntity
    {
        [Column("RES_DATAHORA")]
        public DateTime DataHora { get; set; }




        [Column("RES_IDPROFISSIONAL")]
        public Int64 IdProfissional { get; set; }

        [ForeignKey("IdProfissional")]
        public virtual Profissional Profissional { get; set; }




        [Column("RES_IDSALA")]
        public Int64 IdSala { get; set; }

        [ForeignKey("IdSala")]
        public virtual Sala Sala { get; set; }




        [Column("RES_IDCOBRANCA")]
        public Int64 IdCobranca { get; set; }

        [ForeignKey("IdCobranca")]
        public virtual Cobranca Cobranca { get; set; }
    }
}
