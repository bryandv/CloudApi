using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_PP.Model
{
    public class Teams
    {
        public int Id { get; set; }
        public Speler Speler1 { get; set; }
        public Speler Speler2 { get; set; }
        public int Totaalwaarde { get; set; }

        public void SetTotaalaarde()
        {
            //Totaalwaarde = Speler1.Klassement;
            //Totaalwaarde = Speler1.WaardeKlassement + Speler2.WaardeKlassement;
        }
    }
}
