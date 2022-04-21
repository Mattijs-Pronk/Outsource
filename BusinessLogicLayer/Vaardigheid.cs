using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;

namespace BusinessLogicLayer
{
    public class Vaardigheid
    {
        public int Id;
        public string Name;

        public Vaardigheid(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Vaardigheid(VaardigheidDTO vaardigheid)
        {
            Id = vaardigheid.Id;
            Name = vaardigheid.Name;
        }
    }
}
