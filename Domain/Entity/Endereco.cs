using Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("ENDERECO_END")]
    public class Endereco : BaseEntity
    {
        [Column("END_CEP")]
        [Range(1, 99999999)]
        public Int32 CEP { get; set; }

        [Column("END_LOGRADORO")]
        [MaxLength(20)]
        public String Logradoro { get; set; }

        [Column("END_NUMERO")]
        [Range(1, 99999)]
        public Int32 Numero { get; set; }

        [Column("END_COMPLEMENTO")]
        [MaxLength(60)]
        public String Complemento { get; set; }

        [Column("END_BAIRRO")]
        [MaxLength(30)]
        public String Bairro { get; set; }

        [Column("END_CIDADE")]
        [MaxLength(60)]
        public String Cidade { get; set; }

        [Column("END_UF")]
        [MaxLength(2)]
        public String UF { get; set; }

        [Column("END_UF")]
        [MaxLength(60)]
        public String Pais { get; set; }

        [Column("END_TIPOLOGRADORO")]
        [MaxLength(60)]
        public TipoMoradiaEnum TipoMoradia { get; set; }
    }
}
