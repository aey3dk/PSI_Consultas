using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public enum TipoEnderecoEnum
    {
        Casa,
        Apartamento,
        Flat,
        Kitnet,
        Conjugado
    }

    [Table("ENDERECO_END")]
    public class Endereco
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("END_CEP")]
        [Range(1, 999999999999999)]
        public Int64 Cep { get; set; }

        [Column("END_LOGRADORO")]
        [MaxLength(20)]
        public String Logradoro { get; set; }

        [Column("END_NUMERO")]
        [MaxLength(10)]
        public Int64 Numero { get; set; }

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

        [Column("END_TIPOLOGRADORO")]
        [MaxLength(60)]
        public TipoEnderecoEnum Tipo { get; set; }
    }
}
