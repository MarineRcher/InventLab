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
    public partial class AddAntecedentPatient : Form
    {
        string selectedAntecedent;
        antecedentsDataAccess dataAccess = new antecedentsDataAccess();
        public AddAntecedentPatient(Patient patient)
        {
            InitializeComponent();
            idP.Text = patient.Id.ToString();
            List<string> allergies = dataAccess.getAntecedents();
            listeAllergies.DataSource = allergies;
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listeAntecedents_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as System.Windows.Forms.ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                selectedAntecedent = comboBox.SelectedItem.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idPatient = Convert.ToInt32(idP.Text);
            dataAccess.addAntecedentToPatient(selectedAntecedent, idPatient);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddAntecedent addAntecedent = new AddAntecedent();
            addAntecedent.Show();
        }
    }
}
