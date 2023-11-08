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
        }

        private void buttonAddDrug_Click(object sender, EventArgs e)
        {
            string name = inputNameAddDrug.Text;
            string description = inputDescriptionAddDrug.Text;
            int quantity = (int)inputQuantityAddDrug.Value;
            Drug drug = new Drug(name, description, quantity);
            int result = dataAccess.addDrugToDB(drug);
            MessageBox.Show(result.ToString());
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
