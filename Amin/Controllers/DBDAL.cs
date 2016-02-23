using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Amin.Controllers
{
    public class DBDAL
    {
        private static string dbcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\danda\documents\visual studio 2012\Projects\Amin\Amin\App_Data\Database1.mdf;Integrated Security=True";

        public static void AddPersonToDB(string person)
        {
            try
            {
                string Statement = "INSERT INTO cure (person)" +
                                    " VALUES (@person)";

                //using (var Connection = new SqlConnection(ConfigurationManager.AppSettings["SocialDBConnectionString"]))
                using (var Connection = new SqlConnection(dbcon))
                {
                    Connection.Open();

                    using (var Command = new SqlCommand(Statement, Connection))
                    {
                        Command.Parameters.Add(new SqlParameter("@person", person));

                        Command.ExecuteNonQuery();
                    }

                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                //log.Error("SendLog failed. action: " + action + ", CID: " + CID + ". ", ex);
            }
        }

        public static List<string> GetPersonsFromDB()
        {
            List<string> list = new List<string>();
            try
            {
                //using (var Connection = new SqlConnection(ConfigurationManager.AppSettings["SocialDBConnectionString"]))
                using (var Connection = new SqlConnection(dbcon))
                {
                    Connection.Open();
                    String Statement = "SELECT person FROM cure";

                    using (var Command = new SqlCommand(Statement, Connection))
                    {
                        var Reader = Command.ExecuteReader();
                        while (Reader.Read())
                        {
                            string person = Reader["person"].ToString();

                            list.Add(person);

                        }
                        Reader.Close();
                    }
                    Connection.Close();
                }
            }
            catch (Exception Ex)
            {
                //log.Error("GetLastAlerts failed. ", Ex);
            }
            finally
            {
            }

            return list;
        }

    }
}