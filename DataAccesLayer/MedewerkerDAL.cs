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

            var meds = new List<MedewerkerDTO>() {
            new MedewerkerDTO(1,
                "Tim",
                "emthy",
                1,
                true,
                new List < int > { 1, 3, 4},
                new List < int > { 1, 2}),
                new MedewerkerDTO(1,
                    "Tim",
                    "emhy",
                    1,
                    false,
                    new List < int > { 1, 3},
                    new List < int > { 4}),
                new MedewerkerDTO(1,
                    "Tim",
                    "pany",
                    1,
                    false,
                    new List < int > { 3, 4},
                    new List < int > {  2, 4}),
                new MedewerkerDTO(1,
                    "Kim",
                    "emthy",
                    1,
                    true,
                    new List < int > { 2 },
                    new List < int > { 3, 4}),
                new MedewerkerDTO(1,
                    "Kim",
                    "pahy",
                    1,
                    false,
                    new List < int > { 1, 4},
                    new List < int > { 3}),
            };

            return meds;

            //OpenConnect();

            //cmd.CommandText = "SELECT * FROM GEBRUIKER";

            //using SqlDataReader rdr = cmd.ExecuteReader();

            //List<MedewerkerDTO> listmedewerkers = new List<MedewerkerDTO>();

            //while (rdr.Read())
            //{
            //    MedewerkerDTO medewerker = new MedewerkerDTO()
            //    {
            //        Id = rdr.GetInt32("Id"),
            //        Voornaam = rdr.GetString("Voornaam"),
            //        Achternaam = rdr.GetString("Achternaam"),
            //        Email = rdr.GetString("Email"),
            //        Gebruikersnaam = rdr.GetString("Gebruikersnaam"),
            //        Wachtwoord = rdr.GetString("Wachtwoord"),
            //        FunctieId = rdr.GetInt32("FunctieId"),
            //        DatumLogin = rdr.GetString("DatumLogin"),
            //        IsManager = rdr.GetBoolean("QMANAGER"),
            //    };
            //    listmedewerkers.Add(medewerker);
            //}
            //CloseConnect();
        }
    }
}
