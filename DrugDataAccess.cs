using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventLab
{
    internal class DrugDataAccess
    {

        private List<Drug> drugs = new List<Drug>();

        public void addDrug(Drug drug)
        {
            this.drugs.Add(drug);
        }

        public List<Drug> getDrugList() {  return this.drugs; }
    }
}
