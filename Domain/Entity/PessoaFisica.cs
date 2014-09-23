using Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("PESSOAFISICA_PFI")]
    public class PessoaFisica : BaseEntity
    {
        [Column("PFI_NOME")]
        [MaxLength(60)]
        public String Nome { get; set; }

        [Column("PFI_EMAIL")]
        [MaxLength(60)]
        public String Email { get; set; }

        [Column("PFI_RG")]
        [MaxLength(14)]
        public String RG { get; set; }

        [Column("PFI_CPF")]
        [MaxLength(14)]
        public String CPF { get; set; }

        [Column("PFI_NATURALIDADE")]
        [MaxLength(60)]
        public String Naturalidade { get; set; }

        [Column("PFI_NACIONALIDADE")]
        [MaxLength(60)]
        public String Nacionalidade { get; set; }

        [Column("PFI_SEXO")]
        public SexoEnum Sexo { get; set; }

        [Column("PFI_DATANASCIMENTO")]
        public DateTime DataNascimento { get; set; }

        [Column("PFI_ESTADOCIVIL")]
        public EstadoCivilEnum EstadoCivil { get; set; }
    }
}