﻿namespace DomoticaPrototipo
{
    partial class DispositivoControl
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
            this.components = new System.ComponentModel.Container();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // _flowLayoutPanel
            // 
            this._flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._flowLayoutPanel.Location = new System.Drawing.Point(19, 17);
            this._flowLayoutPanel.Name = "_flowLayoutPanel";
            this._flowLayoutPanel.Size = new System.Drawing.Size(319, 314);
            this._flowLayoutPanel.TabIndex = 0;
            // 
            // DispositivoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this._flowLayoutPanel);
            this.Name = "DispositivoControl";
            this.Size = new System.Drawing.Size(341, 331);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.FlowLayoutPanel _flowLayoutPanel;

    }
}
