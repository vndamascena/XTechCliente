﻿using System.ComponentModel.DataAnnotations;

namespace XTechClienteAPI.Services.Models
{
    public class AtualizarClientesRequestModel
    {

        [MinLength(5, ErrorMessage = "Por favor, informe no minimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no maximo {1} caracteres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o e-mail.")]
        [EmailAddress(ErrorMessage = "Por favor, informe um e-mail válido.")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Por favor, informe a data de nascimento.")]
        public DateTime? DataNascimento { get; set; }

        
    }
}
