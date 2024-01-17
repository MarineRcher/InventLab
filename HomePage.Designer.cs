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
            this.printWelcome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordonnancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesOrdonnancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allergiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneAllergieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antécédentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutsDantécédentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionMotDePasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printWelcome
            // 
            this.printWelcome.AutoSize = true;
            this.printWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printWelcome.Location = new System.Drawing.Point(214, 96);
            this.printWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.printWelcome.Name = "printWelcome";
            this.printWelcome.Size = new System.Drawing.Size(131, 26);
            this.printWelcome.TabIndex = 0;
            this.printWelcome.Text = "Bienvenue ";
            this.printWelcome.Click += new System.EventHandler(this.printWelcome_Click);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(626, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesPatientsToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.patientsToolStripMenuItem.Text = "Patients";
            // 
            // gestionDesPatientsToolStripMenuItem
            // 
            this.gestionDesPatientsToolStripMenuItem.Name = "gestionDesPatientsToolStripMenuItem";
            this.gestionDesPatientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionDesPatientsToolStripMenuItem.Text = "Gestion des patients";
            this.gestionDesPatientsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesPatientsToolStripMenuItem_Click);
            // 
            // médicamentsToolStripMenuItem
            // 
            this.médicamentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventaireToolStripMenuItem});
            this.médicamentsToolStripMenuItem.Name = "médicamentsToolStripMenuItem";
            this.médicamentsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.médicamentsToolStripMenuItem.Text = "Médicaments";
            // 
            // inventaireToolStripMenuItem
            // 
            this.inventaireToolStripMenuItem.Name = "inventaireToolStripMenuItem";
            this.inventaireToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.inventaireToolStripMenuItem.Text = "Inventaire";
            this.inventaireToolStripMenuItem.Click += new System.EventHandler(this.inventaireToolStripMenuItem_Click);
            // 
            // ordonnancesToolStripMenuItem
            // 
            this.ordonnancesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesOrdonnancesToolStripMenuItem});
            this.ordonnancesToolStripMenuItem.Name = "ordonnancesToolStripMenuItem";
            this.ordonnancesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.ordonnancesToolStripMenuItem.Text = "Ordonnances";
            // 
            // gérerLesOrdonnancesToolStripMenuItem
            // 
            this.gérerLesOrdonnancesToolStripMenuItem.Name = "gérerLesOrdonnancesToolStripMenuItem";
            this.gérerLesOrdonnancesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.gérerLesOrdonnancesToolStripMenuItem.Text = "Gérer les ordonnances";
            this.gérerLesOrdonnancesToolStripMenuItem.Click += new System.EventHandler(this.gérerLesOrdonnancesToolStripMenuItem_Click);
            // 
            // allergiesToolStripMenuItem
            // 
            this.allergiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneAllergieToolStripMenuItem});
            this.allergiesToolStripMenuItem.Name = "allergiesToolStripMenuItem";
            this.allergiesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.allergiesToolStripMenuItem.Text = "Allergies";
            // 
            // ajouterUneAllergieToolStripMenuItem
            // 
            this.ajouterUneAllergieToolStripMenuItem.Name = "ajouterUneAllergieToolStripMenuItem";
            this.ajouterUneAllergieToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ajouterUneAllergieToolStripMenuItem.Text = "Ajouter une allergie";
            this.ajouterUneAllergieToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneAllergieToolStripMenuItem_Click);
            // 
            // antécédentsToolStripMenuItem
            // 
            this.antécédentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutsDantécédentsToolStripMenuItem});
            this.antécédentsToolStripMenuItem.Name = "antécédentsToolStripMenuItem";
            this.antécédentsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.antécédentsToolStripMenuItem.Text = "Antécédents";
            // 
            // ajoutsDantécédentsToolStripMenuItem
            // 
            this.ajoutsDantécédentsToolStripMenuItem.Name = "ajoutsDantécédentsToolStripMenuItem";
            this.ajoutsDantécédentsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ajoutsDantécédentsToolStripMenuItem.Text = "Ajouts d\'antécédents";
            this.ajoutsDantécédentsToolStripMenuItem.Click += new System.EventHandler(this.ajoutsDantécédentsToolStripMenuItem_Click);
            // 
            // administrateurToolStripMenuItem
            // 
            this.administrateurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesUtilisateursToolStripMenuItem,
            this.gestionMotDePasseToolStripMenuItem});
            this.administrateurToolStripMenuItem.Name = "administrateurToolStripMenuItem";
            this.administrateurToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrateurToolStripMenuItem.Text = "Administrateur";
            // 
            // gestionDesUtilisateursToolStripMenuItem
            // 
            this.gestionDesUtilisateursToolStripMenuItem.Name = "gestionDesUtilisateursToolStripMenuItem";
            this.gestionDesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gestionDesUtilisateursToolStripMenuItem.Text = "Gestion des utilisateurs";
            this.gestionDesUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.gestionDesUtilisateursToolStripMenuItem_Click);
            // 
            // gestionMotDePasseToolStripMenuItem
            // 
            this.gestionMotDePasseToolStripMenuItem.Name = "gestionMotDePasseToolStripMenuItem";
            this.gestionMotDePasseToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gestionMotDePasseToolStripMenuItem.Text = "Gestion mot de passe";
            this.gestionMotDePasseToolStripMenuItem.Click += new System.EventHandler(this.gestionMotDePasseToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 385);
            this.Controls.Add(this.printWelcome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label printWelcome;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordonnancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesOrdonnancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allergiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneAllergieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antécédentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutsDantécédentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionMotDePasseToolStripMenuItem;
    }
}