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
    // Ce formulaire présente à l'utilisateur toutes les langues disponibles
    public partial class LanguagesForm : Form
    {
        public LanguagesForm()
        {
            InitializeComponent();
            
            this.Shown += createLanguagesButtons;
            this.CenterToScreen();
        }


        public void createLanguagesButtons(object sender, EventArgs e)
        {
            
            List<Langue> languages = DBConnector.getLanguages();

            for (int i = 0; i < languages.Count; i++)
            {
                LanguageButton newButton = new LanguageButton();
                this.Controls.Add(newButton);
                newButton.Text = languages[i].nom_long;
                newButton.Location = new Point(Display.leftMargin, 20 + 40 * i);
                newButton.Size = Display.smallButtonSize;
                newButton.Click += this.language_button_click;
                newButton.langue = languages[i];

                AddSerieButton addSerieButton = new AddSerieButton();
                addSerieButton.langue = languages[i];
                this.Controls.Add(addSerieButton);
                addSerieButton.Text = "Ajouter une série";
                addSerieButton.Location = new Point(Display.leftMargin + Display.leftButtonMargin + Display.smallButtonSize.Width,20 + 40 * i);
                addSerieButton.Size = Display.smallButtonSize;
                addSerieButton.Click += this.addSerieButtonClick;

                this.Size = new Size(340, languages.Count * (Display.bigButtonSize.Height + 40) + Display.topOffSet);
            }

            ButtonAddLanguage.Size = new Size(220,Display.bigButtonSize.Height) ;
            ButtonAddLanguage.Location = new Point(50, languages.Count * 40 + Display.topOffSet);

            this.Size = new Size(ButtonAddLanguage.Right + 50, ButtonAddLanguage.Bottom + 50);
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
