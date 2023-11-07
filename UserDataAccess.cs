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
                string query = "INSERT INTO users (name, lastName, email, password) VALUES (@name, @lastName, @email, @password);";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@name", user.Name);
                    command.Parameters.AddWithValue("@lastName", user.LastName);
                    command.Parameters.AddWithValue("@email", user.Email);
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
                string query = "UPDATE drugs SET password=@newPassword WHERE email=@email;";
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


        public List<User> selectUsers(string name, string lastName, string email)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT name, lastName, email from users;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            User user = new User(name, lastName, email);
                            user.Name = reader.GetString("name");
                            user.LastName = reader.GetString("lastName");
                            user.LastName = reader.GetString("email");

                            users.Add(user);

                        }
                        return users;
                    }
                }
            }
        }

        public List<User> selectUser(string email, string password)
        {
            List<User> users = new List<User>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT name, lastName, email FROM users WHERE email=@email AND password =@password;";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User(email);
                            user.Email = reader.GetString("email");

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
                string query = "delete from users where name=@name and lastName=@lastName and email=@email;";
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
