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
        public class AllergiesAndMeds
        {
            public List<string> Allergies { get; set; }
            public List<string> Medications { get; set; }

            public AllergiesAndMeds()
            {
                Allergies = new List<string>();
                Medications = new List<string>();
            }
        }
        
        public class AntecedentsAndMeds
        {
            public List<string> Antecedents { get; set; }
            public List<string> Medications { get; set; }

            public AntecedentsAndMeds()
            {
                Antecedents = new List<string>();
                Medications = new List<string>();
            }
        }
        public int addOrdonnanceToDB(Ordonnance ordonnance, int Id_m, int Id_med, int Id_p)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "insert into ordonnance (posologie, duree_traitement, instruction_specifique, date_o, id_m, id_med, id_p) values (@posologie, @duree, @instruction, @date, @id_m, @id_med, @id_p)";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@posologie", ordonnance.Posologie);
                    command.Parameters.AddWithValue("@duree", ordonnance.Duree);
                    command.Parameters.AddWithValue("@instruction", ordonnance.Instruction);
                    command.Parameters.AddWithValue("@date", ordonnance.Date);
                    command.Parameters.AddWithValue("@id_m", Id_m);
                    command.Parameters.AddWithValue("@Id_med", Id_med);
                    command.Parameters.AddWithValue("@Id_p", Id_p);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }
        public int deleteOrdonnanceToDB(int id_o)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "delete from ordonnance where id_o = @id_o";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_o", id_o);
                   
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        public List<Ordonnance> selectOrdonnances(int idMed)
        {
            
            this.ordonnances = new List<Ordonnance>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "select a.id_o, a.posologie, a.duree_traitement, a.instruction_specifique, DATE_FORMAT(a.date_o, '%d/%m/%Y') as date_o, p.nom_p as Nom_Patient, p.prenom_p as Prenom_Patient, m.libelle_med as Nom_medicament from gsb.ordonnance a join gsb.patient p on p.id_p = a.id_p join gsb.medicament m on m.id_med= a.id_med where a.id_m=@idMed;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@idMed", idMed);
                  
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ordonnance ordonnance = new Ordonnance();
                            ordonnance.IdOrd = reader.GetInt32("id_o");
                            ordonnance.Posologie = reader.GetString("posologie");
                            ordonnance.Duree = reader.GetString("duree_traitement");
                            ordonnance.Instruction = reader.GetString("instruction_specifique");
                            ordonnance.Date = reader.GetString("date_o");
                            ordonnance.NomPatient = reader.GetString("Nom_Patient"); 
                            ordonnance.PrenomPatient = reader.GetString("Prenom_Patient");
                            ordonnance.LibelleMedicament = reader.GetString("Nom_medicament"); 
                            ordonnances.Add(ordonnance);

                        }
                        return (ordonnances);
                    }
                }
            }
        }

        public List<string> selectMedicationNamesIncompatibles(int idMed)
        {
            List<string> medicationNames = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT m.libelle_med FROM gsb.medicament m JOIN gsb.incompatible i ON m.id_med = i.id_med_Medicament WHERE i.id_med = @idMed;";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@idMed", idMed);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string medName = reader.GetString("libelle_med");
                            medicationNames.Add(medName);
                        }
                    }
                }
            }

            return medicationNames;
        }
        public List<string> selectMedicationNamesIncompatibles(int idMed, int id_p, string date)
        {
            List<string> medicationNames = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT m.libelle_med FROM gsb.medicament m JOIN gsb.incompatible i ON m.id_med = i.id_med_Medicament WHERE i.id_med = @id_med AND m.id_med IN ( SELECT o.id_med FROM gsb.ordonnance o WHERE o.id_p = @id_p AND o.date_o = @date);";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_med", idMed);
                    command.Parameters.AddWithValue("@id_p", id_p);
                    command.Parameters.AddWithValue("@date", date);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string medName = reader.GetString("libelle_med");
                            medicationNames.Add(medName);
                        }
                    }
                }
            }

            return medicationNames;
        }
        public AllergiesAndMeds selectAllergieAndMedIncompatibles(int id_p, int idMed)
        {
            AllergiesAndMeds result = new AllergiesAndMeds();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT a.libelle_al, m.libelle_med FROM est e JOIN incompatible i ON e.id_al = i.id_al JOIN allergie a ON i.id_al = a.id_al JOIN medicament m ON i.id_med = m.id_med WHERE e.id_p = @id_p AND i.id_med = @id_med;";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_p", id_p);
                    command.Parameters.AddWithValue("@id_med", idMed);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string allergy = reader.GetString("libelle_al");
                            string medication = reader.GetString("libelle_med");

                            if (!result.Allergies.Contains(allergy))
                            {
                                result.Allergies.Add(allergy);
                            }

                            if (!result.Medications.Contains(medication))
                            {
                                result.Medications.Add(medication);
                            }
                        }
                    }
                }
            }

            return result;
        }
        public AntecedentsAndMeds selectAntecedentAndMed(int id_p, int idMed)
        {
            AntecedentsAndMeds result = new AntecedentsAndMeds();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = " SELECT a.libelle_a, m.libelle_med FROM a_eu e JOIN incompatible i ON e.id_a = i.id_a JOIN antecedent a ON i.id_a = a.id_a JOIN medicament m ON i.id_med = m.id_med WHERE e.id_p = @id_p AND i.id_med = @id_med;";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id_p", id_p);
                    command.Parameters.AddWithValue("@id_med", idMed);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string antecedent = reader.GetString("libelle_a");
                            string medication = reader.GetString("libelle_med");

                            if (!result.Antecedents.Contains(antecedent))
                            {
                                result.Antecedents.Add(antecedent);
                            }


                            if (!result.Medications.Contains(medication))
                            {
                                result.Medications.Add(medication);
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
