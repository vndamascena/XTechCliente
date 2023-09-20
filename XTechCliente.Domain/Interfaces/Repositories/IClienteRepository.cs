using XTechCliente.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTechCliente.Domain.Interfaces.Repositories
{
    public interface IClienteRpository : IBaseRepository<Cliente>
    {
        Cliente Get(string nome);
        Cliente Get(string email, string cpf);
    }
}
