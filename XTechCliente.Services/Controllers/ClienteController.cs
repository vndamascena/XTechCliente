using XTechClienteAPI.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XTechCliente.Application.Interfaces;
using XTechCliente.Infra.Data.Repositories;
using XTechCliente.Domain.Entities;

namespace XTechClienteAPI.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService? _clienteService;

        public ClienteController (IClienteService? clienteService)
        {
            _clienteService = clienteService;
        }

        [Route("criar-cliente")]
        [HttpPost]
        [ProducesResponseType(typeof(CriarClientesResponseModel),200)]
        public IActionResult CriarCliente([FromBody]CriarClientesRequestModel model)
        {
            try
            {
                var response = _clienteService?.CriarCliente(model);

                return StatusCode(201,response);
            }

            catch (ApplicationException e)
            {
                return StatusCode(400, new {e.Message});
            }
            catch (Exception e)
            {
                return StatusCode(500, new {e.Message});
            }
        }

        [Route("atualizar-dados")]
        [HttpPut]
        [ProducesResponseType(typeof (AtualizarClientesResponseModel),200)]
        public IActionResult AtualizarCliente([FromBody] AtualizarClientesRequestModel model)
        {
            try
            {

                var response = _clienteService?.AtualizarClientes(model, model.Email);
                    return StatusCode(200, response);
                
            }   

            catch (ApplicationException e)
            {
                
                return StatusCode(400, new { e.Message });
            }
            catch (Exception e)
            {
                
                return StatusCode(500, new { e.Message });
            }



           
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ClientesGetModel), 200)]
        public IActionResult Delete(Guid? id)
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ClientesGetModel>), 200)]
        public IActionResult GetAll()
        {
            return Ok();
        }


        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ClientesGetModel), 200)]
        public IActionResult GetById(Guid? id)
        {
            return Ok();
        }
    }
}
