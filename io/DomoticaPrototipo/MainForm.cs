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
    public partial class MainForm : Form
    {
        private Utente _utente;
        private Timer _timerDispositivo;
        private Timer _timerSegnale;
        private Timer _timerCollegato;
        
        private RegistrazioneListener _registrazioneListener;
        private SegnaleListener _segnaleListener;

        private List<String> _posizioni;

        public MainForm(Utente u)
        {
            _utente = u;
            InitializeComponent();
            //abilita lo scroll con la rotella dell'elenco delle categorie
            this.MouseWheel += new MouseEventHandler(flowLayoutPanel_MouseWheel);
        }

        

        private void InitializePrototypeRepos()
        {
            DispositiviRepository.GetInstance().Changed += OnChangeDispositivoRepository;

            DispositivoRemoto remote = new DispositivoRemoto("Lux12", "Lampadina", 40, "lux234", "lux");
            remote.Funzionalita.Add(new FunzionalitaAccensione());
            Dispositivo lux = new Dispositivo(remote);
            lux.Collegato = false;
            DispositiviRepository.GetInstance().Add(lux);

            remote = new DispositivoRemoto("ReX54", "Microonde", 600, "rx443es", "rex");
            remote.Funzionalita.Add(new FunzionalitaCuoci());
            if (remote.Funzionalita[0].Parametri[0].Valore is int)
                remote.Stati.Add(new StatusTimer(1, remote.Funzionalita[0].Parametri[0]));
            else
                remote.Stati.Add(new StatusTimer(1, remote.Funzionalita[0].Parametri[1]));
            Dispositivo rex = new Dispositivo(remote);
            rex.Collegato = true;
            DispositiviRepository.GetInstance().Add(rex);

            remote = new DispositivoRemoto("Del3", "Caldaia", 100, "de4523", "delonghi");
            remote.Funzionalita.Add(new FunzionalitaTemperatura());
            if (remote.Funzionalita[0].Parametri[0].Valore is double)
                remote.Stati.Add(new StatusTemperatura(30, remote.Funzionalita[0].Parametri[0]));
            Dispositivo delonghi = new Dispositivo(remote);
            delonghi.Collegato = true;
            DispositiviRepository.GetInstance().Add(delonghi);

            

            Calendario.GetInstance().Load(new CalendarioPersister());
      
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _posizioni = new List<String>();
            CreaNuovoRiquadro("Altro");//creazione riquadro default (dispositivi con campo posizione vuoto)


            InitializePrototypeRepos();

            DispositivoRegistratore registratore = new DispositivoRegistratore();
            _registrazioneListener = new RegistrazioneListener();
            _registrazioneListener.Registrazione += registratore.Registrazione;
            _timerDispositivo = new Timer();
            _timerDispositivo.Interval = 5000;
            _timerDispositivo.Tick += _registrazioneListener.OnTimedEvent;
            _timerDispositivo.Enabled = true;

            _segnaleListener = new SegnaleListener();
            _segnaleListener.Segnalato += Segnala;
            _timerSegnale = new Timer();
            _timerSegnale.Interval = 3000;
            _timerSegnale.Tick += _segnaleListener.OnTimedEvent;
            _timerSegnale.Enabled = true;

            _timerCollegato = new Timer();
            _timerCollegato.Interval = 10000;
            _timerCollegato.Tick+=  OnTimedCollegato;
            _timerCollegato.Enabled=true;

            CheckCollegati(this, null);

            if (_utente is Standard)//se utente standard, nascondo "gestione utenti"
                foreach (ToolStripMenuItem toolstrip in this._menuStrip.Items)
                    if (toolstrip.Name.Equals("utentiToolStrip"))
                    {
                        toolstrip.DropDownItems["gestioneUtentiToolStrip"].Visible = false;
                    }

            
        }
        private void OnTimedCollegato(object sender, EventArgs e)
        {
            ((Timer)sender).Enabled = false;
            foreach (Dispositivo d in DispositiviRepository.GetInstance().Dispositivi)
                if (d.Seriale.Equals("lux234"))
                    d.Collegato = true;
            ((Timer)sender).Interval = 1000;
            ((Timer)sender).Tick -= OnTimedCollegato;
            ((Timer)sender).Tick += CheckCollegati;
            ((Timer)sender).Enabled = true;

        }
        private void CheckCollegati(object sender, EventArgs e)
        {
            foreach (Control c in this._flowLayoutPanel.Controls)
                if (c is Panel)//bordo categoria
                    foreach (Control cc in ((Panel)c).Controls)
                        if (cc is Panel)//riquadro categoria
                            foreach (Control bordo in ((Panel)cc).Controls)
                                if (bordo is Panel && ((Panel)bordo).Tag != null && ((Panel)bordo).Tag is IDispositivo)
                                {
                                    if (((IDispositivo)((Panel)bordo).Tag).IsCollegato())
                                    {
                                        //Visualizzo lo stato collegato
                                        foreach (Control pan in ((Panel)bordo).Controls)
                                            if (pan is Panel)
                                                foreach (Control immagineDisp in ((Panel)pan).Controls)
                                                    if (immagineDisp is PictureBox)
                                                        foreach (Control immagineStato in immagineDisp.Controls)
                                                            if (immagineStato is PictureBox)//sicuramente si
                                                                ((PictureBox)immagineStato).Image = DomoticaPrototipo.Properties.Resources.accetta;
                                    }
                                    else
                                    {
                                        //Visualizzo lo stato scollegato
                                        foreach (Control pan in ((Panel)bordo).Controls)
                                            if (pan is Panel)
                                                foreach (Control immagineDisp in ((Panel)pan).Controls)
                                                    if (immagineDisp is PictureBox)
                                                        foreach (Control immagineStato in immagineDisp.Controls)
                                                            if (immagineStato is PictureBox)//sicuramente si
                                                                ((PictureBox)immagineStato).Image = DomoticaPrototipo.Properties.Resources.annulla;
                                    }
                                    break;
                                }
        }
        private void CreaNuovoRiquadro(String nomeRiquadro)
        {
            _posizioni.Add(nomeRiquadro);

            Label posL = new Label();
            posL.Text = nomeRiquadro;
            posL.AutoSize = true;
            posL.Font = new Font(posL.Font.FontFamily, 12F);
            this._flowLayoutPanel.Controls.Add(posL);

            Panel bordoPos = new Panel();//624 larghezza totale FlowLayoutP
            bordoPos.Size = new Size(584, 200);
            bordoPos.Tag = nomeRiquadro;
            bordoPos.BackColor = Color.FromArgb(204, 204, 204);//grigio
            this._flowLayoutPanel.Controls.Add(bordoPos);
            

            FlowLayoutPanel posP = new FlowLayoutPanel();
            posP.Size = new Size(582, 198);
            posP.Location = new Point(1, 1);
            posP.BackColor = Color.FromArgb(255, 255, 255);//bianco
            posP.Tag = nomeRiquadro;
            bordoPos.Controls.Add(posP);

            posP.MouseEnter += MioMouseLeave;
        }

        //------ eventi -----

        public void OnChangeDispositivoRepository(object sender, ChangedDispositivoArgs args)
        {
            //in genere, è cambiato un dispositivo....
            // in realtà viene invocata solo quando viene aggiunto
            if (args.ChangeType.Equals("add"))
                AddNewDispositivo((Dispositivo)args.Dispositivo);
            if (args.ChangeType.Equals("change"))
                ChangedDispositivo((Dispositivo)args.Dispositivo);
        }
        private void ChangedDispositivo(Dispositivo d)
        {
            RemoveDispositivo(d);
            AddNewDispositivo(d);
        }
        private void RemoveDispositivo(Dispositivo d)
        {
            //inserisci in riquadro <<target>>
            foreach (Control c in this._flowLayoutPanel.Controls)
                if (c is Panel)
                    foreach (Control cc in ((Panel)c).Controls)
                        if (cc is Panel)//pannello interno
                            foreach (Control bordo in ((Panel)cc).Controls)
                                if (bordo is Panel && ((Panel)bordo).Tag!= null && ((Panel)bordo).Tag.Equals(d))
                                {
                                    cc.Controls.Remove(bordo);
                                    break;
                                }
                       
        }
        private void AddNewDispositivo(Dispositivo d)
        {
            Panel bordo = new Panel();
            bordo.Size = new Size(80, 102);
            bordo.Tag = d;


            String target;//in che riquadro andrà inserito
            if (d.Posizione == null || d.Posizione.Equals(""))
                target = _posizioni[0];//default
            else
            {
                target = d.Posizione;
                if (!_posizioni.Contains(target))
                    CreaNuovoRiquadro(target);
            }
                
                
            //inserisci in riquadro <<target>>
            foreach (Control c in this._flowLayoutPanel.Controls)
                if (c is Panel && ((Panel)c).Tag.Equals(target)) //bordo
                        foreach (Control cc in ((Panel)c).Controls)
                            if (cc is Panel)//pannello interno
                            {
                                ((Panel)cc).Controls.Add(bordo);
                                break;
                            }
            

            Panel pan = new Panel();
            pan.Size = new Size(78, 100);
            pan.Location = new Point(1, 1);
            pan.Tag = d;
            bordo.Controls.Add(pan);

            PictureBox icon = new PictureBox();
            switch(d.Nome)
            {   //ci dovrebbe essere icon.Image = d.Icon;
                //qui immagine associata staticamente x i dispositivi inseriti

                case "Lux12": icon.Image = DomoticaPrototipo.Properties.Resources.lampadina;
                              break;
                //case "ReX54": 
                //              break;
                case "Del3": icon.Image = DomoticaPrototipo.Properties.Resources.termometro;
                             break;
                case "TempoTest12": icon.Image = DomoticaPrototipo.Properties.Resources.telecomando2;
                                    break;
                default: icon.Image = DomoticaPrototipo.Properties.Resources.casa_accesa;
                         break;
            }
              
            icon.SizeMode = PictureBoxSizeMode.CenterImage;
            icon.Size = new Size(58, 58);
            icon.Location = new Point(10, 10);
            icon.Tag = d;
            pan.Controls.Add(icon);
            
            
            PictureBox statoConnessione = new PictureBox();
            if(d.IsCollegato())
                statoConnessione.Image = DomoticaPrototipo.Properties.Resources.accetta;
            else
                statoConnessione.Image = DomoticaPrototipo.Properties.Resources.annulla;
            statoConnessione.Tag = d;
            statoConnessione.SizeMode = PictureBoxSizeMode.StretchImage;
            statoConnessione.Size = new Size(15, 15);
            statoConnessione.Location = new Point(43, 43);
            statoConnessione.BackColor = Color.Transparent;
            icon.Controls.Add(statoConnessione);


            Label nomeDisp = new Label();
            nomeDisp.Text = d.Alias;
            nomeDisp.AutoSize = false;
            nomeDisp.MaximumSize = new Size(73, 15);
            nomeDisp.Location = new Point(5, 75);
            nomeDisp.Font = new Font(nomeDisp.Font.FontFamily, 10F);
            nomeDisp.Tag = d;
            pan.Controls.Add(nomeDisp);

            //set eventi (Mouse Enter/Leave, Mouse Click, Context Menu)
            pan.MouseEnter += MioMouseEnter;
              //se faccio così pan.MouseLeave += MioMouseLeave;
              //l'evento non viene scatendato al passaggio da una finestra ad un'altra
            statoConnessione.MouseEnter += MioMouseEnter;
            

            pan.MouseClick += ClickOnDispositivo;
            icon.MouseClick += ClickOnDispositivo;
            nomeDisp.MouseClick += ClickOnDispositivo;
            statoConnessione.MouseClick += ClickOnDispositivo;

            pan.ContextMenuStrip = _contextMenuStrip;
            icon.ContextMenuStrip = _contextMenuStrip;
            nomeDisp.ContextMenuStrip = _contextMenuStrip;
            statoConnessione.ContextMenuStrip = _contextMenuStrip;

            _toolTip.SetToolTip(pan, d.Alias);
            _toolTip.SetToolTip(icon, d.Alias);
            _toolTip.SetToolTip(nomeDisp, d.Alias);
            _toolTip.SetToolTip(statoConnessione, d.Alias);
        }

        public void Segnala(object sender, SegnaleArgs args)
        {
            SegnaleDialog segnaleDialog = new SegnaleDialog();
            segnaleDialog.Message = args.Message;
            segnaleDialog.Text = args.Dispositivo.Nome;
            segnaleDialog.Show();
        }
        public void ClickOnDispositivo(object sender, EventArgs e)
        {
            Dispositivo disp = null;
            DispositivoDialog dispDialog = new DispositivoDialog();

            if (sender is Panel)
                disp = (Dispositivo)((Panel)sender).Tag;

            if (sender is Label)
                disp = (Dispositivo)((Label)sender).Tag;

            if (sender is PictureBox)
                disp = (Dispositivo)((PictureBox)sender).Tag;

            if (sender is Panel || sender is Label || sender is PictureBox)
            {
                if (disp.Collegato)
                {
                    dispDialog.SetDispositivo(disp);
                    dispDialog.Show();
                }
                else
                {
                    SegnaleDialog segnale = new SegnaleDialog();
                    segnale.Message="Il dispositivo non è collegato!";
                    segnale.Show();
                }
            }
        }
        public void ClickOnContextMenu(object sender, EventArgs e)
        {
            if (sender is ToolStripItem)
            {
                //ottengo _contextMenuStrip
                ContextMenuStrip cms = (ContextMenuStrip)((ToolStripItem)sender).GetCurrentParent();
                //ottengo il tag su cosa ho cliccato
                Dispositivo disp = (Dispositivo)cms.SourceControl.Tag;
                

                if (((ToolStripItem)sender).Name.Equals("statusEFunzioniTSMI"))
                {
                    if (disp.Collegato)
                    {
                        DispositivoDialog dispDialog = new DispositivoDialog();       
                        dispDialog.SetDispositivo(disp);               
                        dispDialog.Show();
                    }
                    else
                    {
                        SegnaleDialog segnale = new SegnaleDialog();
                        segnale.Message = "Il dispositivo non è collegato!";
                        segnale.Show();
                    }

                }

                if (((ToolStripItem)sender).Name.Equals("infoDispositivoTSMI"))
                {
                    DispositivoInfoDialog dispDialog = new DispositivoInfoDialog();
                    dispDialog.SetDispositivo(disp);
                    dispDialog.Show();
                }
            }
        }
        private void MioMouseEnter(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                if (((Panel)sender).Parent is Panel)//se sono nel pannello dentro il bordo
                {
                    ((Panel)sender).BackColor = Color.FromArgb(228, 243, 246);//azzurro
                    ((Panel)sender).Parent.BackColor = Color.FromArgb(112, 192, 231);//blu
                }
            }
        }
        private void MioMouseLeave(object sender, EventArgs e)
        {
            //bug rilevato: se si passa da un riquadro ad un altro servendosi di una dialogBox
            //per fare da ponte, l'evento non viene scatenato.
            //devo togliere il colore da tuttii dispositivi in tutti i riquadri.
            //NON SOLO in quello dove si è scatenato l'evento
            if (sender is FlowLayoutPanel)
            {
                foreach (Control c1 in this._flowLayoutPanel.Controls)
                    if (c1 is Panel) //bordo di una categoria
                        foreach (Control c2 in ((Panel)c1).Controls)
                            if (c2 is Panel)//pannello contenente dispositivi
                                foreach (Control c3 in ((Panel)c2).Controls)
                                    if (c3 is Panel)//bordo di un dispositivo
                                    {
                                        //toglie colore dal bordo del riquadro di un dispositivo
                                        c3.BackColor = _flowLayoutPanel.BackColor;
                                        //e dal riquadro interno
                                        foreach (Control c4 in c3.Controls)
                                            if (c4 is Panel)
                                                c4.BackColor = _flowLayoutPanel.BackColor;
                                    }
            }
        }
        //abilita lo scroll con la rotella dell'elenco delle categorie
        private void flowLayoutPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            _flowLayoutPanel.Focus();
        }
        
        //------- apertura dialog al click delle voci di menu ------

        private void visualizzaCalendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CalendarForm(_utente).Show();
        }

        private void programmaAzioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActionDialog(_utente).Show();
        }

        private void modificaInformazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EditUtenteDialog(_utente,null).Show();
        }

        private void gestioneUtentiToolStrip_Click(object sender, EventArgs e)
        {
            new GestioneUtentiDialog((Amministratore)_utente).Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

    }
}
