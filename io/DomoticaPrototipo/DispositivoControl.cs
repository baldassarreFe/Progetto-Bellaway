using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DomoticaPrototipo
{
    public partial class DispositivoControl : UserControl
    {
        private IDispositivo _dispositivo = null;
        private int _errorCounter = 0;
        private int _rowCount = 1;
        private List<Timer> _timers = new List<Timer>();
        private TableLayoutPanel _statoTLP;
        private TableLayoutPanel _funzionalitaTLP;

        public DispositivoControl()
        {
            InitializeComponent();
        }
        public bool HasError
        {
            get
            {
                return (_errorCounter > 0);
            }
        }
        public void SetDispositivo(IDispositivo dispositivo)
        {
            //	Eliminare da _tableLayoutPanel eventuali controlli inseriti in precedenza.
            //  Invocare il metodo AddStati per aggiungere tutti gli stati
            //  Invocare il metodo AddFunzionalita per aggiungere le funzionalita (una per volta)
            //	Invocare il metodo RefreshControl per richiamare gli stati e aggiornare i parametri.


            if (dispositivo == null)
                throw new ArgumentNullException("dispositivo");
            SuspendLayout();

            _dispositivo = dispositivo;
            _errorCounter = 0;
            _timers.Clear();

            Panel bordoStati;

            if (_dispositivo.Stati != null && _dispositivo.Stati.Count > 0)
            {
                bordoStati = new Panel();
                bordoStati.AutoSize = true;
                bordoStati.BackColor = Color.FromArgb(199, 199, 199);//grigio scuro
                this._flowLayoutPanel.Controls.Add(bordoStati);

                _statoTLP = new TableLayoutPanel();
                _statoTLP.AutoSize = true;
                _statoTLP.ColumnCount = 2;
                _statoTLP.RowCount = 1;
                _statoTLP.Location = new Point(2, 2);
                _statoTLP.BackColor = Color.FromArgb(240, 240, 240);
                bordoStati.Controls.Add(_statoTLP);
                _statoTLP.Controls.Clear();


                AddStati(_dispositivo.Stati);
                foreach (Timer t in _timers)
                {
                    t.Tick += OnTimedEvent;
                    t.Enabled = true;
                }
            }

            Label label = new Label();
            label.Text = "Funzionalità";
            label.Font = new Font(label.Font.FontFamily, 11F);
            label.ForeColor = Color.FromArgb(0, 51, 153);
            label.AutoSize = true;


            Panel bordoFunz = new Panel();
            bordoFunz.AutoSize = true;
            bordoFunz.BackColor = Color.FromArgb(199,199,199);//grigio scuro
            this._flowLayoutPanel.Controls.Add(bordoFunz);

            _funzionalitaTLP = new TableLayoutPanel();
            _funzionalitaTLP.AutoSize = true;
            _funzionalitaTLP.Location = new Point(2, 2);
            _funzionalitaTLP.ColumnCount = 2;
            _funzionalitaTLP.BackColor = Color.FromArgb(240, 240, 240);
            bordoFunz.Controls.Add(_funzionalitaTLP);

            _funzionalitaTLP.Controls.Add(label);
            _funzionalitaTLP.SetRow(label, _rowCount);
            _funzionalitaTLP.SetColumn(label, 0);


            _rowCount++;
            foreach (IFunzionalita f in _dispositivo.Funzionalita)
            {
                AddFunzionalita(f);
            }

            ResumeLayout(false);

        }
        private void AddFunzionalita(IFunzionalita f)
        {
            Label label = new Label();
            label.Text = f.Label+" :";
            label.AutoSize = true;

            _funzionalitaTLP.Controls.Add(label);
            _funzionalitaTLP.SetRow(label, _rowCount);
            _funzionalitaTLP.SetColumn(label, 0);

            _rowCount++;
            TableLayoutPanel subPanel = new TableLayoutPanel();
            subPanel.Tag = f;
            subPanel.ColumnCount = 2;
            int subRowCount = 0;
            // per ogni funzionalità, aggiungo un panel nella colonna a sinistra. Con dentro i control dei parametri.
            foreach(Parametro p in f.Parametri)
            {
                label = new Label();
                if (p.InfoInterfaccia != null && p.InfoInterfaccia.Etichetta != null)
                    label.Text =p.InfoInterfaccia.Etichetta + " : ";
                else
                {
                    if (p.Nome != null)
                        label.Text = p.Nome + ": ";
                    else
                        throw new ArgumentNullException("Nome parametro status");
                }
                label.AutoSize = true;
                subPanel.Controls.Add(label);
                subPanel.SetRow(label,subRowCount);
                subPanel.SetColumn(label, 0);
                if (p.Status != null)
                    p.Status.GetStatus();
                if (p.InfoInterfaccia != null)
                {
                    if (p.InfoInterfaccia.Tipo.Equals(VistaParametro.Button))
                    {
                        Button button = new Button();
                        button.Text = p.InfoInterfaccia.Etichetta;
                        button.Tag = f;
                        button.Click+=OnButtonClick;
                        subPanel.Controls.Add(button);
                        subPanel.SetRow(button, subRowCount);
                        subPanel.SetColumn(button, 1);
                    }
                    if (p.InfoInterfaccia.Tipo.Equals(VistaParametro.CheckBox))
                    {
                        CheckBox chk = new CheckBox();
                        chk.Tag = p;
                        chk.Checked =(bool) p.Valore;
                        subPanel.Controls.Add(chk);
                        subPanel.SetRow(chk, subRowCount);
                        subPanel.SetColumn(chk, 1);
                    }
                    if (p.InfoInterfaccia.Tipo.Equals(VistaParametro.DropList))
                    {
                        ComboBox lsb = new ComboBox();
                        lsb.Items.AddRange(((Discreto)p).ValidValues.ToArray());
                        if (p.Valore != null && lsb.Items.Contains(p.Valore))
                            lsb.SelectedItem = p.Valore;
                        lsb.Tag = p;
                        subPanel.Controls.Add(lsb);
                        subPanel.SetRow(lsb, subRowCount);
                        subPanel.SetColumn(lsb, 1);
                      
                    }
                    if (p.InfoInterfaccia.Tipo.Equals(VistaParametro.TimerBox))
                    {
                        //Prototipo, salto controlli di tipo
                        NumericUpDown nup = new NumericUpDown();
                        nup.AutoSize = true;
                        nup.Tag = p;
                        nup.Value = Decimal.Parse(""+p.Valore);
                        if (p is Limitato)
                        {
                            nup.Minimum = Decimal.Parse("" + ((Limitato)p).Min);
                            nup.Maximum = Decimal.Parse("" + ((Limitato)p).Max);
                        }
                        subPanel.Controls.Add(nup);
                        subPanel.SetRow(nup, subRowCount);
                        subPanel.SetColumn(nup, 1);
                    }
                    if (p.InfoInterfaccia.Tipo.Equals(VistaParametro.TextBox))
                    {
                        TextBox txt = new TextBox();
                        txt.Tag = p;
                        txt.Text = p.Valore.ToString();
                        subPanel.Controls.Add(txt);
                        subPanel.SetRow(txt, subRowCount);
                        subPanel.SetColumn(txt, 1);
                    }
             
                }
                subRowCount++;
            }

            _funzionalitaTLP.Controls.Add(subPanel);
            _funzionalitaTLP.SetColumn(subPanel, 1);
            _funzionalitaTLP.SetRow(subPanel, _rowCount);

            _rowCount++;
        }
      

        private void AddStati(List<IStatus> stati)
        {
            //  Per inizializzare le Label:
            // 	  assegnare alla proprietà Text il valore della proprietà Label di InterfacciaInfo del parametro, o in sua assenza il nome del parametro.
            // 	  assegnare alla proprietà AutoSize il valore true, in modo che il testo venga visualizzato correttamente.
       

            Label label = new Label();
            label.Text = "Stati";
            label.AutoSize = true;
            label.Font = new Font(label.Font.FontFamily, 11F);
            label.ForeColor = Color.FromArgb(0,51,153);

            _statoTLP.Controls.Add(label);
            _statoTLP.SetRow(label, 0);
            _statoTLP.SetColumn(label, 0);

            foreach (IStatus s in stati)
            {
                Control sControl = BuildStatus(s);
                _statoTLP.Controls.Add(sControl);
                _statoTLP.SetRow(sControl, _rowCount);
                _statoTLP.SetColumn(sControl, 1);
                _rowCount++;
            }

        }
        private Control BuildStatus(IStatus s)
        {
            if (s.IntervalloAggiornamento > 0)
            {
                Timer temp = new Timer();
                temp.Interval = s.IntervalloAggiornamento * 1000;
                temp.Tick += s.OnTimedEvent;//because of dummy behaviour
                temp.Tag = s;
                _timers.Add(temp);
            }

            Label label = new Label();
            label.AutoSize = true;
            if (s.Parametro.InfoInterfaccia != null)
            {
                if (s.Parametro.Tipo.Equals(TipoParametro.Void))
                {
                    //Ricavo lo stato dal nome del parametro.
                    label.Text = s.Parametro.Nome;
                    label.Tag = s;
                }
                
                if (s.Parametro.InfoInterfaccia.Tipo.Equals(VistaParametro.TimerBox))
                {
                    if (s.Parametro.InfoInterfaccia != null && s.Parametro.InfoInterfaccia.Etichetta != null)
                        label.Text = s.Parametro.InfoInterfaccia.Etichetta + " : ";
                    else
                    {
                        if (s.Parametro.Nome != null)
                            label.Text = s.Parametro.Nome + ": ";
                        else
                            throw new ArgumentNullException("Nome parametro status");
                    }
                    //Prototipo, salto controlli di tipo
                    label.Text += "" + ((int)s.Parametro.Valore) / 60 + ":" + ((int)s.Parametro.Valore % 60);
                    label.Tag = s;
                }
                if (s.Parametro.InfoInterfaccia.Tipo.Equals(VistaParametro.TextBox))
                {
                    if (s.Parametro.InfoInterfaccia != null && s.Parametro.InfoInterfaccia.Etichetta != null)
                        label.Text = s.Parametro.InfoInterfaccia.Etichetta + " : ";
                    else
                    {
                        if (s.Parametro.Nome != null)
                            label.Text = s.Parametro.Nome + ": ";
                        else
                            throw new ArgumentNullException("Nome parametro status");
                    }
                    //Prototipo, salto controlli di tipo
                    label.Text += s.Parametro.Valore.ToString();
                    label.Tag = s;
                }
            }
            return label;
        }
        private void OnTimedEvent(object sender, EventArgs args)
        {
            if (sender is Timer)
            {
                Timer t = (Timer)sender;
                foreach (Control c in _statoTLP.Controls)
                    if (c.Tag is IStatus && c.Tag.Equals(t.Tag))
                    {
                        int row = _statoTLP.GetRow(c);
                        _statoTLP.Controls.Remove(c);
                        Control sControl=BuildStatus((IStatus) t.Tag);
                        _statoTLP.Controls.Add(sControl);
                        _statoTLP.SetRow(sControl, row);
                        _statoTLP.SetColumn(sControl, 1);
                    }
            }
        }
        private void OnButtonClick(object sender, EventArgs args)
        {
            if (sender is Button)
            {
                Button b = (Button)sender;
                if (b.Tag is IFunzionalita)
                {
                    ((IFunzionalita)b.Tag).Method();
                    b.Text =((IFunzionalita)b.Tag).Parametri[0].InfoInterfaccia.Etichetta;
                }
            }
        }
        public void InvokeMethods()
        {
            //devo invocare i method() di ogni funzionalità dopo aver aggiornato i parametri
            foreach (Control control in this._funzionalitaTLP.Controls)
                if (control is TableLayoutPanel && control.Tag is IFunzionalita)
                {
                    TableLayoutPanel funzionalitaPanel = (TableLayoutPanel) control;
                    foreach (Control paraControl in funzionalitaPanel.Controls)
                        if (paraControl.Tag is Parametro)
                        {
                            Parametro p =(Parametro) paraControl.Tag;
                            if (p.InfoInterfaccia != null)
                            {
                                if (p.InfoInterfaccia.Tipo.Equals(VistaParametro.CheckBox))
                                {
                                    //salto i controlli di tipo
                                    p.Valore = ((CheckBox)paraControl).Checked;
                                }
                                if (p.InfoInterfaccia.Tipo.Equals(VistaParametro.DropList))
                                {
                                    p.Valore = int.Parse(((ComboBox)paraControl).SelectedItem.ToString());
                                }
                                if (p.InfoInterfaccia.Tipo.Equals(VistaParametro.TimerBox))
                                {
                                    p.Valore = int.Parse(((NumericUpDown)paraControl).Value.ToString());
                                }
                                if (p.InfoInterfaccia.Tipo.Equals(VistaParametro.TextBox))
                                {
                                    p.Valore = double.Parse(((TextBox)paraControl).Text);
                                }
                                if (p.InfoInterfaccia.Tipo.Equals(VistaParametro.Button))
                                {
                                    paraControl.Text = p.InfoInterfaccia.Etichetta;
                                }
                            }

                        }
                    ((IFunzionalita)funzionalitaPanel.Tag).Method();
                }
        }
    }
}
