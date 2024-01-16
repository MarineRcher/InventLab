using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InventLab
{
    internal class UserDataAccess
    {


        private string connectionString = ConfigurationManager.ConnectionStrings["localhost"].ConnectionString;

        private List<User> users = new List<User>();


        public void addDrug(User user)
        {
            this.users.Add(user);
        }



        public int addUserToDB(User user, string selectedRole)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query =
                    "INSERT INTO  medecin (prenom_m, nom_m, email_m, login_m, password_m, role) VALUES (@name, @lastName, @email, @login, @password, @role);";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", user.Name);
                    command.Parameters.AddWithValue("@lastName", user.LastName);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@login", user.Login);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@role", selectedRole);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        public int updatePasswordUser(int id_m, string newPassword)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE medecin SET password_m=@newPassword and modificationMotDePasse = ' ' WHERE id_m=@id;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@newPassword", newPassword);
                    command.Parameters.AddWithValue("@id", id_m);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        public int updateAskPasswordUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE medecin SET modificationMotDePasse = 'Yes' WHERE nom_m=@LastName and prenom_m=@Name and email_m=@email and login_m=@login ;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                   
                   
                    command.Parameters.AddWithValue("@Name", user.Name);
                    command.Parameters.AddWithValue("@LastName", user.LastName);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@login", user.Login);
                    Console.WriteLine(user.LastName);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        public List<User> selectUsers()
        {
            List<User> users = new List<User>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id_m, prenom_m, nom_m, email_m, login_m from medecin;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            User user = new User();
                            user.Id = reader.GetInt32("id_m");
                            user.Name = reader.GetString("prenom_m");
                            user.LastName = reader.GetString("nom_m");
                            user.LastName = reader.GetString("email_m");
                            user.Login = reader.GetString("login_m");

                            users.Add(user);

                        }

                        return users;
                    }
                }
            }
        }

        public List<User> selectUser(string login, string password)
        {
            List<User> users = new List<User>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query =
                    "SELECT login_m, role, prenom_m, nom_m, id_m FROM medecin WHERE login_m=@login AND password_m=@password;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User(null, login);
                            ;
                            user.Login = reader.GetString("login_m");
                            user.Role = reader.GetString("role");
                            user.Name = reader.GetString("prenom_m");
                            user.LastName = reader.GetString("nom_m");
                            user.Id = reader.GetInt32("id_m");
                            users.Add(user);
                        }

                        return users;
                    }
                }
            }
        }


        public int deleteUser(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "delete from ordonnance where id_m=@id; delete from medecin where id_m=@id;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", user.Id);

                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        public List<User> getUsers()
        {
            List<User> users = new List<User>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT nom_m FROM medecin";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User();
                            user.Name = reader.GetString("nom_m");

                            users.Add(user);
                        }

                        return users;
                    }
                }
            }
        }
        public List<User> getUserEditPassword()
        {
            List<User> users = new List<User>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "select id_m, nom_m, prenom_m from medecin where modificationMotDePasse='yes'";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User();
                            user.Id = reader.GetInt32("id_m");
                            user.Name = reader.GetString("prenom_m");
                            user.LastName = reader.GetString("nom_m");
                           
                            users.Add(user);

                        }

                        return users;
                    }
                }
            }

        }
    
    public List<User> getRoles()
        {
            List<User> users = new List<User>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "select distinct role from medecin";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User();
                            user.Role = reader.GetString("role");

                            users.Add(user);

                        }

                        return users;
                    }
                }
            }


        }
    }
}
