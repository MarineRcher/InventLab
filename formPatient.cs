﻿using System;
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
        public formPatient()
        {
            InitializeComponent();
           
        }

        private void formPatient_Load(object sender, EventArgs e)
        {
            List<string> allergies = dataAccessAllergy.getAllergies();
            comboBox2.DataSource = allergies;
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

           
            Patient patient = new Patient(null, name, lastName, birth, sexe);
            
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

        private void inputNamePatient_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            addAllergy add = new addAllergy();
            add.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}