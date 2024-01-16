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
        public class AllergyItem
        {
            public string Name { get; set; }
            public bool IsChecked { get; set; }
        }
        AllergyDataAccess dataAccess = new AllergyDataAccess();
       
        private User currentUser;
        public addAllergyToPatient(Patient patient, User user)
        {
            InitializeComponent();
            label2.Text = patient.Name;
            label3.Text = patient.LastName;

         idP.Text = patient.Id.ToString();
            idP.Visible = false;
            List<string> allergies = dataAccess.getAllergies();
            checkedListBoxAllergies.DataSource = allergies;
            this.currentUser = user;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int idPatient = Convert.ToInt32(idP.Text);
            var allergies = checkedListBoxAllergies.CheckedItems;

            foreach (AllergyItem item in allergies)
            {
                dataAccess.addAllergyToPatient(item.Name, idPatient);
            }
        }



        private void idP_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            addAllergy add = new addAllergy(this.currentUser);
            add.Show();
        }

        private void namPatientFormAllergy_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addAllergyToPatient_Load(object sender, EventArgs e)
        {
            var allergies = dataAccess.getAllergies()
                .Select(a => new AllergyItem { Name = a, IsChecked = false })
                .ToList();

     

            checkedListBoxAllergies.DataSource = allergies;
            checkedListBoxAllergies.DisplayMember = "Name";
            checkedListBoxAllergies.ValueMember = "IsChecked";
        }


        private void checkedListBoxAllergies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
