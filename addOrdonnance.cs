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
    public partial class addOrdonnance : Form
    {
        UserDataAccess dataAccessUser = new UserDataAccess();
        DrugDataAccess dataAccessMed = new DrugDataAccess();
        PatientDataAccess dataAccessPatient = new PatientDataAccess();
        public addOrdonnance()
        {
            InitializeComponent();
         //List<string> users = dataAccessUser.getUsers() ;
            //comboBox2.DataSource = users;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addOrdonnance_Load(object sender, EventArgs e)
        {
            //print Date actuelle
            DateTime thisDay = DateTime.Today;
            string formattedDate = thisDay.ToString("dd/M/yyyy");
            label4.Text = formattedDate;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            

        }
    }
}
