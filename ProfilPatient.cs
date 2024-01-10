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
    public partial class ProfilPatient : Form
    {
        private PatientDataAccess dataAccess = new PatientDataAccess();
        private AllergyDataAccess dataAccessAllergy = new AllergyDataAccess();
        public ProfilPatient(Patient patient)
        {
            InitializeComponent();

           
          
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


        }
        
        private void LoadAllergies(Allergy allergy)
        {

            if (allergy != null)
            {
                tableAllergiesPatient.DataSource = allergy;
           
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            editBirthPatient.Visible = true;
            pictureBox1.Visible = false;
            printBirthPatient.Visible=false;
            pictureBox1.Visible = false;
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
    }
}
