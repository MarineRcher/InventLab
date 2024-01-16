namespace InventLab
{
    partial class AskChangePassword
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
            this.printTittle = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputLastName = new System.Windows.Forms.TextBox();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.buttonAskChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printTittle
            // 
            this.printTittle.AutoSize = true;
            this.printTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printTittle.Location = new System.Drawing.Point(111, 9);
            this.printTittle.Name = "printTittle";
            this.printTittle.Size = new System.Drawing.Size(576, 32);
            this.printTittle.TabIndex = 0;
            this.printTittle.Text = "Demande de modifiation de mot de passe";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(225, 104);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(301, 22);
            this.inputName.TabIndex = 1;
            // 
            // inputLastName
            // 
            this.inputLastName.Location = new System.Drawing.Point(225, 191);
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(301, 22);
            this.inputLastName.TabIndex = 2;
            // 
            // inputLogin
            // 
            this.inputLogin.Location = new System.Drawing.Point(225, 343);
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(301, 22);
            this.inputLogin.TabIndex = 3;
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(225, 264);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(301, 22);
            this.inputEmail.TabIndex = 4;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(222, 72);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 16);
            this.name.TabIndex = 5;
            this.name.Text = "Prénom";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(222, 306);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(40, 16);
            this.login.TabIndex = 6;
            this.login.Text = "Login";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(222, 234);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(41, 16);
            this.mail.TabIndex = 7;
            this.mail.Text = "Email";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(222, 161);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(97, 16);
            this.LastName.TabIndex = 8;
            this.LastName.Text = "Nom de famille";
            // 
            // buttonAskChangePassword
            // 
            this.buttonAskChangePassword.Location = new System.Drawing.Point(241, 400);
            this.buttonAskChangePassword.Name = "buttonAskChangePassword";
            this.buttonAskChangePassword.Size = new System.Drawing.Size(269, 63);
            this.buttonAskChangePassword.TabIndex = 9;
            this.buttonAskChangePassword.Text = "Enregistrer";
            this.buttonAskChangePassword.UseVisualStyleBackColor = true;
            this.buttonAskChangePassword.Click += new System.EventHandler(this.buttonAskChangePassword_Click);
            // 
            // AskChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.buttonAskChangePassword);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.login);
            this.Controls.Add(this.name);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.inputLogin);
            this.Controls.Add(this.inputLastName);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.printTittle);
            this.Name = "AskChangePassword";
            this.Text = "AskChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label printTittle;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputLastName;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Button buttonAskChangePassword;
    }
}