using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventLab
{
    public partial class FormDrug : Form
    {
        private User currentUser;
        private DrugDataAccess dataAccess = new DrugDataAccess();
        public FormDrug(User user)
        {
          
            InitializeComponent();
            LoadDrugData(dataAccess.selectDrug()); ;
            tableDrug.Refresh();
            this.currentUser = user;
            tableDrug.ReadOnly = true;
        }

        private void buttonAddDrug_Click(object sender, EventArgs e)
        {
            string name = inputNameAddDrug.Text;
            string description = inputDescriptionAddDrug.Text;
            string contreIndic = inputContreIndication.Text;
            int quantity = (int)inputQuantityAddDrug.Value;
            Drug drug = new Drug(name, description, contreIndic, quantity);
            int result = dataAccess.addDrugToDB(drug);


            LoadDrugData(dataAccess.selectDrug()); ;
            updateData();
        }

       
        public void updateData()
        {
            tableDrug.Refresh();
            this.tableDrug.DataSource = null;
            this.tableDrug.DataSource = dataAccess.selectDrug();
            this.tableDrug.Columns["Id"].Visible = false;
        }
        private void LoadDrugData(List<Drug> drugs)
        {
            if (drugs != null)
            {
                tableDrug.DataSource = drugs;
                this.tableDrug.Columns["Id"].Visible = false;
                tableDrug.Columns["Name"].HeaderText = "Prénom";
                tableDrug.Columns["ContreIndication"].HeaderText = "Contre-Indication";
                tableDrug.Columns["Quantity"].HeaderText = "Quantité";
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
                EditDrug editDrug = new EditDrug(oldName, oldDescription,oldContreIndic, oldQuantity, this.currentUser, this);
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
           
            string name = searchDrug.Text;
            name = name + "%";
            dataAccess.searchDrug(name);
            List<Drug> searchedDrugs = dataAccess.searchDrug(name);

            LoadDrugData(searchedDrugs);

        }
      

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void compo_Click(object sender, EventArgs e)
        {
            if (tableDrug.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tableDrug.SelectedRows[0];

                string name = selectedRow.Cells["name"].Value.ToString();

                CompositionMedicament compositionMedicament = new CompositionMedicament(this.currentUser, name);
                compositionMedicament.Show();
            }
        }
    }
}
