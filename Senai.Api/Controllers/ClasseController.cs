using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Domain.Dtos;
using Senai.Service.Interfaces;

namespace Senai.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ClasseController : ControllerBase
{

    public readonly IClasseService _classeService;

    public ClasseController(IClasseService classeService)
    {
        _classeService = classeService;
    }

    [HttpPost]

    public IActionResult Salvar(ClasseDto model)
    {
        var salvar = _classeService.Salvar(model);
        return Ok(salvar);
    }

    [HttpDelete]
    [Route("DeleteAluno")]

    public IActionResult Delete(long id)
    {
        var remove = _classeService.Remove(id);
        return Ok(remove);
    }

    [HttpGet]
    [Route("BuscarPorId")]

    public IActionResult Get(long id)
    {
        var classe = _classeService.BuscarPorId(id);
        return Ok(classe);
    }

    [HttpGet]
    [Route("BuscarTodos")]

    public IActionResult GetAll()
    {
        var classes = _classeService.BuscarTodos();
        return Ok(classes);
    }

    [HttpPatch]
    [Route("Editar")]

    public IActionResult Editar(ClasseDto model)
    {
        var editar = _classeService.Salvar(model);
        return Ok(editar);
    }

}
