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
    public partial class signUp: Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string name = inputNameAddDrug.Text;
            string description = inputDescriptionAddDrug.Text;

            Drug drug = new Drug(name, description);
            int result = dataAccess.addDrugToDB(drug);
            MessageBox.Show(result.ToString());
        }

        private void titleSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
