using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;



namespace InventLab
{
    public partial class addOrdonnance : Form
    {
        OrdonnanceDataAccess dataAccess = new OrdonnanceDataAccess();
        DrugDataAccess dataAccessMed = new DrugDataAccess();
        PatientDataAccess dataAccessPatient = new PatientDataAccess();
        private User currentUser;
        private string selectedPatient;
        private string selectedNameMed;

        public addOrdonnance(User user)
        {
            InitializeComponent();

            this.currentUser = user;
             label9.Text = currentUser.Name;
            label10.Text = currentUser.LastName;
            int idMed = currentUser.Id;

            List<Patient> patients = dataAccessPatient.getPatientByMed(idMed);


            comboBox1.DataSource = patients;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            List<Drug> drugs = dataAccessMed.selectNameDrug();


            comboBox2.DataSource = drugs;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            var comboBox = sender as System.Windows.Forms.ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                selectedNameMed = comboBox.SelectedItem.ToString();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addOrdonnance_Load(object sender, EventArgs e)
        {
            //print Date actuelle
            DateTime thisDay = DateTime.Today;
            string formattedDate = thisDay.ToString("dd/M/yyyy");
            label4.Text = formattedDate;
        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as System.Windows.Forms.ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                selectedPatient = comboBox.SelectedItem.ToString();
            }


        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id_m = this.currentUser.Id;
            int id_p = Convert.ToInt32(comboBox1.SelectedValue);
            int Id_med = Convert.ToInt32(comboBox2.SelectedValue);

           
            var allergiesAndMeds = dataAccess.selectAllergieAndMedIncompatibles(id_p, Id_med);
            var antecedentsAndMeds = dataAccess.selectAntecedentAndMed(id_p, Id_med);

            // Construire le message d'alerte
            StringBuilder message = new StringBuilder();
            if (allergiesAndMeds.Allergies.Count > 0 || allergiesAndMeds.Medications.Count > 0)
            {
                message.AppendLine("Attention, il existe des incompatibilités avec des allergies !");
            }
            if (antecedentsAndMeds.Antecedents.Count > 0 || antecedentsAndMeds.Medications.Count > 0)
            {
                message.AppendLine("Attention, il existe des incompatibilités avec des antécédents !");
            }

            // Afficher le message d'alerte si nécessaire
            if (message.Length > 0)
            {
                var result = MessageBox.Show(message.ToString(), "Alerte", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel)
                {
                    return; // Arrêter l'exécution si l'utilisateur choisit d'annuler
                }
            }

            // Continuer avec l'ajout de l'ordonnance si tout va bien
            string posologie = textBox1.Text;
            string duree = textBox4.Text;
            string instruction = textBox3.Text;
            DateTime thisDay = DateTime.Today;
            string date = thisDay.ToString("yyyy-MM-dd");
            Ordonnance ordonnance = new Ordonnance(posologie, duree, instruction, date);

            dataAccess.addOrdonnanceToDB(ordonnance, Id_m, Id_med, id_p);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.DefaultExt = "pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (PdfWriter writer = new PdfWriter(filePath))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        // Ajouter le contenu de votre PDF
                        document.Add(new Paragraph("Ordonnance"));
                        document.Add(new Paragraph("Médecin: " + currentUser.Name + " " + currentUser.LastName));
                        document.Add(new Paragraph("Date: " + label4.Text));
                        document.Add(new Paragraph("Médicament : " + comboBox2.Text));
                        document.Add(new Paragraph("Patient : " + comboBox1.Text));
                        document.Add(new Paragraph("Posologie: " + textBox1.Text));
                        document.Add(new Paragraph("Durée: " + textBox4.Text));
                        document.Add(new Paragraph("Instructions: " + textBox3.Text));

                        // Continuez à ajouter d'autres informations si nécessaire

                        MessageBox.Show("PDF créé avec succès !");
                    }
                }
            }
        }

    }
}