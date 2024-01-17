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
    public partial class AskChangePassword : Form
    {
        UserDataAccess dataAccess = new UserDataAccess();
        public AskChangePassword()
        {
            InitializeComponent();
        }

        private void buttonAskChangePassword_Click(object sender, EventArgs e)
        {
           
            string LastName = inputLastName.Text;
            string Name = inputName.Text;
           
            string Login = inputLogin.Text;
            string Email = inputEmail.Text;
            
         
            User user = new User(Name, LastName, Email, Login);
          
            dataAccess.updateAskPasswordUser(user);
            this.Close();
        }
    }
}
