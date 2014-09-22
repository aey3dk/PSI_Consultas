using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("PESSOAJURIDICA_PJD")]
    public class PessoaJuridica
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("PJD_CNPJ")]
        [MaxLength(14)]
        public String CNPJ { get; set; }

        [Column("PJD_INSCRICAOESTADUAL")]
        [MaxLength(9)]
        public String InscricaoEstadual { get; set; }

        [Column("PJD_INSCRICAOMUNICIPAL")]
        [MaxLength(10)]
        public String InscricaoMunicipal { get; set; }
    }
}
