using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApp.Models
{
    public class ConsultaModel
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O campo código é obrigatório")]
        [Range(1, 999999999999999, ErrorMessage = "O campo código deve possuir no máximo 15 dígitos")]
        public Int32 Id { get; set; }

        [Display(Name = "Código do Profissional")]
        [Required(ErrorMessage = "O campo profissional é obrigatório")]
        public Int32 ProfissionalId { get; set; }

        public String ProfissionalNome { get; set; }

        [Display(Name = "Código do Paciente")]
        [Required(ErrorMessage = "O campo paciente é obrigatório")]
        public Int32 PacienteId { get; set; }

        public String PacienteNome { get; set; }

        [Display(Name = "Data de Hora")]
        [Required(ErrorMessage = "O campo data e hora é obrigatório")]
        public String DataHora { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "O campo status é obrigatório")]
        public StatusConsultaEnum Status { get; set; }
    }
}