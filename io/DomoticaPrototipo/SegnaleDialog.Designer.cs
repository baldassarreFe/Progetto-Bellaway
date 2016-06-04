namespace DomoticaPrototipo
{
    partial class SegnaleDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SegnaleDialog));
            this._mainPanel = new System.Windows.Forms.Panel();
            this._messaggio = new System.Windows.Forms.Label();
            this._okButton = new System.Windows.Forms.Button();
            this._mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainPanel
            // 
            this._mainPanel.Controls.Add(this._messaggio);
            this._mainPanel.Controls.Add(this._okButton);
            this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPanel.Location = new System.Drawing.Point(0, 0);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Size = new System.Drawing.Size(442, 118);
            this._mainPanel.TabIndex = 0;
            // 
            // _messaggio
            // 
            this._messaggio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._messaggio.AutoSize = true;
            this._messaggio.Location = new System.Drawing.Point(137, 44);
            this._messaggio.Name = "_messaggio";
            this._messaggio.Size = new System.Drawing.Size(161, 13);
            this._messaggio.TabIndex = 1;
            this._messaggio.Text = "Prova Testo Messaggio Segnale";
            this._messaggio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(177, 83);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 0;
            this._okButton.Text = "Ok";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // SegnaleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 118);
            this.Controls.Add(this._mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SegnaleDialog";
            this.Text = "SegnaleDialog";
            this._mainPanel.ResumeLayout(false);
            this._mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _mainPanel;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Label _messaggio;
    }
}