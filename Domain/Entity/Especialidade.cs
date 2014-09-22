using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("ESPECIALIDADE_ESP")]
    public class Especialidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ESP_CODIGO")]
        [Range(1, 999999999999999)]
        public Int64 Codigo { get; set; }

        [Column("ESP_NOME")]
        [MaxLength(60)]
        public String Nome { get; set; }
        
        [Column("ESP_DESCRICAO")]
        [MaxLength(100)]
        public String Descricao { get; set; }
    }
}
