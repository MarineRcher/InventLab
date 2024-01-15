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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string antecedent = textBox1.Text;
            dataAccess.addAntecedent(antecedent);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            HomePage home = new HomePage(this.currentUser);
            home.Show();
            this.Close();
        }
    }
}
