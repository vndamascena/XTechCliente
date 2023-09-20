using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXTechCliente.Domain.Entities
{
    public class Cliente
    {
        public Guid? Id { set; get; }
        public string? Nome { set; get; }
        public string? Cpf { set; get; }
        public string? Email { set; get; }
        public DateTime? DataNascimento { set; get; }
        public DateTime? DataCriacao { set; get; }
        public DateTime? DataAtualizacao { set; get; }
        public List<HistoricoAtividade>? Historicos { get; set; }


    }
}
