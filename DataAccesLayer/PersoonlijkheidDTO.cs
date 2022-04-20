using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class PersoonlijkheidDTO
    {
        public int Id;

        public string Name;

        public PersoonlijkheidDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
