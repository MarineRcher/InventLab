namespace InventLab
{
    partial class addAllergy
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
            this.inputNameAllergy = new System.Windows.Forms.TextBox();
            this.NameAllergy = new System.Windows.Forms.Label();
            this.buttonAddAllergy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(219, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter une allergie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputNameAllergy
            // 
            this.inputNameAllergy.Location = new System.Drawing.Point(62, 148);
            this.inputNameAllergy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputNameAllergy.Name = "inputNameAllergy";
            this.inputNameAllergy.Size = new System.Drawing.Size(226, 20);
            this.inputNameAllergy.TabIndex = 1;
            this.inputNameAllergy.TextChanged += new System.EventHandler(this.inputNameAllergy_TextChanged);
            // 
            // NameAllergy
            // 
            this.NameAllergy.AutoSize = true;
            this.NameAllergy.Location = new System.Drawing.Point(60, 107);
            this.NameAllergy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameAllergy.Name = "NameAllergy";
            this.NameAllergy.Size = new System.Drawing.Size(84, 13);
            this.NameAllergy.TabIndex = 2;
            this.NameAllergy.Text = "Nom de l\'allergie";
            // 
            // buttonAddAllergy
            // 
            this.buttonAddAllergy.Location = new System.Drawing.Point(62, 265);
            this.buttonAddAllergy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddAllergy.Name = "buttonAddAllergy";
            this.buttonAddAllergy.Size = new System.Drawing.Size(225, 59);
            this.buttonAddAllergy.TabIndex = 3;
            this.buttonAddAllergy.Text = "Ajouter";
            this.buttonAddAllergy.UseVisualStyleBackColor = true;
            this.buttonAddAllergy.Click += new System.EventHandler(this.buttonAddAllergy_Click);
            // 
            // addAllergy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 384);
            this.Controls.Add(this.buttonAddAllergy);
            this.Controls.Add(this.NameAllergy);
            this.Controls.Add(this.inputNameAllergy);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addAllergy";
            this.Text = "addAllergy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNameAllergy;
        private System.Windows.Forms.Label NameAllergy;
        private System.Windows.Forms.Button buttonAddAllergy;
    }
}