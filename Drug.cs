using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventLab
{
    internal class Drug
    {

        public string Name { get; set; }
        public string Description { get; set; }

        public string ContreIndication { get; set; }

        public int Quantity { get; set; }

        public Drug()
        {
            this.Name = null;
            this.Description = null;
            this.ContreIndication = null;
            this.Quantity = 0;
        }
                public Drug(string Name, string Description, string ContreIndication, int? Quantity )
        {
            this.Name = Name;
            this.Description = Description;
            this.ContreIndication = ContreIndication;
            this.Quantity = Quantity ?? 0;
        }
    }
}
