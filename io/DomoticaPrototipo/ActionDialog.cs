using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DomoticaPrototipo
{
    public partial class ActionDialog : Form
    {
        private Azione _selectedAction = null;
        private Utente _user = null;

        public ActionDialog(Utente user) : this(null, user)
        {

        }

        public ActionDialog(Azione selectedAction, Utente user)
        {
            _selectedAction = selectedAction;
            _user = user;
            InitializeComponent();
        }

        public void loadAction()
        {
            if (_selectedAction == null)
            {
                throw new ArgumentNullException();
            }

            _deviceComboBox.SelectedItem = _selectedAction.Dispositivo;
            _functionComboBox.SelectedItem = _selectedAction.Funzionalita;

            if (_selectedAction is AzioneSettimanale)
            {
                _weekDayRadioButton.Select();
                _weekDayComboBox.SelectedItem = ((AzioneSettimanale)_selectedAction).Giorno;
            }
            else
            {
                _yearDayRadioButton.Select();
                _dayPicker.Value = _selectedAction.DateTime;
            }

            _timePicker.Value = _selectedAction.DateTime;
        }

        private void _actionDialog_Load(object sender, EventArgs e)
        {
            // ----- Caricamento dei dispositivi in _deviceComboBox -----
            foreach (IDispositivo d in DispositiviRepository.GetInstance().Dispositivi)
            {
                _deviceComboBox.Items.Add(d);
            }
            _deviceComboBox.SelectedIndex = 0;

            // ----- Caricamento delle funzionalita' in _functionComboBox -----
            updateFunctionComboBox();
            
            // ----- Preparazione di _weekDayComboBox -----
            _weekDayComboBox.Items.Add(DayOfWeek.Monday);
            _weekDayComboBox.Items.Add(DayOfWeek.Tuesday);
            _weekDayComboBox.Items.Add(DayOfWeek.Wednesday);
            _weekDayComboBox.Items.Add(DayOfWeek.Thursday);
            _weekDayComboBox.Items.Add(DayOfWeek.Friday);
            _weekDayComboBox.Items.Add(DayOfWeek.Saturday);
            _weekDayComboBox.Items.Add(DayOfWeek.Sunday);
            _weekDayComboBox.SelectedIndex = 0;

            // Se nessun RadioButton e' selezionato, seleziono _yearDayRadioButton
            if (!_yearDayRadioButton.Checked && !_weekDayRadioButton.Checked)
            {
                _yearDayRadioButton.Checked = true;
            }

            if (_selectedAction != null)
            {
                loadAction();
            }
        }

        private void updateFunctionComboBox()
        {
            _functionComboBox.Items.Clear();

            foreach (IFunzionalita f in ((IDispositivo)_deviceComboBox.SelectedItem).Funzionalita)
            {
                _functionComboBox.Items.Add(f);
            }
            _functionComboBox.SelectedIndex = 0;
        }

        private void _yearDayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Se _yearDayRadioButton viene selezionato rendo attivo _dayPicker e inattivo _weekDayComboBox
            if (_yearDayRadioButton.Checked)
            {
                _dayPicker.Enabled = true;
                _weekDayComboBox.Enabled = false;
            }
        }

        private void _weekDayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Se _weekDayRadioButton viene selezionato rendo attivo _weekDayCombeBox e inattivo _dayPicker
            if (_weekDayRadioButton.Checked)
            {
                _dayPicker.Enabled = false;
                _weekDayComboBox.Enabled = true;
            }
        }

        private void _deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFunctionComboBox();
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            if (_deviceComboBox.SelectedItem != null)
            {
                DateTime date = _dayPicker.Value;
                DateTime time = _timePicker.Value;
                DateTime dt = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
                if (DateTime.Compare(dt, DateTime.Now) < 0 && !_weekDayRadioButton.Checked)
                {
                    this._errorMessage.Visible = true;
                }
                else
                {
                    IDispositivo d = (IDispositivo)_deviceComboBox.SelectedItem;
                    IFunzionalita f = (IFunzionalita)_functionComboBox.SelectedItem;
                    DayOfWeek w = (DayOfWeek)_weekDayComboBox.SelectedItem;

                    if (_selectedAction != null)
                    {
                        Calendario.GetInstance().RimuoviAzione(_selectedAction);
                    }

                    if (_weekDayRadioButton.Checked)
                    {
                        AzioneSettimanale a = new AzioneSettimanale(dt, _user, d, f, w);
                        Calendario.GetInstance().ProgrammaAzioneSettimanale(a);
                        Close();
                    }
                    else
                    {
                        Azione a = new Azione(dt, _user, d, f);
                        Calendario.GetInstance().ProgrammaAzione(a);
                        Close();
                    }
                }
            }
        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
