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
    public partial class HomePage : Form
    {
        public HomePage(UserSession userSession )
        {
            InitializeComponent();
            label2.Text = userSession.CurrentUserId.ToString();
            label3.Text = userSession.UserName;
            label4.Text = userSession.UserLastName;
        }

       
        private void gestionDesPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPatient gestionPatients = new GestionPatient();
            gestionPatients.Show();
            this.Hide();
        }

        private void créerUneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajoutDunPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPatient addPatient = new formPatient();
            addPatient.Show();
            this.Hide();
        }

        private void inventaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDrug formDrug = new FormDrug();
            formDrug.Show();
            this.Hide();
        }

        private void ajouterUneAllergieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAllergy addal = new addAllergy();
            addal.Show();
            this.Hide();
        }

        private void ajoutsDantécédentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAntecedent addAntecedent = new AddAntecedent();
            addAntecedent.Show();
                this.Hide();
        }

        public void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            signUp signUp = new signUp();
            signUp.Show();
            this.Hide();
        }

        public void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionUsers gestionUsers = new GestionUsers(); 
            gestionUsers.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
