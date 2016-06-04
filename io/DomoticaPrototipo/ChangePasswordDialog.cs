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
    public partial class ChangePasswordDialog : Form
    {
        private Utente _utente;
        private Amministratore _admin;
        public ChangePasswordDialog(Utente u,Amministratore admin)
        {
            _utente = u;
            _admin = admin;
            InitializeComponent();
            if (admin!=null)
            {
                _adminOrOldPassword.Text = "Password Admin:";

                this.Text = "Modifica la password dell'utente "+u.Nome;
                this.msg1.Text = "Inserisci una nuova password per "+u.Nome;
                this.msg2.Text = "";
            }
            this.usernPassErrati.Visible = false;
        }

        private void _changeButton_Click(object sender, EventArgs e)
        {
            if (_admin == null)
            {
                if (_utente.isPassword(_adminOrOldPasswordBox.Text) && !_newPassword.Text.Equals("") && _newPassword.Text.Equals(_confermaPasswTB.Text))
                {
                    _utente.setPassword(_adminOrOldPasswordBox.Text, _newPassword.Text);
                    this.Close();
                }
                else
                {
                    this.usernPassErrati.Visible = true;
                }
            }
            else
            {
                if (_admin.isPassword(_adminOrOldPasswordBox.Text) && !_newPassword.Text.Equals("") && _newPassword.Text.Equals(_confermaPasswTB.Text))
                {
                    _utente.setPassword(_adminOrOldPasswordBox.Text, _newPassword.Text);
                    this.Close();
                }
                else
                {
                    this.usernPassErrati.Visible = true;
                }
            }
        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



       
    }
}
