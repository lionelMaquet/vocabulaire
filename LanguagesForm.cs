using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExamenProgrammation
{

    public partial class LanguagesForm : Form
    {
        public LanguagesForm()
        {
            InitializeComponent();
            this.Shown += createLanguagesButtons;
        }


        public void createLanguagesButtons(object sender, EventArgs e)
        {
            List<Langue> languages = DBConnector.getLanguages();

            for (int i = 0; i < languages.Count; i++)
            {
                LanguageButton newButton = new LanguageButton();
                this.Controls.Add(newButton);
                newButton.Text = languages[i].nom_long;
                newButton.Location = new Point(70, 40 * i);
                newButton.Size = new Size(100, 30);
                newButton.Click += this.language_button_click;
                newButton.langue = languages[i];


                AddSerieButton addSerieButton = new AddSerieButton();
                addSerieButton.langue = languages[i];
                this.Controls.Add(addSerieButton);
                addSerieButton.Text = "Ajouter une série";
                addSerieButton.Location = new Point(150, 40 * i);
                addSerieButton.Size = new Size(100, 30);
                addSerieButton.Click += this.addSerieButtonClick;
            }
        }

        private void addSerieButtonClick(object sender, EventArgs e)
        {
            AddSerieForm addSerieForm = new AddSerieForm((sender as AddSerieButton).langue);
            addSerieForm.Show();
        }

        public void language_button_click(object sender, EventArgs e)
        {
            SeriesForm seriesForm = new SeriesForm((sender as LanguageButton).langue, this);
            this.Hide();
            seriesForm.Show();
        }

        private void ButtonAddLanguage_Click(object sender, EventArgs e)
        {
            AddLanguageForm newAddLanguageForm = new AddLanguageForm();
            newAddLanguageForm.Show();
            this.Hide();
        }
    }
}
