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
            }}

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
