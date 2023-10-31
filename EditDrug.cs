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
    public partial class EditDrug : Form
    {
      
        public EditDrug(string name, string description)
        {
            InitializeComponent();
            this.InputNameDrugEdit.Text = name;
            this.inputDescriptionDrugEdit.Text = description;
        }

        private void titleDrugEdit_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modifier_Click(object sender, EventArgs e)
        {
          
           
        }

      


    }
}
