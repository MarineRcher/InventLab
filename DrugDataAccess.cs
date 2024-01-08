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
                string query = "INSERT INTO medication (med_name, med_description, med_contraindication, med_quantity) VALUES (@name, @description, @contreIndic, @quantity);";
               
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", drug.Name);
                    command.Parameters.AddWithValue("@description", drug.Description);
                    command.Parameters.AddWithValue("@contreIndic", drug.ContreIndication);
                    command.Parameters.AddWithValue("@quantity", drug.Quantity);
  
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        public int updateDrug(Drug drug, string oldName, string oldDescription, string oldContreIndic,int oldQuantity)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE medication SET med_name=@newName, med_description=@newDescription, med_contraindication=@newContreIndic, med_quantity=@newQuantity WHERE med_name=@oldName AND med_description=@oldDescription and med_contraindication=@oldContreIndic AND med_quantity=@oldQuantity;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@newName", drug.Name);
                    command.Parameters.AddWithValue("@newDescription", drug.Description);
                    command.Parameters.AddWithValue("@NewContreIndic", drug.ContreIndication);
                    command.Parameters.AddWithValue("@oldContreIndic", oldContreIndic);
                    command.Parameters.AddWithValue("@oldName", oldName);
                    command.Parameters.AddWithValue("@oldDescription", oldDescription);
                    command.Parameters.AddWithValue("@oldQuantity", oldQuantity);
                    command.Parameters.AddWithValue("@newQuantity", drug.Quantity);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }


        public List<Drug> selectDrug(string name, string description, string contreIndic, int? quantity)
        {
           this.drugs = new List<Drug>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "select med_name, med_description, med_contraindication, med_quantity from medication;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Drug drug = new Drug(name, description, contreIndic, quantity); ;
                            drug.Name = reader.GetString("med_name");
                           drug.Description = reader.GetString("med_description");
                            drug.ContreIndication = reader.GetString("med_contraindication");
                            drug.Quantity = reader.GetInt32("med_quantity");

                            drugs.Add(drug);

                                                    
                        }
                        return drugs;
                    }
                }
            }
        }

/*        public List<Drug> searchDrug(string name, string description, int quantity)
        {
            this.drugs.Clear();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = " select * from where name=@name;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", drugs.name);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Drug drug = new Drug(name, description, quantity);
                            drug.Name = reader.GetString("name");
                            drug.Description = reader.GetString("description");
                            drug.Quantity = reader.GetInt32("quantity");

                            drugs.Add(drug);
                        }
                        return drugs;
                    }
                   
                }
            }
        }*/

        public int deleteValue(Drug drug)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "delete from medication where med_name=@name and med_description=@description and med_contraindication=@contreIndic and med_quantity=@quantity;";
                using (MySqlCommand command = new MySqlCommand(query, conn)) 
                {
                    command.Parameters.AddWithValue("@name", drug.Name);
                    command.Parameters.AddWithValue("@description", drug.Description);
                    command.Parameters.AddWithValue("@contreIndic", drug.ContreIndication);
                    command.Parameters.AddWithValue("@quantity", drug.Quantity);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

      
    }
}
