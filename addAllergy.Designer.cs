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
            this.label1.Location = new System.Drawing.Point(64, 39);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter une allergie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputNameAllergy
            // 
            this.inputNameAllergy.Location = new System.Drawing.Point(83, 182);
            this.inputNameAllergy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputNameAllergy.Name = "inputNameAllergy";
            this.inputNameAllergy.Size = new System.Drawing.Size(300, 22);
            this.inputNameAllergy.TabIndex = 1;
            this.inputNameAllergy.TextChanged += new System.EventHandler(this.inputNameAllergy_TextChanged);
            // 
            // NameAllergy
            // 
            this.NameAllergy.AutoSize = true;
            this.NameAllergy.Location = new System.Drawing.Point(80, 132);
            this.NameAllergy.Name = "NameAllergy";
            this.NameAllergy.Size = new System.Drawing.Size(109, 16);
            this.NameAllergy.TabIndex = 2;
            this.NameAllergy.Text = "Nom de l\'allergie";
            // 
            // buttonAddAllergy
            // 
            this.buttonAddAllergy.Location = new System.Drawing.Point(83, 326);
            this.buttonAddAllergy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddAllergy.Name = "buttonAddAllergy";
            this.buttonAddAllergy.Size = new System.Drawing.Size(300, 73);
            this.buttonAddAllergy.TabIndex = 3;
            this.buttonAddAllergy.Text = "Ajouter";
            this.buttonAddAllergy.UseVisualStyleBackColor = true;
            this.buttonAddAllergy.Click += new System.EventHandler(this.buttonAddAllergy_Click);
            // 
            // addAllergy
            // 
            this.AcceptButton = this.buttonAddAllergy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 473);
            this.Controls.Add(this.buttonAddAllergy);
            this.Controls.Add(this.NameAllergy);
            this.Controls.Add(this.inputNameAllergy);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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