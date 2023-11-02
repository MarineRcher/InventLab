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

        private void button1_Click(object sender, EventArgs e)
        {
            this.inputNameAddDrug.Text = Name;
            this.inputDescriptionAddDrug.Text = Description;


            Drug drug = new Drug(Name, Description);
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
    }
}
