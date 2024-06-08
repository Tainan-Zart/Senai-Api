using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Domain.Entidades;
using Senai.Domain.NovaPasta1;
using Senai.Service.Interfaces;
using Senai.Service.Services;

namespace Senai.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {

        public readonly IProfessorService _professorService;

        public ProfessorController(IProfessorService professorService)
        {
            _professorService = professorService;
        }

        [HttpPost]
        [Route("Salvar")]

        public IActionResult Salvar(ProfessorDto model)
        {
            var salvar = _professorService.Salvar(model);
            return Ok(salvar);
        }

        [HttpDelete]
        [Route("Excluir")]

        public IActionResult Excluir(long id)
        {
            var excluir = _professorService.Excluir(id);
            return Ok(excluir);
        }

        [HttpGet]
        [Route("BuscarPorId")]

        public IActionResult Get(long id)
        {
            var buscarPorId = _professorService.BuscarPorId(id);
            return Ok(buscarPorId);
        }

        [HttpGet]
        [Route("BuscarTodos")]

        public IActionResult GetAll()
        {
            var buscarTodos = _professorService.BuscarTodos();
            return Ok(buscarTodos);
        }
    }
}
