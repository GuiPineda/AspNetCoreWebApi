using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IRepository _repo;

        public ProfessorController(DataContext context, IRepository repo)
        {
            _repo = repo;
        }

        // GET: api/<ProfessorController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllProfessores(true);
            return Ok(result);
        }

        // GET api/<ProfessorController>/5
        [HttpGet("byId/{id}")]
        public IActionResult Get(int id)
        {
            var professor = _repo.GetProfessorById(id);
            if (professor == null) return BadRequest("O Professor não foi encontrado.");

            return Ok(professor);
        }

        //[HttpGet("ByName/{nome}")]
        //public IActionResult Get(string nome, string sobrenome)
        //{
        //    var professor = _context.Professores.FirstOrDefault(a => a.Nome.Contains(nome));
        //    if (professor == null) return BadRequest("O Professor não foi encontrado.");

        //    return Ok(professor);
        //}

        // POST api/<ProfessorController>
        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _repo.Add(professor);
            if (_repo.SaveChanges())
            {
                return Ok(professor);
            }

            return BadRequest("Falha ao cadastrar professor");
        }

        // PUT api/<ProfessorController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var alu = _repo.GetProfessorById(id, false);
            if (alu == null) return BadRequest("O Professor não foi encontrado.");

            _repo.Update(professor);
            _repo.SaveChanges();
            return Ok(professor);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var alu = _repo.GetProfessorById(id);
            if (alu == null) return BadRequest("O Professor não foi encontrado.");

            _repo.Update(professor);
            _repo.SaveChanges();
            return Ok(professor);
        }

        // DELETE api/<ProfessorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var professor = _repo.GetProfessorById(id);
            if (professor == null) return BadRequest("O Professor não foi encontrado.");

            _repo.Delete(professor);
            _repo.SaveChanges();
            return Ok();
        }
    }
}

