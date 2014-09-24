using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("PROFISSIONAL_PRO")]
    public class Profissional : PessoaFisica
    {
        [Column("PRO_NUMEROCONSELHO")]
        [Range(1, 999999999)]
        public Int32 NumeroConselho { get; set; }




        [Column("PFI_IDENDERECO")]
        public Int64 IdEndereco { get; set; }

        [ForeignKey("IdEndereco")]
        public virtual Endereco Endereco { get; set; }




        public virtual List<Documento> Documentos { get; set; }

        public virtual List<Telefone> Telefones { get; set; }

        public virtual List<Consulta> Consultas { get; set; }

        public virtual List<Convenio> Convenios { get; set; }

        public virtual List<Especialidade> Especialidades { get; set; }

        public virtual List<Reserva> Reservas { get; set; }
    }
}
