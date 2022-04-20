using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class FunctieDAL : SqlConnect
    {
        public FunctieDAL()
        {
            Initialize();
        }

        public List<FunctieDTO> GetAllFuncties()
        {
            OpenConnect();

            cmd.CommandText = "SELECT * FROM Functie";

            using SqlDataReader rdr = cmd.ExecuteReader();

            List<FunctieDTO> listfuncties = new List<FunctieDTO>();

            while (rdr.Read())
            {
                FunctieDTO functie = new FunctieDTO()
                {
                    Id = rdr.GetInt32("Id"),
                    Name = rdr.GetString("Functie"),
                };
                listfuncties.Add(functie);
            }
            CloseConnect();

            return listfuncties;
        }
    }
}
