//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserva
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> DataHora { get; set; }
        public Nullable<int> ProfissionalId { get; set; }
        public Nullable<int> SalaId { get; set; }
    
        public virtual Cobranca Cobranca { get; set; }
        public virtual Profissional Profissional { get; set; }
        public virtual Sala Sala { get; set; }
    }
}
