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
        public EditDrug(string name, string description)
        {
            InitializeComponent();
            oldName = name;
            oldDescription = description;
            this.InputNameDrugEdit.Text = name;
            this.inputDescriptionDrugEdit.Text = description;
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
            Drug drug = new Drug(this.InputNameDrugEdit.Text, this.inputDescriptionDrugEdit.Text);
            int result = dataAccess.updateDrug(drug, oldName, oldDescription); 
            MessageBox.Show(result.ToString());



        }

        private void inputDescriptionDrugEdit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
