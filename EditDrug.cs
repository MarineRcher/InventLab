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
    public partial class EditDrug : Form
    {
        private DrugDataAccess dataAccess = new DrugDataAccess();
        private string oldName;
        private string oldDescription;
        private string oldQuantity;
        public EditDrug(string name, string description, int quantity)
        {
            InitializeComponent();
            oldName = name;
            oldDescription = description;
            oldQuantity = quantity;
            this.InputNameDrugEdit.Text = name;
            this.inputDescriptionDrugEdit.Text = description;
            this.numericDrugEdit.Value= quantity;
        }

        private void titleDrugEdit_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InputNameDrugEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            string name = InputNameDrugEdit.Text;
           string description = inputDescriptionDrugEdit.Text;
            int quantity = (int)numericDrugEdit.Value;


            Drug drug = new Drug(name, description, null);
            int result = dataAccess.updateNameAndDescriptionDrug(drug, oldName, oldDescription, oldQuantity); 
            MessageBox.Show(result.ToString());

           new FormDrug().Show();

        }

        private void inputDescriptionDrugEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
