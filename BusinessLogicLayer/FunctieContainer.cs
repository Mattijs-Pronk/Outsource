using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;

namespace BusinessLogicLayer
{
    public class FunctieContainer
    {
        public List<Functies> Functies = new List<Functies>();


        //list aanmaken om alle functies met bijbehorende gegevens op te halen.
        public List<Functies> GetAllMedewerkers()
        {
            FunctieDAL dal = new FunctieDAL();
            List<FunctieDTO> listfuncties = dal.GetAllFuncties();

            //.clear om de list leeg te maken en niet dubbele te laten zien.
            Functies.Clear();

            foreach (FunctieDTO functies in listfuncties)
            {
                Functies newfunctie = new Functies(functies);
                Functies.Add(newfunctie);
            }
            return Functies;
        }
    }
}
