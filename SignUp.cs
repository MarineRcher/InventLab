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
        private UserDataAccess dataAccess = new UserDataAccess();
        string selectedRole;
        public signUp()
        {
            InitializeComponent();
        }

      
        private void titleSignUp_Click(object sender, EventArgs e)
        {

        }

        private void inputNameSignUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSignUp_Click_1(object sender, EventArgs e)
        {

            string name = inputNameSignUp.Text;
            string lastName = inputLastNameSignUp.Text;
            string login = inputLogin.Text;
            string email = inputEmailSignUp.Text;
            string password = inputPasswordSignUp.Text;
            string passwordConfirm = inputPasswordConfirmationSignUp.Text;
         

            if (password
                .Equals(passwordConfirm))
            {
                User user = new User(null, name, lastName, email, login, password, selectedRole);
                int result = dataAccess.addUserToDB(user);
               // MessageBox.Show(result.ToString());
            }
            else
            {
                MessageBox.Show("Confirmation du mot de passe différent du mot de passe");
            }


        }

        private void inputLastNameSignUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUp_Load(object sender, EventArgs e)
        {
            List<User> users = dataAccess.getRoles();
            List<string> roles = users.Select(user => user.Role).ToList();
            comboBox1.DataSource = roles;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as System.Windows.Forms.ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                selectedRole = comboBox.SelectedItem.ToString();
            }
        }
    }
}
