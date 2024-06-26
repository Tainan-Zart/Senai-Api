﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Domain.Dtos;
using Senai.Domain.NovaPasta1;
using Senai.Service.Interfaces;

namespace Senai.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        public readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpPost]
        [Route("Salvar")]

        public IActionResult Salvar(AlunoDto model)
        {
            var salvar = _alunoService.Salvar(model);
            return Ok(salvar);

        }

        [HttpDelete]
        [Route("Remover")]
        public IActionResult Remover(long id)
        {
            var remover = _alunoService.Remover(id);
            return Ok(remover);
        }


        [HttpGet]
        [Route("BuscarPorId")]
        public IActionResult Get(long id) {

            var aluno = _alunoService.BuscarPorId(id);
            return Ok(aluno);

        }


        [HttpGet]
        [Route("BuscarTodos")]

        public IActionResult GetAll() {
        
           var todosAlunos = _alunoService.BuscarTodos();
            return Ok(todosAlunos);
        
        }

        [HttpPatch]
        [Route("Editar")]

        public IActionResult Editar(AlunoDto model)
        {
            var editar = _alunoService.Salvar(model);
            return Ok(editar);
        }








}
}
