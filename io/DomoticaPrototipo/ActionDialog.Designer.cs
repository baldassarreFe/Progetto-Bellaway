namespace DomoticaPrototipo
{
    partial class ActionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this._errorMessage = new System.Windows.Forms.Label();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this._deviceComboBox = new System.Windows.Forms.ComboBox();
            this._functionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._yearDayRadioButton = new System.Windows.Forms.RadioButton();
            this._weekDayRadioButton = new System.Windows.Forms.RadioButton();
            this._weekDayComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._timePicker = new System.Windows.Forms.DateTimePicker();
            this._dayPicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._errorMessage);
            this.panel1.Controls.Add(this._okButton);
            this.panel1.Controls.Add(this._cancelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 45);
            this.panel1.TabIndex = 0;
            // 
            // _errorMessage
            // 
            this._errorMessage.AutoSize = true;
            this._errorMessage.ForeColor = System.Drawing.Color.Red;
            this._errorMessage.Location = new System.Drawing.Point(12, 15);
            this._errorMessage.Name = "_errorMessage";
            this._errorMessage.Size = new System.Drawing.Size(188, 13);
            this._errorMessage.TabIndex = 2;
            this._errorMessage.Text = "Errore: la data scelta precede l\'odierna";
            this._errorMessage.Visible = false;
            // 
            // _okButton
            // 
            this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._okButton.Location = new System.Drawing.Point(281, 10);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 1;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(362, 10);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 23);
            this._cancelButton.TabIndex = 0;
            this._cancelButton.Text = "Annulla";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 151);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._deviceComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._functionComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._yearDayRadioButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._weekDayRadioButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this._weekDayComboBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this._timePicker, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this._dayPicker, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 153);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dispositivo:";
            // 
            // _deviceComboBox
            // 
            this._deviceComboBox.FormattingEnabled = true;
            this._deviceComboBox.Location = new System.Drawing.Point(227, 3);
            this._deviceComboBox.Name = "_deviceComboBox";
            this._deviceComboBox.Size = new System.Drawing.Size(191, 21);
            this._deviceComboBox.TabIndex = 1;
            this._deviceComboBox.SelectedIndexChanged += new System.EventHandler(this._deviceComboBox_SelectedIndexChanged);
            // 
            // _functionComboBox
            // 
            this._functionComboBox.FormattingEnabled = true;
            this._functionComboBox.Location = new System.Drawing.Point(227, 28);
            this._functionComboBox.Name = "_functionComboBox";
            this._functionComboBox.Size = new System.Drawing.Size(191, 21);
            this._functionComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funzionalità:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selezione giorno:";
            // 
            // _yearDayRadioButton
            // 
            this._yearDayRadioButton.AutoSize = true;
            this._yearDayRadioButton.Location = new System.Drawing.Point(3, 78);
            this._yearDayRadioButton.Name = "_yearDayRadioButton";
            this._yearDayRadioButton.Size = new System.Drawing.Size(101, 17);
            this._yearDayRadioButton.TabIndex = 5;
            this._yearDayRadioButton.TabStop = true;
            this._yearDayRadioButton.Text = "Giorno dell\'anno";
            this._yearDayRadioButton.UseVisualStyleBackColor = true;
            this._yearDayRadioButton.CheckedChanged += new System.EventHandler(this._yearDayRadioButton_CheckedChanged);
            // 
            // _weekDayRadioButton
            // 
            this._weekDayRadioButton.AutoSize = true;
            this._weekDayRadioButton.Location = new System.Drawing.Point(227, 78);
            this._weekDayRadioButton.Name = "_weekDayRadioButton";
            this._weekDayRadioButton.Size = new System.Drawing.Size(129, 17);
            this._weekDayRadioButton.TabIndex = 6;
            this._weekDayRadioButton.TabStop = true;
            this._weekDayRadioButton.Text = "Giorno della settimana";
            this._weekDayRadioButton.UseVisualStyleBackColor = true;
            this._weekDayRadioButton.CheckedChanged += new System.EventHandler(this._weekDayRadioButton_CheckedChanged);
            // 
            // _weekDayComboBox
            // 
            this._weekDayComboBox.FormattingEnabled = true;
            this._weekDayComboBox.Location = new System.Drawing.Point(227, 103);
            this._weekDayComboBox.Name = "_weekDayComboBox";
            this._weekDayComboBox.Size = new System.Drawing.Size(191, 21);
            this._weekDayComboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seleziona ora:";
            // 
            // _timePicker
            // 
            this._timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this._timePicker.Location = new System.Drawing.Point(227, 128);
            this._timePicker.Name = "_timePicker";
            this._timePicker.ShowUpDown = true;
            this._timePicker.Size = new System.Drawing.Size(191, 20);
            this._timePicker.TabIndex = 10;
            // 
            // _dayPicker
            // 
            this._dayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this._dayPicker.Location = new System.Drawing.Point(3, 103);
            this._dayPicker.Name = "_dayPicker";
            this._dayPicker.Size = new System.Drawing.Size(200, 20);
            this._dayPicker.TabIndex = 11;
            // 
            // ActionDialog
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(449, 196);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActionDialog";
            this.Text = "Azione";
            this.Load += new System.EventHandler(this._actionDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _deviceComboBox;
        private System.Windows.Forms.ComboBox _functionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton _yearDayRadioButton;
        private System.Windows.Forms.RadioButton _weekDayRadioButton;
        private System.Windows.Forms.ComboBox _weekDayComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker _timePicker;
        private System.Windows.Forms.DateTimePicker _dayPicker;
        private System.Windows.Forms.Label _errorMessage;
    }
}