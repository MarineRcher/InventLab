using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventLab
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
           
        }

        private String _message;

        public String Message
        {
            get => _message;
            set => _message = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Message);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _message = InputSignUpUsername.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void InputSignUpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputSignUpLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputSignUpPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
