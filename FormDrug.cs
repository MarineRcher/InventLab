using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventLab
{
    public partial class FormDrug : Form
    {

       

        private DrugDataAccess dataAccess = new DrugDataAccess();
        public FormDrug()
        {
            InitializeComponent();
            LoadDrugData(dataAccess.selectDrug(null, null, null, null)); ;
            tableDrug.Refresh();
        }

        private void buttonAddDrug_Click(object sender, EventArgs e)
        {
            string name = inputNameAddDrug.Text;
            string description = inputDescriptionAddDrug.Text;
            string contreIndic = inputContreIndication.Text;
            int quantity = (int)inputQuantityAddDrug.Value;
            Drug drug = new Drug(name, description, contreIndic, quantity);
            int result = dataAccess.addDrugToDB(drug);


            LoadDrugData(dataAccess.selectDrug(null, null, null, null)); ;
            updateData();
        }

        private void deleteDrug_Click_1(object sender, EventArgs e)
        {
            if (tableDrug.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tableDrug.SelectedRows[0];
                string name = selectedRow.Cells["name"].Value.ToString();
                string description = selectedRow.Cells["description"].Value.ToString();
                string contreIndic = selectedRow.Cells["contreIndication"].Value.ToString();
                int quantity = (int)selectedRow.Cells["quantity"].Value;
                Drug drug = new Drug(name, description, contreIndic, quantity);
                int result = dataAccess.deleteValue(drug);
               // MessageBox.Show(result.ToString());
                updateData();
            }
        }
        public void updateData()
        {
            tableDrug.Refresh();
            this.tableDrug.DataSource = null;
            this.tableDrug.DataSource = dataAccess.selectDrug(null, null,null, null);
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
                string oldContreIndic = selectedRow.Cells["contreIndication"].Value.ToString();
                string quantityStr = selectedRow.Cells["quantity"].Value.ToString();
                int oldQuantity = System.Convert.ToInt32(quantityStr);
                EditDrug editDrug = new EditDrug(oldName, oldDescription,oldContreIndic, oldQuantity);
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

        private void searchDrug_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }
    }
}
