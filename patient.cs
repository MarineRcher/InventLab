using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventLab
{
    public class Patient


    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Birth { get; set; }
        public string Sexe { get; set; }

        public Patient(int? id,string Name, string LastName, string Birth, string Sexe)
        {
            this.Id = id ?? 0 ;
            this.Name = Name;
            this.LastName = LastName;
            this.Birth = Birth;
            this.Sexe = Sexe;
        }

        public Patient()
        {
            this.Name= null;
            this.Id = 0;
        }
        public Patient(int Id)
        {
           
            this.Id =Id;
        }
        public Patient( string Name, string LastName, string Birth, string Sexe)
        {
            
            this.Name = Name;
            this.LastName = LastName;
            this.Birth = Birth;
            this.Sexe = Sexe;
        }
    }
}
