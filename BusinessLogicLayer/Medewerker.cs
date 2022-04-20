using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;

namespace BusinessLogicLayer
{
    public class Medewerker
    {
        public int Id { get; }

        public string Voornaam { get; set; }

        public string Achternaam { get; set; }

        public string Email { get; set; }

        public string Gebruikersnaam { get; set; }

        public string Wachtwoord { get; set; }

        public int FunctieId { get; set; }

        public string DatumLogin { get; set; }

        public bool IsManager { get; set; }

        public List<int> Persoonlijkheden;
        public List<int> Vaardigheden;

        public Medewerker(int id, string voornaam, string achternaam, int functieId, bool isManager, List<int> pers, List<int> vaar) 
        {
            Id = id;
            Voornaam = voornaam;
            Achternaam = achternaam;
            FunctieId = functieId;
            IsManager = isManager;
            Persoonlijkheden = pers;
            Vaardigheden = vaar;
        }

        public Medewerker(MedewerkerDTO medewerker)
        {
            this.Id = medewerker.Id;
            this.Voornaam = medewerker.Voornaam;
            this.Achternaam = medewerker.Achternaam;
            this.Email = medewerker.Email;
            this.Gebruikersnaam = medewerker.Gebruikersnaam;
            this.Wachtwoord = medewerker.Wachtwoord;
            this.FunctieId = medewerker.FunctieId;
            this.DatumLogin = medewerker.DatumLogin;
            this.IsManager = medewerker.IsManager;
        }
    }
}
