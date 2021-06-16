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
    public partial class PlaylistEndForm : Form
    {
        Playlist playlist;
        SeriesForm parentSeriesForm;
        public PlaylistEndForm(Playlist playlist, SeriesForm parentSeriesForm)
        {
            this.playlist = playlist;
            this.parentSeriesForm = parentSeriesForm;
            InitializeComponent();
            this.Shown += initDisplay;
            this.CenterToScreen();
        }

        private void initDisplay(object sender, EventArgs e)
        {
            ResultLabel.Text = $"Vous avez fait un score de {playlist.nombreReussis} sur {playlist.nombreMots}.";
            ButtonRejouerSerieEntiere.Text = "Rejouer série entière";
            ButtonReplayWrongResults.Text = "Rejouer les mauvaises réponses";
            ButtonReplay.Text = "Rejouer la série actuelle";
            ButtonShowDetails.Text = "Details";

            ResultLabel.Left = this.Width / 2 - ResultLabel.Width / 2;

            ButtonBack.Size = Display.smallButtonSize;
            
            
        }

        private void ButtonShowDetails_Click(object sender, EventArgs e)
        {
            ResultDetailsForm resultsDetailsForm = new ResultDetailsForm(playlist);
            resultsDetailsForm.Show();
        }

        private void ButtonReplay_Click(object sender, EventArgs e)
        {
            Playlist resetPlaylist = Helper.ResetPlaylist(playlist);
            playSerieForm playSerieForm = new playSerieForm(resetPlaylist, this.parentSeriesForm);
            playSerieForm.Show();
            this.Close();
        }

        private void ButtonReplayWrongResults_Click(object sender, EventArgs e)
        {
            Playlist onlyWrongResultsPlaylist = Helper.MakePlaylistFromWrongResults(playlist);
            playSerieForm playSerieForm = new playSerieForm(onlyWrongResultsPlaylist, this.parentSeriesForm);
            playSerieForm.Show();
            this.Close();
        }

        private void ButtonRejouerSerieEntiere_Click(object sender, EventArgs e)
        {
            Serie serie = this.playlist.serie;
            Playlist playlist = Helper.MakePlaylist(serie, this.playlist.versFr);
            playSerieForm playForm = new playSerieForm(playlist, this.parentSeriesForm);
            playForm.Show();
            this.Close();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.parentSeriesForm.Show();
            this.Close();
        }
    }
}
