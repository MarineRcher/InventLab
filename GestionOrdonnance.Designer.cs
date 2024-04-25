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
            this.tableOrdonnance = new System.Windows.Forms.DataGridView();
            this.printTitleOrdo = new System.Windows.Forms.Label();
            this.printNameUser = new System.Windows.Forms.Label();
            this.buttonDeleteOrdo = new System.Windows.Forms.Button();
            this.printLastNameUser = new System.Windows.Forms.Label();
            this.addOrdo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableOrdonnance)).BeginInit();
            this.SuspendLayout();
            // 
            // tableOrdonnance
            // 
            this.tableOrdonnance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOrdonnance.Location = new System.Drawing.Point(28, 127);
            this.tableOrdonnance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableOrdonnance.Name = "tableOrdonnance";
            this.tableOrdonnance.RowHeadersWidth = 51;
            this.tableOrdonnance.Size = new System.Drawing.Size(1116, 588);
            this.tableOrdonnance.TabIndex = 0;
            this.tableOrdonnance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableOrdonnance_CellContentClick);
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
            // printNameUser
            // 
            this.printNameUser.AutoSize = true;
            this.printNameUser.Location = new System.Drawing.Point(503, 31);
            this.printNameUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.printNameUser.Name = "printNameUser";
            this.printNameUser.Size = new System.Drawing.Size(57, 16);
            this.printNameUser.TabIndex = 2;
            this.printNameUser.Text = "Prenom ";
            this.printNameUser.Click += new System.EventHandler(this.printNameLastNameUser_Click);
            // 
            // buttonDeleteOrdo
            // 
            this.buttonDeleteOrdo.Location = new System.Drawing.Point(1177, 635);
            this.buttonDeleteOrdo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteOrdo.Name = "buttonDeleteOrdo";
            this.buttonDeleteOrdo.Size = new System.Drawing.Size(263, 80);
            this.buttonDeleteOrdo.TabIndex = 3;
            this.buttonDeleteOrdo.Text = "Supprimer";
            this.buttonDeleteOrdo.UseVisualStyleBackColor = true;
            this.buttonDeleteOrdo.Click += new System.EventHandler(this.buttonDeleteOrdo_Click);
            // 
            // printLastNameUser
            // 
            this.printLastNameUser.AutoSize = true;
            this.printLastNameUser.Location = new System.Drawing.Point(557, 31);
            this.printLastNameUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.printLastNameUser.Name = "printLastNameUser";
            this.printLastNameUser.Size = new System.Drawing.Size(33, 16);
            this.printLastNameUser.TabIndex = 6;
            this.printLastNameUser.Text = "nom";
            // 
            // addOrdo
            // 
            this.addOrdo.Location = new System.Drawing.Point(1177, 482);
            this.addOrdo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addOrdo.Name = "addOrdo";
            this.addOrdo.Size = new System.Drawing.Size(263, 80);
            this.addOrdo.TabIndex = 7;
            this.addOrdo.Text = "Ajouter une ordonnance";
            this.addOrdo.UseVisualStyleBackColor = true;
            this.addOrdo.Click += new System.EventHandler(this.addOrdo_Click);
            // 
            // GestionOrdonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 750);
            this.Controls.Add(this.addOrdo);
            this.Controls.Add(this.printLastNameUser);
            this.Controls.Add(this.buttonDeleteOrdo);
            this.Controls.Add(this.printNameUser);
            this.Controls.Add(this.printTitleOrdo);
            this.Controls.Add(this.tableOrdonnance);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GestionOrdonnance";
            this.Text = "GestionOrdonnance";
            this.Load += new System.EventHandler(this.GestionOrdonnance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableOrdonnance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableOrdonnance;
        private System.Windows.Forms.Label printTitleOrdo;
        private System.Windows.Forms.Label printNameUser;
        private System.Windows.Forms.Button buttonDeleteOrdo;
        private System.Windows.Forms.Label printLastNameUser;
        private System.Windows.Forms.Button addOrdo;
    }
}