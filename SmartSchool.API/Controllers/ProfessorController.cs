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
        private readonly DataContext _context;

        public ProfessorController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<ProfessorController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Professores);
        }

        // GET api/<ProfessorController>/5
        [HttpGet("byId/{id}")]
        public IActionResult Get(int id)
        {
            var professor = _context.Professores.FirstOrDefault(a => a.Id == id);
            if (professor == null) return BadRequest("O Professor não foi encontrado.");

            return Ok(professor);
        }

        [HttpGet("ByName/{nome}")]
        public IActionResult Get(string nome, string sobrenome)
        {
            var professor = _context.Professores.FirstOrDefault(a => a.Nome.Contains(nome));
            if (professor == null) return BadRequest("O Professor não foi encontrado.");

            return Ok(professor);
        }

        // POST api/<ProfessorController>
        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _context.Add(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        // PUT api/<ProfessorController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var alu = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (alu == null) return BadRequest("O Professor não foi encontrado.");

            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var alu = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (alu == null) return BadRequest("O Professor não foi encontrado.");

            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        // DELETE api/<ProfessorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var professor = _context.Professores.FirstOrDefault(a => a.Id == id);
            if (professor == null) return BadRequest("O Professor não foi encontrado.");

            _context.Remove(professor);
            _context.SaveChanges();
            return Ok();
        }
    }
}

