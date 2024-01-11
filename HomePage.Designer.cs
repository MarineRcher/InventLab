namespace InventLab
{
    partial class HomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordonnancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesOrdonnancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allergiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneAllergieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antécédentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutsDantécédentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenue ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsToolStripMenuItem,
            this.médicamentsToolStripMenuItem,
            this.ordonnancesToolStripMenuItem,
            this.allergiesToolStripMenuItem,
            this.antécédentsToolStripMenuItem,
            this.administrateurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesPatientsToolStripMenuItem,
            this.ajoutDunPatientToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.patientsToolStripMenuItem.Text = "Patients";
            // 
            // gestionDesPatientsToolStripMenuItem
            // 
            this.gestionDesPatientsToolStripMenuItem.Name = "gestionDesPatientsToolStripMenuItem";
            this.gestionDesPatientsToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.gestionDesPatientsToolStripMenuItem.Text = "Gestion des patients";
            this.gestionDesPatientsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesPatientsToolStripMenuItem_Click);
            // 
            // ajoutDunPatientToolStripMenuItem
            // 
            this.ajoutDunPatientToolStripMenuItem.Name = "ajoutDunPatientToolStripMenuItem";
            this.ajoutDunPatientToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.ajoutDunPatientToolStripMenuItem.Text = "Ajout d\'un patient";
            this.ajoutDunPatientToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunPatientToolStripMenuItem_Click);
            // 
            // médicamentsToolStripMenuItem
            // 
            this.médicamentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventaireToolStripMenuItem});
            this.médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
            this.médicamentsToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.médicamentsToolStripMenuItem.Text = "Médicaments";
            // 
            // inventaireToolStripMenuItem
            // 
            this.inventaireToolStripMenuItem.Name = "inventaireToolStripMenuItem";
            this.inventaireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inventaireToolStripMenuItem.Text = "Inventaire";
            this.inventaireToolStripMenuItem.Click += new System.EventHandler(this.inventaireToolStripMenuItem_Click);
            // 
            // ordonnancesToolStripMenuItem
            // 
            this.ordonnancesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesOrdonnancesToolStripMenuItem,
            this.créerUneToolStripMenuItem});
            this.ordonnancesToolStripMenuItem.Name = "ordonnancesToolStripMenuItem";
            this.ordonnancesToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.ordonnancesToolStripMenuItem.Text = "Ordonnances";
            // 
            // gérerLesOrdonnancesToolStripMenuItem
            // 
            this.gérerLesOrdonnancesToolStripMenuItem.Name = "gérerLesOrdonnancesToolStripMenuItem";
            this.gérerLesOrdonnancesToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.gérerLesOrdonnancesToolStripMenuItem.Text = "Gérer les ordonnances";
            // 
            // créerUneToolStripMenuItem
            // 
            this.créerUneToolStripMenuItem.Name = "créerUneToolStripMenuItem";
            this.créerUneToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.créerUneToolStripMenuItem.Text = "Créer une ordonnance";
            this.créerUneToolStripMenuItem.Click += new System.EventHandler(this.créerUneToolStripMenuItem_Click);
            // 
            // allergiesToolStripMenuItem
            // 
            this.allergiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneAllergieToolStripMenuItem});
            this.allergiesToolStripMenuItem.Name = "allergiesToolStripMenuItem";
            this.allergiesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.allergiesToolStripMenuItem.Text = "Allergies";
            // 
            // ajouterUneAllergieToolStripMenuItem
            // 
            this.ajouterUneAllergieToolStripMenuItem.Name = "ajouterUneAllergieToolStripMenuItem";
            this.ajouterUneAllergieToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajouterUneAllergieToolStripMenuItem.Text = "Ajouter une allergie";
            this.ajouterUneAllergieToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneAllergieToolStripMenuItem_Click);
            // 
            // antécédentsToolStripMenuItem
            // 
            this.antécédentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutsDantécédentsToolStripMenuItem});
            this.antécédentsToolStripMenuItem.Name = "antécédentsToolStripMenuItem";
            this.antécédentsToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.antécédentsToolStripMenuItem.Text = "Antécédents";
            // 
            // ajoutsDantécédentsToolStripMenuItem
            // 
            this.ajoutsDantécédentsToolStripMenuItem.Name = "ajoutsDantécédentsToolStripMenuItem";
            this.ajoutsDantécédentsToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.ajoutsDantécédentsToolStripMenuItem.Text = "Ajouts d\'antécédents";
            this.ajoutsDantécédentsToolStripMenuItem.Click += new System.EventHandler(this.ajoutsDantécédentsToolStripMenuItem_Click);
            // 
            // administrateurToolStripMenuItem
            // 
            this.administrateurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscriptionToolStripMenuItem,
            this.gestionDesUtilisateursToolStripMenuItem});
            this.administrateurToolStripMenuItem.Name = "administrateurToolStripMenuItem";
            this.administrateurToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.administrateurToolStripMenuItem.Text = "Administrateur";
            // 
            // inscriptionToolStripMenuItem
            // 
            this.inscriptionToolStripMenuItem.Name = "inscriptionToolStripMenuItem";
            this.inscriptionToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.inscriptionToolStripMenuItem.Text = "Inscription";
            this.inscriptionToolStripMenuItem.Click += new System.EventHandler(this.inscriptionToolStripMenuItem_Click);
            // 
            // gestionDesUtilisateursToolStripMenuItem
            // 
            this.gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
            this.gestionDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.gestionDesUtilisateursToolStripMenuItem.Text = "Gestion des utilisateurs";
            this.gestionDesUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.gestionDesUtilisateursToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDunPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordonnancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesOrdonnancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allergiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneAllergieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antécédentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutsDantécédentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem;
    }
}