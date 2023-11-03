using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InventLab
{
    internal class DrugDataAccess
    {

          
            private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

            private List<Drug> drugs = new List<Drug>();
       

        public void addDrug(Drug drug)
        {
            this.drugs.Add(drug);
        }



        public int addDrugToDB(Drug drug)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO drugs (name, description) VALUES (@name, @description);";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", drug.Name);
                    command.Parameters.AddWithValue("@description", drug.Description);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        public int updateDrug(Drug drug, string oldName, string oldDescription)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE drugs SET name=@newName, description=@newDescription WHERE name=@oldName AND description=@oldDescription;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@newName", drug.Name);
                    command.Parameters.AddWithValue("@newDescription", drug.Description);
                    command.Parameters.AddWithValue("@oldName", oldName);
                    command.Parameters.AddWithValue("@oldDescription", oldDescription);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }


        public List<Drug> selectDrug(string name, string description)
        {
           
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "select * from drugs;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Drug drug = new Drug(name, description);
                            drug.Name = reader.GetString("name");
                           drug.Description = reader.GetString("description");

                            drugs.Add(drug);
                           
                        }
                        return drugs;
                    }
                }
            }
        }

        public int deleteValue(Drug drug)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "delete from drugs where name=@name and description=@description;";
                using (MySqlCommand command = new MySqlCommand(query, conn)) 
                {
                    command.Parameters.AddWithValue("@name", drug.Name);
                    command.Parameters.AddWithValue("@description", drug.Description);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

      
    }
}
