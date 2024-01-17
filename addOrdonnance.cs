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
        private GestionOrdonnance gestionOrdonnanceForm;
        public addOrdonnance(User user, GestionOrdonnance gestionOrdonnanceForm)
        {
            InitializeComponent();
            this.gestionOrdonnanceForm = gestionOrdonnanceForm;
            this.currentUser = user;
             printNameMedecin.Text = currentUser.Name;
            printLastNameMedecin.Text = currentUser.LastName;
            int idMed = currentUser.Id;
            Console.WriteLine(idMed);
            List<Patient> patients = dataAccessPatient.getPatientByMed(idMed);


            comboBoxPatient.DataSource = patients;
            comboBoxPatient.DisplayMember = "Name";
            comboBoxPatient.ValueMember = "Id";
            List<Drug> drugs = dataAccessMed.selectNameDrug();


            comboBoxMedicaments.DataSource = drugs;
            comboBoxMedicaments.DisplayMember = "Name";
            comboBoxMedicaments.ValueMember = "Id";


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
            DateActuelle.Text = formattedDate;
        }

        private void DateActuelle_Click(object sender, EventArgs e)
        {


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as System.Windows.Forms.ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                selectedPatient = comboBox.SelectedItem.ToString();
            }


        }

        private void comboBoxMedicaments_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonAddOrdonnance_Click(object sender, EventArgs e)
        {
            int Id_m = this.currentUser.Id;
            int id_p = Convert.ToInt32(comboBoxPatient.SelectedValue);
            int Id_med = Convert.ToInt32(comboBoxMedicaments.SelectedValue);

           
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
            string posologie = inputPosologie.Text;
            string duree = inputDureeTraitement.Text;
            string instruction = inputInstruction.Text;
            DateTime thisDay = DateTime.Today;
            string date = thisDay.ToString("yyyy-MM-dd");
            Ordonnance ordonnance = new Ordonnance(posologie, duree, instruction, date);

            dataAccess.addOrdonnanceToDB(ordonnance, Id_m, Id_med, id_p);
            gestionOrdonnanceForm.updateData();
            this.Close();
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

        private void buttonExportPDF_Click(object sender, EventArgs e)
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

                     

                        document.Add(new Paragraph("Ordonnance du patient " + comboBoxPatient.Text));
                        document.Add(new Paragraph("Par le médecin: " + currentUser.Name + " " + currentUser.LastName));
                        document.Add(new Paragraph("En date du : " + DateActuelle.Text) );
                        document.Add(new Paragraph("Médicament : " + comboBoxMedicaments.Text));
               
                        document.Add(new Paragraph("Posologie: " + inputPosologie.Text));
                        document.Add(new Paragraph("Durée: " + inputDureeTraitement.Text));
                        document.Add(new Paragraph("Instructions: " + inputInstruction.Text));

                        MessageBox.Show("PDF créé avec succès !");
                    }
                }
            }
        }

       
    }
}