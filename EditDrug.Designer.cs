namespace InventLab
{
    partial class EditDrug
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
            this.titleDrugEdit = new System.Windows.Forms.Label();
            this.InputNameDrugEdit = new System.Windows.Forms.TextBox();
            this.inputDescriptionDrugEdit = new System.Windows.Forms.TextBox();
            this.labelDescriptionDrugEdit = new System.Windows.Forms.Label();
            this.labelNameDrugEdit = new System.Windows.Forms.Label();
            this.buttonDrugEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleDrugEdit
            // 
            this.titleDrugEdit.AutoSize = true;
            this.titleDrugEdit.Font = new System.Drawing.Font("Noto Sans Cond", 16.2F, System.Drawing.FontStyle.Bold);
            this.titleDrugEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.titleDrugEdit.Location = new System.Drawing.Point(252, 26);
            this.titleDrugEdit.Name = "titleDrugEdit";
            this.titleDrugEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titleDrugEdit.Size = new System.Drawing.Size(298, 38);
            this.titleDrugEdit.TabIndex = 0;
            this.titleDrugEdit.Text = "Modifier le médicament";
            this.titleDrugEdit.Click += new System.EventHandler(this.titleDrugEdit_Click);
            // 
            // InputNameDrugEdit
            // 
            this.InputNameDrugEdit.Location = new System.Drawing.Point(269, 142);
            this.InputNameDrugEdit.Name = "InputNameDrugEdit";
            this.InputNameDrugEdit.Size = new System.Drawing.Size(222, 22);
            this.InputNameDrugEdit.TabIndex = 1;
            this.InputNameDrugEdit.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputDescriptionDrugEdit
            // 
            this.inputDescriptionDrugEdit.Location = new System.Drawing.Point(269, 229);
            this.inputDescriptionDrugEdit.Name = "inputDescriptionDrugEdit";
            this.inputDescriptionDrugEdit.Size = new System.Drawing.Size(222, 22);
            this.inputDescriptionDrugEdit.TabIndex = 2;
            // 
            // labelDescriptionDrugEdit
            // 
            this.labelDescriptionDrugEdit.AutoSize = true;
            this.labelDescriptionDrugEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptionDrugEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDescriptionDrugEdit.Location = new System.Drawing.Point(269, 197);
            this.labelDescriptionDrugEdit.Name = "labelDescriptionDrugEdit";
            this.labelDescriptionDrugEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelDescriptionDrugEdit.Size = new System.Drawing.Size(146, 29);
            this.labelDescriptionDrugEdit.TabIndex = 3;
            this.labelDescriptionDrugEdit.Text = "Description";
            // 
            // labelNameDrugEdit
            // 
            this.labelNameDrugEdit.AutoSize = true;
            this.labelNameDrugEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameDrugEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNameDrugEdit.Location = new System.Drawing.Point(269, 110);
            this.labelNameDrugEdit.Name = "labelNameDrugEdit";
            this.labelNameDrugEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelNameDrugEdit.Size = new System.Drawing.Size(68, 29);
            this.labelNameDrugEdit.TabIndex = 4;
            this.labelNameDrugEdit.Text = "Nom";
            this.labelNameDrugEdit.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonDrugEdit
            // 
            this.buttonDrugEdit.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonDrugEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buttonDrugEdit.Location = new System.Drawing.Point(269, 304);
            this.buttonDrugEdit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDrugEdit.Name = "buttonDrugEdit";
            this.buttonDrugEdit.Size = new System.Drawing.Size(219, 50);
            this.buttonDrugEdit.TabIndex = 5;
            this.buttonDrugEdit.Text = "Modifier";
            this.buttonDrugEdit.UseVisualStyleBackColor = false;
            this.buttonDrugEdit.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // EditDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDrugEdit);
            this.Controls.Add(this.labelNameDrugEdit);
            this.Controls.Add(this.labelDescriptionDrugEdit);
            this.Controls.Add(this.inputDescriptionDrugEdit);
            this.Controls.Add(this.InputNameDrugEdit);
            this.Controls.Add(this.titleDrugEdit);
            this.Name = "EditDrug";
            this.Text = "EditDrug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleDrugEdit;
        private System.Windows.Forms.TextBox InputNameDrugEdit;
        private System.Windows.Forms.TextBox inputDescriptionDrugEdit;
        private System.Windows.Forms.Label labelDescriptionDrugEdit;
        private System.Windows.Forms.Label labelNameDrugEdit;
        private System.Windows.Forms.Button buttonDrugEdit;
    }
}