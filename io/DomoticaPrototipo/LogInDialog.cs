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
    public partial class LogInDialog : Form
    {
        private Utente _utente;
        public LogInDialog()
        {
            InitializeComponent();
        }
        public Utente LoggedIn
        {
            get { return _utente; }
            set { _utente = value; }
        }
        private void LogInDialog_Load(object sender, EventArgs e)
        {
            usernPassErrati.Visible = false;
            usernameTB.Select();//cursore posizionato automaticamente sulla textBox
        }

        private void accediB_Click(object sender, EventArgs e)
        {
            List<Standard> standardList = UtentiRepository.GetInstance().StandardList;

            Utente u = UtentiRepository.GetInstance().Login(usernameTB.Text, passwordTB.Text);
            
            if(u == null)
            {
                usernPassErrati.Visible = true;

                usernameP.BackColor = Color.Red;
                passwordP.BackColor = Color.Red;
                
                return;
            }

            _utente = u;
            this.Close();
        }
    }
}
