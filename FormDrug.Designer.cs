namespace InventLab
{
    partial class FormDrug
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
            this.inputNameAddDrug = new System.Windows.Forms.TextBox();
            this.inputDescriptionAddDrug = new System.Windows.Forms.TextBox();
            this.buttonAddDrug = new System.Windows.Forms.Button();
            this.labelNameAddDrug = new System.Windows.Forms.Label();
            this.labelDescriptionAddDrug = new System.Windows.Forms.Label();
            this.inputQuantityFormDrug = new System.Windows.Forms.Label();
            this.inputQuantityAddDrug = new System.Windows.Forms.NumericUpDown();
            this.tableDrug = new System.Windows.Forms.DataGridView();
            this.deleteDrug = new System.Windows.Forms.Button();
            this.searchDrug = new System.Windows.Forms.TextBox();
            this.inputContreIndication = new System.Windows.Forms.TextBox();
            this.contreIndicationDRug = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputQuantityAddDrug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDrug)).BeginInit();
            this.SuspendLayout();
            // 
            // inputNameAddDrug
            // 
            this.inputNameAddDrug.Location = new System.Drawing.Point(26, 90);
            this.inputNameAddDrug.Name = "inputNameAddDrug";
            this.inputNameAddDrug.Size = new System.Drawing.Size(255, 20);
            this.inputNameAddDrug.TabIndex = 0;
            this.inputNameAddDrug.TextChanged += new System.EventHandler(this.inputNameAddDrug_TextChanged);
            // 
            // inputDescriptionAddDrug
            // 
            this.inputDescriptionAddDrug.Location = new System.Drawing.Point(26, 167);
            this.inputDescriptionAddDrug.Name = "inputDescriptionAddDrug";
            this.inputDescriptionAddDrug.Size = new System.Drawing.Size(255, 20);
            this.inputDescriptionAddDrug.TabIndex = 1;
            this.inputDescriptionAddDrug.TextChanged += new System.EventHandler(this.inputDescriptionAddDrug_TextChanged);
            // 
            // buttonAddDrug
            // 
            this.buttonAddDrug.Location = new System.Drawing.Point(26, 377);
            this.buttonAddDrug.Name = "buttonAddDrug";
            this.buttonAddDrug.Size = new System.Drawing.Size(254, 40);
            this.buttonAddDrug.TabIndex = 2;
            this.buttonAddDrug.Text = "Ajouter le médicament";
            this.buttonAddDrug.UseVisualStyleBackColor = true;
            this.buttonAddDrug.Click += new System.EventHandler(this.buttonAddDrug_Click);
            // 
            // labelNameAddDrug
            // 
            this.labelNameAddDrug.AutoSize = true;
            this.labelNameAddDrug.Location = new System.Drawing.Point(24, 57);
            this.labelNameAddDrug.Name = "labelNameAddDrug";
            this.labelNameAddDrug.Size = new System.Drawing.Size(89, 13);
            this.labelNameAddDrug.TabIndex = 4;
            this.labelNameAddDrug.Text = "Nom médicament";
            this.labelNameAddDrug.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDescriptionAddDrug
            // 
            this.labelDescriptionAddDrug.AutoSize = true;
            this.labelDescriptionAddDrug.Location = new System.Drawing.Point(24, 139);
            this.labelDescriptionAddDrug.Name = "labelDescriptionAddDrug";
            this.labelDescriptionAddDrug.Size = new System.Drawing.Size(120, 13);
            this.labelDescriptionAddDrug.TabIndex = 5;
            this.labelDescriptionAddDrug.Text = "Description médicament";
            // 
            // inputQuantityFormDrug
            // 
            this.inputQuantityFormDrug.AutoSize = true;
            this.inputQuantityFormDrug.Location = new System.Drawing.Point(24, 284);
            this.inputQuantityFormDrug.Name = "inputQuantityFormDrug";
            this.inputQuantityFormDrug.Size = new System.Drawing.Size(47, 13);
            this.inputQuantityFormDrug.TabIndex = 7;
            this.inputQuantityFormDrug.Text = "Quantité";
            this.inputQuantityFormDrug.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // inputQuantityAddDrug
            // 
            this.inputQuantityAddDrug.Location = new System.Drawing.Point(26, 315);
            this.inputQuantityAddDrug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputQuantityAddDrug.Name = "inputQuantityAddDrug";
            this.inputQuantityAddDrug.Size = new System.Drawing.Size(44, 20);
            this.inputQuantityAddDrug.TabIndex = 9;
            this.inputQuantityAddDrug.ValueChanged += new System.EventHandler(this.inputQuantityAddDrug_ValueChanged);
            // 
            // tableDrug
            // 
            this.tableDrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDrug.Location = new System.Drawing.Point(315, 78);
            this.tableDrug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableDrug.Name = "tableDrug";
            this.tableDrug.RowHeadersWidth = 51;
            this.tableDrug.RowTemplate.Height = 24;
            this.tableDrug.Size = new System.Drawing.Size(448, 327);
            this.tableDrug.TabIndex = 10;
            this.tableDrug.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDrug_CellContentClick);
            // 
            // deleteDrug
            // 
            this.deleteDrug.Location = new System.Drawing.Point(774, 339);
            this.deleteDrug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteDrug.Name = "deleteDrug";
            this.deleteDrug.Size = new System.Drawing.Size(195, 66);
            this.deleteDrug.TabIndex = 11;
            this.deleteDrug.Text = "Supprimer le médicament";
            this.deleteDrug.UseVisualStyleBackColor = true;
            this.deleteDrug.Click += new System.EventHandler(this.deleteDrug_Click_1);
            // 
            // searchDrug
            // 
            this.searchDrug.Location = new System.Drawing.Point(352, 28);
            this.searchDrug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchDrug.Name = "searchDrug";
            this.searchDrug.Size = new System.Drawing.Size(342, 20);
            this.searchDrug.TabIndex = 12;
            this.searchDrug.Text = "Rechercher";
            this.searchDrug.TextChanged += new System.EventHandler(this.searchDrug_TextChanged);
            // 
            // inputContreIndication
            // 
            this.inputContreIndication.Location = new System.Drawing.Point(26, 230);
            this.inputContreIndication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputContreIndication.Name = "inputContreIndication";
            this.inputContreIndication.Size = new System.Drawing.Size(255, 20);
            this.inputContreIndication.TabIndex = 13;
            // 
            // contreIndicationDRug
            // 
            this.contreIndicationDRug.AutoSize = true;
            this.contreIndicationDRug.Location = new System.Drawing.Point(26, 206);
            this.contreIndicationDRug.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contreIndicationDRug.Name = "contreIndicationDRug";
            this.contreIndicationDRug.Size = new System.Drawing.Size(86, 13);
            this.contreIndicationDRug.TabIndex = 14;
            this.contreIndicationDRug.Text = "Contre indication";
            this.contreIndicationDRug.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 16;
            // 
            // FormDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contreIndicationDRug);
            this.Controls.Add(this.inputContreIndication);
            this.Controls.Add(this.searchDrug);
            this.Controls.Add(this.deleteDrug);
            this.Controls.Add(this.tableDrug);
            this.Controls.Add(this.inputQuantityAddDrug);
            this.Controls.Add(this.inputQuantityFormDrug);
            this.Controls.Add(this.labelDescriptionAddDrug);
            this.Controls.Add(this.labelNameAddDrug);
            this.Controls.Add(this.buttonAddDrug);
            this.Controls.Add(this.inputDescriptionAddDrug);
            this.Controls.Add(this.inputNameAddDrug);
            this.Name = "FormDrug";
            this.Text = "FormDrug";
            this.Load += new System.EventHandler(this.FormDrug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputQuantityAddDrug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDrug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNameAddDrug;
        private System.Windows.Forms.TextBox inputDescriptionAddDrug;
        private System.Windows.Forms.Button buttonAddDrug;
        private System.Windows.Forms.Label labelNameAddDrug;
        private System.Windows.Forms.Label labelDescriptionAddDrug;
        private System.Windows.Forms.Label inputQuantityFormDrug;
        private System.Windows.Forms.NumericUpDown inputQuantityAddDrug;
        private System.Windows.Forms.DataGridView tableDrug;
        private System.Windows.Forms.Button deleteDrug;
        private System.Windows.Forms.TextBox searchDrug;
        private System.Windows.Forms.TextBox inputContreIndication;
        private System.Windows.Forms.Label contreIndicationDRug;
        private System.Windows.Forms.Label label3;
    }
}