using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace InventLab
{
    public partial class GestionPatient : Form

    {
        private User currentUser;

        private PatientDataAccess dataAccess = new PatientDataAccess();
        public GestionPatient(User user)
        {
            
            InitializeComponent();
          this.currentUser = user;
          int idMed = currentUser.Id;
            LoadPatientsData(dataAccess.getPatients(idMed));
            tablePatient.ReadOnly = true;
            tablePatient.Refresh();
            
        }      
     
       
        private void GestionPatient_Load(object sender, EventArgs e)
        {

        }
      
        private void LoadPatientsData(List<Patient> patients)
        {
          
            if (patients != null)
            {
                tablePatient.DataSource = patients;
                this.tablePatient.Columns["id"].Visible = false;
            }

        }
        public void updateData()
        {

            tablePatient.Refresh();
            this.tablePatient.DataSource = null;
            int idMed = currentUser.Id;
            this.tablePatient.DataSource = dataAccess.getPatients(idMed);
            this.tablePatient.Columns["id"].Visible = false;
        }
        private void buttonAddPatientPage_Click(object sender, EventArgs e)
        {
            formPatient formPatient = new formPatient(this.currentUser, this);
            formPatient.Show();

        }

        private void tablePatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {

            if (tablePatient.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tablePatient.SelectedRows[0];
              
                int id = (int)selectedRow.Cells["id"].Value;
                Patient patient = new Patient(id);
                int result = dataAccess.deletePatient(patient);
                // MessageBox.Show(result.ToString());

               updateData();
            }
        }

        private void profilPatient_Click(object sender, EventArgs e)
        {
            if (tablePatient.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tablePatient.SelectedRows[0];
                string name = selectedRow.Cells["name"].Value.ToString();
                string lastName = selectedRow.Cells["lastName"].Value.ToString();
                string birth = selectedRow.Cells["birth"].Value.ToString();
                string sexe = selectedRow.Cells["sexe"].Value.ToString();
                int id = (int)selectedRow.Cells["id"].Value;
               
                Patient patient = new Patient(id, name, lastName, birth, sexe);
                ProfilPatient profilPatient = new ProfilPatient(patient, this.currentUser);
                profilPatient.Show();

            }
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
           
            HomePage home = new HomePage(this.currentUser);
            home.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void titleGestionPatients_Click(object sender, EventArgs e)
        {

        }
    }
}
