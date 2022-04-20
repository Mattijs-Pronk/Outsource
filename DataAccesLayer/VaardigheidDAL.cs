using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class VaardigheidDAL
    {
        public List<VaardigheidDTO> GetAll()
        {
            var ls = new List<VaardigheidDTO>();
            ls.Add(new VaardigheidDTO(1, "Gay"));
            ls.Add(new VaardigheidDTO(2, "Hetero"));
            ls.Add(new VaardigheidDTO(3, "Bisexual"));
            ls.Add(new VaardigheidDTO(4, "X"));
            return ls;
        }
    }
}
