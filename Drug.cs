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

        public int Quantity { get; set; }

        public Drug(string Name, string Description, int quantity = 0)
        {
            this.Name = Name;
            this.Description = Description;
            this.Quantity = Quantity;



        }
    }
}
