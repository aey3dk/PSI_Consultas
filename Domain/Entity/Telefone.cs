using Domain.Enum;
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
        public Int32 Numero { get; set; }

        [Column("TEL_RAMAL")]
        [Range(1, 999999)]
        public Int32 Ramal { get; set; }

        [Column("TEL_TIPO")]
        public TipoTelefoneEnum Tipo { get; set; }




        [Column("TEL_IDPESSOAFISICA")]
        public Int64 IdPessoaFisica { get; set; }

        [ForeignKey("TEL_IDPESSOAFISICA")]
        public virtual PessoaFisica PessoaFisica { get; set; }




        [Column("TEL_IDCONVENIO")]
        public Int64 IdConvenio { get; set; }

        [ForeignKey("TEL_IDCONVENIO")]
        public virtual Convenio Convenio { get; set; }
    }
}
