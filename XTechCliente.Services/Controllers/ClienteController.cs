using LXTechClienteAPI.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LXTechClienteAPI.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
       
    
        [HttpPost]
        [ProducesResponseType(typeof(CriarClientesResponseModel),200)]
        public IActionResult CriarCliente([FromBody]CriarClientesRequestModel model)
        {
            return Ok();
        }

        [HttpPut]
        [ProducesResponseType(typeof (AtualizarClientesResponseModel),200)]
        public IActionResult AtualizarCliente([FromBody] AtualizarClientesRequestModel model)
        {
            return Ok();
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
