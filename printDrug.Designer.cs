namespace InventLab
{
    partial class printDrug
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
            this.tableDrug = new System.Windows.Forms.DataGridView();
            this.titlePrintDrug = new System.Windows.Forms.Label();
            this.deleteDrug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableDrug)).BeginInit();
            this.SuspendLayout();
            // 
            // tableDrug
            // 
            this.tableDrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDrug.Location = new System.Drawing.Point(43, 94);
            this.tableDrug.Name = "tableDrug";
            this.tableDrug.RowHeadersWidth = 51;
            this.tableDrug.RowTemplate.Height = 24;
            this.tableDrug.Size = new System.Drawing.Size(692, 329);
            this.tableDrug.TabIndex = 0;
            this.tableDrug.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDrug_CellContentClick);
            // 
            // titlePrintDrug
            // 
            this.titlePrintDrug.AutoSize = true;
            this.titlePrintDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePrintDrug.Location = new System.Drawing.Point(278, 32);
            this.titlePrintDrug.Name = "titlePrintDrug";
            this.titlePrintDrug.Size = new System.Drawing.Size(194, 32);
            this.titlePrintDrug.TabIndex = 1;
            this.titlePrintDrug.Text = "Médicaments";
            this.titlePrintDrug.Click += new System.EventHandler(this.titlePrintDrug_Click);
            // 
            // deleteDrug
            // 
            this.deleteDrug.Location = new System.Drawing.Point(43, 463);
            this.deleteDrug.Name = "deleteDrug";
            this.deleteDrug.Size = new System.Drawing.Size(260, 81);
            this.deleteDrug.TabIndex = 2;
            this.deleteDrug.Text = "Supprimer le médicament";
            this.deleteDrug.UseVisualStyleBackColor = true;
            this.deleteDrug.Click += new System.EventHandler(this.deleteDrug_Click);
            // 
            // printDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 645);
            this.Controls.Add(this.deleteDrug);
            this.Controls.Add(this.titlePrintDrug);
            this.Controls.Add(this.tableDrug);
            this.Name = "printDrug";
            this.Text = "printDrug";
            ((System.ComponentModel.ISupportInitialize)(this.tableDrug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableDrug;
        private System.Windows.Forms.Label titlePrintDrug;
        private System.Windows.Forms.Button deleteDrug;
    }
}