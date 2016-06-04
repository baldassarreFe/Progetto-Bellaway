namespace DomoticaPrototipo
{
    partial class EditUtenteDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUtenteDialog));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._changePassword = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._nameBox = new System.Windows.Forms.TextBox();
            this._usernameBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._saveButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._usernameLB = new System.Windows.Forms.Label();
            this._nomeUtenteLB = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.71672F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.28328F));
            this.tableLayoutPanel1.Controls.Add(this._changePassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._nameBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._usernameBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.19048F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.80952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _changePassword
            // 
            this._changePassword.AutoSize = true;
            this._changePassword.Location = new System.Drawing.Point(92, 106);
            this._changePassword.Name = "_changePassword";
            this._changePassword.Size = new System.Drawing.Size(95, 13);
            this._changePassword.TabIndex = 5;
            this._changePassword.TabStop = true;
            this._changePassword.Text = "Modifica password";
            this._changePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._changePassword_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // _nameBox
            // 
            this._nameBox.Location = new System.Drawing.Point(92, 3);
            this._nameBox.Name = "_nameBox";
            this._nameBox.Size = new System.Drawing.Size(161, 20);
            this._nameBox.TabIndex = 4;
            // 
            // _usernameBox
            // 
            this._usernameBox.Location = new System.Drawing.Point(92, 57);
            this._usernameBox.Name = "_usernameBox";
            this._usernameBox.Size = new System.Drawing.Size(161, 20);
            this._usernameBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._saveButton);
            this.panel1.Controls.Add(this._cancelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 63);
            this.panel1.TabIndex = 1;
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(194, 20);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(75, 23);
            this._saveButton.TabIndex = 1;
            this._saveButton.Text = "Salva";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this._saveButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(297, 20);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 0;
            this._cancelButton.Text = "Annulla";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DomoticaPrototipo.Properties.Resources.account;
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.panel2.Controls.Add(this._usernameLB);
            this.panel2.Controls.Add(this._nomeUtenteLB);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 66);
            this.panel2.TabIndex = 3;
            // 
            // _usernameLB
            // 
            this._usernameLB.AutoSize = true;
            this._usernameLB.Location = new System.Drawing.Point(66, 35);
            this._usernameLB.Name = "_usernameLB";
            this._usernameLB.Size = new System.Drawing.Size(98, 13);
            this._usernameLB.TabIndex = 4;
            this._usernameLB.Text = "\"Username utente\"";
            // 
            // _nomeUtenteLB
            // 
            this._nomeUtenteLB.AutoSize = true;
            this._nomeUtenteLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nomeUtenteLB.Location = new System.Drawing.Point(66, 9);
            this._nomeUtenteLB.Name = "_nomeUtenteLB";
            this._nomeUtenteLB.Size = new System.Drawing.Size(99, 17);
            this._nomeUtenteLB.TabIndex = 3;
            this._nomeUtenteLB.Text = "\"Nome utente\"";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(192)))), ((int)(((byte)(231)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(340, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 68);
            this.panel3.TabIndex = 4;
            // 
            // EditUtenteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 251);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditUtenteDialog";
            this.Text = "Modifica dell\'account utente";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _nameBox;
        private System.Windows.Forms.TextBox _usernameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label _usernameLB;
        private System.Windows.Forms.Label _nomeUtenteLB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel _changePassword;
    }
}