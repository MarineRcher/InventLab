using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace InventLab
{
    public partial class formPatient : Form
    {
        private PatientDataAccess dataAccess = new PatientDataAccess();
        private AllergyDataAccess dataAccessAllergy = new AllergyDataAccess();
        private antecedentsDataAccess dataAccessAntecedent = new antecedentsDataAccess();
        string selectedAllergy;
        string selectedAntecedent;
        private User currentUser;

        private GestionPatient gestionPatientForm;
        public formPatient(User user, GestionPatient gestionPatientForm)
        {
            InitializeComponent();
            this.currentUser = user;
            this.gestionPatientForm = gestionPatientForm;
            DateTimePicker timePickerBirth = new DateTimePicker();
        }

        private void FormPatient_Load(object sender, EventArgs e)
        {
            List<string> allergies = dataAccessAllergy.getAllergies();  
            comboBoxAllergy.DataSource = allergies;

            List<string> antecedents = dataAccessAntecedent.getAntecedents();
            comboBoxAntecedent.DataSource = antecedents;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {

            string sexe = "";

            if (checkWomenSexePatient.Checked)
            {
                sexe = "F";
            }
            else if (checkSexeManPatient.Checked)
            {
                sexe = "H";
            }

            string name = inputNamePatient.Text;
            string lastName = inputLastNamePatient.Text;

           
            DateTime selectedDate = timePickerBirth.Value; 
            string birth = selectedDate.ToString("yyyy-MM-dd");
            int id = currentUser.Id;
           
            Patient patient = new Patient( name, lastName, birth, sexe);
            
            int result = dataAccess.addPatientToDB(patient, id);

            dataAccess.inscriptionPatientAllergies(patient, selectedAllergy);
            dataAccess.inscriptionPatientAntecedent(patient, selectedAntecedent);


            gestionPatientForm.updateData();
            this.Close();

        }
        private void checkSexeManPatient_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSexeManPatient.Checked)
            {
                checkWomenSexePatient.Checked = false;
            }
        }

        private void checkWomenSexePatient_CheckedChanged(object sender, EventArgs e)
        {
            if (checkWomenSexePatient.Checked)
            {
                checkSexeManPatient.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void inputNamePatient_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            addAllergy add = new addAllergy(this.currentUser);
            add.Show();
        }

        private void comboBoxAllergy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as System.Windows.Forms.ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                selectedAllergy = comboBox.SelectedItem.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddAntecedent addAntecedent = new AddAntecedent(this.currentUser);
            addAntecedent.Show();

        }

        private void comboBoxAntecedent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as System.Windows.Forms.ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                selectedAntecedent = comboBox.SelectedItem.ToString();
            }
        }

       
    }
}
