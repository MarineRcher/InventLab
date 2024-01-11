using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventLab
{
    internal class Ordonnance
    {
       public int IdOrd {  get; set; }
        public string Posologie { get; set; }
        public string Duree { get; set; }

        public string Instruction { get; set; }

        public string Date { get; set; }

        public Ordonnance(int IdOrd, string Posologie, string Duree, string Instruction, string Date)
        {
            this.IdOrd = IdOrd;
            this.Posologie = Posologie;
            this.Duree = Duree;
            this.Instruction = Instruction;
            this.Date = Date ;
        }
    }
}
