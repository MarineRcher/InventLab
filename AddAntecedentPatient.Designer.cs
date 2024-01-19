namespace InventLab
{
    partial class AddAntecedentPatient
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
            this.idP = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxAntecedent = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // idP
            // 
            this.idP.AutoSize = true;
            this.idP.Location = new System.Drawing.Point(344, 433);
            this.idP.Name = "idP";
            this.idP.Size = new System.Drawing.Size(27, 16);
            this.idP.TabIndex = 11;
            this.idP.Text = "idP";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ajouter un antecedent";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkedListBoxAntecedent
            // 
            this.checkedListBoxAntecedent.FormattingEnabled = true;
            this.checkedListBoxAntecedent.Location = new System.Drawing.Point(24, 124);
            this.checkedListBoxAntecedent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxAntecedent.Name = "checkedListBoxAntecedent";
            this.checkedListBoxAntecedent.Size = new System.Drawing.Size(340, 259);
            this.checkedListBoxAntecedent.TabIndex = 12;
            this.checkedListBoxAntecedent.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxAntecedent_Load);
            // 
            // AddAntecedentPatient
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 498);
            this.Controls.Add(this.checkedListBoxAntecedent);
            this.Controls.Add(this.idP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddAntecedentPatient";
            this.Text = "AddAntecedentPatient";
            this.Load += new System.EventHandler(this.AddAntecedentPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxAntecedent;
    }
}