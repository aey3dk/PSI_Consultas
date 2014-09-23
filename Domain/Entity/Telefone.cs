﻿using Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("TELEFONE_TEL")]
    public class Telefone : BaseEntity
    {
        [Column("TEL_DDI")]
        [Range(1, 999)]
        public Int16 DDI { get; set; }

        [Column("TEL_DDD")]
        [Range(1, 999)]
        public Int16 DDD { get; set; }

        [Column("TEL_NUMERO")]
        [Range(1, 999999999)]
        public Int16 Numero { get; set; }

        [Column("TEL_RAMAL")]
        [Range(1, 99999)]
        public Int32 Ramal { get; set; }

        [Column("TEL_TIPO")]
        public TipoTelefoneEnum Tipo { get; set; }
    }
}
