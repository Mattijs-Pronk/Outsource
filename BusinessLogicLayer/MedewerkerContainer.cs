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

        private List<Medewerker> FilterMedewerkersFunc(List<Medewerker> medewerkersList, int filterType, string filterString)
        {
            var filteredMedewerkers = new List<Medewerker>();
            if (filterType < 0 || filterType > 3) return filteredMedewerkers;

            if (filterType == FilterOn.Functie) //Filter on Name
            {
                medewerkersList.ForEach((m) => { if (FilterMedOnFunctie(m, filterType, filterString)) filteredMedewerkers.Add(m); });
            }
            else if (filterType == FilterOn.Persoonlijkheid)
            {
                medewerkersList.ForEach((m) => { if (FilterMedOnPersoonlijkheid(m, filterType, filterString)) filteredMedewerkers.Add(m); });
            }
            else if (filterType == FilterOn.Vaardigheid)
            {
                medewerkersList.ForEach((m) => { if (FilterMedOnVaardigheid(m, filterType, filterString)) filteredMedewerkers.Add(m); });
            }
            else
            {
                medewerkersList.ForEach((m) => { if (FilterMedOnName(m, filterType, filterString)) filteredMedewerkers.Add(m); });
            }

            return filteredMedewerkers;
        }

        private bool FilterMedOnPersoonlijkheid(Medewerker m, int filterType, string filterString)
        {
            return (md.Voornaam + " " + md.Achternaam).Contains(filterString);
        }

        private bool FilterMedOnFunctie(Medewerker m, int filterType, string filterString)
        {
            return (md.Voornaam + " " + md.Achternaam).Contains(filterString);
        }

        private bool FilterMedOnVaardigheid(Medewerker m, int filterType, string filterString)
        {
            return (md.Voornaam + " " + md.Achternaam).Contains(filterString);
        }

        private bool FilterMedOnName(Medewerker md, int filterType, string filterString)
        {
            return (md.Voornaam + " " + md.Achternaam).Contains(filterString);
        }

    }
    public class FilterOn
    {
        public static int Naam = 0;
        public static int Functie = 1;
        public static int Persoonlijkheid = 2;
        public static int Vaardigheid = 3;
    }
}
