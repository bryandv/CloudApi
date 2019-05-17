using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_PP.Model
{
    public class DBInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            //Create the db if not yet exists
            context.Database.EnsureCreated();

            //Are there already books present ?
            if (!context.Team.Any())
            {
       
               var team = new Teams()
                {
                   
                    Speler1 = new Speler()
                    {
                        Naam = "haha",
                        Club = "Merksplas",
                        Klassement = "C0"
                    },
                    Speler2 = new Speler()
                    {
                        Naam = "Torfs Yordi",
                        Club = "Merksplas",
                        Klassement = "B6"
                    }


                };

                context.Team.Add(team);
                context.SaveChanges();
            }
        }
    }
}
