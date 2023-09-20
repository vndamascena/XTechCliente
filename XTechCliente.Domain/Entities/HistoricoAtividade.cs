using XTechCliente.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTechCliente.Domain.Entities
{
    public class HistoricoAtividade
    {
        public Guid? Id { get; set; }
        public DateTime? DataHora { get; set; }

        public TipoAtividade? Tipo { get; set; }

        public string? Descricao { get; set; }


    }
}
