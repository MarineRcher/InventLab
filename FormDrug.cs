using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace InventLab
{
    public partial class FormDrug : Form
    {

       

        private DrugDataAccess dataAccess = new DrugDataAccess();
        public FormDrug()
        {
            InitializeComponent();
            LoadDrugData(dataAccess.selectDrug(null, null, null));
            tableDrug.Refresh();
        }

        private void buttonAddDrug_Click(object sender, EventArgs e)
        {
            string name = inputNameAddDrug.Text;
            string description = inputDescriptionAddDrug.Text;
            int quantity = (int)inputQuantityAddDrug.Value;
            Drug drug = new Drug(name, description, quantity);
            int result = dataAccess.addDrugToDB(drug);

            MessageBox.Show(result.ToString());
            LoadDrugData(dataAccess.selectDrug(null, null, null));
            updateData();
        }

        private void deleteDrug_Click_1(object sender, EventArgs e)
        {
            if (tableDrug.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tableDrug.SelectedRows[0];
                string name = selectedRow.Cells["name"].Value.ToString();
                string description = selectedRow.Cells["description"].Value.ToString();
                int quantity = (int)selectedRow.Cells["quantity"].Value;
                Drug drug = new Drug(name, description, quantity);
                int result = dataAccess.deleteValue(drug);
                MessageBox.Show(result.ToString());
                updateData();
            }
        }
        public void updateData()
        {
            tableDrug.Refresh();
            this.tableDrug.DataSource = null;
            this.tableDrug.DataSource = dataAccess.selectDrug(null, null, null);
        }
        private void LoadDrugData(List<Drug> drugs)
        {
            if (drugs != null)
            {
                tableDrug.DataSource = drugs;
            }
        }
        public void tableDrug_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = tableDrug.Rows[e.RowIndex];
                string oldName = selectedRow.Cells["name"].Value.ToString();
                string oldDescription = selectedRow.Cells["description"].Value.ToString();

                EditDrug editDrug = new EditDrug(oldName, oldDescription);
                editDrug.Show();
            }
        }


        private void FormDrug_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputNameAddDrug_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputDescriptionAddDrug_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
       

        private void inputQuantityAddDrug_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputQuantityAddDrug_ValueChanged(object sender, EventArgs e)
        {

        }

       
      
    }
}
