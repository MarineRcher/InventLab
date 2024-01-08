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
                string query = "INSERT INTO patient (pat_name, pat_lastName, pat_birth, pat_sexe) VALUES (@name, @lastName, @birth, @sexe);";
               
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

        public List<Patient> getPatients(string name, string lastName, string birth, string sexe) { 
        
           using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "select pat_name, pat_lastName, pat_birth, pat_sexe from patient";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using(MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient(name, lastName, birth, sexe);
                            patient.Name = reader.GetString("pat_name");
                            patient.LastName = reader.GetString("pat_lastName");
                            patient.Birth = reader.GetString("pat_birth");
                            patient.Sexe = reader.GetString("pat_sexe");

                            patients.Add(patient);  
                        }
                        return patients;    
                        
                    }
                }
                
            } 
           
        }
    }
}
