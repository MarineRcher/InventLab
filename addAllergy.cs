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
        private AllergyDataAccess dataAccess = new AllergyDataAccess();
        private User currentUser;
        public addAllergy(User user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void buttonAddAllergy_Click(object sender, EventArgs e)
        {
            string Allergie = inputNameAllergy.Text;
            dataAccess.addAllergy(Allergie);
            this.Close();
        }

        private void inputNameAllergy_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
    }
}
