namespace LXTechClienteAPI.Services.Models
{
    public class CriarClientesResponseModel
    {
        public Guid? Id { get; set; }


        public string? Nome { get; set; }


        public string? Email { get; set; }


        public string? Cpf { get; set; }


        public DateTime? DataNascimento { get; set; }

        public DateTime? DataHoraCriação { get; set; }
    }
}
