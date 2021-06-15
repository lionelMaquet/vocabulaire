using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenProgrammation
{
    public partial class playSerieForm : Form
    {
        Playlist playlist;
        SeriesForm parentSeriesForm;
        
        public playSerieForm(Playlist playlist, SeriesForm parentSeriesForm)
        {
            this.playlist = playlist;
            this.parentSeriesForm = parentSeriesForm;
            
            InitializeComponent();
            this.Shown += InitPlaylist;
        }

        private void InitPlaylist(object sender, EventArgs e)
        {
            if (playlist.versFr)
            {
                LabelMotATraduire.Text = playlist.resultats[playlist.currentMotIndex].mot.traduction;
            } else
            {
                
                LabelMotATraduire.Text = playlist.resultats[playlist.currentMotIndex].mot.langue_fr;
            }
            
            LabelCurrentQuestionNumber.Text = $"{playlist.currentMotIndex + 1}/{playlist.nombreMots}";
            ButtonValiderReponse.Text = "Valider";
        }

        private void UpdatePlaylistInfos()
        {
            bool answeredRight = false;
            if (playlist.versFr)
            {
                answeredRight = playlist.resultats[playlist.currentMotIndex].mot.langue_fr == TextboxTraductionInputUser.Text;
            } else
            {
                answeredRight = playlist.resultats[playlist.currentMotIndex].mot.traduction == TextboxTraductionInputUser.Text;
            }

            playlist.resultats[playlist.currentMotIndex].reponse = TextboxTraductionInputUser.Text;
            // Si la réponse est juste
            if (answeredRight)
            {
                playlist.nombreReussis++;
                playlist.resultats[playlist.currentMotIndex].answeredRight = true;
                playlist.resultats[playlist.currentMotIndex].mot.nombre_reussi++;
            }
            else
            {
                playlist.resultats[playlist.currentMotIndex].mot.nombre_rate++;
                playlist.nombreRates++;
            }

            playlist.currentMotIndex++;

            if(playlist.currentMotIndex == playlist.nombreMots)
            {
                playlist.isActive = false;
            }
        }

        private void ShowNextQuestion()
        {
            if (playlist.versFr)
            {
                LabelMotATraduire.Text = playlist.resultats[playlist.currentMotIndex].mot.traduction;
            }
            else
            {
                LabelMotATraduire.Text = playlist.resultats[playlist.currentMotIndex].mot.langue_fr;
            }
            LabelCurrentQuestionNumber.Text = $"{playlist.currentMotIndex + 1}/{playlist.nombreMots}";
            TextboxTraductionInputUser.Text = "";
        }

        private void ButtonValiderReponse_Click(object sender, EventArgs e)
        {
            UpdatePlaylistInfos();
            if (playlist.isActive)
            {
                ShowNextQuestion();
            } else
            {
                DBConnector.updateWords(playlist); // Update la database - statistiques réussi ou non
                PlaylistEndForm playlistEndForm = new PlaylistEndForm(this.playlist, this.parentSeriesForm);
                playlistEndForm.Show();
                this.Close();
            }
            

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.parentSeriesForm.Show();
            this.Close();
        }
    }
}
