namespace LXTechClienteAPI.Services.Models
{
    public class ClientesGetModel
    {
        public Guid? Id { get; set; }

        public string? Nome { get; set; }


        public string? Email { get; set; }

        public string? Cpf { get; set; }

        public DateTime? DataNascimento { get; set; }
        public DateTime? DataHoraCriacao { get; set; }
        public DateTime? DataHoraUltimaAlteracao { get; set; }
    }
}
