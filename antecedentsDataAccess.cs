
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static InventLab.antecedentsDataAccess;

namespace InventLab
{
    internal class antecedentsDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
 
        public class Antecedent
        {
            public string Name { get; set; }

        }
        public List<Antecedent> GetAntecedentByPatient(int idPatient)
        {
            List<Antecedent> antecedents = new List<Antecedent>();


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open(); 
                string query = "SELECT distinct antecedent.libelle_a AS Nom FROM (antecedent, a_eu) INNER JOIN est ON antecedent.id_a = a_eu.id_a WHERE a_eu.id_p =@id";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", idPatient);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            antecedents.Add(new Antecedent { Name = reader.GetString("Nom") });

                        }

                        return antecedents;
                    }
                }
            }
        }

        public int addAntecedent(string antecedent)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO antecedent (libelle_a) VALUES (@antecedent);";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@antecedent", antecedent);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return (int)result;
                }

            }
        }
        public List<string> getAntecedents()
        {
            List<string> antecedent = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "select libelle_a from antecedent;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            antecedent.Add(reader.GetString("libelle_a"));
                        }
                        return antecedent;
                    }
                }
            }
        }
        public int addAntecedentToPatient(string selectAntecedent, int idPatient)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "insert into a_eu (id_a, id_p) values ((select id_a from antecedent where libelle_a=@name), @id)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", selectAntecedent);
                    command.Parameters.AddWithValue("@id", idPatient);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }
        public int deleteAntecedentPatient(string antecedent, Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "delete from a_eu where id_a=(select id_a from antecedent where libelle_a=@antecedent) and id_p=@idPatient;";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@antecedent", antecedent);
                    command.Parameters.AddWithValue("@idPatient", patient.Id);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return (int)result;
                }

            }
        }
    }
}
