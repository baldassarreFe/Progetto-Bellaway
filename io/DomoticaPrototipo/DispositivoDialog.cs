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
    public partial class DispositivoDialog : Form
    {
        public DispositivoDialog()
        {
            InitializeComponent();
            //abilita lo scroll con la rotella dell'elenco delle categorie
            this.MouseWheel += new MouseEventHandler(dispositivoControl_MouseWheel);
        }
        public void SetDispositivo(IDispositivo dispositivo )
        {
            _dispositivoControl.SetDispositivo(dispositivo);
            this.Text = dispositivo.Alias + " - Status e Funzioni";
        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _inviaButton_Click(object sender, EventArgs e)
        {

            _dispositivoControl.InvokeMethods();

        }

        //abilita lo scroll con la rotella dell'elenco delle categorie
        private void dispositivoControl_MouseWheel(object sender, MouseEventArgs e)
        {
            _dispositivoControl.Focus();
        }

    }
}
