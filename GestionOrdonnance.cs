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
    public partial class GestionOrdonnance : Form
    {
        OrdonnanceDataAccess dataAccess = new OrdonnanceDataAccess();
        private User currentUser;
        public GestionOrdonnance(User user)
        {
            InitializeComponent();
            this.currentUser = user;
            LoadOrdonnancesData(dataAccess.selectOrdonnances(currentUser.Id));
            tableOrdonnance.ReadOnly = true;
            tableOrdonnance.Refresh();
            printNameUser.Text = currentUser.Name;
                printLastNameUser.Text = currentUser.LastName;
        }

        private void GestionOrdonnance_Load(object sender, EventArgs e)
        {

        }
        private void LoadOrdonnancesData(List<Ordonnance> ordonnances)
        {

            if (ordonnances != null)
            {
                tableOrdonnance.DataSource = ordonnances;
                this.tableOrdonnance.Columns["idOrd"].Visible = false;
                tableOrdonnance.Columns["posologie"].HeaderText = "Posologie";
                tableOrdonnance.Columns["Duree"].HeaderText = "Durée du traitement";
                tableOrdonnance.Columns["NomPatient"].HeaderText = "Nom Patient";
                tableOrdonnance.Columns["PrenomPatient"].HeaderText = "Prénom";
                tableOrdonnance.Columns["LibelleMedicament"].HeaderText = "Nom du médicament";
            }
        }

        private void buttonDeleteOrdo_Click(object sender, EventArgs e)
        {
            if (tableOrdonnance.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tableOrdonnance.SelectedRows[0];

                int id = (int)selectedRow.Cells["idOrd"].Value;

                int result = dataAccess.deleteOrdonnanceToDB(id);
                // MessageBox.Show(result.ToString());
                updateData();
            }
        }
        public void updateData()
        {
            tableOrdonnance.Refresh();
            this.tableOrdonnance.DataSource = null;
            this.tableOrdonnance.DataSource = dataAccess.selectOrdonnances(currentUser.Id);
            this.tableOrdonnance.Columns["idOrd"].Visible = false;
            tableOrdonnance.Columns["posologie"].HeaderText = "Posologie";
            if (tableOrdonnance.Columns.Contains("duree_traitement"))
            {
                tableOrdonnance.Columns["duree_traitement"].HeaderText = "Durée du traitement";
            }

            tableOrdonnance.Columns["instruction_specifique"].HeaderText = "Instructions";
            tableOrdonnance.Columns["date_o"].HeaderText = "Date";
            tableOrdonnance.Columns["Nom_Patient"].HeaderText = "Nom Patient";
            tableOrdonnance.Columns["Prenom_Patient"].HeaderText = "Prénom";
             tableOrdonnance.Columns["Nom_medicament"].HeaderText = "Nom du médicament";

        }

        private void printNameLastNameUser_Click(object sender, EventArgs e)
        {

        }

     

        private void addOrdo_Click(object sender, EventArgs e)
        {
            addOrdonnance addOrd = new addOrdonnance(this.currentUser, this);
            addOrd.Show();
        }
    }
}
