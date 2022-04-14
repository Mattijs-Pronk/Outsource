using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class MedewerkerDAL : SqlConnect
    {

        public MedewerkerDAL()
        {
            Initialize();
        }

        public List<MedewerkerDTO> GetAllMedewerkers()
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM GEBRUIKER";

            using SqlDataReader rdr = cmd.ExecuteReader();

            List<MedewerkerDTO> listmedewerkers = new List<MedewerkerDTO>();

            while (rdr.Read())
            {
                MedewerkerDTO medewerker = new MedewerkerDTO()
                {
                    Id = rdr.GetInt32("Id"),
                    Voornaam = rdr.GetString("Voornaam"),
                    Achternaam = rdr.GetString("Achternaam"),
                    Email = rdr.GetString("Email"),
                    Gebruikersnaam = rdr.GetString("Gebruikersnaam"),
                    Wachtwoord = rdr.GetString("Wachtwoord"),
                    FunctieId = rdr.GetInt32("FunctieId"),
                    DatumLogin = rdr.GetString("DatumLogin"),
                    IsManager = rdr.GetBoolean("QMANAGER"),
                };
                listmedewerkers.Add(medewerker);
            }
            CloseConnect();

            return listmedewerkers;
        }
    }
}
