using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Persoonlijkheid
    {
        public int Id;
        public string Name;

        public Persoonlijkheid(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
