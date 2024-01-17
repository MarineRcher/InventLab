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
        private User currentUser;
        private GestionUsers gestionUsers;
        public signUp(User user, GestionUsers gestionUsers)
        {
            InitializeComponent();
            this.currentUser = user;
            this.gestionUsers = gestionUsers;
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
                
                User user = new User(null, name, lastName, email, login, password);
                
                int result = dataAccess.addUserToDB(user, selectedRole);
               // MessageBox.Show(result.ToString());
               gestionUsers.updateData();
               this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez entrer les memes mots de passes");
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
           
            if (comboBox1 != null && comboBox1.SelectedItem != null)
            {
                selectedRole = comboBox1.SelectedItem.ToString();
            }
        }

      
    }
}
