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
    public partial class EditUtenteDialog : Form
    {
        private Utente _utente;
        private Amministratore _admin;
        public EditUtenteDialog(Utente u,Amministratore admin)
        {
            _utente = u;
            _admin = admin;
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this._nameBox.Text = _utente.Nome;
            this._usernameBox.Text = _utente.Username;
            this._nomeUtenteLB.Text = _utente.Nome;
            this._usernameLB.Text = _utente.Username;
        }
        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _saveButton_Click(object sender, EventArgs e)
        {
            _utente.Nome = _nameBox.Text;
            _utente.Username = _usernameBox.Text;
            this.Close();
        }

        private void _changePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ChangePasswordDialog(_utente, _admin).Show();
        }
    }
}
