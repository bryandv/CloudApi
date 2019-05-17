using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_PP.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public List<Teams> GetTeams()
        {
            return _context.Team.ToList();
        }

    }
}