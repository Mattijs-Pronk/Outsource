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
            ls.Add(new VaardigheidDTO(1, "Sex"));
            ls.Add(new VaardigheidDTO(2, "Blowjobs"));
            ls.Add(new VaardigheidDTO(3, "KontjePorren"));
            ls.Add(new VaardigheidDTO(4, "X"));
            return ls;
        }
    }
}
