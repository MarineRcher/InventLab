namespace InventLab
{
    partial class GestionOrdonnance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionOrdonnance));
            this.tableOrdonnance = new System.Windows.Forms.DataGridView();
            this.printTitleOrdo = new System.Windows.Forms.Label();
            this.printNameLastNameUser = new System.Windows.Forms.Label();
            this.buttonDeleteOrdo = new System.Windows.Forms.Button();
            this.HomePage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableOrdonnance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableOrdonnance
            // 
            this.tableOrdonnance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOrdonnance.Location = new System.Drawing.Point(28, 127);
            this.tableOrdonnance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableOrdonnance.Name = "tableOrdonnance";
            this.tableOrdonnance.RowHeadersWidth = 51;
            this.tableOrdonnance.Size = new System.Drawing.Size(752, 412);
            this.tableOrdonnance.TabIndex = 0;
            // 
            // printTitleOrdo
            // 
            this.printTitleOrdo.AutoSize = true;
            this.printTitleOrdo.Location = new System.Drawing.Point(392, 31);
            this.printTitleOrdo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.printTitleOrdo.Name = "printTitleOrdo";
            this.printTitleOrdo.Size = new System.Drawing.Size(107, 16);
            this.printTitleOrdo.TabIndex = 1;
            this.printTitleOrdo.Text = "Ordonnances de";
            // 
            // printNameLastNameUser
            // 
            this.printNameLastNameUser.AutoSize = true;
            this.printNameLastNameUser.Location = new System.Drawing.Point(508, 31);
            this.printNameLastNameUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.printNameLastNameUser.Name = "printNameLastNameUser";
            this.printNameLastNameUser.Size = new System.Drawing.Size(97, 16);
            this.printNameLastNameUser.TabIndex = 2;
            this.printNameLastNameUser.Text = "Prenom et nom";
            this.printNameLastNameUser.Click += new System.EventHandler(this.printNameLastNameUser_Click);
            // 
            // buttonDeleteOrdo
            // 
            this.buttonDeleteOrdo.Location = new System.Drawing.Point(788, 459);
            this.buttonDeleteOrdo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteOrdo.Name = "buttonDeleteOrdo";
            this.buttonDeleteOrdo.Size = new System.Drawing.Size(263, 80);
            this.buttonDeleteOrdo.TabIndex = 3;
            this.buttonDeleteOrdo.Text = "Supprimer";
            this.buttonDeleteOrdo.UseVisualStyleBackColor = true;
            this.buttonDeleteOrdo.Click += new System.EventHandler(this.buttonDeleteOrdo_Click);
            // 
            // HomePage
            // 
            this.HomePage.Image = ((System.Drawing.Image)(resources.GetObject("HomePage.Image")));
            this.HomePage.Location = new System.Drawing.Point(930, 40);
            this.HomePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(68, 50);
            this.HomePage.TabIndex = 5;
            this.HomePage.TabStop = false;
            this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
            // 
            // GestionOrdonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.HomePage);
            this.Controls.Add(this.buttonDeleteOrdo);
            this.Controls.Add(this.printNameLastNameUser);
            this.Controls.Add(this.printTitleOrdo);
            this.Controls.Add(this.tableOrdonnance);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GestionOrdonnance";
            this.Text = "GestionOrdonnance";
            this.Load += new System.EventHandler(this.GestionOrdonnance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableOrdonnance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableOrdonnance;
        private System.Windows.Forms.Label printTitleOrdo;
        private System.Windows.Forms.Label printNameLastNameUser;
        private System.Windows.Forms.Button buttonDeleteOrdo;
        private System.Windows.Forms.PictureBox HomePage;
    }
}