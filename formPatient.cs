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
        public formPatient()
        {
            InitializeComponent();
        }

        private void formPatient_Load(object sender, EventArgs e)
        {

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

            DateTimePicker timePickerBirth = new DateTimePicker(); 
            DateTime selectedDate = timePickerBirth.Value; 
            string birth = selectedDate.ToString("yyyy-MM-dd");

           
            Patient patient = new Patient(name, lastName, birth, sexe);
            
            int result = dataAccess.addPatientToDB(patient);


          
            
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

        
    }
}
