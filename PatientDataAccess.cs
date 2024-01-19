using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data;
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


        public int addPatientToDB(Patient patient, int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string query = "INSERT INTO patient (prenom_p, nom_p, birth, sexe, id_m) VALUES (@name, @lastName, @birth, @sexe, @idmedecin);";
               
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", patient.Name);
                    command.Parameters.AddWithValue("@lastName", patient.LastName);
                    command.Parameters.AddWithValue("@birth", patient.Birth);
                    command.Parameters.AddWithValue("@sexe", patient.Sexe);
                    command.Parameters.AddWithValue("@idmedecin", id); 
                 
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
               
            }
        }

        public List<Patient> getPatients(int Id) {
            this.patients = new List<Patient>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
              
                conn.Open();
                string query = "select id_p, prenom_p, nom_p, DATE_FORMAT(birth, '%d/%m/%Y') as birth, sexe from patient where id_m=@id";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", Id);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient();
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
        public List<Patient> getPatient(int Id)
        {
            this.patients = new List<Patient>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

                conn.Open();
                string query = "select id_p, prenom_p, nom_p, DATE_FORMAT(birth, '%d/%m/%Y') as birth, sexe from patient where id_p=@id";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", Id);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient();
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
                string query = "delete from gsb.a_eu where id_p=@id; delete from gsb.est where id_p=@id; delete from patient where id_p=@id;";
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

        public int inscriptionPatientAllergies (Patient patient, string selectedAllergy)
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "insert into est (id_al, id_p) values ((select id_al from allergie where libelle_al=@name),(select id_p from patient where nom_p=@lastName and prenom_p=@nameP and birth=@birth limit 1))";
                using(MySqlCommand command = new MySqlCommand( query, conn))
                {
                    command.Parameters.AddWithValue("@name", selectedAllergy);
                    command.Parameters.AddWithValue("@lastName", patient.LastName);
                    command.Parameters.AddWithValue("@nameP", patient.Name);
                    command.Parameters.AddWithValue("@birth", patient.Birth);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }
        public int inscriptionPatientAntecedent(Patient patient, string selectedAntecedent)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "insert into a_eu (id_a, id_p) values ((select id_a from antecedent where libelle_a=@name),(select id_p from patient where nom_p=@lastName and prenom_p=@nameP and birth=@birth limit 1))";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", selectedAntecedent);
                    command.Parameters.AddWithValue("@lastName", patient.LastName);
                    command.Parameters.AddWithValue("@nameP", patient.Name);
                    command.Parameters.AddWithValue("@birth", patient.Birth);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }
        public List<Patient> getPatientByMed(int idMed)
        {
            this.patients = new List<Patient>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "select id_p, concat( prenom_p, ' ', nom_p) as name from patient where id_m= @id";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", idMed);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient();
                            patient.Id = reader.GetInt32("id_p");
                            patient.Name = reader.GetString("name");
                           


                            patients.Add(patient);
                        }
                        return patients;

                    }

                }

            }

        }




    }
}
