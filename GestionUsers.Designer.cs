namespace InventLab
{
    partial class GestionUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsers));
            this.gestUser = new System.Windows.Forms.Label();
            this.tableUsers = new System.Windows.Forms.DataGridView();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.HomePage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).BeginInit();
            this.SuspendLayout();
            // 
            // gestUser
            // 
            this.gestUser.AutoSize = true;
            this.gestUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestUser.Location = new System.Drawing.Point(215, 9);
            this.gestUser.Name = "gestUser";
            this.gestUser.Size = new System.Drawing.Size(335, 32);
            this.gestUser.TabIndex = 0;
            this.gestUser.Text = "Gestion des utilisateurs";
            this.gestUser.Click += new System.EventHandler(this.gestUser_Click);
            // 
            // tableUsers
            // 
            this.tableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableUsers.Location = new System.Drawing.Point(42, 73);
            this.tableUsers.Name = "tableUsers";
            this.tableUsers.RowHeadersWidth = 51;
            this.tableUsers.RowTemplate.Height = 24;
            this.tableUsers.Size = new System.Drawing.Size(542, 332);
            this.tableUsers.TabIndex = 1;
            this.tableUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableUsers_CellContentClick);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(599, 354);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(189, 51);
            this.buttonDeleteUser.TabIndex = 2;
            this.buttonDeleteUser.Text = "Supprimer";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // HomePage
            // 
            this.HomePage.Image = ((System.Drawing.Image)(resources.GetObject("HomePage.Image")));
            this.HomePage.Location = new System.Drawing.Point(688, 23);
            this.HomePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(59, 50);
            this.HomePage.TabIndex = 17;
            this.HomePage.TabStop = false;
            this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
            // 
            // GestionUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomePage);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.tableUsers);
            this.Controls.Add(this.gestUser);
            this.Name = "GestionUsers";
            this.Text = "GestionUsers";
            this.Load += new System.EventHandler(this.GestionUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gestUser;
        private System.Windows.Forms.DataGridView tableUsers;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.PictureBox HomePage;
    }
}