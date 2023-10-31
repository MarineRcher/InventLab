using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventLab
{
    internal class UserDataAccess
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;
        private List<Drug> drugs = new List<Drug>();

        public void addDrug(Drug drug)
        {
            this.drugs.Add(drug);
        }

        public List<Drug> getDrugList() { return this.drugs; }

        public int addDrugToDB(Drug drug)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO drugs (name, description) VALUES (@name, @description)";
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
