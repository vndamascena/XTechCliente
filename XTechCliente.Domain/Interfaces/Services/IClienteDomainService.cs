using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XTechCliente.Domain.Entities;

namespace XTechCliente.Domain.Interfaces.Services
{
    public interface IClienteDomainService
    {
        void CriarCliente(Cliente cliente);

        Cliente ConsultarCliente(string nome, string cpf, string email);

        Cliente ConsultarId(Guid id);

        Cliente AtualizarDados(string nome, string email, DateTime? dataNascimento);


    }
}
