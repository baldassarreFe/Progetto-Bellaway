namespace DomoticaPrototipo
{
    partial class CalendarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
            this._commandPanel = new System.Windows.Forms.Panel();
            this._closeButton = new System.Windows.Forms.Button();
            this._editActionButton = new System.Windows.Forms.Button();
            this._deleteActionButton = new System.Windows.Forms.Button();
            this._addActionButton = new System.Windows.Forms.Button();
            this._searchPanel = new System.Windows.Forms.Panel();
            this._sottotitolo = new System.Windows.Forms.Label();
            this._titolo = new System.Windows.Forms.Label();
            this._dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._deviceCB = new System.Windows.Forms.ComboBox();
            this._deviceTypeCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._displayPanel = new System.Windows.Forms.Panel();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._commandPanel.SuspendLayout();
            this._searchPanel.SuspendLayout();
            this._displayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _commandPanel
            // 
            this._commandPanel.Controls.Add(this._closeButton);
            this._commandPanel.Controls.Add(this._editActionButton);
            this._commandPanel.Controls.Add(this._deleteActionButton);
            this._commandPanel.Controls.Add(this._addActionButton);
            this._commandPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._commandPanel.Location = new System.Drawing.Point(0, 451);
            this._commandPanel.Name = "_commandPanel";
            this._commandPanel.Size = new System.Drawing.Size(718, 35);
            this._commandPanel.TabIndex = 0;
            // 
            // _closeButton
            // 
            this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._closeButton.Location = new System.Drawing.Point(631, 6);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(75, 23);
            this._closeButton.TabIndex = 3;
            this._closeButton.Text = "Chiudi";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this._closeButton_Click);
            // 
            // _editActionButton
            // 
            this._editActionButton.AutoSize = true;
            this._editActionButton.Location = new System.Drawing.Point(207, 6);
            this._editActionButton.Name = "_editActionButton";
            this._editActionButton.Size = new System.Drawing.Size(92, 23);
            this._editActionButton.TabIndex = 2;
            this._editActionButton.Text = "Modifica Azione";
            this._editActionButton.UseVisualStyleBackColor = true;
            this._editActionButton.Click += new System.EventHandler(this._editActionButton_Click);
            // 
            // _deleteActionButton
            // 
            this._deleteActionButton.AutoSize = true;
            this._deleteActionButton.Location = new System.Drawing.Point(111, 6);
            this._deleteActionButton.Name = "_deleteActionButton";
            this._deleteActionButton.Size = new System.Drawing.Size(90, 23);
            this._deleteActionButton.TabIndex = 1;
            this._deleteActionButton.Text = "Rimuovi Azione";
            this._deleteActionButton.UseVisualStyleBackColor = true;
            this._deleteActionButton.Click += new System.EventHandler(this._deleteActionButton_Click);
            // 
            // _addActionButton
            // 
            this._addActionButton.AutoSize = true;
            this._addActionButton.Location = new System.Drawing.Point(12, 6);
            this._addActionButton.Name = "_addActionButton";
            this._addActionButton.Size = new System.Drawing.Size(93, 23);
            this._addActionButton.TabIndex = 0;
            this._addActionButton.Text = "Aggiungi Azione";
            this._addActionButton.UseVisualStyleBackColor = true;
            this._addActionButton.Click += new System.EventHandler(this._addActionButton_Click);
            // 
            // _searchPanel
            // 
            this._searchPanel.Controls.Add(this._sottotitolo);
            this._searchPanel.Controls.Add(this._titolo);
            this._searchPanel.Controls.Add(this._dateTimePicker);
            this._searchPanel.Controls.Add(this._deviceCB);
            this._searchPanel.Controls.Add(this._deviceTypeCB);
            this._searchPanel.Controls.Add(this.label3);
            this._searchPanel.Controls.Add(this.label2);
            this._searchPanel.Controls.Add(this.label1);
            this._searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._searchPanel.Location = new System.Drawing.Point(0, 0);
            this._searchPanel.Name = "_searchPanel";
            this._searchPanel.Size = new System.Drawing.Size(718, 147);
            this._searchPanel.TabIndex = 1;
            // 
            // _sottotitolo
            // 
            this._sottotitolo.AutoSize = true;
            this._sottotitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sottotitolo.Location = new System.Drawing.Point(15, 59);
            this._sottotitolo.MaximumSize = new System.Drawing.Size(700, 0);
            this._sottotitolo.Name = "_sottotitolo";
            this._sottotitolo.Size = new System.Drawing.Size(647, 18);
            this._sottotitolo.TabIndex = 8;
            this._sottotitolo.Text = "Puoi effettuare la ricerca selezionando la tipologia di dispositivo OPPURE un dis" +
    "positivo specifico";
            // 
            // _titolo
            // 
            this._titolo.AutoSize = true;
            this._titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this._titolo.Location = new System.Drawing.Point(13, 13);
            this._titolo.Name = "_titolo";
            this._titolo.Size = new System.Drawing.Size(311, 26);
            this._titolo.TabIndex = 7;
            this._titolo.Text = "Seleziona i parametri di ricerca";
            // 
            // _dateTimePicker
            // 
            this._dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._dateTimePicker.Location = new System.Drawing.Point(59, 101);
            this._dateTimePicker.MaximumSize = new System.Drawing.Size(160, 20);
            this._dateTimePicker.MinimumSize = new System.Drawing.Size(160, 20);
            this._dateTimePicker.Name = "_dateTimePicker";
            this._dateTimePicker.Size = new System.Drawing.Size(160, 20);
            this._dateTimePicker.TabIndex = 6;
            this._dateTimePicker.ValueChanged += new System.EventHandler(this._dateTimePicker_ValueChanged);
            // 
            // _deviceCB
            // 
            this._deviceCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._deviceCB.FormattingEnabled = true;
            this._deviceCB.Location = new System.Drawing.Point(547, 101);
            this._deviceCB.MaximumSize = new System.Drawing.Size(160, 0);
            this._deviceCB.MinimumSize = new System.Drawing.Size(160, 0);
            this._deviceCB.Name = "_deviceCB";
            this._deviceCB.Size = new System.Drawing.Size(160, 21);
            this._deviceCB.TabIndex = 5;
            this._deviceCB.SelectedIndexChanged += new System.EventHandler(this._deviceCB_SelectedIndexChanged);
            // 
            // _deviceTypeCB
            // 
            this._deviceTypeCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._deviceTypeCB.FormattingEnabled = true;
            this._deviceTypeCB.Location = new System.Drawing.Point(314, 101);
            this._deviceTypeCB.MaximumSize = new System.Drawing.Size(160, 0);
            this._deviceTypeCB.MinimumSize = new System.Drawing.Size(160, 0);
            this._deviceTypeCB.Name = "_deviceTypeCB";
            this._deviceTypeCB.Size = new System.Drawing.Size(160, 21);
            this._deviceTypeCB.TabIndex = 4;
            this._deviceTypeCB.SelectedIndexChanged += new System.EventHandler(this._deviceTypeCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dispositivo:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo dispositivo:\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giorno:";
            // 
            // _displayPanel
            // 
            this._displayPanel.Controls.Add(this._dataGridView);
            this._displayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._displayPanel.Location = new System.Drawing.Point(0, 147);
            this._displayPanel.Name = "_displayPanel";
            this._displayPanel.Size = new System.Drawing.Size(718, 304);
            this._displayPanel.TabIndex = 2;
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.AllowUserToOrderColumns = true;
            this._dataGridView.AllowUserToResizeRows = false;
            this._dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.device,
            this.function});
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._dataGridView.Location = new System.Drawing.Point(0, 0);
            this._dataGridView.MultiSelect = false;
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            this._dataGridView.RowHeadersVisible = false;
            this._dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridView.Size = new System.Drawing.Size(718, 304);
            this._dataGridView.TabIndex = 0;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.HeaderText = "Ora";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // device
            // 
            this.device.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.device.HeaderText = "Dispositivo";
            this.device.Name = "device";
            this.device.ReadOnly = true;
            // 
            // function
            // 
            this.function.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.function.HeaderText = "Funzionalità";
            this.function.Name = "function";
            this.function.ReadOnly = true;
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 486);
            this.Controls.Add(this._displayPanel);
            this.Controls.Add(this._searchPanel);
            this.Controls.Add(this._commandPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalendarForm";
            this.Text = "Calendario";
            this._commandPanel.ResumeLayout(false);
            this._commandPanel.PerformLayout();
            this._searchPanel.ResumeLayout(false);
            this._searchPanel.PerformLayout();
            this._displayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _commandPanel;
        private System.Windows.Forms.Panel _searchPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel _displayPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _deviceCB;
        private System.Windows.Forms.ComboBox _deviceTypeCB;
        private System.Windows.Forms.Button _editActionButton;
        private System.Windows.Forms.Button _deleteActionButton;
        private System.Windows.Forms.Button _addActionButton;
        private System.Windows.Forms.Button _closeButton;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.DateTimePicker _dateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn device;
        private System.Windows.Forms.DataGridViewTextBoxColumn function;
        private System.Windows.Forms.Label _titolo;
        private System.Windows.Forms.Label _sottotitolo;
    }
}