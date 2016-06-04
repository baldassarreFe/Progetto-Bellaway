namespace DomoticaPrototipo
{
    partial class DispositivoDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DispositivoDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this._inviaButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._dispositivoControl = new DomoticaPrototipo.DispositivoControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._inviaButton);
            this.panel1.Controls.Add(this._cancelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 54);
            this.panel1.TabIndex = 1;
            // 
            // _inviaButton
            // 
            this._inviaButton.Location = new System.Drawing.Point(216, 14);
            this._inviaButton.Name = "_inviaButton";
            this._inviaButton.Size = new System.Drawing.Size(75, 23);
            this._inviaButton.TabIndex = 1;
            this._inviaButton.Text = "Invia";
            this._inviaButton.UseVisualStyleBackColor = true;
            this._inviaButton.Click += new System.EventHandler(this._inviaButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(314, 14);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 0;
            this._cancelButton.Text = "Chiudi";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // _dispositivoControl
            // 
            this._dispositivoControl.AutoScroll = true;
            this._dispositivoControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._dispositivoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dispositivoControl.Location = new System.Drawing.Point(0, 0);
            this._dispositivoControl.Name = "_dispositivoControl";
            this._dispositivoControl.Size = new System.Drawing.Size(410, 403);
            this._dispositivoControl.TabIndex = 0;
            // 
            // DispositivoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._dispositivoControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DispositivoDialog";
            this.Text = "DispositivoDialog";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DispositivoControl _dispositivoControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _inviaButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}