using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public enum TipoFisicaEnum
    {
        Rio_de_Janeiro,
        Caxias,
        Niteroi,
        Mage,
        BRA,
        ARG,
        FRA,
        Casaso,
        Solteiro,
    }

    [Table("PESSOAFISICA_PFI")]
    public class PessoaFisica
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("PFI_RG")]
        [MaxLength(9)]
        public String Rg { get; set; }

        [Column("PFI_CPF")]
        [MaxLength(14)]
        public String CPF { get; set; }

        [Column("PFI_NATURALIDADE")]
        [MaxLength(20)]
        public TipoFisicaEnum Naturalidade { get; set; }

        [Column("PFI_NACIONALIDADE")]
        [MaxLength(3)]
        public TipoFisicaEnum Nacionalidade { get; set; }

        [Column("PFI_DATANASCIMENTO")]
        public DateTime DataNascimento { get; set; }

        [Column("PFI_ESTADOCIVIL")]
        [MaxLength(7)]
        public TipoFisicaEnum EstadoCivil { get; set; }
    }
}
