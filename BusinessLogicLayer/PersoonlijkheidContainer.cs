using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;

namespace BusinessLogicLayer
{
    public class PersoonlijkheidContainer
    {
        PersoonlijkheidDAL psDal;
        public PersoonlijkheidContainer()
        {
            psDal = new PersoonlijkheidDAL();
        }
        public List<Persoonlijkheid> GetAll()
        {
            List<Persoonlijkheid> result = new List<Persoonlijkheid>();
            psDal.GetAll().ForEach(p => result.Add(new Persoonlijkheid(p.Id, p.Name)));
            return result;
        }
    }
}
