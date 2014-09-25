using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class PacienteModel
    {
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O campo código é obrigatório")]
        [Range(1, 999999999999999, ErrorMessage = "O campo código deve possuir no máximo 15 dígitos")]
        public Int32 Id { get; set; }

        [Display(Name = "Nome completo")]
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        [MaxLength(60, ErrorMessage = "O campo descrição deve possuir no máximo 60 dígitos")]
        public String Nome { get; set; }

        //yyyy-MM-dd
        [Display(Name = "Data de nascimento")]
        [Required(ErrorMessage = "O campo data de nascimento é obrigatório")]
        public String DataNascimento { get; set; }

        //123.456.789-00
        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        public String CPF { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo e-mail é obrigatório")]
        [MaxLength(60, ErrorMessage = "O campo e-mail deve possuir no máximo 60 dígitos")]
        public String Email { get; set; }
    }
}