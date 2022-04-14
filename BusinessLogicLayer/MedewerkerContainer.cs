using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using BusinessLogicLayer;

namespace BusinessLogicLayer
{
    public class MedewerkerContainer
    {
        public List<Medewerker> Medewerkers = new List<Medewerker>();


        //list aanmaken om alle medewerkers met bijbehorende gegevens op te halen.
        public List<Medewerker> GetAllMedewerkers()
        {
            MedewerkerDAL dal = new MedewerkerDAL();
            List<MedewerkerDTO> listmedewerkers = dal.GetAllMedewerkers();

            //.clear om de list leeg te maken en niet dubbele te laten zien.
            Medewerkers.Clear();

            foreach (MedewerkerDTO medewerkers in listmedewerkers)
            {
                Medewerker newmedewerker = new Medewerker(medewerkers);
                Medewerkers.Add(newmedewerker);
            }
            return Medewerkers;
        }

    }
}
