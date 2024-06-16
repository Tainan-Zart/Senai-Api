using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Domain.Dtos;
using Senai.Domain.Interfaces;
using Senai.Service.Interfaces;

namespace Senai.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class NotaController : ControllerBase
{
    public readonly INotaService _notaService;

    public NotaController(INotaService notaService)
    {
        _notaService = notaService;
    }

    [HttpPost]

    public IActionResult Post(NotaDto model)
    {
        var escola = _notaService.Salvar(model);
        return Ok(escola);
    }

    [HttpGet]
    [Route("MediaAluno")]

    public IActionResult GetMediaNotas(MediaNotasPorAlunoESemestreDto nota) {

        var media = _notaService.MediaNotas(nota);
        return Ok(media);
    
    }




}
