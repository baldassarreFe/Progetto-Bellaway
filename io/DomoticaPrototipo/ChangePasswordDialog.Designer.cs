namespace DomoticaPrototipo
{
    partial class ChangePasswordDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordDialog));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._adminOrOldPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._adminOrOldPasswordBox = new System.Windows.Forms.TextBox();
            this._newPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._confermaPasswTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._changeButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.usernPassErrati = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msg1 = new System.Windows.Forms.Label();
            this.msg2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._adminOrOldPassword, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._adminOrOldPasswordBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._newPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._confermaPasswTB, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(96, 141);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 127);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _adminOrOldPassword
            // 
            this._adminOrOldPassword.AutoSize = true;
            this._adminOrOldPassword.Location = new System.Drawing.Point(3, 0);
            this._adminOrOldPassword.Name = "_adminOrOldPassword";
            this._adminOrOldPassword.Size = new System.Drawing.Size(101, 13);
            this._adminOrOldPassword.TabIndex = 0;
            this._adminOrOldPassword.Text = "Password corrente :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nuova password :";
            // 
            // _adminOrOldPasswordBox
            // 
            this._adminOrOldPasswordBox.Location = new System.Drawing.Point(180, 3);
            this._adminOrOldPasswordBox.Name = "_adminOrOldPasswordBox";
            this._adminOrOldPasswordBox.PasswordChar = '•';
            this._adminOrOldPasswordBox.Size = new System.Drawing.Size(149, 20);
            this._adminOrOldPasswordBox.TabIndex = 2;
            // 
            // _newPassword
            // 
            this._newPassword.Location = new System.Drawing.Point(180, 43);
            this._newPassword.Name = "_newPassword";
            this._newPassword.PasswordChar = '•';
            this._newPassword.Size = new System.Drawing.Size(149, 20);
            this._newPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conferma la nuova password :";
            // 
            // _confermaPasswTB
            // 
            this._confermaPasswTB.Location = new System.Drawing.Point(180, 83);
            this._confermaPasswTB.Name = "_confermaPasswTB";
            this._confermaPasswTB.PasswordChar = '•';
            this._confermaPasswTB.Size = new System.Drawing.Size(149, 20);
            this._confermaPasswTB.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._changeButton);
            this.panel1.Controls.Add(this._cancelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 66);
            this.panel1.TabIndex = 1;
            // 
            // _changeButton
            // 
            this._changeButton.Location = new System.Drawing.Point(183, 20);
            this._changeButton.Name = "_changeButton";
            this._changeButton.Size = new System.Drawing.Size(75, 23);
            this._changeButton.TabIndex = 1;
            this._changeButton.Text = "Cambia";
            this._changeButton.UseVisualStyleBackColor = true;
            this._changeButton.Click += new System.EventHandler(this._changeButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(276, 20);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 0;
            this._cancelButton.Text = "Annulla";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // usernPassErrati
            // 
            this.usernPassErrati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.usernPassErrati.AutoSize = true;
            this.usernPassErrati.ForeColor = System.Drawing.Color.Red;
            this.usernPassErrati.Location = new System.Drawing.Point(273, 271);
            this.usernPassErrati.Name = "usernPassErrati";
            this.usernPassErrati.Size = new System.Drawing.Size(175, 13);
            this.usernPassErrati.TabIndex = 7;
            this.usernPassErrati.Text = "La password inserita non è corretta.";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(191, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cambia la password";
            // 
            // msg1
            // 
            this.msg1.AutoSize = true;
            this.msg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg1.Location = new System.Drawing.Point(25, 40);
            this.msg1.Name = "msg1";
            this.msg1.Size = new System.Drawing.Size(256, 15);
            this.msg1.TabIndex = 9;
            this.msg1.Text = "Inserisci la nuova password per il tuo account.";
            // 
            // msg2
            // 
            this.msg2.AutoSize = true;
            this.msg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg2.Location = new System.Drawing.Point(25, 55);
            this.msg2.Name = "msg2";
            this.msg2.Size = new System.Drawing.Size(496, 15);
            this.msg2.TabIndex = 10;
            this.msg2.Text = "Ti consigliamo vivamente di creare una password univoca che non utilizzi per altr" +
    "i siti web.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(401, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nota: non puoi riutilizzare la password precedente dopo averla cambiata";
            // 
            // ChangePasswordDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 353);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msg2);
            this.Controls.Add(this.msg1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernPassErrati);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswordDialog";
            this.Text = "Modifica la password del tuo account";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _changeButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label _adminOrOldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _adminOrOldPasswordBox;
        private System.Windows.Forms.TextBox _newPassword;
        private System.Windows.Forms.Label usernPassErrati;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _confermaPasswTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label msg1;
        private System.Windows.Forms.Label msg2;
        private System.Windows.Forms.Label label6;
    }
}