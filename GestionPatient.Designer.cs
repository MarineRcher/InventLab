namespace InventLab
{
    partial class GestionPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPatient));
            this.tablePatient = new System.Windows.Forms.DataGridView();
            this.buttonDeletePatient = new System.Windows.Forms.Button();
            this.buttonAddPatientPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.profilPatient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablePatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePatient
            // 
            this.tablePatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePatient.Location = new System.Drawing.Point(87, 105);
            this.tablePatient.Name = "tablePatient";
            this.tablePatient.RowHeadersWidth = 51;
            this.tablePatient.RowTemplate.Height = 24;
            this.tablePatient.Size = new System.Drawing.Size(597, 598);
            this.tablePatient.TabIndex = 11;
            this.tablePatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablePatient_CellContentClick);
            // 
            // buttonDeletePatient
            // 
            this.buttonDeletePatient.Location = new System.Drawing.Point(705, 441);
            this.buttonDeletePatient.Name = "buttonDeletePatient";
            this.buttonDeletePatient.Size = new System.Drawing.Size(259, 72);
            this.buttonDeletePatient.TabIndex = 12;
            this.buttonDeletePatient.Text = "Supprimer ce patient";
            this.buttonDeletePatient.UseVisualStyleBackColor = true;
            this.buttonDeletePatient.Click += new System.EventHandler(this.buttonDeletePatient_Click);
            // 
            // buttonAddPatientPage
            // 
            this.buttonAddPatientPage.Location = new System.Drawing.Point(705, 277);
            this.buttonAddPatientPage.Name = "buttonAddPatientPage";
            this.buttonAddPatientPage.Size = new System.Drawing.Size(259, 79);
            this.buttonAddPatientPage.TabIndex = 13;
            this.buttonAddPatientPage.Text = "Ajouter un patient";
            this.buttonAddPatientPage.UseVisualStyleBackColor = true;
            this.buttonAddPatientPage.Click += new System.EventHandler(this.buttonAddPatientPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gestion des patients";
            // 
            // profilPatient
            // 
            this.profilPatient.Location = new System.Drawing.Point(705, 105);
            this.profilPatient.Name = "profilPatient";
            this.profilPatient.Size = new System.Drawing.Size(259, 76);
            this.profilPatient.TabIndex = 15;
            this.profilPatient.Text = "Profil patient";
            this.profilPatient.UseVisualStyleBackColor = true;
            this.profilPatient.Click += new System.EventHandler(this.profilPatient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(863, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 51);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GestionPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 743);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.profilPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddPatientPage);
            this.Controls.Add(this.buttonDeletePatient);
            this.Controls.Add(this.tablePatient);
            this.Name = "GestionPatient";
            this.Text = "GestionPatient";
            this.Load += new System.EventHandler(this.GestionPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablePatient;
        private System.Windows.Forms.Button buttonDeletePatient;
        private System.Windows.Forms.Button buttonAddPatientPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button profilPatient;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}