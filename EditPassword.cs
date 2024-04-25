using MySqlX.XDevAPI;
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
    public partial class EditPassword : Form
    {
        private User currentUser;
        UserDataAccess dataAccess = new UserDataAccess();
        private GestionMotDePasse gestionMotDePasse;
        public EditPassword(User user, User currentUser, GestionMotDePasse gestionMotDePasse)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            label3.Text = user.Name + ' ' + user.LastName;
            label5.Text = user.Id.ToString();
            label5.Visible = false;
            this.gestionMotDePasse = gestionMotDePasse;
        }

        private void EditPassword_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                int id = Convert.ToInt32(label5.Text);
                string password = textBox1.Text;
                string passwordConfirm = textBox2.Text;
              
                if (password.Equals(passwordConfirm))
                {
                    dataAccess.updatePasswordUser(id, password);
                    gestionMotDePasse.updateData();
                this.Close();
            }
                else
                {
                        MessageBox.Show("Veuillez utiliser le meme mot de passe");
                }
           
                
        }
    }
}
