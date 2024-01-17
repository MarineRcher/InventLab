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
    public partial class GestionUsers : Form
    {
        UserDataAccess dataAccess= new UserDataAccess();
        private User currentUser;
        public GestionUsers(User user)
        {
            InitializeComponent();
            LoadUsersData(dataAccess.selectUsers()) ;
            tableUsers.Refresh();
            this.currentUser = user;
            tableUsers.ReadOnly = true;
        }

        private void GestionUsers_Load(object sender, EventArgs e)
        {

        }

        private void LoadUsersData(List<User> users)
        {
            if (users != null)
            {
                tableUsers.DataSource = users;
                this.tableUsers.Columns["Id"].Visible = false;
                this.tableUsers.Columns["Password"].Visible = false;
            }
        }

        private void tableUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void updateData()
        {
            tableUsers.Refresh();
            this.tableUsers.DataSource = null;
            this.tableUsers.DataSource = dataAccess.selectUsers();
            this.tableUsers.Columns["Id"].Visible = false;
            this.tableUsers.Columns["Password"].Visible = false;
        }
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (tableUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tableUsers.SelectedRows[0];

                int id = (int)selectedRow.Cells["Id"].Value;
                User user = new User(id);
                int result = dataAccess.deleteUser(user);
                // MessageBox.Show(result.ToString());
                updateData();
            }
        }

        private void gestUser_Click(object sender, EventArgs e)
        {

        }

       

        private void addUser_Click(object sender, EventArgs e)
        {
            signUp up = new signUp(this.currentUser, this);
            up.Show();
        }
    }
}
