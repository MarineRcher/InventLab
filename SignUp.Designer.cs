namespace InventLab
{
    partial class SignUp
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.InputSignUpUsername = new System.Windows.Forms.TextBox();
            this.InputSignUpPassword = new System.Windows.Forms.TextBox();
            this.titleSignUp = new System.Windows.Forms.Label();
            this.labelSignUpUsername = new System.Windows.Forms.Label();
            this.labelSignUpPassword = new System.Windows.Forms.Label();
            this.InputSignUpLastName = new System.Windows.Forms.TextBox();
            this.labelSignUpLastName = new System.Windows.Forms.Label();
            this.labelSignUpName = new System.Windows.Forms.Label();
            this.InputSignUpName = new System.Windows.Forms.TextBox();
            this.labelSignUpPassword2 = new System.Windows.Forms.Label();
            this.inputSignUpPassword2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(230, 584);
            this.buttonSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonSignUp.Size = new System.Drawing.Size(333, 66);
            this.buttonSignUp.TabIndex = 0;
            this.buttonSignUp.Text = "Inscription";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // InputSignUpUsername
            // 
            this.InputSignUpUsername.Location = new System.Drawing.Point(265, 352);
            this.InputSignUpUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputSignUpUsername.Name = "InputSignUpUsername";
            this.InputSignUpUsername.Size = new System.Drawing.Size(267, 22);
            this.InputSignUpUsername.TabIndex = 2;
            this.InputSignUpUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // InputSignUpPassword
            // 
            this.InputSignUpPassword.Location = new System.Drawing.Point(265, 440);
            this.InputSignUpPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputSignUpPassword.Name = "InputSignUpPassword";
            this.InputSignUpPassword.Size = new System.Drawing.Size(267, 22);
            this.InputSignUpPassword.TabIndex = 3;
            this.InputSignUpPassword.TextChanged += new System.EventHandler(this.InputSignUpPassword_TextChanged);
            // 
            // titleSignUp
            // 
            this.titleSignUp.AutoSize = true;
            this.titleSignUp.Font = new System.Drawing.Font("Amiri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSignUp.Location = new System.Drawing.Point(324, 11);
            this.titleSignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleSignUp.Name = "titleSignUp";
            this.titleSignUp.Size = new System.Drawing.Size(162, 75);
            this.titleSignUp.TabIndex = 4;
            this.titleSignUp.Text = "Inscription";
            this.titleSignUp.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSignUpUsername
            // 
            this.labelSignUpUsername.AutoSize = true;
            this.labelSignUpUsername.Font = new System.Drawing.Font("Amiri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUpUsername.Location = new System.Drawing.Point(255, 283);
            this.labelSignUpUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSignUpUsername.Name = "labelSignUpUsername";
            this.labelSignUpUsername.Size = new System.Drawing.Size(111, 55);
            this.labelSignUpUsername.TabIndex = 5;
            this.labelSignUpUsername.Text = "Username";
            this.labelSignUpUsername.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelSignUpPassword
            // 
            this.labelSignUpPassword.AutoSize = true;
            this.labelSignUpPassword.Font = new System.Drawing.Font("Amiri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUpPassword.Location = new System.Drawing.Point(255, 383);
            this.labelSignUpPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSignUpPassword.Name = "labelSignUpPassword";
            this.labelSignUpPassword.Size = new System.Drawing.Size(136, 55);
            this.labelSignUpPassword.TabIndex = 6;
            this.labelSignUpPassword.Text = "Mot de passe";
            // 
            // InputSignUpLastName
            // 
            this.InputSignUpLastName.Location = new System.Drawing.Point(265, 238);
            this.InputSignUpLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputSignUpLastName.Name = "InputSignUpLastName";
            this.InputSignUpLastName.Size = new System.Drawing.Size(267, 22);
            this.InputSignUpLastName.TabIndex = 7;
            this.InputSignUpLastName.TextChanged += new System.EventHandler(this.InputSignUpLastName_TextChanged);
            // 
            // labelSignUpLastName
            // 
            this.labelSignUpLastName.AutoSize = true;
            this.labelSignUpLastName.Font = new System.Drawing.Font("Amiri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUpLastName.Location = new System.Drawing.Point(255, 181);
            this.labelSignUpLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSignUpLastName.Name = "labelSignUpLastName";
            this.labelSignUpLastName.Size = new System.Drawing.Size(158, 55);
            this.labelSignUpLastName.TabIndex = 8;
            this.labelSignUpLastName.Text = "Nom de famille";
            this.labelSignUpLastName.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelSignUpName
            // 
            this.labelSignUpName.AutoSize = true;
            this.labelSignUpName.Font = new System.Drawing.Font("Amiri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUpName.Location = new System.Drawing.Point(255, 86);
            this.labelSignUpName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSignUpName.Name = "labelSignUpName";
            this.labelSignUpName.Size = new System.Drawing.Size(92, 55);
            this.labelSignUpName.TabIndex = 9;
            this.labelSignUpName.Text = "Prénom";
            this.labelSignUpName.Click += new System.EventHandler(this.label5_Click);
            // 
            // InputSignUpName
            // 
            this.InputSignUpName.Location = new System.Drawing.Point(265, 143);
            this.InputSignUpName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputSignUpName.Name = "InputSignUpName";
            this.InputSignUpName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InputSignUpName.Size = new System.Drawing.Size(267, 22);
            this.InputSignUpName.TabIndex = 10;
            this.InputSignUpName.TextChanged += new System.EventHandler(this.InputSignUpName_TextChanged);
            // 
            // labelSignUpPassword2
            // 
            this.labelSignUpPassword2.AutoSize = true;
            this.labelSignUpPassword2.Font = new System.Drawing.Font("Amiri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUpPassword2.Location = new System.Drawing.Point(255, 482);
            this.labelSignUpPassword2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSignUpPassword2.Name = "labelSignUpPassword2";
            this.labelSignUpPassword2.Size = new System.Drawing.Size(253, 55);
            this.labelSignUpPassword2.TabIndex = 11;
            this.labelSignUpPassword2.Text = "Confirmer le mot de passe";
            this.labelSignUpPassword2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // inputSignUpPassword2
            // 
            this.inputSignUpPassword2.Location = new System.Drawing.Point(265, 539);
            this.inputSignUpPassword2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputSignUpPassword2.Name = "inputSignUpPassword2";
            this.inputSignUpPassword2.Size = new System.Drawing.Size(267, 22);
            this.inputSignUpPassword2.TabIndex = 12;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 691);
            this.Controls.Add(this.inputSignUpPassword2);
            this.Controls.Add(this.labelSignUpPassword2);
            this.Controls.Add(this.InputSignUpName);
            this.Controls.Add(this.labelSignUpName);
            this.Controls.Add(this.labelSignUpLastName);
            this.Controls.Add(this.InputSignUpLastName);
            this.Controls.Add(this.labelSignUpPassword);
            this.Controls.Add(this.labelSignUpUsername);
            this.Controls.Add(this.titleSignUp);
            this.Controls.Add(this.InputSignUpPassword);
            this.Controls.Add(this.InputSignUpUsername);
            this.Controls.Add(this.buttonSignUp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignUp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox InputSignUpUsername;
        private System.Windows.Forms.TextBox InputSignUpPassword;
        private System.Windows.Forms.Label titleSignUp;
        private System.Windows.Forms.Label labelSignUpUsername;
        private System.Windows.Forms.Label labelSignUpPassword;
        private System.Windows.Forms.TextBox InputSignUpLastName;
        private System.Windows.Forms.Label labelSignUpLastName;
        private System.Windows.Forms.Label labelSignUpName;
        private System.Windows.Forms.TextBox InputSignUpName;
        private System.Windows.Forms.Label labelSignUpPassword2;
        private System.Windows.Forms.TextBox inputSignUpPassword2;
    }
}

