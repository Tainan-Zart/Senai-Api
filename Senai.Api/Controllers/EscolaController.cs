using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Domain.NovaPasta1;
using Senai.Service.Interfaces;

namespace Senai.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolaController : ControllerBase
    {
        private readonly IEscolaService _escolaService;

        public EscolaController(IEscolaService escolaService)
        {
            _escolaService = escolaService;
        }

        [HttpPost]
        public IActionResult Salvar(EscolaDto model)
        {

            var escola = _escolaService.Adicionar(model);
            return Ok(escola);
        }

        [HttpDelete]
        public IActionResult Remover(long id)
        {
            _escolaService.Remover(id);
            return NoContent();
        }

        [HttpGet]
        

        public IActionResult Get(long id)
        {
           
           return Ok();
        }
    }
}
