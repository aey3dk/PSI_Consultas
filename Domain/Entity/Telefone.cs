using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public enum TipoTelefoneEnum
    {
        CELULAR,
        RESIDENCIAL,
        COMERCIAL
    }

    [Table("TELEFONE_TEL")]
    public class Telefone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("TEL_TIPOTELEFONE")]
        public TipoTelefoneEnum TipoTelefone { get; set; }

        [Column("TEL_DDI")]
        [MaxLength(3)]
        public String DDI { get; set; }

        [Column("TEL_DDD")]
        [MaxLength(3)]
        public String DDD { get; set; }

        [Column("TEL_NUMERO")]
        [MaxLength(10)]
        public String Numero { get; set; }
    }
}
