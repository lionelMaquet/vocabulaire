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
            }
        }

        public void language_button_click(object sender, EventArgs e)
        {
            SeriesForm seriesForm = new SeriesForm((sender as LanguageButton).langue);
            this.Hide();
            seriesForm.Show();
        }
    }
}
