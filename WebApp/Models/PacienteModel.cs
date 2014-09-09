using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class PacienteModel
    {
        [Display(Name = "Código")]
        public Int32 Codigo { get; set; }

        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        [Display(Name = "Descrição")]
        [MaxLength(60, ErrorMessage = "O campo descrição deve possuir no máximo 60 dígitos")]
        public String Descricao { get; set; }

        [Required(ErrorMessage = "O campo data de nascimento é obrigatório")]
        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}