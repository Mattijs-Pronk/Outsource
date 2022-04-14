using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class SqlConnect
    {
        //variabele aanmaken die in de DAL kunnen worden gebuikt.
        internal SqlCommand cmd;
        internal SqlConnection con;

        //Methode om connection tussen database op te zetten.
        public void Initialize()
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\matti\Desktop\Outsource VECOZO\DataAccesLayer\outsourcing.mdf; Integrated Security = True";
            con = new SqlConnection(connectionString);
            cmd = con.CreateCommand();
        }

        //Connectie opzetten met database.
        public bool OpenConnect()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        //Connectie afsluiten met database.
        public bool CloseConnect()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
