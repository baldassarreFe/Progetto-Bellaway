using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace BeautifulWeight.View
{
    partial class BeautifulUI
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
            this._UISplitContainer = new Telerik.WinControls.UI.RadSplitContainer();
            this._users = new Telerik.WinControls.UI.SplitPanel();
            this._usersListView = new Telerik.WinControls.UI.RadListView();
            this._usersMenuPanel = new Telerik.WinControls.UI.RadPanel();
            this._aggiungiButton = new Telerik.WinControls.UI.RadButton();
            this._profile = new Telerik.WinControls.UI.SplitPanel();
            this._profilePanel = new System.Windows.Forms.Panel();
            this._profileMenuPanel = new Telerik.WinControls.UI.RadPanel();
            this._diet = new Telerik.WinControls.UI.SplitPanel();
            this._dietPanel = new Telerik.WinControls.UI.RadPanel();
            this._dietUpperPanel = new Telerik.WinControls.UI.RadPanel();
            this._dietButtonsPanel = new Telerik.WinControls.UI.RadPanel();
            this._dietButtons = new System.Windows.Forms.TableLayoutPanel();
            this._newDietButton = new Telerik.WinControls.UI.RadButton();
            this._deleteDietButton = new Telerik.WinControls.UI.RadButton();
            this._versionStatusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this._versionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._UISplitContainer)).BeginInit();
            this._UISplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._users)).BeginInit();
            this._users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._usersListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._usersMenuPanel)).BeginInit();
            this._usersMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._aggiungiButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._profile)).BeginInit();
            this._profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._profileMenuPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._diet)).BeginInit();
            this._diet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dietPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dietUpperPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dietButtonsPanel)).BeginInit();
            this._dietButtonsPanel.SuspendLayout();
            this._dietButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._newDietButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._deleteDietButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._versionStatusStrip)).BeginInit();
            this._versionStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // _UISplitContainer
            // 
            this._UISplitContainer.Controls.Add(this._users);
            this._UISplitContainer.Controls.Add(this._profile);
            this._UISplitContainer.Controls.Add(this._diet);
            this._UISplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._UISplitContainer.Location = new System.Drawing.Point(0, 0);
            this._UISplitContainer.Name = "_UISplitContainer";
            // 
            // 
            // 
            this._UISplitContainer.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this._UISplitContainer.Size = new System.Drawing.Size(1597, 555);
            this._UISplitContainer.SplitterWidth = 2;
            this._UISplitContainer.TabIndex = 1;
            this._UISplitContainer.TabStop = false;
            this._UISplitContainer.Text = "radSplitContainer1";
            // 
            // _users
            // 
            this._users.Controls.Add(this._usersListView);
            this._users.Controls.Add(this._usersMenuPanel);
            this._users.Location = new System.Drawing.Point(0, 0);
            this._users.Name = "_users";
            // 
            // 
            // 
            this._users.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this._users.Size = new System.Drawing.Size(290, 555);
            this._users.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.1512869F, 0F);
            this._users.SizeInfo.SplitterCorrection = new System.Drawing.Size(-114, 0);
            this._users.TabIndex = 0;
            this._users.TabStop = false;
            this._users.Text = "splitPanel1";
            // 
            // _usersListView
            // 
            this._usersListView.AllowColumnReorder = false;
            this._usersListView.AllowColumnResize = false;
            this._usersListView.AllowEdit = false;
            this._usersListView.AllowRemove = false;
            this._usersListView.AutoScroll = true;
            this._usersListView.CheckOnClickMode = Telerik.WinControls.UI.CheckOnClickMode.FirstClick;
            this._usersListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._usersListView.FullRowSelect = false;
            this._usersListView.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide;
            this._usersListView.ItemSize = new System.Drawing.Size(300, 100);
            this._usersListView.Location = new System.Drawing.Point(0, 0);
            this._usersListView.Name = "_usersListView";
            this._usersListView.SelectLastAddedItem = false;
            this._usersListView.ShowColumnHeaders = false;
            this._usersListView.Size = new System.Drawing.Size(290, 519);
            this._usersListView.TabIndex = 1;
            this._usersListView.Text = "_usersListView";
            // 
            // _usersMenuPanel
            // 
            this._usersMenuPanel.Controls.Add(this._aggiungiButton);
            this._usersMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._usersMenuPanel.Location = new System.Drawing.Point(0, 519);
            this._usersMenuPanel.Name = "_usersMenuPanel";
            this._usersMenuPanel.Size = new System.Drawing.Size(290, 36);
            this._usersMenuPanel.TabIndex = 0;
            // 
            // _aggiungiButton
            // 
            this._aggiungiButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._aggiungiButton.Enabled = false;
            this._aggiungiButton.Location = new System.Drawing.Point(0, 0);
            this._aggiungiButton.Name = "_aggiungiButton";
            this._aggiungiButton.Size = new System.Drawing.Size(290, 36);
            this._aggiungiButton.TabIndex = 3;
            this._aggiungiButton.Text = "Aggiungi";
            // 
            // _profile
            // 
            this._profile.Controls.Add(this._profilePanel);
            this._profile.Controls.Add(this._profileMenuPanel);
            this._profile.Location = new System.Drawing.Point(292, 0);
            this._profile.Name = "_profile";
            // 
            // 
            // 
            this._profile.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this._profile.Size = new System.Drawing.Size(538, 555);
            this._profile.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.004394203F, 0F);
            this._profile.SizeInfo.SplitterCorrection = new System.Drawing.Size(-26, 0);
            this._profile.TabIndex = 1;
            this._profile.TabStop = false;
            this._profile.Text = "splitPanel2";
            // 
            // _profilePanel
            // 
            this._profilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._profilePanel.Location = new System.Drawing.Point(0, 0);
            this._profilePanel.Name = "_profilePanel";
            this._profilePanel.Size = new System.Drawing.Size(538, 519);
            this._profilePanel.TabIndex = 2;
            // 
            // _profileMenuPanel
            // 
            this._profileMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._profileMenuPanel.Location = new System.Drawing.Point(0, 519);
            this._profileMenuPanel.Name = "_profileMenuPanel";
            this._profileMenuPanel.Size = new System.Drawing.Size(538, 36);
            this._profileMenuPanel.TabIndex = 1;
            // 
            // _diet
            // 
            this._diet.Controls.Add(this._dietPanel);
            this._diet.Controls.Add(this._dietUpperPanel);
            this._diet.Controls.Add(this._dietButtonsPanel);
            this._diet.Location = new System.Drawing.Point(832, 0);
            this._diet.Name = "_diet";
            // 
            // 
            // 
            this._diet.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this._diet.Size = new System.Drawing.Size(765, 555);
            this._diet.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.1468927F, 0F);
            this._diet.SizeInfo.SplitterCorrection = new System.Drawing.Size(140, 0);
            this._diet.TabIndex = 2;
            this._diet.TabStop = false;
            this._diet.Text = "splitPanel3";
            // 
            // _dietPanel
            // 
            this._dietPanel.AutoScroll = true;
            this._dietPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dietPanel.Location = new System.Drawing.Point(0, 46);
            this._dietPanel.Name = "_dietPanel";
            this._dietPanel.Size = new System.Drawing.Size(765, 473);
            this._dietPanel.TabIndex = 3;
            // 
            // _dietUpperPanel
            // 
            this._dietUpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._dietUpperPanel.Location = new System.Drawing.Point(0, 0);
            this._dietUpperPanel.Name = "_dietUpperPanel";
            this._dietUpperPanel.Size = new System.Drawing.Size(765, 46);
            this._dietUpperPanel.TabIndex = 2;
            // 
            // _dietButtonsPanel
            // 
            this._dietButtonsPanel.Controls.Add(this._dietButtons);
            this._dietButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._dietButtonsPanel.Location = new System.Drawing.Point(0, 519);
            this._dietButtonsPanel.Name = "_dietButtonsPanel";
            this._dietButtonsPanel.Size = new System.Drawing.Size(765, 36);
            this._dietButtonsPanel.TabIndex = 1;
            // 
            // _dietButtons
            // 
            this._dietButtons.ColumnCount = 2;
            this._dietButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._dietButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._dietButtons.Controls.Add(this._newDietButton, 0, 0);
            this._dietButtons.Controls.Add(this._deleteDietButton, 0, 0);
            this._dietButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dietButtons.Location = new System.Drawing.Point(0, 0);
            this._dietButtons.Name = "_dietButtons";
            this._dietButtons.RowCount = 1;
            this._dietButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._dietButtons.Size = new System.Drawing.Size(765, 36);
            this._dietButtons.TabIndex = 0;
            // 
            // _newDietButton
            // 
            this._newDietButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._newDietButton.Enabled = false;
            this._newDietButton.Location = new System.Drawing.Point(385, 3);
            this._newDietButton.Name = "_newDietButton";
            this._newDietButton.Size = new System.Drawing.Size(377, 30);
            this._newDietButton.TabIndex = 5;
            this._newDietButton.Text = "Nuova Dieta";
            // 
            // _deleteDietButton
            // 
            this._deleteDietButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._deleteDietButton.Enabled = false;
            this._deleteDietButton.Location = new System.Drawing.Point(3, 3);
            this._deleteDietButton.Name = "_deleteDietButton";
            this._deleteDietButton.Size = new System.Drawing.Size(376, 30);
            this._deleteDietButton.TabIndex = 4;
            this._deleteDietButton.Text = "Elimina Dieta";
            // 
            // _versionStatusStrip
            // 
            this._versionStatusStrip.Controls.Add(this._versionLabel);
            this._versionStatusStrip.Location = new System.Drawing.Point(0, 555);
            this._versionStatusStrip.Name = "_versionStatusStrip";
            this._versionStatusStrip.Size = new System.Drawing.Size(1597, 26);
            this._versionStatusStrip.TabIndex = 0;
            // 
            // _versionLabel
            // 
            this._versionLabel.BackColor = System.Drawing.Color.Transparent;
            this._versionLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._versionLabel.Location = new System.Drawing.Point(0, 0);
            this._versionLabel.Name = "_versionLabel";
            this._versionLabel.Size = new System.Drawing.Size(251, 26);
            this._versionLabel.TabIndex = 0;
            this._versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BeautifulUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 581);
            this.Controls.Add(this._UISplitContainer);
            this.Controls.Add(this._versionStatusStrip);
            this.MaximizeBox = false;
            this.Name = "BeautifulUI";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "BeautifulWeight";
            ((System.ComponentModel.ISupportInitialize)(this._UISplitContainer)).EndInit();
            this._UISplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._users)).EndInit();
            this._users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._usersListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._usersMenuPanel)).EndInit();
            this._usersMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._aggiungiButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._profile)).EndInit();
            this._profile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._profileMenuPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._diet)).EndInit();
            this._diet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dietPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dietUpperPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dietButtonsPanel)).EndInit();
            this._dietButtonsPanel.ResumeLayout(false);
            this._dietButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._newDietButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._deleteDietButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._versionStatusStrip)).EndInit();
            this._versionStatusStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadSplitContainer _UISplitContainer;
        private Telerik.WinControls.UI.SplitPanel _users;
        private Telerik.WinControls.UI.SplitPanel _profile;
        private Telerik.WinControls.UI.SplitPanel _diet;
        private Telerik.WinControls.UI.RadListView _usersListView;
        private Telerik.WinControls.UI.RadPanel _usersMenuPanel;
        private Telerik.WinControls.UI.RadPanel _profileMenuPanel;
        private Telerik.WinControls.UI.RadPanel _dietButtonsPanel;
        private Telerik.WinControls.UI.RadStatusStrip _versionStatusStrip;
        private Label _versionLabel;
        private Panel _profilePanel;
        private TableLayoutPanel _dietButtons;
        private RadButton _newDietButton;
        private RadButton _deleteDietButton;
        private RadButton _aggiungiButton;
        private RadPanel _dietUpperPanel;
        private RadPanel _dietPanel;
    }
}
