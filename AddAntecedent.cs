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
    public partial class AddAntecedent : Form
    {
        antecedentsDataAccess dataAccess = new antecedentsDataAccess();
        private User currentUser;
        public AddAntecedent(User user)
        {
            InitializeComponent();
            this.currentUser = user;
        }

        private void inputAntecedent_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddAntecedent_Click(object sender, EventArgs e)
        {
            string antecedent = inputAntecedent.Text;
            dataAccess.addAntecedent(antecedent);
            this.Close();
        }

       
        private void AddAntecedent_Load(object sender, EventArgs e)
        {

        }
    }
}
