namespace InventLab
{
    partial class ProfilPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilPatient));
            this.NameAndLastname = new System.Windows.Forms.Label();
            this.birthPatient = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableAllergiesPatient = new System.Windows.Forms.DataGridView();
            this.tableAntecedents = new System.Windows.Forms.DataGridView();
            this.printBirthPatient = new System.Windows.Forms.Label();
            this.printSexePatient = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonEditBirth = new System.Windows.Forms.Button();
            this.editBirthPatient = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tableAllergiesPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAntecedents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameAndLastname
            // 
            this.NameAndLastname.AutoSize = true;
            this.NameAndLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameAndLastname.Location = new System.Drawing.Point(443, 31);
            this.NameAndLastname.Name = "NameAndLastname";
            this.NameAndLastname.Size = new System.Drawing.Size(143, 29);
            this.NameAndLastname.TabIndex = 0;
            this.NameAndLastname.Text = "Nom patient";
            this.NameAndLastname.Click += new System.EventHandler(this.label1_Click);
            // 
            // birthPatient
            // 
            this.birthPatient.AutoSize = true;
            this.birthPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthPatient.Location = new System.Drawing.Point(38, 163);
            this.birthPatient.Name = "birthPatient";
            this.birthPatient.Size = new System.Drawing.Size(211, 29);
            this.birthPatient.TabIndex = 1;
            this.birthPatient.Text = "Date de naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(631, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Allergies";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(631, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Antecedents";
            // 
            // tableAllergiesPatient
            // 
            this.tableAllergiesPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAllergiesPatient.Location = new System.Drawing.Point(636, 167);
            this.tableAllergiesPatient.Name = "tableAllergiesPatient";
            this.tableAllergiesPatient.RowHeadersWidth = 51;
            this.tableAllergiesPatient.RowTemplate.Height = 24;
            this.tableAllergiesPatient.Size = new System.Drawing.Size(375, 129);
            this.tableAllergiesPatient.TabIndex = 5;
            this.tableAllergiesPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableAntecedents
            // 
            this.tableAntecedents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAntecedents.Location = new System.Drawing.Point(636, 456);
            this.tableAntecedents.Name = "tableAntecedents";
            this.tableAntecedents.RowHeadersWidth = 51;
            this.tableAntecedents.RowTemplate.Height = 24;
            this.tableAntecedents.Size = new System.Drawing.Size(375, 129);
            this.tableAntecedents.TabIndex = 6;
            this.tableAntecedents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableAntecedents_CellContentClick);
            // 
            // printBirthPatient
            // 
            this.printBirthPatient.AutoSize = true;
            this.printBirthPatient.Location = new System.Drawing.Point(40, 208);
            this.printBirthPatient.Name = "printBirthPatient";
            this.printBirthPatient.Size = new System.Drawing.Size(44, 16);
            this.printBirthPatient.TabIndex = 7;
            this.printBirthPatient.Text = "label6";
            // 
            // printSexePatient
            // 
            this.printSexePatient.AutoSize = true;
            this.printSexePatient.Location = new System.Drawing.Point(40, 306);
            this.printSexePatient.Name = "printSexePatient";
            this.printSexePatient.Size = new System.Drawing.Size(44, 16);
            this.printSexePatient.TabIndex = 8;
            this.printSexePatient.Text = "label7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(837, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(636, 603);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 48);
            this.button3.TabIndex = 11;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(837, 603);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 48);
            this.button4.TabIndex = 12;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(232, 304);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 16);
            this.id.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(255, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ButtonEditBirth
            // 
            this.ButtonEditBirth.Location = new System.Drawing.Point(351, 204);
            this.ButtonEditBirth.Name = "ButtonEditBirth";
            this.ButtonEditBirth.Size = new System.Drawing.Size(205, 35);
            this.ButtonEditBirth.TabIndex = 17;
            this.ButtonEditBirth.Text = "Modifier";
            this.ButtonEditBirth.UseVisualStyleBackColor = true;
            this.ButtonEditBirth.Click += new System.EventHandler(this.ButtonEditBirth_Click);
            // 
            // editBirthPatient
            // 
            this.editBirthPatient.Location = new System.Drawing.Point(32, 208);
            this.editBirthPatient.Name = "editBirthPatient";
            this.editBirthPatient.Size = new System.Drawing.Size(246, 22);
            this.editBirthPatient.TabIndex = 18;
            // 
            // ProfilPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 682);
            this.Controls.Add(this.editBirthPatient);
            this.Controls.Add(this.ButtonEditBirth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.printSexePatient);
            this.Controls.Add(this.printBirthPatient);
            this.Controls.Add(this.tableAntecedents);
            this.Controls.Add(this.tableAllergiesPatient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birthPatient);
            this.Controls.Add(this.NameAndLastname);
            this.Name = "ProfilPatient";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProfilPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableAllergiesPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAntecedents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameAndLastname;
        private System.Windows.Forms.Label birthPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tableAllergiesPatient;
        private System.Windows.Forms.DataGridView tableAntecedents;
        private System.Windows.Forms.Label printBirthPatient;
        private System.Windows.Forms.Label printSexePatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonEditBirth;
        private System.Windows.Forms.DateTimePicker editBirthPatient;
    }
}