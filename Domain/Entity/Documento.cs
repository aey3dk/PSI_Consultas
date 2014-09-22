using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Table("DOCUMENTO_DOC")]
    public class Documento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("COB_CODIGO")]
        [Range(1, 999999999999999)]
        public Int32 Codigo { get; set; }

        [Column("DOC_DESCRICAO")]
        public String Descricao { get; set; }
    }
}
