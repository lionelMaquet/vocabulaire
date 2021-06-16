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
    public partial class ListWordsForm : Form
    {
        Serie serie;
        public ListWordsForm(Serie serie)
        {
            this.serie = serie;
            InitializeComponent();
            this.Shown += createWordsLabels;
            this.CenterToScreen();
        }

        private void createWordsLabels(object sender, EventArgs e)
        {
            List<Mot> mots = DBConnector.getWords(serie);

            int labelWidth = 100;
            int marginLeft = 10;
            Size size = new Size(labelWidth, 30);

            // Création des titres

            // titre langue fr
            Label titreLangueFR = new Label();
            this.Controls.Add(titreLangueFR);
            titreLangueFR.Text = "Français";
            titreLangueFR.Location = new Point(Display.leftMargin + marginLeft * 1 + labelWidth * 0, 40 );
            titreLangueFR.Size = size;
            titreLangueFR.Font = new Font(titreLangueFR.Font, FontStyle.Bold);

            // titre traduction
            Label titreLangueTrad = new Label();
            this.Controls.Add(titreLangueTrad);
            titreLangueTrad.Text = "Traduction";
            titreLangueTrad.Location = new Point(Display.leftMargin + marginLeft * 2 + labelWidth * 1, 40);
            titreLangueTrad.Size = size;
            titreLangueTrad.Font = new Font(titreLangueTrad.Font, FontStyle.Bold);

            // titre stat
            Label titreStat = new Label();
            this.Controls.Add(titreStat);
            titreStat.Text = "Taux de réussite";
            titreStat.Location = new Point(Display.leftMargin + marginLeft * 2 + labelWidth * 2, 40);
            titreStat.Size = size;
            titreStat.Font = new Font(titreStat.Font, FontStyle.Bold);

            for (int i = 0; i < mots.Count; i++)
            {
                
                
                    // Label langue fr
                    Label langueFR = new Label();
                    this.Controls.Add(langueFR);
                    langueFR.Text = mots[i].langue_fr;
                    langueFR.Location = new Point(Display.leftMargin + marginLeft * 1 + labelWidth * 0, 40 * (i + 2) );
                    langueFR.Size = size;

                    // Label traduction
                    Label langueTrad = new Label();
                    this.Controls.Add(langueTrad);
                    langueTrad.Text = mots[i].traduction;
                    langueTrad.Location = new Point(Display.leftMargin + marginLeft * 2 + labelWidth * 1, 40 * (i+2));
                    langueTrad.Size = size;

                    // Label stat
                    Label stat = new Label();
                    this.Controls.Add(stat);
                    stat.Text = $"{ mots[i].getStats().ToString()}%";
                    stat.Location = new Point(Display.leftMargin + marginLeft * 2 + labelWidth * 2, 40 * (i+2));
                    stat.Size = size;
                
                    
                
            }

            this.Size = new Size(titreStat.Right + Display.leftMargin, 40 * (mots.Count + 3));
        }
    }
}
