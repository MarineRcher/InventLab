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
    public partial class printDrug : Form
    {
     
        private DrugDataAccess dataAccess = new DrugDataAccess();
       
      
        public printDrug()
        {
            InitializeComponent();
            LoadDrugData(dataAccess.selectDrug(null, null));
        }

        public void tableDrug_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = tableDrug.Rows[e.RowIndex];
                string oldName = selectedRow.Cells["name"].Value.ToString();
                string oldDescription = selectedRow.Cells["description"].Value.ToString();

                EditDrug editDrug = new EditDrug(oldName, oldDescription);
                editDrug.Show();
            }
        }
        private void LoadDrugData(List<Drug> drugs)
        {
            if (drugs != null)
            {
                tableDrug.DataSource = drugs;
            }
        }



        private void titlePrintDrug_Click(object sender, EventArgs e)
        {

        }

        private void deleteDrug_Click(object sender, EventArgs e)
        {
            if (tableDrug.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tableDrug.SelectedRows[0];
                string name = selectedRow.Cells["name"].Value.ToString();
                string description = selectedRow.Cells["description"].Value.ToString();
                Drug drug = new Drug(name, description);
                int result = dataAccess.deleteValue(drug);
                MessageBox.Show(result.ToString());
            }
        }

    }
}
