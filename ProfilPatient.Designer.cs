namespace InventLab
{
    partial class ProfilPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilPatient));
            this.NameAndLastname = new System.Windows.Forms.Label();
            this.birthPatient = new System.Windows.Forms.Label();
            this.labelSexe = new System.Windows.Forms.Label();
            this.printAllergy = new System.Windows.Forms.Label();
            this.printAntecedent = new System.Windows.Forms.Label();
            this.tableAllergiesPatient = new System.Windows.Forms.DataGridView();
            this.tableAntecedents = new System.Windows.Forms.DataGridView();
            this.printBirthPatient = new System.Windows.Forms.Label();
            this.printSexePatient = new System.Windows.Forms.Label();
            this.buttonAddAllergyPatient = new System.Windows.Forms.Button();
            this.buttonDeleteAllergyToPatient = new System.Windows.Forms.Button();
            this.buttonAddToPatientAntecedent = new System.Windows.Forms.Button();
            this.buttonDeleteAntecedentPatient = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.editBirth = new System.Windows.Forms.PictureBox();
            this.ButtonEditBirth = new System.Windows.Forms.Button();
            this.editBirthPatient = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tableAllergiesPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAntecedents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBirth)).BeginInit();
            this.SuspendLayout();
            // 
            // NameAndLastname
            // 
            this.NameAndLastname.AutoSize = true;
            this.NameAndLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameAndLastname.Location = new System.Drawing.Point(332, 25);
            this.NameAndLastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameAndLastname.Name = "NameAndLastname";
            this.NameAndLastname.Size = new System.Drawing.Size(111, 24);
            this.NameAndLastname.TabIndex = 0;
            this.NameAndLastname.Text = "Nom patient";
            this.NameAndLastname.Click += new System.EventHandler(this.label1_Click);
            // 
            // birthPatient
            // 
            this.birthPatient.AutoSize = true;
            this.birthPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthPatient.Location = new System.Drawing.Point(28, 132);
            this.birthPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthPatient.Name = "birthPatient";
            this.birthPatient.Size = new System.Drawing.Size(165, 24);
            this.birthPatient.TabIndex = 1;
            this.birthPatient.Text = "Date de naissance";
            // 
            // labelSexe
            // 
            this.labelSexe.AutoSize = true;
            this.labelSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexe.Location = new System.Drawing.Point(28, 217);
            this.labelSexe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSexe.Name = "labelSexe";
            this.labelSexe.Size = new System.Drawing.Size(54, 24);
            this.labelSexe.TabIndex = 2;
            this.labelSexe.Text = "Sexe";
            // 
            // printAllergy
            // 
            this.printAllergy.AutoSize = true;
            this.printAllergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printAllergy.Location = new System.Drawing.Point(473, 104);
            this.printAllergy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.printAllergy.Name = "printAllergy";
            this.printAllergy.Size = new System.Drawing.Size(83, 24);
            this.printAllergy.TabIndex = 3;
            this.printAllergy.Text = "Allergies";
            this.printAllergy.Click += new System.EventHandler(this.label4_Click);
            // 
            // printAntecedent
            // 
            this.printAntecedent.AutoSize = true;
            this.printAntecedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printAntecedent.Location = new System.Drawing.Point(473, 335);
            this.printAntecedent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.printAntecedent.Name = "printAntecedent";
            this.printAntecedent.Size = new System.Drawing.Size(116, 24);
            this.printAntecedent.TabIndex = 4;
            this.printAntecedent.Text = "Antecedents";
            // 
            // tableAllergiesPatient
            // 
            this.tableAllergiesPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAllergiesPatient.Location = new System.Drawing.Point(477, 136);
            this.tableAllergiesPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableAllergiesPatient.Name = "tableAllergiesPatient";
            this.tableAllergiesPatient.RowHeadersWidth = 51;
            this.tableAllergiesPatient.RowTemplate.Height = 24;
            this.tableAllergiesPatient.Size = new System.Drawing.Size(281, 105);
            this.tableAllergiesPatient.TabIndex = 5;
            this.tableAllergiesPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableAntecedents
            // 
            this.tableAntecedents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAntecedents.Location = new System.Drawing.Point(477, 370);
            this.tableAntecedents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableAntecedents.Name = "tableAntecedents";
            this.tableAntecedents.RowHeadersWidth = 51;
            this.tableAntecedents.RowTemplate.Height = 24;
            this.tableAntecedents.Size = new System.Drawing.Size(281, 105);
            this.tableAntecedents.TabIndex = 6;
            this.tableAntecedents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableAntecedents_CellContentClick);
            // 
            // printBirthPatient
            // 
            this.printBirthPatient.AutoSize = true;
            this.printBirthPatient.Location = new System.Drawing.Point(30, 169);
            this.printBirthPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.printBirthPatient.Name = "printBirthPatient";
            this.printBirthPatient.Size = new System.Drawing.Size(35, 13);
            this.printBirthPatient.TabIndex = 7;
            this.printBirthPatient.Text = "label6";
            // 
            // printSexePatient
            // 
            this.printSexePatient.AutoSize = true;
            this.printSexePatient.Location = new System.Drawing.Point(30, 249);
            this.printSexePatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.printSexePatient.Name = "printSexePatient";
            this.printSexePatient.Size = new System.Drawing.Size(84, 13);
            this.printSexePatient.TabIndex = 8;
            this.printSexePatient.Text = "printSexePatient";
            // 
            // buttonAddAllergyPatient
            // 
            this.buttonAddAllergyPatient.Location = new System.Drawing.Point(477, 249);
            this.buttonAddAllergyPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddAllergyPatient.Name = "buttonAddAllergyPatient";
            this.buttonAddAllergyPatient.Size = new System.Drawing.Size(128, 39);
            this.buttonAddAllergyPatient.TabIndex = 9;
            this.buttonAddAllergyPatient.Text = "Ajouter";
            this.buttonAddAllergyPatient.UseVisualStyleBackColor = true;
            this.buttonAddAllergyPatient.Click += new System.EventHandler(this.buttonAddAllergyPatient_Click);
            // 
            // buttonDeleteAllergyToPatient
            // 
            this.buttonDeleteAllergyToPatient.Location = new System.Drawing.Point(628, 249);
            this.buttonDeleteAllergyToPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteAllergyToPatient.Name = "buttonDeleteAllergyToPatient";
            this.buttonDeleteAllergyToPatient.Size = new System.Drawing.Size(130, 39);
            this.buttonDeleteAllergyToPatient.TabIndex = 10;
            this.buttonDeleteAllergyToPatient.Text = "Supprimer";
            this.buttonDeleteAllergyToPatient.UseVisualStyleBackColor = true;
            this.buttonDeleteAllergyToPatient.Click += new System.EventHandler(this.buttonDeleteAllergyToPatient_Click);
            // 
            // buttonAddToPatientAntecedent
            // 
            this.buttonAddToPatientAntecedent.Location = new System.Drawing.Point(477, 490);
            this.buttonAddToPatientAntecedent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddToPatientAntecedent.Name = "buttonAddToPatientAntecedent";
            this.buttonAddToPatientAntecedent.Size = new System.Drawing.Size(128, 39);
            this.buttonAddToPatientAntecedent.TabIndex = 11;
            this.buttonAddToPatientAntecedent.Text = "Ajouter";
            this.buttonAddToPatientAntecedent.UseVisualStyleBackColor = true;
            this.buttonAddToPatientAntecedent.Click += new System.EventHandler(this.buttonAddToPatientAntecedent_Click);
            // 
            // buttonDeleteAntecedentPatient
            // 
            this.buttonDeleteAntecedentPatient.Location = new System.Drawing.Point(628, 490);
            this.buttonDeleteAntecedentPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteAntecedentPatient.Name = "buttonDeleteAntecedentPatient";
            this.buttonDeleteAntecedentPatient.Size = new System.Drawing.Size(130, 39);
            this.buttonDeleteAntecedentPatient.TabIndex = 12;
            this.buttonDeleteAntecedentPatient.Text = "Supprimer";
            this.buttonDeleteAntecedentPatient.UseVisualStyleBackColor = true;
            this.buttonDeleteAntecedentPatient.Click += new System.EventHandler(this.buttonDeleteAntecedentPatient_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(174, 247);
            this.id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 13);
            this.id.TabIndex = 13;
            // 
            // editBirth
            // 
            this.editBirth.Image = ((System.Drawing.Image)(resources.GetObject("editBirth.Image")));
            this.editBirth.Location = new System.Drawing.Point(191, 138);
            this.editBirth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editBirth.Name = "editBirth";
            this.editBirth.Size = new System.Drawing.Size(17, 18);
            this.editBirth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editBirth.TabIndex = 14;
            this.editBirth.TabStop = false;
            this.editBirth.Click += new System.EventHandler(this.editBirth_Click);
            // 
            // ButtonEditBirth
            // 
            this.ButtonEditBirth.Location = new System.Drawing.Point(263, 166);
            this.ButtonEditBirth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonEditBirth.Name = "ButtonEditBirth";
            this.ButtonEditBirth.Size = new System.Drawing.Size(154, 28);
            this.ButtonEditBirth.TabIndex = 17;
            this.ButtonEditBirth.Text = "Modifier";
            this.ButtonEditBirth.UseVisualStyleBackColor = true;
            this.ButtonEditBirth.Click += new System.EventHandler(this.ButtonEditBirth_Click);
            // 
            // editBirthPatient
            // 
            this.editBirthPatient.Location = new System.Drawing.Point(22, 168);
            this.editBirthPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editBirthPatient.Name = "editBirthPatient";
            this.editBirthPatient.Size = new System.Drawing.Size(186, 20);
            this.editBirthPatient.TabIndex = 18;
            // 
            // ProfilPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 554);
            this.Controls.Add(this.editBirthPatient);
            this.Controls.Add(this.ButtonEditBirth);
            this.Controls.Add(this.editBirth);
            this.Controls.Add(this.id);
            this.Controls.Add(this.buttonDeleteAntecedentPatient);
            this.Controls.Add(this.buttonAddToPatientAntecedent);
            this.Controls.Add(this.buttonDeleteAllergyToPatient);
            this.Controls.Add(this.buttonAddAllergyPatient);
            this.Controls.Add(this.printSexePatient);
            this.Controls.Add(this.printBirthPatient);
            this.Controls.Add(this.tableAntecedents);
            this.Controls.Add(this.tableAllergiesPatient);
            this.Controls.Add(this.printAntecedent);
            this.Controls.Add(this.printAllergy);
            this.Controls.Add(this.labelSexe);
            this.Controls.Add(this.birthPatient);
            this.Controls.Add(this.NameAndLastname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProfilPatient";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProfilPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableAllergiesPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAntecedents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editBirth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameAndLastname;
        private System.Windows.Forms.Label birthPatient;
        private System.Windows.Forms.Label labelSexe;
        private System.Windows.Forms.Label printAllergy;
        private System.Windows.Forms.Label printAntecedent;
        private System.Windows.Forms.DataGridView tableAllergiesPatient;
        private System.Windows.Forms.DataGridView tableAntecedents;
        private System.Windows.Forms.Label printBirthPatient;
        private System.Windows.Forms.Label printSexePatient;
        private System.Windows.Forms.Button buttonAddAllergyPatient;
        private System.Windows.Forms.Button buttonDeleteAllergyToPatient;
        private System.Windows.Forms.Button buttonAddToPatientAntecedent;
        private System.Windows.Forms.Button buttonDeleteAntecedentPatient;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.PictureBox editBirth;
        private System.Windows.Forms.Button ButtonEditBirth;
        private System.Windows.Forms.DateTimePicker editBirthPatient;
    }
}