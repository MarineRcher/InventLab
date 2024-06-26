﻿using System;
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

        public string NomPatient { get; set; }
        public string PrenomPatient { get; set; }
        public string LibelleMedicament { get; set; }

        public Ordonnance(int IdOrd, string Posologie, string Duree, string Instruction, string Date, string NomPatient, string PrenomPatient, string LibelleMedicament)
        {
            this.IdOrd = IdOrd;
            this.Posologie = Posologie;
            this.Duree = Duree;
            this.Instruction = Instruction;
            this.Date = Date ;
            this.NomPatient = NomPatient;
            this.PrenomPatient = PrenomPatient;
            this.LibelleMedicament = LibelleMedicament;
        }  public Ordonnance(int IdOrd, string Posologie, string Duree, string Instruction, string Date)
        {
            this.IdOrd = IdOrd;
            this.Posologie = Posologie;
            this.Duree = Duree;
            this.Instruction = Instruction;
            this.Date = Date ;
        }
        public Ordonnance( string Posologie, string Duree, string Instruction, string Date)
        {
           
            this.Posologie = Posologie;
            this.Duree = Duree;
            this.Instruction = Instruction;
            this.Date = Date;
        }

        public Ordonnance()
        {
            this.IdOrd = 0;
            this.Posologie = null;
            this.Duree = null;
            this.Instruction = null;
            this.Date = null;
        }
    }
}
