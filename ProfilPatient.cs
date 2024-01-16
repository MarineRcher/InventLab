using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static InventLab.AllergyDataAccess;
using static InventLab.GestionPatient;

namespace InventLab
{
    public partial class ProfilPatient : Form
    {
        private PatientDataAccess dataAccess = new PatientDataAccess();
        private AllergyDataAccess dataAccessAllergy = new AllergyDataAccess();
        private antecedentsDataAccess dataAccessAntecedents = new antecedentsDataAccess();
        private User currentUser;
        public ProfilPatient(Patient patient, User user)
        {
            InitializeComponent();

            tableAllergiesPatient.Refresh();
            tableAntecedents.Refresh();

            // Print nom et prénom patient
            NameAndLastname.Text = patient.Name + " " + patient.LastName;
            printBirthPatient.Text = patient.Birth;
            printSexePatient.Text = patient.Sexe;
            id.Text= patient.Id.ToString();
            ButtonEditBirth.Visible = false;
           editBirthPatient.Visible = false;
            this.id.Visible =false;

            int idPatient = patient.Id;
            LoadAllergies(dataAccessAllergy.GetAllergyByPatient(idPatient));
            LoadAntecedents(dataAccessAntecedents.GetAntecedentByPatient(idPatient));

            this.currentUser = user;

        }

    


        private void LoadAllergies(List<AllergyDataAccess.Allergy> allergies)
        {
            if (allergies != null)
            {
                tableAllergiesPatient.DataSource = allergies;
            }
        }
        private void LoadAntecedents(List<antecedentsDataAccess.Antecedent> antecedents)
        {
            if (antecedents != null)
            {
                tableAntecedents.DataSource = antecedents;
            }
        }


        private void ProfilPatient_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void editBirth_Click(object sender, EventArgs e)
        {
            editBirthPatient.Visible = true;
            editBirth.Visible = false;
            printBirthPatient.Visible=false;
            editBirth.Visible = false;
            ButtonEditBirth.Visible = true;
          
        }

        private void ButtonEditBirth_Click(object sender, EventArgs e)
        {
            string name = "null";
            string lastName = "null";
            DateTimePicker editBirthPatient = new DateTimePicker();
            DateTime selectedDate = editBirthPatient.Value;
            string newBirth = selectedDate.ToString("yyyy-MM-dd");
          
            string sexe = "null";
            int idPatient = Convert.ToInt32(id.Text);
            Patient patient = new Patient(idPatient, name, lastName, newBirth, sexe);
            dataAccess.updateBirth(patient);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddAllergyPatient_Click(object sender, EventArgs e)

        {
            int idPatient = Convert.ToInt32(id.Text);
            Patient patient = new Patient(idPatient, null, null, null, null);
            addAllergyToPatient add = new addAllergyToPatient( patient, this.currentUser);
            add.Show();
           


        }

        private void tableAntecedents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDeleteAllergyToPatient_Click(object sender, EventArgs e)
        {
            if (tableAllergiesPatient.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tableAllergiesPatient.SelectedRows[0];
                string allergie = selectedRow.Cells["Name"].Value.ToString();
                int idPatient = Convert.ToInt32(id.Text);
                Patient patient = new Patient(idPatient, null, null, null, null);
                dataAccessAllergy.deleteAllergyPatient(allergie, patient);
                updateDataAllergies();
            }

        }

        private void buttonAddToPatientAntecedent_Click(object sender, EventArgs e)
        {
            int idPatient = Convert.ToInt32(id.Text);
            Patient patient = new Patient(idPatient, null, null, null, null);
            AddAntecedentPatient addAntecedent = new AddAntecedentPatient(patient, this.currentUser);
            addAntecedent.Show();
          
        }

        private void buttonDeleteAntecedentPatient_Click(object sender, EventArgs e)
        {
            if (tableAntecedents.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tableAntecedents.SelectedRows[0];
                string antecedent = selectedRow.Cells["Name"].Value.ToString();
                int idPatient = Convert.ToInt32(id.Text);
                Patient patient = new Patient(idPatient, null, null, null, null);
                dataAccessAntecedents.deleteAntecedentPatient(antecedent, patient);
                updateDataAntecedent();
            }
        }
        public void updateDataAntecedent()
        {
            int idPatient = Convert.ToInt32(id.Text);
            tableAntecedents.Refresh();
            this.tableAntecedents.DataSource = null;
            this.tableAntecedents.DataSource = dataAccessAntecedents.GetAntecedentByPatient(idPatient);
        }

        public void updateDataAllergies()
        {
            int idPatient = Convert.ToInt32(id.Text);
            tableAllergiesPatient.Refresh();
            this.tableAllergiesPatient.DataSource = null;
            this.tableAllergiesPatient.DataSource = dataAccessAllergy.GetAllergyByPatient(idPatient);
        }
        private void HomePage_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage(this.currentUser);
            home.Show();
            this.Close();
        }
    }
}
