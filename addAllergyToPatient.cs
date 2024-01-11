using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventLab
{
    public partial class addAllergyToPatient : Form
    {
        AllergyDataAccess dataAccess = new AllergyDataAccess();
        string selectedAllergy; 

        public addAllergyToPatient(Patient patient)
        {
            InitializeComponent();

         idP.Text = patient.Id.ToString();
            List<string> allergies = dataAccess.getAllergies();
            listeAllergies.DataSource = allergies;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as System.Windows.Forms.ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                selectedAllergy = comboBox.SelectedItem.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idPatient = Convert.ToInt32(idP.Text);
            dataAccess.addAllergyToPatient(selectedAllergy, idPatient);
        }

        private void idP_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            addAllergy add = new addAllergy();
            add.Show();
        }

        private void namPatientFormAllergy_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
