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
    
    public partial class Sala
    {
        public Sala()
        {
            this.Reservas = new HashSet<Reserva>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Numero { get; set; }
        public Nullable<StatusSalaEnum> Status { get; set; }
    
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
