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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelNameAddDrug = new System.Windows.Forms.Label();
            this.labelDescriptionAddDrug = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputNameAddDrug
            // 
            this.inputNameAddDrug.Location = new System.Drawing.Point(220, 123);
            this.inputNameAddDrug.Margin = new System.Windows.Forms.Padding(4);
            this.inputNameAddDrug.Name = "inputNameAddDrug";
            this.inputNameAddDrug.Size = new System.Drawing.Size(339, 22);
            this.inputNameAddDrug.TabIndex = 0;
            this.inputNameAddDrug.TextChanged += new System.EventHandler(this.inputNameAddDrug_TextChanged);
            // 
            // inputDescriptionAddDrug
            // 
            this.inputDescriptionAddDrug.Location = new System.Drawing.Point(220, 240);
            this.inputDescriptionAddDrug.Margin = new System.Windows.Forms.Padding(4);
            this.inputDescriptionAddDrug.Name = "inputDescriptionAddDrug";
            this.inputDescriptionAddDrug.Size = new System.Drawing.Size(339, 22);
            this.inputDescriptionAddDrug.TabIndex = 1;
            // 
            // buttonAddDrug
            // 
            this.buttonAddDrug.Location = new System.Drawing.Point(243, 332);
            this.buttonAddDrug.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddDrug.Name = "buttonAddDrug";
            this.buttonAddDrug.Size = new System.Drawing.Size(257, 49);
            this.buttonAddDrug.TabIndex = 2;
            this.buttonAddDrug.Text = "Ajouter le médicament";
            this.buttonAddDrug.UseVisualStyleBackColor = true;
            this.buttonAddDrug.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(623, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(399, 400);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelNameAddDrug
            // 
            this.labelNameAddDrug.AutoSize = true;
            this.labelNameAddDrug.Location = new System.Drawing.Point(269, 78);
            this.labelNameAddDrug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameAddDrug.Name = "labelNameAddDrug";
            this.labelNameAddDrug.Size = new System.Drawing.Size(113, 16);
            this.labelNameAddDrug.TabIndex = 4;
            this.labelNameAddDrug.Text = "Nom médicament";
            this.labelNameAddDrug.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDescriptionAddDrug
            // 
            this.labelDescriptionAddDrug.AutoSize = true;
            this.labelDescriptionAddDrug.Location = new System.Drawing.Point(269, 204);
            this.labelDescriptionAddDrug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescriptionAddDrug.Name = "labelDescriptionAddDrug";
            this.labelDescriptionAddDrug.Size = new System.Drawing.Size(152, 16);
            this.labelDescriptionAddDrug.TabIndex = 5;
            this.labelDescriptionAddDrug.Text = "Description médicament";
            // 
            // FormDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelDescriptionAddDrug);
            this.Controls.Add(this.labelNameAddDrug);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddDrug);
            this.Controls.Add(this.inputDescriptionAddDrug);
            this.Controls.Add(this.inputNameAddDrug);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDrug";
            this.Text = "FormDrug";
            this.Load += new System.EventHandler(this.FormDrug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNameAddDrug;
        private System.Windows.Forms.TextBox inputDescriptionAddDrug;
        private System.Windows.Forms.Button buttonAddDrug;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelNameAddDrug;
        private System.Windows.Forms.Label labelDescriptionAddDrug;
    }
}