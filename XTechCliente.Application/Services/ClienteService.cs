using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XTechCliente.Application.Interfaces;
using XTechCliente.Domain.Entities;
using XTechCliente.Domain.Interfaces.Services;
using XTechClienteAPI.Services.Models;

namespace XTechCliente.Application.Services
{
    public class ClienteService : IClienteService
    {
      private readonly IClienteDomainService _clienteDomainService;

        public ClienteService(IClienteDomainService clienteDomainService)
        {
            _clienteDomainService = clienteDomainService;
        }

        public AtualizarClientesResponseModel AtualizarClientes(AtualizarClientesRequestModel model, string email)
        {
            

            var clienteAtualizado = _clienteDomainService?.AtualizarDados(email, model.Nome, model.DataNascimento);

            var response = new AtualizarClientesResponseModel
            {

                Id = clienteAtualizado.Id,
                Nome = clienteAtualizado.Nome,
                Email = clienteAtualizado.Email,
                Cpf = clienteAtualizado.Cpf,
                DataNascimento = clienteAtualizado.DataNascimento,
                DataHoraAtualizacao = clienteAtualizado.DataAtualizacao

            };
            return response;
        }

        public ClientesGetModel ConsultarCliente(ClientesGetModel model)
        {
            throw new NotImplementedException();
        }

        public CriarClientesResponseModel CriarCliente(CriarClientesRequestModel model)
        {
            var cliente = new Cliente
            {
                Id = Guid.NewGuid(),
                Nome = model.Nome,
                Cpf = model.Cpf,
                Email = model.Email,
                DataNascimento = model.DataNascimento,
                DataCriacao = DateTime.Now,
                DataAtualizacao = DateTime.Now
                

            };
            _clienteDomainService?.CriarCliente(cliente);

            var response = new CriarClientesResponseModel
            {
                Id = cliente.Id,
                Nome = model.Nome,
                Cpf = model.Cpf,
                Email = model.Email,
                DataNascimento = model.DataNascimento,
                DataHoraCriação = DateTime.Now
            };

            return response;
        }
    }
}
