using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BeautifulWeight.View
{
    partial class PreferencesDialog
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
            this._preferencesList = new Telerik.WinControls.UI.RadListView();
            this._buttonPanel = new System.Windows.Forms.Panel();
            this._okButton = new Telerik.WinControls.UI.RadButton();
            this._annullaButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this._preferencesList)).BeginInit();
            this._buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._okButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._annullaButton)).BeginInit();
            this.SuspendLayout();
            // 
            // _preferencesList
            // 
            this._preferencesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._preferencesList.FullRowSelect = false;
            this._preferencesList.ItemSize = new System.Drawing.Size(64, 64);
            this._preferencesList.Location = new System.Drawing.Point(0, 0);
            this._preferencesList.Name = "_preferencesList";
            this._preferencesList.ShowCheckBoxes = true;
            this._preferencesList.Size = new System.Drawing.Size(445, 247);
            this._preferencesList.TabIndex = 0;
            this._preferencesList.Text = "radListView1";
            this._preferencesList.ViewType = Telerik.WinControls.UI.ListViewType.IconsView;
            // 
            // _buttonPanel
            // 
            this._buttonPanel.BackColor = System.Drawing.Color.White;
            this._buttonPanel.Controls.Add(this._annullaButton);
            this._buttonPanel.Controls.Add(this._okButton);
            this._buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._buttonPanel.Location = new System.Drawing.Point(0, 207);
            this._buttonPanel.Name = "_buttonPanel";
            this._buttonPanel.Size = new System.Drawing.Size(445, 40);
            this._buttonPanel.TabIndex = 0;
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(311, 4);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(110, 24);
            this._okButton.TabIndex = 0;
            this._okButton.Text = "Conferma";
            // 
            // _annullaButton
            // 
            this._annullaButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._annullaButton.Location = new System.Drawing.Point(170, 4);
            this._annullaButton.Name = "_annullaButton";
            this._annullaButton.Size = new System.Drawing.Size(110, 24);
            this._annullaButton.TabIndex = 1;
            this._annullaButton.Text = "Annulla";
            // 
            // PreferencesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 247);
            this.Controls.Add(this._buttonPanel);
            this.Controls.Add(this._preferencesList);
            this.Name = "PreferencesDialog";
            this.Text = "PreferencesDialog";
            ((System.ComponentModel.ISupportInitialize)(this._preferencesList)).EndInit();
            this._buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._okButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._annullaButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListView _preferencesList;
        private System.Windows.Forms.Panel _buttonPanel;
        private RadButton _okButton;
        private RadButton _annullaButton;
    }
}