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
    public partial class GestioneUtentiDialog : Form
    {
        private Amministratore _admin;
        public GestioneUtentiDialog(Amministratore admin)
        {
            _admin = admin;
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach (Standard u in UtentiRepository.GetInstance().StandardList)
            {
                Panel bordo = new Panel();
                bordo.Size = new Size(205, 68);
                this._flowLayoutPanel.Controls.Add(bordo);

                Panel tmp = new Panel();
                tmp.Size = new Size(203, 66);
                tmp.Location = new Point(1, 1);
                tmp.Tag = u;
                bordo.Controls.Add(tmp);

                PictureBox icon = new PictureBox();
                icon.Image = DomoticaPrototipo.Properties.Resources.account;
                //ci dovrebbe andare l'immagine dell'utente: u.Icon
                //qui immagine di default
                icon.SizeMode = PictureBoxSizeMode.AutoSize;
                icon.Location = new Point(13, 9);
                icon.Tag = u;
                tmp.Controls.Add(icon);

                Label userL = new Label();
                userL.Text = u.Nome;
                userL.AutoSize = true;
                userL.Location = new Point(66, 9);
                userL.Font = new Font(userL.Font.FontFamily, 10.9F);
                userL.Tag = u;
                tmp.Controls.Add(userL);

                Label usernameL = new Label();
                usernameL.Text = u.Username;
                usernameL.AutoSize = true;
                usernameL.Location = new Point(66, 35);
                usernameL.Tag = u;
                tmp.Controls.Add(usernameL);

                //set eventi (Mouse Enter/Leave & Mouse Click)
                tmp.MouseEnter += MioMouseEnter;
                 //se faccio così bordo.MouseLeave += MioMouseLeave;
                 //l'evento non viene scatendato al passaggio da una finestra ad un'altra
                this._flowLayoutPanel.MouseEnter += MioMouseLeave;

                tmp.MouseClick += OnClick;
                icon.MouseClick += OnClick;
                userL.MouseClick += OnClick;
                usernameL.MouseClick += OnClick;
            }

        }
        public void OnClick(object sender, EventArgs e)
        {
            Standard utente = null;

            if (sender is Panel)
                utente = (Standard)((Panel)sender).Tag;

            if (sender is Label)
                utente = (Standard)((Label)sender).Tag;

            if (sender is PictureBox)
                utente = (Standard)((PictureBox)sender).Tag;


            if (sender is Panel || sender is Label || sender is PictureBox)
                new EditUtenteDialog(utente, _admin).Show();

        }
        private void MioMouseEnter(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                if (((Panel)sender).Parent is Panel)//se sono nel pannello dentro il bordo
                {//sicuramente si dato che l'evento è associato SOLO a "tmp"
                    ((Panel)sender).BackColor = Color.FromArgb(228, 243, 246);//azzurro
                    ((Panel)sender).Parent.BackColor = Color.FromArgb(112, 192, 231);//blu
                }
            }
        }
        private void MioMouseLeave(object sender, EventArgs e)
        {
            if (sender is FlowLayoutPanel)
            {
                foreach (Control c in ((FlowLayoutPanel)sender).Controls)
                {   //colora di grigio i figli (bordi)
                    c.BackColor = Color.FromArgb(240, 240, 240);

                    //e i figli dei figli (panel dentro bordo)
                    foreach (Control cc in c.Controls)
                       cc.BackColor = Color.FromArgb(240, 240, 240);
                }
            }
        }
    }
}
