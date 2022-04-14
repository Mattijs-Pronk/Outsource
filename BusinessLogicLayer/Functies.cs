using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;

namespace BusinessLogicLayer
{
    public class Functies
    {
        public int Id { get; set; }
        public string Functie { get; set; }

        public Functies(FunctieDTO functie)
        {
            this.Id = functie.Id;
            this.Functie = functie.Functie;
        }
    }
}
