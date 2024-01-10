using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventLab
{
    internal class AllergyDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        List<string> Allergy = new List<string>();
        public int addAllergy(Allergy allergy)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO allergie (libelle_al) VALUES (@allergie);";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@allergie", allergy.Nom);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return (int)result;
                }

            }
        }

        public List<Allergy> getAllergies()
        {
      
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "select libelle_al from allergie;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Allergy allergy = new Allergy(nom);
                            Allergy.Nom=reader.GetString("libelle_al"));

                        }
                        return Allergy;
                    }
                }
            }
        }

        //table est qui contient id allergie et patient
      

        public List<string> GetAllergyByPatient(int idPatient)
        {

          
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "select libelle_al as Nom from (allergie, est) where allergie.id_al = est.id_al and id_p = @id";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", idPatient);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            allergies.Add(reader.GetString("Nom"));

                          
                      
                    }
                        return allergies;
                       
                    }
            }
        }
    }
    }
}
