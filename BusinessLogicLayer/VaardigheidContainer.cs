using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class VaardigheidContainer
    {
        VaardigheidDAL vgDal;
        public VaardigheidContainer()
        {
            vgDal = new VaardigheidDAL();
        }
        public List<Vaardigheid> GetAll()
        {
            List<Vaardigheid> result = new List<Vaardigheid>();
            vgDal.GetAll().ForEach(p => { result.Add(new Vaardigheid(p.Id, p.Name)); });
            return result;
        }
    }
}
