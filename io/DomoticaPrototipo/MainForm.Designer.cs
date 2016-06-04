namespace DomoticaPrototipo
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaCalendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmaAzioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utentiToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaInformazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioneUtentiToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.aiutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusEFunzioniTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.infoDispositivoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._titolo = new System.Windows.Forms.Label();
            this._menuStrip.SuspendLayout();
            this._contextMenuStrip.SuspendLayout();
            this._flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _menuStrip
            // 
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendarioToolStripMenuItem,
            this.utentiToolStrip,
            this.aiutoToolStripMenuItem});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(624, 24);
            this._menuStrip.TabIndex = 0;
            this._menuStrip.Text = "menuStrip1";
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizzaCalendarioToolStripMenuItem,
            this.programmaAzioneToolStripMenuItem});
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            // 
            // visualizzaCalendarioToolStripMenuItem
            // 
            this.visualizzaCalendarioToolStripMenuItem.Name = "visualizzaCalendarioToolStripMenuItem";
            this.visualizzaCalendarioToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.visualizzaCalendarioToolStripMenuItem.Text = "Visualizza Calendario";
            this.visualizzaCalendarioToolStripMenuItem.Click += new System.EventHandler(this.visualizzaCalendarioToolStripMenuItem_Click);
            // 
            // programmaAzioneToolStripMenuItem
            // 
            this.programmaAzioneToolStripMenuItem.Name = "programmaAzioneToolStripMenuItem";
            this.programmaAzioneToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.programmaAzioneToolStripMenuItem.Text = "Programma Azione";
            this.programmaAzioneToolStripMenuItem.Click += new System.EventHandler(this.programmaAzioneToolStripMenuItem_Click);
            // 
            // utentiToolStrip
            // 
            this.utentiToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaInformazioniToolStripMenuItem,
            this.gestioneUtentiToolStrip});
            this.utentiToolStrip.Name = "utentiToolStrip";
            this.utentiToolStrip.Size = new System.Drawing.Size(51, 20);
            this.utentiToolStrip.Text = "Utenti";
            // 
            // modificaInformazioniToolStripMenuItem
            // 
            this.modificaInformazioniToolStripMenuItem.Name = "modificaInformazioniToolStripMenuItem";
            this.modificaInformazioniToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.modificaInformazioniToolStripMenuItem.Text = "Modifica Credenziali";
            this.modificaInformazioniToolStripMenuItem.Click += new System.EventHandler(this.modificaInformazioniToolStripMenuItem_Click);
            // 
            // gestioneUtentiToolStrip
            // 
            this.gestioneUtentiToolStrip.Name = "gestioneUtentiToolStrip";
            this.gestioneUtentiToolStrip.Size = new System.Drawing.Size(182, 22);
            this.gestioneUtentiToolStrip.Text = "Gestione Utenti";
            this.gestioneUtentiToolStrip.Click += new System.EventHandler(this.gestioneUtentiToolStrip_Click);
            // 
            // aiutoToolStripMenuItem
            // 
            this.aiutoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.aiutoToolStripMenuItem.Name = "aiutoToolStripMenuItem";
            this.aiutoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aiutoToolStripMenuItem.Text = "Aiuto";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // _contextMenuStrip
            // 
            this._contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusEFunzioniTSMI,
            this.infoDispositivoTSMI});
            this._contextMenuStrip.Name = "_contextMenuStrip";
            this._contextMenuStrip.Size = new System.Drawing.Size(178, 48);
            // 
            // statusEFunzioniTSMI
            // 
            this.statusEFunzioniTSMI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.statusEFunzioniTSMI.Name = "statusEFunzioniTSMI";
            this.statusEFunzioniTSMI.Size = new System.Drawing.Size(177, 22);
            this.statusEFunzioniTSMI.Text = "Status e Funzioni...";
            this.statusEFunzioniTSMI.Click += new System.EventHandler(this.ClickOnContextMenu);
            // 
            // infoDispositivoTSMI
            // 
            this.infoDispositivoTSMI.Name = "infoDispositivoTSMI";
            this.infoDispositivoTSMI.Size = new System.Drawing.Size(177, 22);
            this.infoDispositivoTSMI.Text = "Info Dispositivo...";
            this.infoDispositivoTSMI.Click += new System.EventHandler(this.ClickOnContextMenu);
            // 
            // _flowLayoutPanel
            // 
            this._flowLayoutPanel.AutoScroll = true;
            this._flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this._flowLayoutPanel.Controls.Add(this._titolo);
            this._flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._flowLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this._flowLayoutPanel.Name = "_flowLayoutPanel";
            this._flowLayoutPanel.Size = new System.Drawing.Size(624, 373);
            this._flowLayoutPanel.TabIndex = 1;
            this._flowLayoutPanel.WrapContents = false;
            // 
            // _titolo
            // 
            this._titolo.AutoSize = true;
            this._titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this._titolo.Location = new System.Drawing.Point(3, 0);
            this._titolo.Name = "_titolo";
            this._titolo.Size = new System.Drawing.Size(184, 26);
            this._titolo.TabIndex = 0;
            this._titolo.Text = "Elenco Dispositivi";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(624, 397);
            this.Controls.Add(this._flowLayoutPanel);
            this.Controls.Add(this._menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this._menuStrip;
            this.Name = "MainForm";
            this.Text = "Alfred";
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this._contextMenuStrip.ResumeLayout(false);
            this._flowLayoutPanel.ResumeLayout(false);
            this._flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaCalendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmaAzioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utentiToolStrip;
        private System.Windows.Forms.ToolStripMenuItem modificaInformazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aiutoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem infoDispositivoTSMI;
        private System.Windows.Forms.ToolStripMenuItem gestioneUtentiToolStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusEFunzioniTSMI;
        private System.Windows.Forms.ToolTip _toolTip;
        private System.Windows.Forms.FlowLayoutPanel _flowLayoutPanel;
        private System.Windows.Forms.Label _titolo;
    }
}

