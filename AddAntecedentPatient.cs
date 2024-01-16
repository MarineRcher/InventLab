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
        public class AntecedentsItem
        {
            public string Name { get; set; }
            public bool IsChecked { get; set; }
        }
  
        antecedentsDataAccess dataAccess = new antecedentsDataAccess();
        private User currentUser;
        public AddAntecedentPatient(Patient patient, User user)
        {
            InitializeComponent();
            label2.Text = patient.Name;
            label3.Text = patient.LastName;
            idP.Text = patient.Id.ToString();
           idP.Visible = false;
            List<string> antecedents = dataAccess.getAntecedents();
            checkedListBoxAntecedent.DataSource = antecedents;
            this.currentUser = user;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listeAntecedents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idPatient = Convert.ToInt32(idP.Text);
            var antecdents = checkedListBoxAntecedent.CheckedItems;
            foreach(AntecedentsItem item in antecdents) { 
                dataAccess.addAntecedentToPatient(item.Name, idPatient);
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddAntecedent addAntecedent = new AddAntecedent(this.currentUser);
            addAntecedent.Show();
        }

        private void checkedListBoxAntecedent_Load(object sender, EventArgs e)
        {

        }

        private void AddAntecedentPatient_Load(object sender, EventArgs e)
        {

            var antecedents = dataAccess.getAntecedents()
               .Select(a => new AntecedentsItem { Name = a, IsChecked = false })
               .ToList();

            checkedListBoxAntecedent.DataSource = antecedents;
            checkedListBoxAntecedent.DisplayMember = "Name";
            checkedListBoxAntecedent.ValueMember = "IsChecked";
        }
    }
}
