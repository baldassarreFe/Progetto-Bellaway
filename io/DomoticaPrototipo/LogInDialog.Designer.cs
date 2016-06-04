namespace DomoticaPrototipo
{
    partial class LogInDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.accediB = new System.Windows.Forms.Button();
            this.usernPassErrati = new System.Windows.Forms.Label();
            this.usernameP = new System.Windows.Forms.Panel();
            this.passwordP = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameP.SuspendLayout();
            this.passwordP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Effettua l’accesso al sistema inserendo le tue credenziali qui di seguito";
            // 
            // username
            // 
            this.username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(180, 115);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(58, 13);
            this.username.TabIndex = 1;
            this.username.Text = "Username:";
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(180, 171);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(56, 13);
            this.password.TabIndex = 2;
            this.password.Text = "Password:";
            // 
            // usernameTB
            // 
            this.usernameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.usernameTB.Location = new System.Drawing.Point(1, 1);
            this.usernameTB.MaximumSize = new System.Drawing.Size(165, 20);
            this.usernameTB.MinimumSize = new System.Drawing.Size(165, 20);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(165, 20);
            this.usernameTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            this.passwordTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.passwordTB.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passwordTB.Location = new System.Drawing.Point(1, 1);
            this.passwordTB.MaximumSize = new System.Drawing.Size(165, 20);
            this.passwordTB.MinimumSize = new System.Drawing.Size(165, 20);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '•';
            this.passwordTB.Size = new System.Drawing.Size(165, 20);
            this.passwordTB.TabIndex = 2;
            // 
            // accediB
            // 
            this.accediB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.accediB.Location = new System.Drawing.Point(459, 252);
            this.accediB.Name = "accediB";
            this.accediB.Size = new System.Drawing.Size(96, 39);
            this.accediB.TabIndex = 5;
            this.accediB.Text = "Accedi";
            this.accediB.UseVisualStyleBackColor = true;
            this.accediB.Click += new System.EventHandler(this.accediB_Click);
            // 
            // usernPassErrati
            // 
            this.usernPassErrati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.usernPassErrati.AutoSize = true;
            this.usernPassErrati.ForeColor = System.Drawing.Color.Red;
            this.usernPassErrati.Location = new System.Drawing.Point(273, 218);
            this.usernPassErrati.Name = "usernPassErrati";
            this.usernPassErrati.Size = new System.Drawing.Size(253, 13);
            this.usernPassErrati.TabIndex = 6;
            this.usernPassErrati.Text = "La password o il nome utente inserito non è corretto.";
            // 
            // usernameP
            // 
            this.usernameP.Controls.Add(this.usernameTB);
            this.usernameP.Location = new System.Drawing.Point(271, 115);
            this.usernameP.Name = "usernameP";
            this.usernameP.Size = new System.Drawing.Size(167, 22);
            this.usernameP.TabIndex = 8;
            // 
            // passwordP
            // 
            this.passwordP.Controls.Add(this.passwordTB);
            this.passwordP.Location = new System.Drawing.Point(270, 171);
            this.passwordP.Name = "passwordP";
            this.passwordP.Size = new System.Drawing.Size(167, 22);
            this.passwordP.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DomoticaPrototipo.Properties.Resources.immagine_logo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LogInDialog
            // 
            this.AcceptButton = this.accediB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 303);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordP);
            this.Controls.Add(this.usernameP);
            this.Controls.Add(this.usernPassErrati);
            this.Controls.Add(this.accediB);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInDialog";
            this.Text = "Accesso A Domotica";
            this.Load += new System.EventHandler(this.LogInDialog_Load);
            this.usernameP.ResumeLayout(false);
            this.usernameP.PerformLayout();
            this.passwordP.ResumeLayout(false);
            this.passwordP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button accediB;
        private System.Windows.Forms.Label usernPassErrati;
        private System.Windows.Forms.Panel usernameP;
        private System.Windows.Forms.Panel passwordP;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}