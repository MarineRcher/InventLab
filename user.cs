using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InventLab
{
    public class User
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }

        public string Role { get; set; }

        public User(int? Id = null, string Name = null, string LastName = null, string Email = null, string Login = null, string Password = null, string role = null)
        {
            this.Id = Id ?? 0;
            this.Name = Name;
            this.LastName = LastName;
            this.Email = Email;
            this.Login = Login;
            this.Password = Password;
            this.Role = Role;
        }
        public User(int Id, string Name, string LastName)
        {
            this.Id = Id;
            this.Name = Name;
            this.LastName = LastName;

        }
        public User(string Name, string LastName, string Email, string Login)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Email = Email;
            this.Login = Login;
        }
        public User()
        {
            this.Id = 0;
            this.Name = null;
            this.LastName = null;
            this.Role= null;
        }
    }
}
