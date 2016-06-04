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
    public partial class DispositivoInfoDialog : Form
    {
        private IDispositivo _dispositivo;
        public DispositivoInfoDialog()
        {
            InitializeComponent();
        }
        public void SetDispositivo(IDispositivo dispositivo)
        {
            this.Text = dispositivo.Alias + " - Informazioni dispositivo";
            _nomeBox.Text = dispositivo.Nome;
            _tipoBox.Text = dispositivo.Tipo;
            _produttoreBox.Text = dispositivo.Produttore;
            _serialeBox.Text = dispositivo.Seriale;
            _consumoBox.Text = "" + dispositivo.Consumo + " W";
            _aliasBox.Text = dispositivo.Alias;
            _descrizioneBox.Text = dispositivo.Descrizione;
            _posizioneBox.Text = dispositivo.Posizione;
            _dispositivo = dispositivo;

            
            switch(_dispositivo.Nome)
            {   //ci dovrebbe essere icon.Image = _dispositivo.Icon;
                //qui immagine associata staticamente x i dispositivi inseriti

                case "Lux12": _iconaDispositivo.Image = DomoticaPrototipo.Properties.Resources.lampadina;
                              break;
                //case "ReX54": 
                //              break;
                case "Del3": _iconaDispositivo.Image = DomoticaPrototipo.Properties.Resources.termometro;
                             break;
                case "TempoTest12": _iconaDispositivo.Image = DomoticaPrototipo.Properties.Resources.telecomando2;
                                    break;
                default: _iconaDispositivo.Image = DomoticaPrototipo.Properties.Resources.casa_accesa;
                         break;
            }


            //devo crearla qui x settare correttamente il suo contenitore (immagine dispositivo)
            //per avere una sua corretta gestione del colore di sfondo
            PictureBox _statoConnessione = new PictureBox();
            _statoConnessione.Size = new Size(26, 26);
            _statoConnessione.Location = new Point(74, 74);
            _statoConnessione.SizeMode = PictureBoxSizeMode.StretchImage;
            _statoConnessione.BackColor = Color.Transparent;
            if (_dispositivo.IsCollegato())//set stato connessione
                _statoConnessione.Image = DomoticaPrototipo.Properties.Resources.accetta;
            else
                _statoConnessione.Image = DomoticaPrototipo.Properties.Resources.annulla;
            _iconaDispositivo.Controls.Add(_statoConnessione);
             
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            DispositiviRepository.GetInstance().ChangeCustomize(_dispositivo,_posizioneBox.Text,_descrizioneBox.Text,_aliasBox.Text);
            this.Close();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
