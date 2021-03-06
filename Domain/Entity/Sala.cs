﻿using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    [Obsolete("Classe obsoleta, substituída pela nova engenharia de comunicação com a base de dados")]
    [Table("SALA_SAL")]
    public class Sala : BaseEntity
    {
        [Column("SAL_NUMERO")]
        [Range(1, 99999)]
        public Int32 Numero { get; set; }

        [Column("SAL_STATUS")]
        public StatusSalaEnum Status { get; set; }



        public virtual List<Reserva> Reservas { get; set; }
    }
}
