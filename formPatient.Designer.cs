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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPatient));
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.checkSexeManPatient = new System.Windows.Forms.CheckBox();
            this.checkWomenSexePatient = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // namePatient
            // 
            this.namePatient.AutoSize = true;
            this.namePatient.Location = new System.Drawing.Point(24, 86);
            this.namePatient.Name = "namePatient";
            this.namePatient.Size = new System.Drawing.Size(54, 16);
            this.namePatient.TabIndex = 0;
            this.namePatient.Text = "Prénom";
            this.namePatient.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputNamePatient
            // 
            this.inputNamePatient.Location = new System.Drawing.Point(27, 117);
            this.inputNamePatient.Name = "inputNamePatient";
            this.inputNamePatient.Size = new System.Drawing.Size(248, 22);
            this.inputNamePatient.TabIndex = 1;
            this.inputNamePatient.TextChanged += new System.EventHandler(this.inputNamePatient_TextChanged);
            // 
            // antecedentPatient
            // 
            this.antecedentPatient.AutoSize = true;
            this.antecedentPatient.Location = new System.Drawing.Point(416, 86);
            this.antecedentPatient.Name = "antecedentPatient";
            this.antecedentPatient.Size = new System.Drawing.Size(82, 16);
            this.antecedentPatient.TabIndex = 2;
            this.antecedentPatient.Text = "Antécédents";
            // 
            // lastNamePatient
            // 
            this.lastNamePatient.AutoSize = true;
            this.lastNamePatient.Location = new System.Drawing.Point(24, 181);
            this.lastNamePatient.Name = "lastNamePatient";
            this.lastNamePatient.Size = new System.Drawing.Size(97, 16);
            this.lastNamePatient.TabIndex = 3;
            this.lastNamePatient.Text = "Nom de famille";
            // 
            // inputLastNamePatient
            // 
            this.inputLastNamePatient.Location = new System.Drawing.Point(27, 214);
            this.inputLastNamePatient.Name = "inputLastNamePatient";
            this.inputLastNamePatient.Size = new System.Drawing.Size(248, 22);
            this.inputLastNamePatient.TabIndex = 5;
            // 
            // sexePatient
            // 
            this.sexePatient.AutoSize = true;
            this.sexePatient.Location = new System.Drawing.Point(24, 275);
            this.sexePatient.Name = "sexePatient";
            this.sexePatient.Size = new System.Drawing.Size(44, 16);
            this.sexePatient.TabIndex = 7;
            this.sexePatient.Text = "Genre";
            // 
            // allergyPatient
            // 
            this.allergyPatient.AutoSize = true;
            this.allergyPatient.Location = new System.Drawing.Point(416, 181);
            this.allergyPatient.Name = "allergyPatient";
            this.allergyPatient.Size = new System.Drawing.Size(53, 16);
            this.allergyPatient.TabIndex = 8;
            this.allergyPatient.Text = "Allergie";
            // 
            // birthPatient
            // 
            this.birthPatient.AutoSize = true;
            this.birthPatient.Location = new System.Drawing.Point(416, 275);
            this.birthPatient.Name = "birthPatient";
            this.birthPatient.Size = new System.Drawing.Size(120, 16);
            this.birthPatient.TabIndex = 9;
            this.birthPatient.Text = "Date de naissance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 10;
            // 
            // titleAddNewPatient
            // 
            this.titleAddNewPatient.AutoSize = true;
            this.titleAddNewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAddNewPatient.Location = new System.Drawing.Point(219, 15);
            this.titleAddNewPatient.Name = "titleAddNewPatient";
            this.titleAddNewPatient.Size = new System.Drawing.Size(328, 42);
            this.titleAddNewPatient.TabIndex = 13;
            this.titleAddNewPatient.Text = "Ajouter un patient";
            this.titleAddNewPatient.UseWaitCursor = true;
            this.titleAddNewPatient.Click += new System.EventHandler(this.label8_Click);
            // 
            // timePickerBirth
            // 
            this.timePickerBirth.Location = new System.Drawing.Point(419, 305);
            this.timePickerBirth.Name = "timePickerBirth";
            this.timePickerBirth.Size = new System.Drawing.Size(237, 22);
            this.timePickerBirth.TabIndex = 14;
            this.timePickerBirth.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(419, 212);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(210, 24);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Location = new System.Drawing.Point(175, 431);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(341, 71);
            this.buttonAddPatient.TabIndex = 17;
            this.buttonAddPatient.Text = "Ajouter ce patient";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // checkSexeManPatient
            // 
            this.checkSexeManPatient.AutoSize = true;
            this.checkSexeManPatient.Location = new System.Drawing.Point(175, 309);
            this.checkSexeManPatient.Name = "checkSexeManPatient";
            this.checkSexeManPatient.Size = new System.Drawing.Size(74, 20);
            this.checkSexeManPatient.TabIndex = 18;
            this.checkSexeManPatient.Text = "homme";
            this.checkSexeManPatient.UseVisualStyleBackColor = true;
            this.checkSexeManPatient.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkWomenSexePatient
            // 
            this.checkWomenSexePatient.AutoSize = true;
            this.checkWomenSexePatient.Location = new System.Drawing.Point(27, 309);
            this.checkWomenSexePatient.Name = "checkWomenSexePatient";
            this.checkWomenSexePatient.Size = new System.Drawing.Size(70, 20);
            this.checkWomenSexePatient.TabIndex = 19;
            this.checkWomenSexePatient.Text = "femme";
            this.checkWomenSexePatient.UseVisualStyleBackColor = true;
            this.checkWomenSexePatient.CheckedChanged += new System.EventHandler(this.checkWomenSexePatient_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(419, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 24);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(635, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "+";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(639, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 58);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // formPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 606);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkWomenSexePatient);
            this.Controls.Add(this.checkSexeManPatient);
            this.Controls.Add(this.buttonAddPatient);
            this.Controls.Add(this.comboBox2);
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
            this.Name = "formPatient";
            this.Text = "formPatient";
            this.Load += new System.EventHandler(this.FormPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.CheckBox checkSexeManPatient;
        private System.Windows.Forms.CheckBox checkWomenSexePatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}