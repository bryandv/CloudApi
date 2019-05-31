using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_PP.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_PP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PP2Controller : ControllerBase
    {
        public LibraryContext _context;
        public PP2Controller (LibraryContext ctxt)
        {
            _context = ctxt;
        }

        [HttpGet]
        public List<Speler2> GetTeams()
        {
            return _context.Speler.ToList();
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult getSpeler(int id)
        {
            var speler = _context.Speler
                    .Include(d => d.Club)
                    .SingleOrDefault(d => d.Id == id);

            if (speler == null)
                return NotFound();

            return Ok(speler);
        }
    }
}