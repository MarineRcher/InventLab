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
        public GestionUsers()
        {
            InitializeComponent();
            LoadUsersData(dataAccess.selectUsers(0,null, null, null, null)) ;
            tableUsers.Refresh();
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
            }
        }

        private void tableUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void updateData()
        {
            tableUsers.Refresh();
            this.tableUsers.DataSource = null;
            this.tableUsers.DataSource = dataAccess.selectUsers(0, null, null, null, null);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tableUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tableUsers.SelectedRows[0];

                int id = (int)selectedRow.Cells["Id"].Value;
                User user = new User(id, null, null, null, null, null);
                int result = dataAccess.deleteUser(user);
                // MessageBox.Show(result.ToString());
                updateData();
            }
        }
    }
}
