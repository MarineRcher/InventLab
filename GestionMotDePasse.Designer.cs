namespace InventLab
{
    partial class GestionMotDePasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionMotDePasse));
            this.tablePassword = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.HomePage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePassword
            // 
            this.tablePassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePassword.Location = new System.Drawing.Point(57, 180);
            this.tablePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablePassword.Name = "tablePassword";
            this.tablePassword.RowHeadersWidth = 51;
            this.tablePassword.Size = new System.Drawing.Size(627, 310);
            this.tablePassword.TabIndex = 0;
            this.tablePassword.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablePassword_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Demandes de changement de mot de passe";
            // 
            // HomePage
            // 
            this.HomePage.Image = ((System.Drawing.Image)(resources.GetObject("HomePage.Image")));
            this.HomePage.Location = new System.Drawing.Point(655, 41);
            this.HomePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(59, 50);
            this.HomePage.TabIndex = 17;
            this.HomePage.TabStop = false;
            this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
            // 
            // GestionMotDePasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 554);
            this.Controls.Add(this.HomePage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablePassword);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GestionMotDePasse";
            this.Text = "GestionMotDePasse";
            this.Load += new System.EventHandler(this.GestionMotDePasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox HomePage;
    }
}