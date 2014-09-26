using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Obsolete("Classe obsoleta, substituída pela nova engenharia de comunicação com a base de dados")]
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(1, 999999999999999)]
        [Column("CODIGO")]
        public Int64 Codigo { get; set; }
    }
}