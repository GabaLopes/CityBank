using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterTodosClientes()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult ObterCliente(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CadastrarCliente()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult AtualizarCliente()
        {
            return Ok();
        }

        [HttpDelete] 
        public IActionResult ExcluirCliente()
        {
            return Ok();
        }
    }
}
