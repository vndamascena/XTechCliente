using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using XTechCliente.Domain.Entities;
using XTechCliente.Domain.Enums;
using XTechCliente.Domain.Interfaces.Repositories;

namespace XTechCliente.Domain.Interfaces.Services
{
    public class ClienteDomainService : IClienteDomainService
    {
        private readonly IClienteRpository? _clienteRpository;
        private readonly IHistoricoAtividadeRepository? _historicoAtividadeRepository;

        public ClienteDomainService(IClienteRpository? clienteRpository, IHistoricoAtividadeRepository? historicoAtividadeRepository)
        {
            _clienteRpository = clienteRpository;
            _historicoAtividadeRepository = historicoAtividadeRepository;
        }

        public Cliente AtualizarDados(string email,string nome, DateTime? dataNascimento)
        {
            var cliente = _clienteRpository?.Get(email);

            if (cliente == null)
            {
                throw new ApplicationException("Usuário não encontrado, verifique o email informado.");
            }
            var dadosAtualizados = false;

            if (!string.IsNullOrWhiteSpace(nome))
            {
                cliente.Nome = nome;
                dadosAtualizados = true;
            }

            if (dataNascimento.HasValue)
            {
                cliente.DataNascimento = dataNascimento.Value;
                dadosAtualizados = true;
            }
            cliente.DataAtualizacao = DateTime.Now;

            if (dadosAtualizados)
            {
                _clienteRpository?.Update(cliente);
            }
            else
            {
                throw new ApplicationException("Informe pelo menos 1 campo do usuário para ser atualizado.");
            }

            

            return cliente;


        }


        public Cliente ConsultarCliente(string nome, string cpf, string email)
        {
            throw new NotImplementedException();
        }

        public Cliente ConsultarId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void CriarCliente(Cliente cliente)
        {

            if (_clienteRpository?.Get(cliente.Email) != null)
            {
                throw new ApplicationException("O e-mail informado ja tem cadastro. Tente outro.");
            }

            var clienteCpf = _clienteRpository?.Get(cliente.Cpf);

            try
            {
               

                _clienteRpository?.Create(cliente);


                var historicoAtividade = new HistoricoAtividade
                {
                    Id = Guid.NewGuid(),
                    Tipo = TipoAtividade.CRIAÇÃO_DE_CLIENTE,
                    DataHora = DateTime.Now,
                    Descricao = $"Cadastro do cliente {cliente.Nome} realizado com sucesso.",
                    ClienteId = cliente.Id
                };

                _historicoAtividadeRepository?.Create(historicoAtividade);

            }
            catch(Exception e)
            {
                throw new ApplicationException("cliente com CPF ja cadastrado, informe outro.", e);
            }

            

           
        }

    }
}
