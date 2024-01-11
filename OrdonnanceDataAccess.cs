using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InventLab
{
    internal class OrdonnanceDataAccess
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        private List<Ordonnance> ordonnances = new List<Ordonnance>();


        public void addOrdonnance(Ordonnance ordonnance)
        {
            this.ordonnances.Add(ordonnance);
        }

        public int addOrdonnanceToDB(Ordonnance ordonnance)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "insert into ordonnance (posologie, duree_traitement, instruction_specifique, date_o) values (@posologie, @duree, @instruction, @date)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@posologie", ordonnance.Posologie);
                    command.Parameters.AddWithValue("@duree", ordonnance.Duree);
                    command.Parameters.AddWithValue("@instruction", ordonnance.Instruction);
                    command.Parameters.AddWithValue("@date", ordonnance.Date);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }
        public List<Ordonnance> selectOrdonnances(int idOrdon, string posologie, string duree, string instruction, string date, int idMed)
        {
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "select id_o posologie, duree_traitement, instruction_specifique, date_o from ordonnance where id_m=@idMed;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@idMed", idMed);
                  
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ordonnance ordonnance = new Ordonnance(idOrdon, posologie, duree, instruction, date);
                            ordonnance.IdOrd = reader.GetInt32("idOrdon");
                            ordonnance.Posologie = reader.GetString("posologie");
                            ordonnance.Duree = reader.GetString("duree_traitement");
                            ordonnance.Instruction = reader.GetString("instruction_specifique");
                            ordonnance.Date = reader.GetString("date_o");

                            ordonnances.Add(ordonnance);


                        }
                        return ordonnances;
                    }
                }
            }
        }



    }
}
