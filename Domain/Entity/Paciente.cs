using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("PACIENTE_PAC")]
    public class Paciente : PessoaFisica
    {
        [Column("PAC_IDENDERECO")]
        public Int64 IdEndereco { get; set; }

        [ForeignKey("IdEndereco")]
        public virtual Endereco Endereco { get; set; }




        [Column("PAC_IDCONVENIO")]
        public Int64 IdConvenio { get; set; }

        [ForeignKey("IdConvenio")]
        public virtual Convenio Convenio { get; set; }




        public virtual List<Documento> Documentos { get; set; }

        public virtual List<Telefone> Telefones { get; set; }

        public virtual List<Consulta> Consultas { get; set; }
    }
}
