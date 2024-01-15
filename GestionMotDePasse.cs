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
    public partial class GestionMotDePasse : Form
    {
        UserDataAccess dataAccess = new UserDataAccess();
        private User currentUser;
        public GestionMotDePasse(User user)
        {
            InitializeComponent();
            LoadPasswordData(dataAccess.getUserEditPassword());

            tablePassword.Refresh();
            this.currentUser = user;
        }
        private void LoadPasswordData(List<User> users)
        {

            if (users != null)
            {
                tablePassword.DataSource = users;
               this.tablePassword.Columns["Id"].Visible = false;
            }

        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
               DataGridViewRow selectedRow = tablePassword.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
               string name = selectedRow.Cells["name"].Value.ToString();
               string lastName = selectedRow.Cells["LastName"].Value.ToString();
               User user = new User(id, name, lastName);
                EditPassword editPassword = new EditPassword(user, this.currentUser);
                editPassword.Show();
            }
        }

        private void GestionMotDePasse_Load(object sender, EventArgs e)
        {

        }
    }
}
