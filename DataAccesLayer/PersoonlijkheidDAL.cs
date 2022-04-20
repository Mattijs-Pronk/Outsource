using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class PersoonlijkheidDAL
    {

        public List<PersoonlijkheidDTO> GetAll()
        {
            var ls = new List<PersoonlijkheidDTO>();
            ls.Add(new PersoonlijkheidDTO(1, "Gay"));
            ls.Add(new PersoonlijkheidDTO(2, "Hetero"));
            ls.Add(new PersoonlijkheidDTO(3, "Bisexual"));
            ls.Add(new PersoonlijkheidDTO(4, "X"));
            return ls;
        }
    }
}
