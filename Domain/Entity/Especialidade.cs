using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Obsolete("Classe obsoleta, substituída pela nova engenharia de comunicação com a base de dados")]
    [Table("ESPECIALIDADE_ESP")]
    public class Especialidade : BaseEntity
    {
        [Column("ESP_NOME")]
        [MaxLength(60)]
        public String Nome { get; set; }

        [Column("ESP_DESCRICAO")]
        [MaxLength(60)]
        public String Descricao { get; set; }



        public virtual List<Profissional> Profissionais { get; set; }
    }
}
