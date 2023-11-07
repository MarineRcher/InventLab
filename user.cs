using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventLab
{
    internal class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public User(string Name = null, string LastName = null, string Email = null, string Password = null)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Email = Email;
            this.Password = Password;
        }
    }
}
