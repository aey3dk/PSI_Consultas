﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("PACIENTE_PAC")]
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("PAC_CODIGO")]
        [Range(1, 999999999999999)]
        public Int64 Codigo { get; set; }

        [Column("PAC_NOME")]
        [MaxLength(60)]
        public String Nome { get; set; }

        [Column("PAC_DATANASCIMENTO")]
        public DateTime DataNascimento { get; set; }

        [Column("PAC_CPF")]
        [MaxLength(14)]
        public String CPF { get; set; }

        [Column("PAC_EMAIL")]
        public String Email { get; set; }
    }
}
