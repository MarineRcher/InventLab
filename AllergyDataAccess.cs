using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static InventLab.GestionPatient;

namespace InventLab
{
    internal class AllergyDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        public class Allergy
        {
            public string Name { get; set; }
           
        }
        public int addAllergy(string allergie)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO allergie (libelle_al) VALUES (@allergie);";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@allergie", allergie);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return (int)result;
                }

            }
        }

        public List<string> getAllergies()
        {
            List<string> allergies = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "select distinct libelle_al from allergie;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allergies.Add(reader.GetString("libelle_al"));
                        }
                        return allergies;
                    }
                }
            }
        }

        //table est qui contient id allergie et patient


        public List<Allergy> GetAllergyByPatient(int idPatient)
        {
            List<Allergy> allergies = new List<Allergy>();


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT allergie.libelle_al AS Nom FROM allergie INNER JOIN est ON allergie.id_al = est.id_al WHERE est.id_p = @id";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", idPatient);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allergies.Add(new Allergy { Name = reader.GetString("Nom") });
                           
                        }

                        return allergies;
                    }
                }
            }
        }
        public int addAllergyToPatient(string selectedAllergy, int idPatient)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "insert into est (id_al, id_p) values ((select id_al from allergie where libelle_al=@name), @id)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", selectedAllergy);
                    command.Parameters.AddWithValue("@id", idPatient);
                    
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }
        public int deleteAllergyPatient(string allergie, Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "delete from est where id_al=(select id_al from allergie where libelle_al=@allergie) and id_p=@idPatient;";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@allergie", allergie);
                    command.Parameters.AddWithValue("@idPatient", patient.Id);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return (int)result;
                }

            }
        }

    }
}
