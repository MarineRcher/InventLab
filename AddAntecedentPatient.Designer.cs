namespace InventLab
{
    partial class AddAntecedentPatient
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
            this.idP = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listeAllergies = new System.Windows.Forms.ComboBox();
            this.namPatientFormAllergy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idP
            // 
            this.idP.AutoSize = true;
            this.idP.Location = new System.Drawing.Point(344, 433);
            this.idP.Name = "idP";
            this.idP.Size = new System.Drawing.Size(27, 16);
            this.idP.TabIndex = 11;
            this.idP.Text = "idP";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "+";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listeAllergies
            // 
            this.listeAllergies.FormattingEnabled = true;
            this.listeAllergies.Location = new System.Drawing.Point(53, 182);
            this.listeAllergies.Name = "listeAllergies";
            this.listeAllergies.Size = new System.Drawing.Size(268, 24);
            this.listeAllergies.TabIndex = 8;
            this.listeAllergies.SelectedIndexChanged += new System.EventHandler(this.listeAntecedents_SelectedIndexChanged);
            // 
            // namPatientFormAllergy
            // 
            this.namPatientFormAllergy.AutoSize = true;
            this.namPatientFormAllergy.Location = new System.Drawing.Point(172, 72);
            this.namPatientFormAllergy.Name = "namPatientFormAllergy";
            this.namPatientFormAllergy.Size = new System.Drawing.Size(44, 16);
            this.namPatientFormAllergy.TabIndex = 7;
            this.namPatientFormAllergy.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ajouter un antecedent à ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddAntecedentPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 498);
            this.Controls.Add(this.idP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listeAllergies);
            this.Controls.Add(this.namPatientFormAllergy);
            this.Controls.Add(this.label1);
            this.Name = "AddAntecedentPatient";
            this.Text = "AddAntecedentPatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listeAllergies;
        private System.Windows.Forms.Label namPatientFormAllergy;
        private System.Windows.Forms.Label label1;
    }
}