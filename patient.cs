using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventLab
{
    internal class Patient


    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Birth { get; set; }
        public string Sexe { get; set; }

        public Patient(string Name, string LastName, string Birth, string Sexe)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Birth = Birth;
            this.Sexe = Sexe;
        }
    }
}
