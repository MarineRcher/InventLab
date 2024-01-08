using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventLab
{
    internal class Patient


    {
        public string Name;
        public string LastName;
        public string Birth;
        public string Sexe;

        public Patient(string Name, string LastName, string Birth, string Sexe)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Birth = Birth;
            this.Sexe = Sexe;
        }
    }
}
