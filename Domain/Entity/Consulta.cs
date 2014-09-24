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




        [ForeignKey("Paciente")]
        public Int64 IdPaciente { get; set; }

        [ForeignKey("IdPaciente")]
        public virtual Paciente Paciente { get; set; }




        [Column("CON_IDPROFISSIONAL")]
        public Int64 IdProfissional { get; set; }

        [ForeignKey("IdProfissional")]
        public virtual Profissional Profissional { get; set; }




        [Column("CON_IDCOBRANCA")]
        public Int64 IdCobranca { get; set; }

        [ForeignKey("IdCobranca")]
        public virtual Cobranca Cobranca { get; set; }
    }
}
