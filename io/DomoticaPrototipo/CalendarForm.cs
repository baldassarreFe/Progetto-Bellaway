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
    public partial class CalendarForm : Form
    {
        private Utente _user;

        public CalendarForm(Utente user)
        {
            _user = user;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            // ----- Caricamento dei tipi di dispositivi in _deviceTypeCB -----

            _deviceTypeCB.Items.Add(""); // Aggiungiamo string vuota per la non selezione

            foreach (string t in DispositiviRepository.GetInstance().getDeviceTypes())
            {
                _deviceTypeCB.Items.Add(t);
            }

            // ----- Caricamento dei dispositivi in _deviceCB -----
            _deviceCB.Items.Add("");

            foreach (IDispositivo d in DispositiviRepository.GetInstance().Dispositivi)
            {
                _deviceCB.Items.Add(d);
            }

            Calendario.GetInstance().Changed += updateDataGrid;

            // Chiamata iniziale alla funzione di riempimento della tabella
            updateDataGrid();
        }

        private void _closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _addActionButton_Click(object sender, EventArgs e)
        {
            ActionDialog actDialog = new ActionDialog(_user);
            actDialog.ShowDialog();
        }

        private void _deleteActionButton_Click(object sender, EventArgs e)
        {
            if (getSelectedAction() != null)
                Calendario.GetInstance().RimuoviAzione(getSelectedAction());
        }

        private void _editActionButton_Click(object sender, EventArgs e)
        {
            if (getSelectedAction() != null)
            {
                ActionDialog actDialog = new ActionDialog(getSelectedAction(), _user);
                actDialog.ShowDialog();
            }
        }

        private Azione getSelectedAction()
        {
            if (_dataGridView.RowCount > 0)
                return (Azione) _dataGridView.SelectedRows[0].Tag;

            return null;
        }

        private void updateDataGrid()
        {
            updateDataGrid(this, EventArgs.Empty);
        }

        private void updateDataGrid(object sender, EventArgs e)
        {
            // Parametri di ricerca
            IDispositivo disp;

            if (_deviceCB.SelectedItem == null || String.IsNullOrEmpty(_deviceCB.SelectedItem.ToString()))
                disp = null;
            else
                disp = (IDispositivo)_deviceCB.SelectedItem;
            

            string tipo = (String)_deviceTypeCB.SelectedItem;
            tipo = (String.IsNullOrEmpty(tipo)) ? null : tipo;

            DateTime date = _dateTimePicker.Value.Date;


            // Ricerca delle azioni che soddisfano i parametri
            List<Azione> actions = Calendario.GetInstance().Search(date, disp, tipo);

            // Settaggio nuove azioni nella DataGridView
            _dataGridView.Rows.Clear();
            foreach (Azione a in actions)
            {
                int index = _dataGridView.Rows.Add();
                DataGridViewRow row = _dataGridView.Rows[index];
                row.Cells["time"].Value = a.DateTime;
                row.Cells["device"].Value = a.Dispositivo;
                row.Cells["function"].Value = a.Funzionalita;
                row.Tag = a;

                //_dataGridView.Rows.Add(a.DateTime, a.Dispositivo, a.Funzionalita);
            }
        }

        private void _deviceTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se seleziono un tipo di dispositivo specifico, seleziono tutti i dispositivi per la ricerca
            if (_deviceTypeCB.SelectedIndex != 0)
            {
                _deviceCB.SelectedIndex = 0;
            }

            updateDataGrid();
        }

        private void _deviceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se seleziono un dispositivo specifico, seleziono tutti i tipi di dispositivo per la ricerca
            if (_deviceCB.SelectedIndex != 0)
            {
                _deviceTypeCB.SelectedIndex = 0;
            }

            updateDataGrid();
        }

        private void _dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            updateDataGrid();
        }

    }
}
