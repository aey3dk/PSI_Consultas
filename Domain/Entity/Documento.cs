﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("DOCUMENTO_DOC")]
    public class Documento : BaseEntity
    {
        [Column("DOC_DESCRICAO")]
        [MaxLength(60)]
        public String Descricao { get; set; }




        [Column("DOC_IDPESSOAFISICA")]
        public Int64 IdPessoaFisica { get; set; }

        [ForeignKey("DOC_IDPESSOAFISICA")]
        public virtual PessoaFisica PessoaFisica { get; set; }
    }
}
