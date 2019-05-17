using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_PP.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_PP.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    
    public class PPController : ControllerBase
    {
        
        [HttpGet]
        public Speler get()
        {
            var speler = new Speler()
            {
            Naam = "Bryan Devolder",
            Club = "Merksplas",
            Klassement = "C0"
            };

            return speler;
        }
        [Route("Lijst")]
        [HttpGet]
        
        public List<Teams> GetPlayers()
        {
            var spelers = new List<Speler>();
            var teams = new List<Teams>();
            teams.Add(new Teams()
            {
                Id = 1,
               Speler1 = new Speler()
               {
                   Naam = "Devolder Bryan",
                   Club = "Merksplas",
                   Klassement = "C0"
               },
               Speler2 = new Speler()
               {
                   Naam = "Torfs Yordi",
                   Club = "Merksplas",
                   Klassement = "B6"
               }
              
               
            });
            teams.Add(new Teams()
            {
                Id = 2,
                Speler1 = new Speler()
                {
                    Naam = "Niels Maes",
                    Club = "Merksplas",
                    Klassement = "C0"
                },
                Speler2 = new Speler()
                {
                    Naam = "Laura Van Baekel",
                    Club = "Merksplas",
                    Klassement = "C4"
                }

            });
            teams.Add(new Teams()
            {
                Id = 3,
                Speler1 = new Speler()
                {
                    Naam = "Glen Steas",
                    Club = "Merksplas",
                    Klassement = "C0"
                },
                Speler2 = new Speler()
                {
                    Naam = "Tim Peeters",
                    Club = "Merksplas",
                    Klassement = "C4"
                }

            });

            spelers.Add(new Speler()
            {
                Naam = "Glen Staes",
                Club = "Merksplas",
                Klassement = "C0"
            });
            return teams;
        }
    }
}

