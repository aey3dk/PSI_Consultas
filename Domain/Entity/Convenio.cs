using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Obsolete("Classe obsoleta, substituída pela nova engenharia de comunicação com a base de dados")]
    [Table("CONVENIO_COV")]
    public class Convenio : BaseEntity
    {
        [Column("COV_NOME")]
        [MaxLength(60)]
        public String Nome { get; set; }

        [Column("COV_EMAIL")]
        [MaxLength(60)]
        public String Email { get; set; }

        [Column("COV_NUMEROCARTAO")]
        [Range(1, 9999999999999999)]
        public Int64 NumeroCartao { get; set; }

        [Column("COV_TIPOPLANOSAUDE")]
        public TipoPlanoSaudeEnum TipoPlanoSaude { get; set; }




        public virtual List<Telefone> Telefones { get; set; }

        public virtual List<Profissional> Profissionais { get; set; }
    }
}
