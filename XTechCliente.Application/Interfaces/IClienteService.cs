using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XTechClienteAPI.Services.Models;

namespace XTechCliente.Application.Interfaces
{
    public interface IClienteService
    {
        CriarClientesResponseModel CriarCliente(CriarClientesRequestModel model);

        AtualizarClientesResponseModel AtualizarClientes(AtualizarClientesRequestModel model, string email);


        ClientesGetModel ConsultarCliente(ClientesGetModel model);
        
    }
}
