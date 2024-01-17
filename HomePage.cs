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
        private User currentUser;
        public HomePage(User user )
        {
            InitializeComponent();
            this.currentUser = user;
         
        }

       
        private void gestionDesPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            GestionPatient gestionPatients = new GestionPatient(this.currentUser);
            gestionPatients.Show();
        }

      



        private void inventaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            FormDrug formDrug = new FormDrug(this.currentUser);
            formDrug.Show();
           
        }

        private void ajouterUneAllergieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addAllergy addal = new addAllergy(this.currentUser);
            addal.Show();
            
        }

        private void ajoutsDantécédentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            AddAntecedent addAntecedent = new AddAntecedent(this.currentUser);
            addAntecedent.Show();
             
        }

        

        public void gestionDesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionUsers gestionUsers = new GestionUsers(this.currentUser); 
            gestionUsers.Show();
          
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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void gérerLesOrdonnancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionOrdonnance gestionOrdonnance = new GestionOrdonnance(this.currentUser);
            gestionOrdonnance.Show();
       
        }

        private void gestionMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionMotDePasse gestionMotDePasse = new GestionMotDePasse(this.currentUser);
            gestionMotDePasse.Show();
        }

        private void printWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
