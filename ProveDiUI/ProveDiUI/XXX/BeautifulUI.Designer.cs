namespace ProveDiUI
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
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this._footerStatusStrip = new Telerik.WinControls.UI.RadStatusStrip();
            this._UISplitContainer = new Telerik.WinControls.UI.RadSplitContainer();
            this._users = new Telerik.WinControls.UI.SplitPanel();
            this._profile = new Telerik.WinControls.UI.SplitPanel();
            this._diet = new Telerik.WinControls.UI.SplitPanel();
            this._usersMenuPanel = new Telerik.WinControls.UI.RadPanel();
            this._profileMenuPanel = new Telerik.WinControls.UI.RadPanel();
            this._dietMenuPanel = new Telerik.WinControls.UI.RadPanel();
            this._usersListView = new Telerik.WinControls.UI.RadListView();
            this._dietSelectionMenu = new Telerik.WinControls.UI.RadPanorama();
            this._dietListView = new Telerik.WinControls.UI.RadListView();
            ((System.ComponentModel.ISupportInitialize)(this._footerStatusStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._UISplitContainer)).BeginInit();
            this._UISplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._users)).BeginInit();
            this._users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._profile)).BeginInit();
            this._profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._diet)).BeginInit();
            this._diet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._usersMenuPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._profileMenuPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dietMenuPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._usersListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dietSelectionMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dietListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // _footerStatusStrip
            // 
            this._footerStatusStrip.Location = new System.Drawing.Point(0, 368);
            this._footerStatusStrip.Name = "_footerStatusStrip";
            this._footerStatusStrip.Size = new System.Drawing.Size(641, 26);
            this._footerStatusStrip.TabIndex = 0;
            this._footerStatusStrip.Text = "radStatusStrip1";
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
            this._UISplitContainer.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this._UISplitContainer.Size = new System.Drawing.Size(641, 368);
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
            this._users.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this._users.Size = new System.Drawing.Size(124, 368);
            this._users.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.1374408F, 0F);
            this._users.SizeInfo.SplitterCorrection = new System.Drawing.Size(-87, 0);
            this._users.TabIndex = 0;
            this._users.TabStop = false;
            this._users.Text = "splitPanel1";
            // 
            // _profile
            // 
            this._profile.Controls.Add(this._profileMenuPanel);
            this._profile.Location = new System.Drawing.Point(128, 0);
            this._profile.Name = "_profile";
            // 
            // 
            // 
            this._profile.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this._profile.Size = new System.Drawing.Size(217, 368);
            this._profile.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.009478658F, 0F);
            this._profile.SizeInfo.SplitterCorrection = new System.Drawing.Size(6, 0);
            this._profile.TabIndex = 1;
            this._profile.TabStop = false;
            this._profile.Text = "splitPanel2";
            // 
            // _diet
            // 
            this._diet.Controls.Add(this._dietListView);
            this._diet.Controls.Add(this._dietSelectionMenu);
            this._diet.Controls.Add(this._dietMenuPanel);
            this._diet.Location = new System.Drawing.Point(349, 0);
            this._diet.Name = "_diet";
            // 
            // 
            // 
            this._diet.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this._diet.Size = new System.Drawing.Size(292, 368);
            this._diet.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.1279621F, 0F);
            this._diet.SizeInfo.SplitterCorrection = new System.Drawing.Size(81, 0);
            this._diet.TabIndex = 2;
            this._diet.TabStop = false;
            this._diet.Text = "splitPanel3";
            // 
            // _usersMenuPanel
            // 
            this._usersMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._usersMenuPanel.Location = new System.Drawing.Point(0, 332);
            this._usersMenuPanel.Name = "_usersMenuPanel";
            this._usersMenuPanel.Size = new System.Drawing.Size(124, 36);
            this._usersMenuPanel.TabIndex = 0;
            // 
            // _profileMenuPanel
            // 
            this._profileMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._profileMenuPanel.Location = new System.Drawing.Point(0, 332);
            this._profileMenuPanel.Name = "_profileMenuPanel";
            this._profileMenuPanel.Size = new System.Drawing.Size(217, 36);
            this._profileMenuPanel.TabIndex = 1;
            // 
            // _dietMenuPanel
            // 
            this._dietMenuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._dietMenuPanel.Location = new System.Drawing.Point(0, 332);
            this._dietMenuPanel.Name = "_dietMenuPanel";
            this._dietMenuPanel.Size = new System.Drawing.Size(292, 36);
            this._dietMenuPanel.TabIndex = 1;
            // 
            // _usersListView
            // 
            this._usersListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._usersListView.Location = new System.Drawing.Point(0, 0);
            this._usersListView.Name = "_usersListView";
            this._usersListView.Size = new System.Drawing.Size(124, 332);
            this._usersListView.TabIndex = 1;
            this._usersListView.Text = "radListView1";
            // 
            // _dietSelectionMenu
            // 
            this._dietSelectionMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this._dietSelectionMenu.Location = new System.Drawing.Point(0, 0);
            this._dietSelectionMenu.Name = "_dietSelectionMenu";
            this._dietSelectionMenu.Size = new System.Drawing.Size(292, 82);
            this._dietSelectionMenu.TabIndex = 2;
            this._dietSelectionMenu.Text = "radPanorama1";
            // 
            // _dietListView
            // 
            this._dietListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dietListView.Location = new System.Drawing.Point(0, 82);
            this._dietListView.Name = "_dietListView";
            this._dietListView.Size = new System.Drawing.Size(292, 250);
            this._dietListView.TabIndex = 3;
            this._dietListView.Text = "radListView2";
            // 
            // BeautifulUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 394);
            this.Controls.Add(this._UISplitContainer);
            this.Controls.Add(this._footerStatusStrip);
            this.MaximizeBox = false;
            this.Name = "BeautifulUI";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "BeautifulWeight";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this._footerStatusStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._UISplitContainer)).EndInit();
            this._UISplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._users)).EndInit();
            this._users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._profile)).EndInit();
            this._profile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._diet)).EndInit();
            this._diet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._usersMenuPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._profileMenuPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dietMenuPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._usersListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dietSelectionMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dietListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadStatusStrip _footerStatusStrip;
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
    }
}

