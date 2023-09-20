using XTechCliente.Domain.Entities;
using XTechCliente.Domain.Interfaces.Repositories;
using XTechCliente.Infra.Data.Contetxs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTechCliente.Infra.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRpository
    {
        public Cliente Get(string nome)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Clientes.FirstOrDefault(u => u.Nome.Equals(nome));
            }
        }

        public Cliente Get(string email, string cpf)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Clientes.FirstOrDefault(u => u.Email.Equals(email) && u.Cpf.Equals(cpf));
            }
        }
    }
}
