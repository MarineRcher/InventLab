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
    public partial class CompositionMedicament : Form
    {

        private User currentUser;
        private DrugDataAccess dataAccess = new DrugDataAccess();
        public CompositionMedicament(User user, string name_med)
        {
            InitializeComponent();

            this.currentUser = user;
            List<Drug> drugs = dataAccess.moleculeMedicament(name_med);
            dataGridView1.DataSource = drugs;
            this.dataGridView1.Columns["Id"].Visible = false;
        this.dataGridView1.Columns["Name"].Visible = false;
        this.dataGridView1.Columns["Description"].Visible = false;
        this.dataGridView1.Columns["ContreIndication"].Visible = false;
        this.dataGridView1.Columns["Quantity"].Visible = false;

            label1.Text = name_med;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
