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
            this.label1 = new System.Windows.Forms.Label();
            this.tableUsers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des utilisateurs";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestionUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableUsers);
            this.Controls.Add(this.label1);
            this.Name = "GestionUsers";
            this.Text = "GestionUsers";
            this.Load += new System.EventHandler(this.GestionUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableUsers;
        private System.Windows.Forms.Button button1;
    }
}