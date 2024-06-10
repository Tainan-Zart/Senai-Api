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
}
