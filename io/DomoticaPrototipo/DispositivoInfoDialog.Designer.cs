namespace DomoticaPrototipo
{
    partial class DispositivoInfoDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DispositivoInfoDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._nomeBox = new System.Windows.Forms.TextBox();
            this._tipoBox = new System.Windows.Forms.TextBox();
            this._produttoreBox = new System.Windows.Forms.TextBox();
            this._serialeBox = new System.Windows.Forms.TextBox();
            this._consumoBox = new System.Windows.Forms.TextBox();
            this._aliasBox = new System.Windows.Forms.TextBox();
            this._descrizioneBox = new System.Windows.Forms.TextBox();
            this._posizioneBox = new System.Windows.Forms.TextBox();
            this._datiProduttore = new System.Windows.Forms.Label();
            this._iconaDispositivo = new System.Windows.Forms.PictureBox();
            this._personalizzaDispositivo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._iconaDispositivo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 48);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(446, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Annulla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Produttore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seriale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Consumo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Alias";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Descrizione";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Posizione";
            // 
            // _nomeBox
            // 
            this._nomeBox.Enabled = false;
            this._nomeBox.Location = new System.Drawing.Point(164, 67);
            this._nomeBox.Name = "_nomeBox";
            this._nomeBox.Size = new System.Drawing.Size(155, 20);
            this._nomeBox.TabIndex = 0;
            // 
            // _tipoBox
            // 
            this._tipoBox.Enabled = false;
            this._tipoBox.Location = new System.Drawing.Point(164, 93);
            this._tipoBox.Name = "_tipoBox";
            this._tipoBox.Size = new System.Drawing.Size(155, 20);
            this._tipoBox.TabIndex = 0;
            // 
            // _produttoreBox
            // 
            this._produttoreBox.Enabled = false;
            this._produttoreBox.Location = new System.Drawing.Point(164, 171);
            this._produttoreBox.Name = "_produttoreBox";
            this._produttoreBox.Size = new System.Drawing.Size(155, 20);
            this._produttoreBox.TabIndex = 0;
            // 
            // _serialeBox
            // 
            this._serialeBox.Enabled = false;
            this._serialeBox.Location = new System.Drawing.Point(164, 145);
            this._serialeBox.Name = "_serialeBox";
            this._serialeBox.Size = new System.Drawing.Size(155, 20);
            this._serialeBox.TabIndex = 0;
            // 
            // _consumoBox
            // 
            this._consumoBox.Enabled = false;
            this._consumoBox.Location = new System.Drawing.Point(164, 119);
            this._consumoBox.Name = "_consumoBox";
            this._consumoBox.Size = new System.Drawing.Size(155, 20);
            this._consumoBox.TabIndex = 0;
            // 
            // _aliasBox
            // 
            this._aliasBox.Location = new System.Drawing.Point(161, 256);
            this._aliasBox.Name = "_aliasBox";
            this._aliasBox.Size = new System.Drawing.Size(155, 20);
            this._aliasBox.TabIndex = 0;
            // 
            // _descrizioneBox
            // 
            this._descrizioneBox.AcceptsReturn = true;
            this._descrizioneBox.AcceptsTab = true;
            this._descrizioneBox.Location = new System.Drawing.Point(161, 336);
            this._descrizioneBox.MaxLength = 1000;
            this._descrizioneBox.Multiline = true;
            this._descrizioneBox.Name = "_descrizioneBox";
            this._descrizioneBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._descrizioneBox.Size = new System.Drawing.Size(371, 88);
            this._descrizioneBox.TabIndex = 0;
            // 
            // _posizioneBox
            // 
            this._posizioneBox.Location = new System.Drawing.Point(161, 296);
            this._posizioneBox.Name = "_posizioneBox";
            this._posizioneBox.Size = new System.Drawing.Size(155, 20);
            this._posizioneBox.TabIndex = 0;
            // 
            // _datiProduttore
            // 
            this._datiProduttore.AutoSize = true;
            this._datiProduttore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._datiProduttore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this._datiProduttore.Location = new System.Drawing.Point(40, 28);
            this._datiProduttore.Name = "_datiProduttore";
            this._datiProduttore.Size = new System.Drawing.Size(226, 18);
            this._datiProduttore.TabIndex = 2;
            this._datiProduttore.Text = "Dati del produttore del dispositivo";
            // 
            // _iconaDispositivo
            // 
            this._iconaDispositivo.Location = new System.Drawing.Point(400, 39);
            this._iconaDispositivo.MaximumSize = new System.Drawing.Size(100, 100);
            this._iconaDispositivo.Name = "_iconaDispositivo";
            this._iconaDispositivo.Size = new System.Drawing.Size(100, 100);
            this._iconaDispositivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._iconaDispositivo.TabIndex = 3;
            this._iconaDispositivo.TabStop = false;
            // 
            // _personalizzaDispositivo
            // 
            this._personalizzaDispositivo.AutoSize = true;
            this._personalizzaDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._personalizzaDispositivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this._personalizzaDispositivo.Location = new System.Drawing.Point(40, 224);
            this._personalizzaDispositivo.Name = "_personalizzaDispositivo";
            this._personalizzaDispositivo.Size = new System.Drawing.Size(181, 18);
            this._personalizzaDispositivo.TabIndex = 4;
            this._personalizzaDispositivo.Text = "Personalizza il Dispositivo";
            // 
            // DispositivoInfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(558, 478);
            this.Controls.Add(this._personalizzaDispositivo);
            this.Controls.Add(this._iconaDispositivo);
            this.Controls.Add(this._datiProduttore);
            this.Controls.Add(this._nomeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._tipoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._produttoreBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._serialeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._consumoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._aliasBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._descrizioneBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._posizioneBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DispositivoInfoDialog";
            this.Text = "DispositivoInfoDialog";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._iconaDispositivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _nomeBox;
        private System.Windows.Forms.TextBox _tipoBox;
        private System.Windows.Forms.TextBox _produttoreBox;
        private System.Windows.Forms.TextBox _serialeBox;
        private System.Windows.Forms.TextBox _consumoBox;
        private System.Windows.Forms.TextBox _aliasBox;
        private System.Windows.Forms.TextBox _descrizioneBox;
        private System.Windows.Forms.TextBox _posizioneBox;
        private System.Windows.Forms.Label _datiProduttore;
        private System.Windows.Forms.PictureBox _iconaDispositivo;
        private System.Windows.Forms.Label _personalizzaDispositivo;
    }
}