namespace InventLab
{
    partial class SignIn
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
            this.inputSignInUsername = new System.Windows.Forms.TextBox();
            this.inputSignInPassword = new System.Windows.Forms.TextBox();
            this.titleSignIn = new System.Windows.Forms.Label();
            this.labelSignInPassword = new System.Windows.Forms.Label();
            this.labelSignInUsername = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputSignInUsername
            // 
            this.inputSignInUsername.Location = new System.Drawing.Point(432, 161);
            this.inputSignInUsername.Name = "inputSignInUsername";
            this.inputSignInUsername.Size = new System.Drawing.Size(361, 22);
            this.inputSignInUsername.TabIndex = 0;
            // 
            // inputSignInPassword
            // 
            this.inputSignInPassword.Location = new System.Drawing.Point(432, 288);
            this.inputSignInPassword.Name = "inputSignInPassword";
            this.inputSignInPassword.Size = new System.Drawing.Size(361, 22);
            this.inputSignInPassword.TabIndex = 1;
            // 
            // titleSignIn
            // 
            this.titleSignIn.AutoSize = true;
            this.titleSignIn.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSignIn.Location = new System.Drawing.Point(528, 38);
            this.titleSignIn.Name = "titleSignIn";
            this.titleSignIn.Size = new System.Drawing.Size(166, 37);
            this.titleSignIn.TabIndex = 2;
            this.titleSignIn.Text = "Connexion";
            // 
            // labelSignInPassword
            // 
            this.labelSignInPassword.AutoSize = true;
            this.labelSignInPassword.Font = new System.Drawing.Font("Microsoft YaHei", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignInPassword.Location = new System.Drawing.Point(429, 247);
            this.labelSignInPassword.Name = "labelSignInPassword";
            this.labelSignInPassword.Size = new System.Drawing.Size(168, 31);
            this.labelSignInPassword.TabIndex = 3;
            this.labelSignInPassword.Text = "Mot de passe";
            this.labelSignInPassword.Click += new System.EventHandler(this.labelSignInPassword_Click);
            // 
            // labelSignInUsername
            // 
            this.labelSignInUsername.AutoSize = true;
            this.labelSignInUsername.Font = new System.Drawing.Font("Microsoft YaHei", 12.8F, System.Drawing.FontStyle.Bold);
            this.labelSignInUsername.Location = new System.Drawing.Point(426, 118);
            this.labelSignInUsername.Name = "labelSignInUsername";
            this.labelSignInUsername.Size = new System.Drawing.Size(210, 30);
            this.labelSignInUsername.TabIndex = 4;
            this.labelSignInUsername.Text = "Nom d\'utilisateur";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(432, 396);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(361, 69);
            this.buttonSignIn.TabIndex = 5;
            this.buttonSignIn.Text = "Connexion";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 657);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.labelSignInUsername);
            this.Controls.Add(this.labelSignInPassword);
            this.Controls.Add(this.titleSignIn);
            this.Controls.Add(this.inputSignInPassword);
            this.Controls.Add(this.inputSignInUsername);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputSignInUsername;
        private System.Windows.Forms.TextBox inputSignInPassword;
        private System.Windows.Forms.Label titleSignIn;
        private System.Windows.Forms.Label labelSignInPassword;
        private System.Windows.Forms.Label labelSignInUsername;
        private System.Windows.Forms.Button buttonSignIn;
    }
}