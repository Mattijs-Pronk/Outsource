using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class VaardigheidDTO
    {
        public int Id;

        public string Name;

        public VaardigheidDTO(int id, string Name)
        {
            Id = id;
            Name = Name;
        }
    }
}
