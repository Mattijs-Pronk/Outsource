using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;

namespace BusinessLogicLayer
{
    public class Functie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Functie(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Functie(FunctieDTO functie)
        {
            this.Id = functie.Id;
            this.Name = functie.Name;
        }
    }
}
