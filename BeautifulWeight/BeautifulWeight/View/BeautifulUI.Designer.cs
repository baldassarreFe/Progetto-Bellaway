﻿using System.Windows.Forms;
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
            this._dietListView = new Telerik.WinControls.UI.RadListView();
            this._dietSelectionMenu = new Telerik.WinControls.UI.RadPanorama();
            this._dietMenuPanel = new Telerik.WinControls.UI.RadPanel();
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
            ((System.ComponentModel.ISupportInitialize)(this._dietListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dietSelectionMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dietMenuPanel)).BeginInit();
            this._dietMenuPanel.SuspendLayout();
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
            this._UISplitContainer.Size = new System.Drawing.Size(759, 451);
            this._UISplitContainer.SplitterWidth = 0;
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
            this._users.Size = new System.Drawing.Size(116, 451);
            this._users.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.1810155F, 0F);
            this._users.SizeInfo.SplitterCorrection = new System.Drawing.Size(-122, 0);
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
            this._usersListView.ShowColumnHeaders = false;
            this._usersListView.Size = new System.Drawing.Size(116, 415);
            this._usersListView.TabIndex = 1;
            this._usersListView.Text = "_usersListView";
            // 
            // _usersMenuPanel
            // 
            this._usersMenuPanel.Controls.Add(this._aggiungiButton);
            this._usersMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._usersMenuPanel.Location = new System.Drawing.Point(0, 415);
            this._usersMenuPanel.Name = "_usersMenuPanel";
            this._usersMenuPanel.Size = new System.Drawing.Size(116, 36);
            this._usersMenuPanel.TabIndex = 0;
            // 
            // _aggiungiButton
            // 
            this._aggiungiButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._aggiungiButton.Location = new System.Drawing.Point(0, 0);
            this._aggiungiButton.Name = "_aggiungiButton";
            this._aggiungiButton.Size = new System.Drawing.Size(116, 36);
            this._aggiungiButton.TabIndex = 3;
            this._aggiungiButton.Text = "Aggiungi";
            // 
            // _profile
            // 
            this._profile.Controls.Add(this._profilePanel);
            this._profile.Controls.Add(this._profileMenuPanel);
            this._profile.Location = new System.Drawing.Point(116, 0);
            this._profile.Name = "_profile";
            // 
            // 
            // 
            this._profile.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this._profile.Size = new System.Drawing.Size(309, 451);
            this._profile.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.07328919F, 0F);
            this._profile.SizeInfo.SplitterCorrection = new System.Drawing.Size(54, 0);
            this._profile.TabIndex = 1;
            this._profile.TabStop = false;
            this._profile.Text = "splitPanel2";
            // 
            // _profilePanel
            // 
            this._profilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._profilePanel.Location = new System.Drawing.Point(0, 0);
            this._profilePanel.Name = "_profilePanel";
            this._profilePanel.Size = new System.Drawing.Size(309, 415);
            this._profilePanel.TabIndex = 2;
            // 
            // _profileMenuPanel
            // 
            this._profileMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._profileMenuPanel.Location = new System.Drawing.Point(0, 415);
            this._profileMenuPanel.Name = "_profileMenuPanel";
            this._profileMenuPanel.Size = new System.Drawing.Size(309, 36);
            this._profileMenuPanel.TabIndex = 1;
            // 
            // _diet
            // 
            this._diet.Controls.Add(this._dietListView);
            this._diet.Controls.Add(this._dietSelectionMenu);
            this._diet.Controls.Add(this._dietMenuPanel);
            this._diet.Location = new System.Drawing.Point(425, 0);
            this._diet.Name = "_diet";
            // 
            // 
            // 
            this._diet.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this._diet.Size = new System.Drawing.Size(334, 451);
            this._diet.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.1077263F, 0F);
            this._diet.SizeInfo.SplitterCorrection = new System.Drawing.Size(68, 0);
            this._diet.TabIndex = 2;
            this._diet.TabStop = false;
            this._diet.Text = "splitPanel3";
            // 
            // _dietListView
            // 
            this._dietListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dietListView.Location = new System.Drawing.Point(0, 82);
            this._dietListView.Name = "_dietListView";
            this._dietListView.Size = new System.Drawing.Size(334, 333);
            this._dietListView.TabIndex = 3;
            this._dietListView.Text = "radListView2";
            // 
            // _dietSelectionMenu
            // 
            this._dietSelectionMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this._dietSelectionMenu.Location = new System.Drawing.Point(0, 0);
            this._dietSelectionMenu.Name = "_dietSelectionMenu";
            this._dietSelectionMenu.Size = new System.Drawing.Size(334, 82);
            this._dietSelectionMenu.TabIndex = 2;
            this._dietSelectionMenu.Text = "radPanorama1";
            // 
            // _dietMenuPanel
            // 
            this._dietMenuPanel.Controls.Add(this._dietButtons);
            this._dietMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._dietMenuPanel.Location = new System.Drawing.Point(0, 415);
            this._dietMenuPanel.Name = "_dietMenuPanel";
            this._dietMenuPanel.Size = new System.Drawing.Size(334, 36);
            this._dietMenuPanel.TabIndex = 1;
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
            this._dietButtons.Size = new System.Drawing.Size(334, 36);
            this._dietButtons.TabIndex = 0;
            // 
            // _newDietButton
            // 
            this._newDietButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._newDietButton.Location = new System.Drawing.Point(170, 3);
            this._newDietButton.Name = "_newDietButton";
            this._newDietButton.Size = new System.Drawing.Size(161, 30);
            this._newDietButton.TabIndex = 5;
            this._newDietButton.Text = "Nuova Dieta";
            // 
            // _deleteDietButton
            // 
            this._deleteDietButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._deleteDietButton.Location = new System.Drawing.Point(3, 3);
            this._deleteDietButton.Name = "_deleteDietButton";
            this._deleteDietButton.Size = new System.Drawing.Size(161, 30);
            this._deleteDietButton.TabIndex = 4;
            this._deleteDietButton.Text = "Elimina Dieta";
            // 
            // _versionStatusStrip
            // 
            this._versionStatusStrip.Controls.Add(this._versionLabel);
            this._versionStatusStrip.Location = new System.Drawing.Point(0, 451);
            this._versionStatusStrip.Name = "_versionStatusStrip";
            this._versionStatusStrip.Size = new System.Drawing.Size(759, 26);
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
            this.ClientSize = new System.Drawing.Size(759, 477);
            this.Controls.Add(this._UISplitContainer);
            this.Controls.Add(this._versionStatusStrip);
            this.MaximizeBox = false;
            this.Name = "BeautifulUI";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "BeautifulWeight";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            ((System.ComponentModel.ISupportInitialize)(this._dietListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dietSelectionMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dietMenuPanel)).EndInit();
            this._dietMenuPanel.ResumeLayout(false);
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
        private Telerik.WinControls.UI.RadListView _dietListView;
        private Telerik.WinControls.UI.RadPanorama _dietSelectionMenu;
        private Telerik.WinControls.UI.RadPanel _dietMenuPanel;
        private Telerik.WinControls.UI.RadStatusStrip _versionStatusStrip;
        private Label _versionLabel;
        private Panel _profilePanel;
        private TableLayoutPanel _dietButtons;
        private RadButton _newDietButton;
        private RadButton _deleteDietButton;
        private RadButton _aggiungiButton;
    }
}
