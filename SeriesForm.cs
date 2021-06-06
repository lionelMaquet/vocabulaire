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
        public SeriesForm(Langue langue)
        {
            this.langue = langue;
            InitializeComponent();
            this.Shown += createSeriesButtons;
        }

        public void createSeriesButtons(object sender, EventArgs e)
        {
            List<Serie> series = DBConnector.getSeries(this.langue);
            for (int i = 0; i < series.Count; i++)
            {
                int buttonWidth = 100;
                int marginLeft = 10;
                Size size = new Size(buttonWidth, 30);

                // Label for serie name 
                Label serieName = new Label();
                this.Controls.Add(serieName);
                serieName.Text = series[i].nom_serie;
                serieName.Location = new Point(marginLeft * 1 + buttonWidth * 0, 40 * i);
                serieName.Size = size;


                // Button for listing words 
                SerieButton listWordsButton = new SerieButton();
                this.Controls.Add(listWordsButton);
                listWordsButton.Text = "Lister";
                listWordsButton.Size = size;
                listWordsButton.Click += this.listWordsButtonClick;
                listWordsButton.serie = series[i];
                listWordsButton.Location = new Point(marginLeft * 2 + buttonWidth * 1, 40 * i);

                // Button for adding a word
                SerieButton addWordButton = new SerieButton();
                this.Controls.Add(addWordButton);
                addWordButton.Text = "Ajouter mot";
                addWordButton.Size = size;
                addWordButton.Click += this.addWordButtonClick;
                addWordButton.serie = series[i];
                addWordButton.Location = new Point(marginLeft * 3 + buttonWidth * 2, 40 * i);

                // Button for playing the serie 
                SerieButton playSerieButton = new SerieButton();
                this.Controls.Add(playSerieButton);
                playSerieButton.Text = "Jouer série";
                playSerieButton.Size = size;
                playSerieButton.Click += this.playSerieButton;
                playSerieButton.serie = series[i];
                playSerieButton.Location = new Point(marginLeft * 4 + buttonWidth * 3, 40 * i);
            }
        }

        private void playSerieButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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


    }
}
