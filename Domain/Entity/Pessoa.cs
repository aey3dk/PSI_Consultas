using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("PESSOA_PES")]
    public class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("PES_NOME")]
        [MaxLength(60)]
        public String Nome { get; set; }

        [Column("PES_EMAIL")]
        public String Email { get; set; }
    }
}
