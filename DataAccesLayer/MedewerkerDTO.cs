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
    }
}
