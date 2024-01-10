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
    public partial class GestionPatient : Form
    {
        private PatientDataAccess dataAccess = new PatientDataAccess();
        public GestionPatient()
        {
            InitializeComponent();
            LoadPatientsData(dataAccess.getPatients(null, null, null, null)) ; 
           
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
            }

        }
        private void buttonAddPatientPage_Click(object sender, EventArgs e)
        {
            formPatient formPatient = new formPatient();
            formPatient.Show();
        }

        private void tablePatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
