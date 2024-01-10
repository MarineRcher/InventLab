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



        public int addUserToDB(User user)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO  medecin (prenom_m, nom_m, email_m, login_m, password_m) VALUES (@name, @lastName, @email, @login, @password);";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", user.Name);
                    command.Parameters.AddWithValue("@lastName", user.LastName);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@login", user.Login);
                    command.Parameters.AddWithValue("@password", user.Password);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        public int updatePasswordUser(User user, string newPassword)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE medecin SET password_m=@newPassword WHERE email_m=@email;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@newPassword", newPassword);
                    command.Parameters.AddWithValue("@email", user.Email);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }


        public List<User> selectUsers(string name, string lastName, string email, string login)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT prenom_m, nom_m, email_m, login_m from medecin;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            User user = new User(name, lastName, email, login);
                            user.Name = reader.GetString("prenom_m");
                            user.LastName = reader.GetString("nom_m");
                            user.LastName = reader.GetString("email_m");
                            user.Login= reader.GetString("login_m");

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
                string query = "SELECT login_m FROM medecin WHERE login_m=@login AND password_m=@password;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User(login);
                            user.Login = reader.GetString("login_m");

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
                string query = "delete from medecin where prenom_m=@name and nom_m=@lastName and email_m=@email;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", user.Name);
                    command.Parameters.AddWithValue("@lastName", user.LastName);
                    command.Parameters.AddWithValue("@email", user.Email);
                    int result = command.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }
    }
}
