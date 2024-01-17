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
        private string oldContreIndic;
        private int oldQuantity;
        private User currentUser;
        private FormDrug formDrug;
        public EditDrug(string name, string description, string contreIndic, int quantity, User user, FormDrug formDrug)
        {
            InitializeComponent();
            oldName = name;
            oldDescription = description;
            oldContreIndic = contreIndic;
            oldQuantity = quantity;
            this.InputNameDrugEdit.Text = name;
            this.inputDescriptionDrugEdit.Text = description;
            this.inputContreIndic.Text = contreIndic;
            this.numericDrugEdit.Value = quantity;
            this.currentUser = user;
            this.formDrug = formDrug;
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
            string contreIndic = inputContreIndic.Text;
            int quantity = (int)numericDrugEdit.Value;
            

            Drug drug = new Drug(name, description, contreIndic, quantity);
             dataAccess.updateDrug(drug, oldName, oldDescription, oldContreIndic, oldQuantity); 
           
            formDrug.updateData();
          this.Close();


        }

        private void inputDescriptionDrugEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void inputContreIndic_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
