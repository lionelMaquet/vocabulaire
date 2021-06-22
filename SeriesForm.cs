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
    public partial class SeriesForm : Form
    {
        Langue langue;
        LanguagesForm parentLanguagesForm;
        public SeriesForm(Langue langue, LanguagesForm parentLanguagesForm)
        {
            this.langue = langue;
            this.parentLanguagesForm = parentLanguagesForm;
            InitializeComponent();
            this.Shown += createSeriesButtons;
            this.CenterToScreen();
        }

        public void createSeriesButtons(object sender, EventArgs e)
        {
            this.Hide();
            List<Serie> series = DBConnector.getSeries(this.langue);

            ButtonBack.Location = Display.backButtonLocation;
            ButtonBack.Size = Display.smallButtonSize;
            ButtonBack.Text = "Retour";
            for (int i = 0; i < series.Count; i++)
            {
                int buttonWidth = 100;
                int marginLeft = 10;
                Size size = new Size(buttonWidth, 30);

                // Label for serie name 
                Label serieName = new Label();
                this.Controls.Add(serieName);
                serieName.Text = series[i].nom_serie;
                serieName.Location = new Point(150 , Display.topOffSet + 50 * i + 5);
                serieName.Size = Display.smallButtonSize;

                // Button for listing words 
                SerieButton listWordsButton = new SerieButton();
                this.Controls.Add(listWordsButton);
                listWordsButton.Text = "Lister";
                listWordsButton.Size = Display.smallButtonSize;
                listWordsButton.Click += this.listWordsButtonClick;
                listWordsButton.serie = series[i];
                listWordsButton.Location = new Point(150 + (Display.leftButtonMargin + Display.smallButtonSize.Width) * 1, Display.topOffSet + 50 * i);

                // Button for adding a word
                SerieButton addWordButton = new SerieButton();
                this.Controls.Add(addWordButton);
                addWordButton.Text = "Ajouter mot";
                addWordButton.Size = Display.smallButtonSize;
                addWordButton.Click += this.addWordButtonClick;
                addWordButton.serie = series[i];
                addWordButton.Location = new Point(150 + (Display.leftButtonMargin + Display.smallButtonSize.Width) * 2, Display.topOffSet + 50 * i);

                // Button for playing the serie 
                SerieButton playSerieButtonVersTrad = new SerieButton();
                this.Controls.Add(playSerieButtonVersTrad);
                playSerieButtonVersTrad.Text = "Vers trad";
                playSerieButtonVersTrad.versFr = false;
                playSerieButtonVersTrad.Size = Display.smallButtonSize;
                playSerieButtonVersTrad.Click += this.playSerieButton;
                playSerieButtonVersTrad.serie = series[i];
                playSerieButtonVersTrad.Location = new Point(150 + (Display.leftButtonMargin + Display.smallButtonSize.Width) * 3, Display.topOffSet + 50 * i);

                // Button for playing the serie 
                SerieButton playSerieButtonVersFr = new SerieButton();
                this.Controls.Add(playSerieButtonVersFr);
                playSerieButtonVersFr.Text = "Vers fr";
                playSerieButtonVersFr.versFr = true;
                playSerieButtonVersFr.Size = size;
                playSerieButtonVersFr.Click += this.playSerieButton;
                playSerieButtonVersFr.serie = series[i];
                playSerieButtonVersFr.Location = new Point(150 + (Display.leftButtonMargin + Display.smallButtonSize.Width) * 4, Display.topOffSet + 50 * i);

                this.Size = new Size(playSerieButtonVersFr.Right + Display.leftMargin , playSerieButtonVersTrad.Bottom + 100);
            }
            this.CenterToScreen();
            this.Show();
        }

        private void playSerieButton(object sender, EventArgs e)
        {
            Serie serie = (sender as SerieButton).serie;
            bool versFr = (sender as SerieButton).versFr;
            Playlist playlist = Helper.MakePlaylist(serie, versFr);
            playSerieForm playForm = new playSerieForm(playlist, this);
            playForm.Show();
            this.Hide();
        }

        private void addWordButtonClick(object sender, EventArgs e)
        {
            Serie serie = (sender as SerieButton).serie;
            AddWordForm addWordForm = new AddWordForm(serie);
            addWordForm.Show();
        }

        private void listWordsButtonClick(object sender, EventArgs e)
        {
            Serie serie = (sender as SerieButton).serie;
            ListWordsForm listWordsForm = new ListWordsForm(serie);
            listWordsForm.Show();
        }

        public void serie_button_click(object sender, EventArgs e)
        {
            MessageBox.Show($"{(sender as SerieButton).serie.num_serie} {(sender as SerieButton).serie.nom_serie} {(sender as SerieButton).serie.langue_traduction} ");
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {

            this.parentLanguagesForm.Show();
            this.Close();
        }
    }
}
