using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace InventLab
{
    public partial class SignIn : Form
    {
        private UserDataAccess dataAccess = new UserDataAccess();
        public SignIn()
        {
            InitializeComponent();
        }

   
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(inputSignInEmail.Text) || string.IsNullOrEmpty(inputSignInPassword.Text)))
            {
                MessageBox.Show("email ou mot de passe incorrect");
            } else
            {
              
                string email = inputSignInEmail.Text;
                string password = inputSignInPassword.Text;
                List<User> users = dataAccess.selectUser(email, password);

                if (users.Count == 0)
                {
                    MessageBox.Show("Merci de vous inscrire");
                }
                else
                {
                    MessageBox.Show("Vous êtes connecté");
                }
            }
        }

      
    }
}
