namespace InventLab
{
    partial class addOrdonnance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.patient = new System.Windows.Forms.Label();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.printTitle = new System.Windows.Forms.Label();
            this.DateActuelle = new System.Windows.Forms.Label();
            this.medicament = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.dureeTraitement = new System.Windows.Forms.Label();
            this.posologie = new System.Windows.Forms.Label();
            this.printNameMedecin = new System.Windows.Forms.Label();
            this.printLastNameMedecin = new System.Windows.Forms.Label();
            this.inputPosologie = new System.Windows.Forms.TextBox();
            this.inputInstruction = new System.Windows.Forms.TextBox();
            this.inputDureeTraitement = new System.Windows.Forms.TextBox();
            this.buttonAddOrdonnance = new System.Windows.Forms.Button();
            this.comboBoxMedicaments = new System.Windows.Forms.ComboBox();
            this.buttonExportPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medecin";
            // 
            // patient
            // 
            this.patient.AutoSize = true;
            this.patient.Location = new System.Drawing.Point(27, 170);
            this.patient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(40, 13);
            this.patient.TabIndex = 1;
            this.patient.Text = "Patient";
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(30, 185);
            this.comboBoxPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(105, 21);
            this.comboBoxPatient.TabIndex = 2;
            this.comboBoxPatient.SelectedIndexChanged += new System.EventHandler(this.comboBoxPatient_SelectedIndexChanged);
            // 
            // printTitle
            // 
            this.printTitle.AutoSize = true;
            this.printTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printTitle.Location = new System.Drawing.Point(99, 19);
            this.printTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.printTitle.Name = "printTitle";
            this.printTitle.Size = new System.Drawing.Size(238, 26);
            this.printTitle.TabIndex = 4;
            this.printTitle.Text = "Création Ordonnance";
            this.printTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // DateActuelle
            // 
            this.DateActuelle.AutoSize = true;
            this.DateActuelle.Location = new System.Drawing.Point(353, 170);
            this.DateActuelle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateActuelle.Name = "DateActuelle";
            this.DateActuelle.Size = new System.Drawing.Size(70, 13);
            this.DateActuelle.TabIndex = 5;
            this.DateActuelle.Text = "Date actuelle";
            this.DateActuelle.Click += new System.EventHandler(this.DateActuelle_Click);
            // 
            // medicament
            // 
            this.medicament.AutoSize = true;
            this.medicament.Location = new System.Drawing.Point(27, 294);
            this.medicament.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.medicament.Name = "medicament";
            this.medicament.Size = new System.Drawing.Size(65, 13);
            this.medicament.TabIndex = 6;
            this.medicament.Text = "Medicament";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.Location = new System.Drawing.Point(27, 362);
            this.instruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(56, 13);
            this.instruction.TabIndex = 7;
            this.instruction.Text = "Instruction";
            // 
            // dureeTraitement
            // 
            this.dureeTraitement.AutoSize = true;
            this.dureeTraitement.Location = new System.Drawing.Point(30, 424);
            this.dureeTraitement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dureeTraitement.Name = "dureeTraitement";
            this.dureeTraitement.Size = new System.Drawing.Size(83, 13);
            this.dureeTraitement.TabIndex = 8;
            this.dureeTraitement.Text = "durée traitement";
            // 
            // posologie
            // 
            this.posologie.AutoSize = true;
            this.posologie.Location = new System.Drawing.Point(27, 224);
            this.posologie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.posologie.Name = "posologie";
            this.posologie.Size = new System.Drawing.Size(53, 13);
            this.posologie.TabIndex = 9;
            this.posologie.Text = "Posologie";
            // 
            // printNameMedecin
            // 
            this.printNameMedecin.AutoSize = true;
            this.printNameMedecin.Location = new System.Drawing.Point(27, 95);
            this.printNameMedecin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.printNameMedecin.Name = "printNameMedecin";
            this.printNameMedecin.Size = new System.Drawing.Size(86, 13);
            this.printNameMedecin.TabIndex = 10;
            this.printNameMedecin.Text = "Prenom medecin";
            this.printNameMedecin.Click += new System.EventHandler(this.label9_Click);
            // 
            // printLastNameMedecin
            // 
            this.printLastNameMedecin.AutoSize = true;
            this.printLastNameMedecin.Location = new System.Drawing.Point(166, 95);
            this.printLastNameMedecin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.printLastNameMedecin.Name = "printLastNameMedecin";
            this.printLastNameMedecin.Size = new System.Drawing.Size(72, 13);
            this.printLastNameMedecin.TabIndex = 11;
            this.printLastNameMedecin.Text = "Nom medecin";
            this.printLastNameMedecin.Click += new System.EventHandler(this.label10_Click);
            // 
            // inputPosologie
            // 
            this.inputPosologie.Location = new System.Drawing.Point(30, 240);
            this.inputPosologie.Name = "inputPosologie";
            this.inputPosologie.Size = new System.Drawing.Size(266, 20);
            this.inputPosologie.TabIndex = 12;
            this.inputPosologie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputInstruction
            // 
            this.inputInstruction.Location = new System.Drawing.Point(30, 378);
            this.inputInstruction.Name = "inputInstruction";
            this.inputInstruction.Size = new System.Drawing.Size(266, 20);
            this.inputInstruction.TabIndex = 14;
            this.inputInstruction.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // inputDureeTraitement
            // 
            this.inputDureeTraitement.Location = new System.Drawing.Point(30, 440);
            this.inputDureeTraitement.Name = "inputDureeTraitement";
            this.inputDureeTraitement.Size = new System.Drawing.Size(266, 20);
            this.inputDureeTraitement.TabIndex = 15;
            this.inputDureeTraitement.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // buttonAddOrdonnance
            // 
            this.buttonAddOrdonnance.Location = new System.Drawing.Point(116, 490);
            this.buttonAddOrdonnance.Name = "buttonAddOrdonnance";
            this.buttonAddOrdonnance.Size = new System.Drawing.Size(221, 36);
            this.buttonAddOrdonnance.TabIndex = 16;
            this.buttonAddOrdonnance.Text = "Enregistrer";
            this.buttonAddOrdonnance.UseVisualStyleBackColor = true;
            this.buttonAddOrdonnance.Click += new System.EventHandler(this.buttonAddOrdonnance_Click);
            // 
            // comboBoxMedicaments
            // 
            this.comboBoxMedicaments.FormattingEnabled = true;
            this.comboBoxMedicaments.Location = new System.Drawing.Point(30, 309);
            this.comboBoxMedicaments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxMedicaments.Name = "comboBoxMedicaments";
            this.comboBoxMedicaments.Size = new System.Drawing.Size(105, 21);
            this.comboBoxMedicaments.TabIndex = 17;
            this.comboBoxMedicaments.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedicaments_SelectedIndexChanged_1);
            // 
            // buttonExportPDF
            // 
            this.buttonExportPDF.Location = new System.Drawing.Point(116, 549);
            this.buttonExportPDF.Name = "buttonExportPDF";
            this.buttonExportPDF.Size = new System.Drawing.Size(221, 28);
            this.buttonExportPDF.TabIndex = 18;
            this.buttonExportPDF.Text = "Export en PDF";
            this.buttonExportPDF.UseVisualStyleBackColor = true;
            this.buttonExportPDF.Click += new System.EventHandler(this.buttonExportPDF_Click);
            // 
            // addOrdonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 606);
            this.Controls.Add(this.buttonExportPDF);
            this.Controls.Add(this.comboBoxMedicaments);
            this.Controls.Add(this.buttonAddOrdonnance);
            this.Controls.Add(this.inputDureeTraitement);
            this.Controls.Add(this.inputInstruction);
            this.Controls.Add(this.inputPosologie);
            this.Controls.Add(this.printLastNameMedecin);
            this.Controls.Add(this.printNameMedecin);
            this.Controls.Add(this.posologie);
            this.Controls.Add(this.dureeTraitement);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.medicament);
            this.Controls.Add(this.DateActuelle);
            this.Controls.Add(this.printTitle);
            this.Controls.Add(this.comboBoxPatient);
            this.Controls.Add(this.patient);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addOrdonnance";
            this.Text = "addOrdonnance";
            this.Load += new System.EventHandler(this.addOrdonnance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label patient;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.Label printTitle;
        private System.Windows.Forms.Label DateActuelle;
        private System.Windows.Forms.Label medicament;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.Label dureeTraitement;
        private System.Windows.Forms.Label posologie;
        private System.Windows.Forms.Label printNameMedecin;
        private System.Windows.Forms.Label printLastNameMedecin;
        private System.Windows.Forms.TextBox inputPosologie;
        private System.Windows.Forms.TextBox inputInstruction;
        private System.Windows.Forms.TextBox inputDureeTraitement;
        private System.Windows.Forms.Button buttonAddOrdonnance;
        private System.Windows.Forms.ComboBox comboBoxMedicaments;
        private System.Windows.Forms.Button buttonExportPDF;
    }
}