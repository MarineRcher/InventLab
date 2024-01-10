using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventLab
{
    public partial class addAllergy : Form
    {
        private PatientDataAccess dataAccess = new PatientDataAccess();
        public addAllergy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Allergie = inputNameAllergy.Text;
            dataAccess.addAllergy(Allergie);
        }
    }
}
