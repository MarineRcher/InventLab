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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePatient
            // 
            this.tablePatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePatient.Location = new System.Drawing.Point(65, 85);
            this.tablePatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tablePatient.Name = "tablePatient";
            this.tablePatient.RowHeadersWidth = 51;
            this.tablePatient.RowTemplate.Height = 24;
            this.tablePatient.Size = new System.Drawing.Size(448, 486);
            this.tablePatient.TabIndex = 11;
            this.tablePatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablePatient_CellContentClick);
            // 
            // buttonDeletePatient
            // 
            this.buttonDeletePatient.Location = new System.Drawing.Point(529, 358);
            this.buttonDeletePatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeletePatient.Name = "buttonDeletePatient";
            this.buttonDeletePatient.Size = new System.Drawing.Size(194, 58);
            this.buttonDeletePatient.TabIndex = 12;
            this.buttonDeletePatient.Text = "Supprimer ce patient";
            this.buttonDeletePatient.UseVisualStyleBackColor = true;
            this.buttonDeletePatient.Click += new System.EventHandler(this.buttonDeletePatient_Click);
            // 
            // buttonAddPatientPage
            // 
            this.buttonAddPatientPage.Location = new System.Drawing.Point(529, 225);
            this.buttonAddPatientPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddPatientPage.Name = "buttonAddPatientPage";
            this.buttonAddPatientPage.Size = new System.Drawing.Size(194, 64);
            this.buttonAddPatientPage.TabIndex = 13;
            this.buttonAddPatientPage.Text = "Ajouter un patient";
            this.buttonAddPatientPage.UseVisualStyleBackColor = true;
            this.buttonAddPatientPage.Click += new System.EventHandler(this.buttonAddPatientPage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gestion des patients";
            // 
            // profilPatient
            // 
            this.profilPatient.Location = new System.Drawing.Point(529, 85);
            this.profilPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profilPatient.Name = "profilPatient";
            this.profilPatient.Size = new System.Drawing.Size(194, 62);
            this.profilPatient.TabIndex = 15;
            this.profilPatient.Text = "Profil patient";
            this.profilPatient.UseVisualStyleBackColor = true;
            this.profilPatient.Click += new System.EventHandler(this.profilPatient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(647, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 41);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Prenom";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GestionPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 604);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.profilPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddPatientPage);
            this.Controls.Add(this.buttonDeletePatient);
            this.Controls.Add(this.tablePatient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}