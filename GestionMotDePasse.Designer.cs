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
            this.tablePassword = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePassword
            // 
            this.tablePassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePassword.Location = new System.Drawing.Point(43, 146);
            this.tablePassword.Name = "tablePassword";
            this.tablePassword.Size = new System.Drawing.Size(470, 252);
            this.tablePassword.TabIndex = 0;
            this.tablePassword.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Demandes de changement de mot de passe";
            // 
            // GestionMotDePasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablePassword);
            this.Name = "GestionMotDePasse";
            this.Text = "GestionMotDePasse";
            this.Load += new System.EventHandler(this.GestionMotDePasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablePassword;
        private System.Windows.Forms.Label label1;
    }
}