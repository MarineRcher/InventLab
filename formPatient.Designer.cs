namespace InventLab
{
    partial class formPatient
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
            this.namePatient = new System.Windows.Forms.Label();
            this.inputNamePatient = new System.Windows.Forms.TextBox();
            this.antecedentPatient = new System.Windows.Forms.Label();
            this.lastNamePatient = new System.Windows.Forms.Label();
            this.inputLastNamePatient = new System.Windows.Forms.TextBox();
            this.sexePatient = new System.Windows.Forms.Label();
            this.allergyPatient = new System.Windows.Forms.Label();
            this.birthPatient = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titleAddNewPatient = new System.Windows.Forms.Label();
            this.timePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAllergy = new System.Windows.Forms.ComboBox();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.checkSexeManPatient = new System.Windows.Forms.CheckBox();
            this.checkWomenSexePatient = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAntecedent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namePatient
            // 
            this.namePatient.AutoSize = true;
            this.namePatient.Location = new System.Drawing.Point(18, 70);
            this.namePatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namePatient.Name = "namePatient";
            this.namePatient.Size = new System.Drawing.Size(43, 13);
            this.namePatient.TabIndex = 0;
            this.namePatient.Text = "Prénom";
            this.namePatient.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputNamePatient
            // 
            this.inputNamePatient.Location = new System.Drawing.Point(20, 95);
            this.inputNamePatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputNamePatient.Name = "inputNamePatient";
            this.inputNamePatient.Size = new System.Drawing.Size(187, 20);
            this.inputNamePatient.TabIndex = 1;
            this.inputNamePatient.TextChanged += new System.EventHandler(this.inputNamePatient_TextChanged);
            // 
            // antecedentPatient
            // 
            this.antecedentPatient.AutoSize = true;
            this.antecedentPatient.Location = new System.Drawing.Point(312, 70);
            this.antecedentPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.antecedentPatient.Name = "antecedentPatient";
            this.antecedentPatient.Size = new System.Drawing.Size(67, 13);
            this.antecedentPatient.TabIndex = 2;
            this.antecedentPatient.Text = "Antécédents";
            // 
            // lastNamePatient
            // 
            this.lastNamePatient.AutoSize = true;
            this.lastNamePatient.Location = new System.Drawing.Point(18, 147);
            this.lastNamePatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNamePatient.Name = "lastNamePatient";
            this.lastNamePatient.Size = new System.Drawing.Size(76, 13);
            this.lastNamePatient.TabIndex = 3;
            this.lastNamePatient.Text = "Nom de famille";
            // 
            // inputLastNamePatient
            // 
            this.inputLastNamePatient.Location = new System.Drawing.Point(20, 174);
            this.inputLastNamePatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputLastNamePatient.Name = "inputLastNamePatient";
            this.inputLastNamePatient.Size = new System.Drawing.Size(187, 20);
            this.inputLastNamePatient.TabIndex = 5;
            // 
            // sexePatient
            // 
            this.sexePatient.AutoSize = true;
            this.sexePatient.Location = new System.Drawing.Point(18, 223);
            this.sexePatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sexePatient.Name = "sexePatient";
            this.sexePatient.Size = new System.Drawing.Size(36, 13);
            this.sexePatient.TabIndex = 7;
            this.sexePatient.Text = "Genre";
            // 
            // allergyPatient
            // 
            this.allergyPatient.AutoSize = true;
            this.allergyPatient.Location = new System.Drawing.Point(312, 147);
            this.allergyPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.allergyPatient.Name = "allergyPatient";
            this.allergyPatient.Size = new System.Drawing.Size(41, 13);
            this.allergyPatient.TabIndex = 8;
            this.allergyPatient.Text = "Allergie";
            // 
            // birthPatient
            // 
            this.birthPatient.AutoSize = true;
            this.birthPatient.Location = new System.Drawing.Point(312, 223);
            this.birthPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthPatient.Name = "birthPatient";
            this.birthPatient.Size = new System.Drawing.Size(96, 13);
            this.birthPatient.TabIndex = 9;
            this.birthPatient.Text = "Date de naissance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 10;
            // 
            // titleAddNewPatient
            // 
            this.titleAddNewPatient.AutoSize = true;
            this.titleAddNewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAddNewPatient.Location = new System.Drawing.Point(164, 12);
            this.titleAddNewPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleAddNewPatient.Name = "titleAddNewPatient";
            this.titleAddNewPatient.Size = new System.Drawing.Size(268, 36);
            this.titleAddNewPatient.TabIndex = 13;
            this.titleAddNewPatient.Text = "Ajouter un patient";
            this.titleAddNewPatient.UseWaitCursor = true;
            this.titleAddNewPatient.Click += new System.EventHandler(this.label8_Click);
            // 
            // timePickerBirth
            // 
            this.timePickerBirth.Location = new System.Drawing.Point(314, 248);
            this.timePickerBirth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timePickerBirth.Name = "timePickerBirth";
            this.timePickerBirth.Size = new System.Drawing.Size(179, 20);
            this.timePickerBirth.TabIndex = 14;
            this.timePickerBirth.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBoxAllergy
            // 
            this.comboBoxAllergy.FormattingEnabled = true;
            this.comboBoxAllergy.Location = new System.Drawing.Point(314, 172);
            this.comboBoxAllergy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAllergy.Name = "comboBoxAllergy";
            this.comboBoxAllergy.Size = new System.Drawing.Size(158, 21);
            this.comboBoxAllergy.TabIndex = 16;
            this.comboBoxAllergy.SelectedIndexChanged += new System.EventHandler(this.comboBoxAllergy_SelectedIndexChanged);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Location = new System.Drawing.Point(131, 350);
            this.buttonAddPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(256, 58);
            this.buttonAddPatient.TabIndex = 17;
            this.buttonAddPatient.Text = "Ajouter ce patient";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // checkSexeManPatient
            // 
            this.checkSexeManPatient.AutoSize = true;
            this.checkSexeManPatient.Location = new System.Drawing.Point(131, 251);
            this.checkSexeManPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkSexeManPatient.Name = "checkSexeManPatient";
            this.checkSexeManPatient.Size = new System.Drawing.Size(60, 17);
            this.checkSexeManPatient.TabIndex = 18;
            this.checkSexeManPatient.Text = "homme";
            this.checkSexeManPatient.UseVisualStyleBackColor = true;
            this.checkSexeManPatient.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkWomenSexePatient
            // 
            this.checkWomenSexePatient.AutoSize = true;
            this.checkWomenSexePatient.Location = new System.Drawing.Point(20, 251);
            this.checkWomenSexePatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkWomenSexePatient.Name = "checkWomenSexePatient";
            this.checkWomenSexePatient.Size = new System.Drawing.Size(57, 17);
            this.checkWomenSexePatient.TabIndex = 19;
            this.checkWomenSexePatient.Text = "femme";
            this.checkWomenSexePatient.UseVisualStyleBackColor = true;
            this.checkWomenSexePatient.CheckedChanged += new System.EventHandler(this.checkWomenSexePatient_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBoxAntecedent
            // 
            this.comboBoxAntecedent.FormattingEnabled = true;
            this.comboBoxAntecedent.Location = new System.Drawing.Point(314, 93);
            this.comboBoxAntecedent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAntecedent.Name = "comboBoxAntecedent";
            this.comboBoxAntecedent.Size = new System.Drawing.Size(158, 21);
            this.comboBoxAntecedent.TabIndex = 21;
            this.comboBoxAntecedent.SelectedIndexChanged += new System.EventHandler(this.comboBoxAntecedent_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "+";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // formPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAntecedent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkWomenSexePatient);
            this.Controls.Add(this.checkSexeManPatient);
            this.Controls.Add(this.buttonAddPatient);
            this.Controls.Add(this.comboBoxAllergy);
            this.Controls.Add(this.timePickerBirth);
            this.Controls.Add(this.titleAddNewPatient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.birthPatient);
            this.Controls.Add(this.allergyPatient);
            this.Controls.Add(this.sexePatient);
            this.Controls.Add(this.inputLastNamePatient);
            this.Controls.Add(this.lastNamePatient);
            this.Controls.Add(this.antecedentPatient);
            this.Controls.Add(this.inputNamePatient);
            this.Controls.Add(this.namePatient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formPatient";
            this.Text = "formPatient";
            this.Load += new System.EventHandler(this.FormPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namePatient;
        private System.Windows.Forms.TextBox inputNamePatient;
        private System.Windows.Forms.Label antecedentPatient;
        private System.Windows.Forms.Label lastNamePatient;
        private System.Windows.Forms.TextBox inputLastNamePatient;
        private System.Windows.Forms.Label sexePatient;
        private System.Windows.Forms.Label allergyPatient;
        private System.Windows.Forms.Label birthPatient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label titleAddNewPatient;
        private System.Windows.Forms.DateTimePicker timePickerBirth;
        private System.Windows.Forms.ComboBox comboBoxAllergy;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.CheckBox checkSexeManPatient;
        private System.Windows.Forms.CheckBox checkWomenSexePatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAntecedent;
        private System.Windows.Forms.Label label2;
    }
}