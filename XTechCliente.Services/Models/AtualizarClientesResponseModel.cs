namespace LXTechClienteAPI.Services.Models
{
    public class AtualizarClientesResponseModel
    {
        public Guid? Id { get; set; }

        public string? Nome { get; set; }

        public string? Email { get; set; }

        public string? Cpf { get; set; }

        public DateTime? DataNascimento { get; set; }

        public DateTime? DataHoraAtualizacao { get; set; }
    }
}
