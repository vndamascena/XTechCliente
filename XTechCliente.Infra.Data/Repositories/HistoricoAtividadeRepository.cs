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
    public class HistoricoAtividadeRepository : BaseRepository<HistoricoAtividade>, IHistoricoAtividadeRepository
    {


        public List<HistoricoAtividade> Get(Guid clienteId)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.HistoricoAtividades
                .Where(h => h.Id.Equals(clienteId))
               .OrderByDescending(h => h.DataHora)
               .ToList();
            }
        }


    }
}
