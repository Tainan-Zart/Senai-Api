using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Domain.Entidades;
using Senai.Domain.NovaPasta1;

namespace Senai.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Salvar(EscolaDto escola)
        {
          
            return Ok();
        }
    }
}
