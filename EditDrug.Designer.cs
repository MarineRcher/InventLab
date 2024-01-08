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
            this.quantityDrugEdit = new System.Windows.Forms.Label();
            this.numericDrugEdit = new System.Windows.Forms.NumericUpDown();
            this.nameContreIndic = new System.Windows.Forms.Label();
            this.inputContreIndic = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericDrugEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // titleDrugEdit
            // 
            this.titleDrugEdit.AutoSize = true;
            this.titleDrugEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.titleDrugEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.titleDrugEdit.Location = new System.Drawing.Point(252, 26);
            this.titleDrugEdit.Name = "titleDrugEdit";
            this.titleDrugEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titleDrugEdit.Size = new System.Drawing.Size(330, 32);
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
            this.InputNameDrugEdit.TextChanged += new System.EventHandler(this.InputNameDrugEdit_TextChanged);
            // 
            // inputDescriptionDrugEdit
            // 
            this.inputDescriptionDrugEdit.Location = new System.Drawing.Point(269, 240);
            this.inputDescriptionDrugEdit.Name = "inputDescriptionDrugEdit";
            this.inputDescriptionDrugEdit.Size = new System.Drawing.Size(222, 22);
            this.inputDescriptionDrugEdit.TabIndex = 2;
            this.inputDescriptionDrugEdit.TextChanged += new System.EventHandler(this.inputDescriptionDrugEdit_TextChanged);
            // 
            // labelDescriptionDrugEdit
            // 
            this.labelDescriptionDrugEdit.AutoSize = true;
            this.labelDescriptionDrugEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptionDrugEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDescriptionDrugEdit.Location = new System.Drawing.Point(269, 208);
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
            this.buttonDrugEdit.Location = new System.Drawing.Point(269, 449);
            this.buttonDrugEdit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDrugEdit.Name = "buttonDrugEdit";
            this.buttonDrugEdit.Size = new System.Drawing.Size(219, 50);
            this.buttonDrugEdit.TabIndex = 5;
            this.buttonDrugEdit.Text = "Modifier";
            this.buttonDrugEdit.UseVisualStyleBackColor = false;
            this.buttonDrugEdit.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // quantityDrugEdit
            // 
            this.quantityDrugEdit.AutoSize = true;
            this.quantityDrugEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityDrugEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quantityDrugEdit.Location = new System.Drawing.Point(269, 360);
            this.quantityDrugEdit.Name = "quantityDrugEdit";
            this.quantityDrugEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.quantityDrugEdit.Size = new System.Drawing.Size(111, 29);
            this.quantityDrugEdit.TabIndex = 6;
            this.quantityDrugEdit.Text = "Quantité";
            this.quantityDrugEdit.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericDrugEdit
            // 
            this.numericDrugEdit.Location = new System.Drawing.Point(269, 404);
            this.numericDrugEdit.Name = "numericDrugEdit";
            this.numericDrugEdit.Size = new System.Drawing.Size(77, 22);
            this.numericDrugEdit.TabIndex = 7;
            // 
            // nameContreIndic
            // 
            this.nameContreIndic.AutoSize = true;
            this.nameContreIndic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameContreIndic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameContreIndic.Location = new System.Drawing.Point(269, 283);
            this.nameContreIndic.Name = "nameContreIndic";
            this.nameContreIndic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameContreIndic.Size = new System.Drawing.Size(211, 29);
            this.nameContreIndic.TabIndex = 8;
            this.nameContreIndic.Text = "Contre indication";
            this.nameContreIndic.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // inputContreIndic
            // 
            this.inputContreIndic.Location = new System.Drawing.Point(269, 315);
            this.inputContreIndic.Name = "inputContreIndic";
            this.inputContreIndic.Size = new System.Drawing.Size(222, 22);
            this.inputContreIndic.TabIndex = 9;
            this.inputContreIndic.TextChanged += new System.EventHandler(this.inputContreIndic_TextChanged);
            // 
            // EditDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(873, 697);
            this.Controls.Add(this.inputContreIndic);
            this.Controls.Add(this.nameContreIndic);
            this.Controls.Add(this.numericDrugEdit);
            this.Controls.Add(this.quantityDrugEdit);
            this.Controls.Add(this.buttonDrugEdit);
            this.Controls.Add(this.labelNameDrugEdit);
            this.Controls.Add(this.labelDescriptionDrugEdit);
            this.Controls.Add(this.inputDescriptionDrugEdit);
            this.Controls.Add(this.InputNameDrugEdit);
            this.Controls.Add(this.titleDrugEdit);
            this.Name = "EditDrug";
            this.Text = "EditDrug";
            ((System.ComponentModel.ISupportInitialize)(this.numericDrugEdit)).EndInit();
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
        private System.Windows.Forms.Label quantityDrugEdit;
        private System.Windows.Forms.NumericUpDown numericDrugEdit;
        private System.Windows.Forms.Label nameContreIndic;
        private System.Windows.Forms.TextBox inputContreIndic;
    }
}