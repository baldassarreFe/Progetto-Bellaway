namespace BeautifulWeight.View
{
    partial class UserStrip2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._nomeLabel = new System.Windows.Forms.Label();
            this._cognomeLabel = new System.Windows.Forms.Label();
            this._profileImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._profileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // _nomeLabel
            // 
            this._nomeLabel.AutoSize = true;
            this._nomeLabel.Location = new System.Drawing.Point(106, 19);
            this._nomeLabel.Name = "_nomeLabel";
            this._nomeLabel.Size = new System.Drawing.Size(35, 13);
            this._nomeLabel.TabIndex = 0;
            this._nomeLabel.Text = "Nome";
            // 
            // _cognomeLabel
            // 
            this._cognomeLabel.AutoSize = true;
            this._cognomeLabel.Location = new System.Drawing.Point(106, 66);
            this._cognomeLabel.Name = "_cognomeLabel";
            this._cognomeLabel.Size = new System.Drawing.Size(52, 13);
            this._cognomeLabel.TabIndex = 1;
            this._cognomeLabel.Text = "Cognome";
            // 
            // _profileImage
            // 
            this._profileImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._profileImage.Location = new System.Drawing.Point(0, 4);
            this._profileImage.Name = "_profileImage";
            this._profileImage.Size = new System.Drawing.Size(100, 100);
            this._profileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._profileImage.TabIndex = 2;
            this._profileImage.TabStop = false;
            // 
            // UserStrip2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this._profileImage);
            this.Controls.Add(this._nomeLabel);
            this.Controls.Add(this._cognomeLabel);
            this.Name = "UserStrip2";
            this.Size = new System.Drawing.Size(357, 106);
            ((System.ComponentModel.ISupportInitialize)(this._profileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _nomeLabel;
        private System.Windows.Forms.Label _cognomeLabel;
        private System.Windows.Forms.PictureBox _profileImage;
    }
}
