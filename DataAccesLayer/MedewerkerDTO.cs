using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class MedewerkerDTO
    {
        public int Id;

        public string Voornaam;

        public string Achternaam;

        public string Email;

        public string Gebruikersnaam;

        public string Wachtwoord;

        public int FunctieId;

        public string DatumLogin;

        public bool IsManager;

        public List<int> Persoonlijkheden;
        public List<int> Vaardigheden;

        public MedewerkerDTO(int id, string voornaam, string achternaam, int functieId, bool isManager, List<int> pers, List<int> vaar)
        {
            Id = id;
            Voornaam = voornaam;
            Achternaam = achternaam;
            FunctieId = functieId;
            IsManager = isManager;
            Persoonlijkheden = pers;
            Vaardigheden = vaar;
        }
    }
}
