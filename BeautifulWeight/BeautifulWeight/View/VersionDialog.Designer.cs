namespace BeautifulWeight.View
{
    partial class VersionDialog
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
            this._buttonPanel = new System.Windows.Forms.Panel();
            this._codeBox4 = new System.Windows.Forms.RichTextBox();
            this._codeBox3 = new System.Windows.Forms.RichTextBox();
            this._codeBox2 = new System.Windows.Forms.RichTextBox();
            this._codeBox1 = new System.Windows.Forms.RichTextBox();
            this._annullaButton = new Telerik.WinControls.UI.RadButton();
            this._okButton = new Telerik.WinControls.UI.RadButton();
            this._versionsListView = new Telerik.WinControls.UI.RadListView();
            this._buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._annullaButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._okButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._versionsListView)).BeginInit();
            this.SuspendLayout();
            // 
            // _buttonPanel
            // 
            this._buttonPanel.BackColor = System.Drawing.Color.White;
            this._buttonPanel.Controls.Add(this._codeBox4);
            this._buttonPanel.Controls.Add(this._codeBox3);
            this._buttonPanel.Controls.Add(this._codeBox2);
            this._buttonPanel.Controls.Add(this._codeBox1);
            this._buttonPanel.Controls.Add(this._annullaButton);
            this._buttonPanel.Controls.Add(this._okButton);
            this._buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._buttonPanel.Location = new System.Drawing.Point(0, 282);
            this._buttonPanel.Name = "_buttonPanel";
            this._buttonPanel.Size = new System.Drawing.Size(661, 40);
            this._buttonPanel.TabIndex = 1;
            // 
            // _codeBox4
            // 
            this._codeBox4.Location = new System.Drawing.Point(323, 7);
            this._codeBox4.Margin = new System.Windows.Forms.Padding(2);
            this._codeBox4.MaxLength = 4;
            this._codeBox4.Multiline = false;
            this._codeBox4.Name = "_codeBox4";
            this._codeBox4.Size = new System.Drawing.Size(102, 25);
            this._codeBox4.TabIndex = 5;
            this._codeBox4.Text = "";
            // 
            // _codeBox3
            // 
            this._codeBox3.Location = new System.Drawing.Point(218, 7);
            this._codeBox3.Margin = new System.Windows.Forms.Padding(2);
            this._codeBox3.MaxLength = 4;
            this._codeBox3.Multiline = false;
            this._codeBox3.Name = "_codeBox3";
            this._codeBox3.Size = new System.Drawing.Size(102, 25);
            this._codeBox3.TabIndex = 4;
            this._codeBox3.Text = "";
            // 
            // _codeBox2
            // 
            this._codeBox2.Location = new System.Drawing.Point(113, 8);
            this._codeBox2.Margin = new System.Windows.Forms.Padding(2);
            this._codeBox2.MaxLength = 4;
            this._codeBox2.Multiline = false;
            this._codeBox2.Name = "_codeBox2";
            this._codeBox2.Size = new System.Drawing.Size(102, 25);
            this._codeBox2.TabIndex = 3;
            this._codeBox2.Text = "";
            // 
            // _codeBox1
            // 
            this._codeBox1.Location = new System.Drawing.Point(9, 7);
            this._codeBox1.Margin = new System.Windows.Forms.Padding(2);
            this._codeBox1.MaxLength = 4;
            this._codeBox1.Multiline = false;
            this._codeBox1.Name = "_codeBox1";
            this._codeBox1.Size = new System.Drawing.Size(102, 25);
            this._codeBox1.TabIndex = 2;
            this._codeBox1.Text = "";
            // 
            // _annullaButton
            // 
            this._annullaButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._annullaButton.Location = new System.Drawing.Point(428, 7);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(110, 24);
            this._annullaButton.TabIndex = 1;
            this._annullaButton.Text = "Annulla";
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Enabled = false;
            this._okButton.Location = new System.Drawing.Point(543, 8);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(110, 24);
            this._okButton.TabIndex = 0;
            this._okButton.Text = "Conferma";
            // 
            // _versionsListView
            // 
            this._versionsListView.AllowColumnReorder = false;
            this._versionsListView.AllowColumnResize = false;
            this._versionsListView.AllowEdit = false;
            this._versionsListView.AllowRemove = false;
            this._versionsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._versionsListView.HotTracking = false;
            this._versionsListView.Location = new System.Drawing.Point(0, 0);
            this._versionsListView.Name = "_versionsListView";
            this._versionsListView.SelectLastAddedItem = false;
            this._versionsListView.Size = new System.Drawing.Size(661, 282);
            this._versionsListView.TabIndex = 2;
            this._versionsListView.Text = "radListView1";
            // 
            // VersionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(661, 322);
            this.Controls.Add(this._versionsListView);
            this.Controls.Add(this._buttonPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VersionDialog";
            this.Text = "VersionDialog";
            this._buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._annullaButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._okButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._versionsListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _buttonPanel;
        private Telerik.WinControls.UI.RadButton _annullaButton;
        private Telerik.WinControls.UI.RadButton _okButton;
        private System.Windows.Forms.RichTextBox _codeBox4;
        private System.Windows.Forms.RichTextBox _codeBox3;
        private System.Windows.Forms.RichTextBox _codeBox2;
        private System.Windows.Forms.RichTextBox _codeBox1;
        private Telerik.WinControls.UI.RadListView _versionsListView;
    }
}