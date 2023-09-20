using System.ComponentModel.DataAnnotations;

namespace LXTechClienteAPI.Services.Models
{
    public class AtualizarClientesRequestModel
    {

        [MinLength(5, ErrorMessage = "Por favor, informe no minimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no maximo {1} caracteres.")]
        public string? Nome { get; set; }


        [Required(ErrorMessage = "Por favor, informe a data de nascimento.")]
        public DateTime? DataNascimento { get; set; }
    }
}
