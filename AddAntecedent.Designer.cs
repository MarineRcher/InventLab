﻿namespace InventLab
{
    partial class AddAntecedent
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
            this.titleAntecedent = new System.Windows.Forms.Label();
            this.inputAntecedent = new System.Windows.Forms.TextBox();
            this.buttonAddAntecedent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleAntecedent
            // 
            this.titleAntecedent.AutoSize = true;
            this.titleAntecedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAntecedent.Location = new System.Drawing.Point(33, 30);
            this.titleAntecedent.Name = "titleAntecedent";
            this.titleAntecedent.Size = new System.Drawing.Size(314, 32);
            this.titleAntecedent.TabIndex = 0;
            this.titleAntecedent.Text = "Ajouter un antécédent";
            // 
            // inputAntecedent
            // 
            this.inputAntecedent.Location = new System.Drawing.Point(116, 206);
            this.inputAntecedent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputAntecedent.Name = "inputAntecedent";
            this.inputAntecedent.Size = new System.Drawing.Size(231, 22);
            this.inputAntecedent.TabIndex = 1;
            this.inputAntecedent.TextChanged += new System.EventHandler(this.inputAntecedent_TextChanged);
            // 
            // buttonAddAntecedent
            // 
            this.buttonAddAntecedent.Location = new System.Drawing.Point(136, 274);
            this.buttonAddAntecedent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddAntecedent.Name = "buttonAddAntecedent";
            this.buttonAddAntecedent.Size = new System.Drawing.Size(181, 57);
            this.buttonAddAntecedent.TabIndex = 2;
            this.buttonAddAntecedent.Text = "Ajouter";
            this.buttonAddAntecedent.UseVisualStyleBackColor = true;
            this.buttonAddAntecedent.Click += new System.EventHandler(this.buttonAddAntecedent_Click);
            // 
            // AddAntecedent
            // 
            this.AcceptButton = this.buttonAddAntecedent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 526);
            this.Controls.Add(this.buttonAddAntecedent);
            this.Controls.Add(this.inputAntecedent);
            this.Controls.Add(this.titleAntecedent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddAntecedent";
            this.Text = "AddAntecedent";
            this.Load += new System.EventHandler(this.AddAntecedent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleAntecedent;
        private System.Windows.Forms.TextBox inputAntecedent;
        private System.Windows.Forms.Button buttonAddAntecedent;
    }
}