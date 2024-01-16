namespace InventLab
{
    partial class addAllergyToPatient
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
            this.namPatientFormAllergy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBoxAllergies = new System.Windows.Forms.CheckedListBox();
            this.idP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter une allergie à ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // namPatientFormAllergy
            // 
            this.namPatientFormAllergy.AutoSize = true;
            this.namPatientFormAllergy.Location = new System.Drawing.Point(208, 63);
            this.namPatientFormAllergy.Name = "namPatientFormAllergy";
            this.namPatientFormAllergy.Size = new System.Drawing.Size(44, 16);
            this.namPatientFormAllergy.TabIndex = 1;
            this.namPatientFormAllergy.Text = "label2";
            this.namPatientFormAllergy.Click += new System.EventHandler(this.namPatientFormAllergy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 554);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBoxAllergies
            // 
            this.checkedListBoxAllergies.FormattingEnabled = true;
            this.checkedListBoxAllergies.Location = new System.Drawing.Point(183, 234);
            this.checkedListBoxAllergies.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxAllergies.Name = "checkedListBoxAllergies";
            this.checkedListBoxAllergies.Size = new System.Drawing.Size(159, 106);
            this.checkedListBoxAllergies.TabIndex = 6;
            this.checkedListBoxAllergies.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxAllergies_SelectedIndexChanged);
            // 
            // idP
            // 
            this.idP.AutoSize = true;
            this.idP.Location = new System.Drawing.Point(489, 623);
            this.idP.Name = "idP";
            this.idP.Size = new System.Drawing.Size(27, 16);
            this.idP.TabIndex = 5;
            this.idP.Text = "idP";
            this.idP.Click += new System.EventHandler(this.idP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "label2";
            // 
            // addAllergyToPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 678);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBoxAllergies);
            this.Controls.Add(this.idP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namPatientFormAllergy);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addAllergyToPatient";
            this.Text = "addAllergyToPatient";
            this.Load += new System.EventHandler(this.addAllergyToPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label namPatientFormAllergy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBoxAllergies;
        private System.Windows.Forms.Label idP;
        private System.Windows.Forms.Label label3;
    }
}