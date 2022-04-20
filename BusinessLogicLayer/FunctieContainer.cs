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
        public List<Functie> Functies = new List<Functie>();
        FunctieDAL fnDal;

        public FunctieContainer()
        {
            fnDal = new FunctieDAL();
        }
        //list aanmaken om alle functies met bijbehorende gegevens op te halen.
        public List<Functie> GetAllMedewerkers()
        {
            List<FunctieDTO> listfuncties = fnDal.GetAllFuncties();

            //.clear om de list leeg te maken en niet dubbele te laten zien.
            Functies.Clear();

            foreach (FunctieDTO functies in listfuncties)
            {
                Functie newfunctie = new Functie(functies);
                Functies.Add(newfunctie);
            }
            return Functies;
        }

        internal List<Functie> GetAll()
        {
            List<Functie> result = new List<Functie>();
            fnDal.GetAllFuncties().ForEach(f => result.Add(new Functie(f.Id, f.Name)));
            return result;
        }
    }
}
