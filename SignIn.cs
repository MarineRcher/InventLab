using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Bcpg.OpenPgp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if ((string.IsNullOrEmpty(inputSignInLogin.Text) || string.IsNullOrEmpty(inputSignInPassword.Text)))
            {
                MessageBox.Show("login ou mot de passe incorrect");
            }
            else
            {

                string email = inputSignInLogin.Text;
                string password = inputSignInPassword.Text;
                List<User> users = dataAccess.selectUser(email, password);
            
                if (users.Count == 0)
                {
                    MessageBox.Show("Merci de vous inscrire");
                }
                else
                {
                    
                    string role = users[0].Role;
                    User user = new User
                    {
                        Id = users[0].Id,
                        Name = users[0].Name,
                        LastName = users[0].LastName,
                       
                    };
                    Console.WriteLine(user.Id);
                    HomePage home = new HomePage(user);
                    home.Show();
                    this.Hide();
                    if (role == "admin")
                    {

                        foreach (ToolStripItem item in home.menuStrip1.Items)
                        {
                            item.Visible = true;
                            item.Enabled = true;
                        }

                    }
                    else if (role == "utilisateur")
                    {
                        foreach (ToolStripItem item in home.menuStrip1.Items)
                        {
                            switch (item.Name)
                            {
                                case "administrateurToolStripMenuItem":


                                    item.Visible = false;
                                    item.Enabled = false;
                                    break;

                            }
                        }

                        
                    }
                }
            }
        }


        private void inputSignInEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void inputSignInPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
              
           
        }



        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void askChangePassword_Click(object sender, EventArgs e)
        {
           AskChangePassword askChangePassword = new AskChangePassword();
            askChangePassword.Show();
        }
     



        private void inputSignInPassword_TextChanged(object sender, EventArgs e)
        {

            inputSignInPassword.PasswordChar = '*';

            inputSignInPassword.MaxLength = 14;
        }

    }
}
