using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventLab
{
    internal class user
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public User(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }
    }
}
