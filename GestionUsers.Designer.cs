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
            this.gestUser = new System.Windows.Forms.Label();
            this.tableUsers = new System.Windows.Forms.DataGridView();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // gestUser
            // 
            this.gestUser.AutoSize = true;
            this.gestUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestUser.Location = new System.Drawing.Point(161, 7);
            this.gestUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gestUser.Name = "gestUser";
            this.gestUser.Size = new System.Drawing.Size(262, 26);
            this.gestUser.TabIndex = 0;
            this.gestUser.Text = "Gestion des utilisateurs";
            this.gestUser.Click += new System.EventHandler(this.gestUser_Click);
            // 
            // tableUsers
            // 
            this.tableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableUsers.Location = new System.Drawing.Point(32, 59);
            this.tableUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableUsers.Name = "tableUsers";
            this.tableUsers.RowHeadersWidth = 51;
            this.tableUsers.RowTemplate.Height = 24;
            this.tableUsers.Size = new System.Drawing.Size(406, 270);
            this.tableUsers.TabIndex = 1;
            this.tableUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableUsers_CellContentClick);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(449, 288);
            this.buttonDeleteUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(142, 41);
            this.buttonDeleteUser.TabIndex = 2;
            this.buttonDeleteUser.Text = "Supprimer";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(449, 213);
            this.addUser.Margin = new System.Windows.Forms.Padding(2);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(142, 41);
            this.addUser.TabIndex = 18;
            this.addUser.Text = "Inscirption";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // GestionUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.tableUsers);
            this.Controls.Add(this.gestUser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GestionUsers";
            this.Text = "GestionUsers";
            this.Load += new System.EventHandler(this.GestionUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gestUser;
        private System.Windows.Forms.DataGridView tableUsers;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button addUser;
    }
}