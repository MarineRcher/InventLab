using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace InventLab
{
    public partial class FormDrug : Form
    {

       

        private DrugDataAccess dataAccess = new DrugDataAccess();
        public FormDrug()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Drug drug = new Drug(this.textBox1.Text, this.textBox2.Text);
            //dataAccess.addDrug(drug);
            int result = dataAccess.addDrugToDB(drug);
            MessageBox.Show(result.ToString());
            //updateDataGridView();
        }

        public void updateDataGridView()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = dataAccess.getDrugList();
        }

        private void FormDrug_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string name = selectedRow.Cells["name"].Value.ToString();
                string description = selectedRow.Cells["description"].Value.ToString();

                EditDrug editDrug = new EditDrug(name, description);
                editDrug.Show();
            }
        }
    }
}
