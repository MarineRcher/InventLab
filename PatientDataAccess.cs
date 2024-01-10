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
    internal class PatientDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        private List<Patient> patients = new List<Patient>();

        public void addPatient(Patient patient)
        {
            this.patients.Add(patient);
        }


        public int addPatientToDB(Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO patient (prenom_p, nom_p, birth, sexe) VALUES (@name, @lastName, @birth, @sexe);";
               
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", patient.Name);
                    command.Parameters.AddWithValue("@lastName", patient.LastName);
                    command.Parameters.AddWithValue("@birth", patient.Birth);
                    command.Parameters.AddWithValue("@sexe", patient.Sexe);
                 
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
               
            }
        }

        public List<Patient> getPatients(int? id,string name, string lastName, string birth, string sexe) {
            this.patients = new List<Patient>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "select id_p, prenom_p, nom_p, DATE_FORMAT(birth, '%d/%m/%Y') as birth, sexe from patient";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient(id, name, lastName, birth, sexe);
                            patient.Id = reader.GetInt32("id_p");
                            patient.Name = reader.GetString("prenom_p");
                            patient.LastName = reader.GetString("nom_p");
                            patient.Birth = reader.GetString("birth");
                            patient.Sexe = reader.GetString("sexe");
                           

                            patients.Add(patient);  
                        }
                        return patients;    
                       
                    }

                }
                
            } 
           
        }
        
        public int deletePatient(Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "delete from patient where id_p=@id;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", patient.Id);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        public int updateBirth(Patient patient)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE patient set birth=@newBirth where id_p=@id;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@newBirth", patient.Birth);
                    command.Parameters.AddWithValue("@id", patient.Id);
                   
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        public List<string> getAllergies()
        {
            List<string> allergies = new List<string>();
            using (MySqlConnection conn= new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "select libelle_al from allergie;";
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

    }
}
