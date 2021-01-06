using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public readonly IRepository _repo;

        public AlunoController(DataContext context, IRepository repo)
        {
            _repo = repo;
        }

        // GET: api/<AlunoController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllAlunos(true); //teste
            return Ok(result);
        }

        // GET api/<AlunoController>/5
        [HttpGet("byId/{id}")]
        public IActionResult Get(int id)
        {
            var aluno = _repo.GetAlunoById(id, false);
            if (aluno == null) return BadRequest("O Aluno não foi encontrado.");

            return Ok(aluno);
        }

        //[HttpGet("ByName/{nome}/{sobrenome}")]
        //public IActionResult Get(string nome, string sobrenome)
        //{
        //    var aluno = _context.Alunos.FirstOrDefault(a => a.Nome.Contains(nome) && a.Sobrenome.Contains(sobrenome));
        //    if (aluno == null) return BadRequest("O Aluno não foi encontrado.");

        //    return Ok(aluno);
        //}

        // POST api/<AlunoController>
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _repo.Add(aluno);
            if (_repo.SaveChanges())
            {
                return Ok(aluno);
            }

            return BadRequest("Falha ao cadastrar aluno");
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            var alu = _repo.GetAlunoById(id, false);
            if (alu == null) return BadRequest("O Aluno não foi encontrado.");

            _repo.Update(aluno);
            if (_repo.SaveChanges())
            {
                return Ok(aluno);
            }

            return BadRequest("Falha ao atualizar aluno");
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            var alu = _repo.GetAlunoById(id, false);
            if (alu == null) return BadRequest("O Aluno não foi encontrado.");

            _repo.Update(aluno);
            if (_repo.SaveChanges())
            {
                return Ok(aluno);
            }

            return BadRequest("Falha ao atualizar aluno");
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var aluno = _repo.GetAlunoById(id, false);
            if (aluno == null) return BadRequest("O Aluno não foi encontrado.");

            _repo.Delete(aluno);
            if (_repo.SaveChanges())
            {
                return Ok("Usuário deletado com sucesso.");
            }

            return BadRequest("Falha ao deletar aluno");
        }
    }
}
