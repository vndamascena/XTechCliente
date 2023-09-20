using LXTechCliente.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXTechCliente.Domain.Interfaces.Repositories
{
    public interface IHistoricoAtividadeRepository : IBaseRepository<HistoricoAtividade>
    {
        List<HistoricoAtividade> Get(Guid clienteId);
    }
}
