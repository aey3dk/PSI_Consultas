using Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Obsolete("Classe obsoleta, substituída pela nova engenharia de comunicação com a base de dados")]
    [Table("ENDERECO_END")]
    public class Endereco : BaseEntity
    {
        [Column("END_CEP")]
        [Range(1, 99999999)]
        public Int32 CEP { get; set; }

        [Column("END_LOGRADORO")]
        [MaxLength(60)]
        public String Logradoro { get; set; }

        [Column("END_NUMERO")]
        [Range(1, 99999)]
        public Int32 Numero { get; set; }

        [Column("END_COMPLEMENTO")]
        [MaxLength(60)]
        public String Complemento { get; set; }

        [Column("END_BAIRRO")]
        [MaxLength(60)]
        public String Bairro { get; set; }

        [Column("END_CIDADE")]
        [MaxLength(60)]
        public String Cidade { get; set; }

        [Column("END_UF")]
        [MaxLength(2)]
        public String UF { get; set; }

        [Column("END_PAIS")]
        [MaxLength(60)]
        public String Pais { get; set; }

        [Column("END_TIPOLOGRADORO")]
        public TipoMoradiaEnum TipoMoradia { get; set; }




        [Column("END_IDPESSOAFISICA")]
        public Int64 IdPessoaFisica { get; set; }

        [ForeignKey("IdPessoaFisica")]
        public virtual PessoaFisica PessoaFisica { get; set; }
    }
}
