using System.ComponentModel.DataAnnotations;

namespace XTechClienteAPI.Services.Models
{
    public class CriarClientesRequestModel
    {
        [MinLength(5, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe um nome.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o e-mail.")]
        [EmailAddress(ErrorMessage = "Por favor, informe um e-mail válido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Por favor, informe o CPF.")]
        [MinLength(11, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(11, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        public string? Cpf { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de nascimento.")]
        [MinAge(18, ErrorMessage = "O cliente deve ser maior de idade.")]
        public DateTime? DataNascimento { get; set; }
    }

    public class MinAgeAttribute : ValidationAttribute
    {
        private readonly int _minAge;

        public MinAgeAttribute(int minAge)
        {
            _minAge = minAge;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime dataNascimento)
            {
                var hoje = DateTime.Today;
                var idade = hoje.Year - dataNascimento.Year;
                if (dataNascimento.Date > hoje.AddYears(-idade))
                {
                    idade--;
                }

                if (idade >= _minAge)
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult(ErrorMessage);
        }
    }
}
