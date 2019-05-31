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


        [HttpPost]
        public IActionResult CreateSpeler([FromBody] Speler2 newspeler)
        {
            _context.Speler.Add(newspeler);
            _context.SaveChanges();
            return Created("", newspeler);
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult DeleteSpeler(int id)
        {
            var speler = _context.Speler.Find(id);
            if (speler == null)
                return NotFound();

            _context.Speler.Remove(speler);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateSpeler([FromBody] Speler2 updatespeler)
        {
            var orgSpeler = _context.Speler.Find(updatespeler.Id);
            if (orgSpeler == null)
                return NotFound();

            orgSpeler.Name = updatespeler.Name;
            orgSpeler.Klassement = updatespeler.Klassement;
            orgSpeler.WaardeKlassement = updatespeler.WaardeKlassement;
            orgSpeler.Club = updatespeler.Club;

            _context.SaveChanges();
            return Ok(orgSpeler);
        }

    }
}