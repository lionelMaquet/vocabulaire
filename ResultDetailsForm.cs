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
    public partial class ResultDetailsForm : Form
    {
        Playlist playlist;
        public ResultDetailsForm(Playlist playlist)
        {
            this.playlist = playlist;
            InitializeComponent();
            this.Shown += DisplayDetails;
            this.CenterToScreen();
        }

        private void DisplayDetails(object sender, EventArgs e)
        {
            int labelWidth = 100;
            int marginLeft = 10;
            Size size = new Size(labelWidth, 30);

           

            for (int i = 0; i < playlist.resultats.Count; i++)
            {
                Resultat currentResult = playlist.resultats[i];
                // Label mot à traduire
                Label MotATraduire = new Label();
                this.Controls.Add(MotATraduire);
                if (playlist.versFr)
                {
                    MotATraduire.Text = currentResult.mot.traduction;
                } else
                {
                    MotATraduire.Text = currentResult.mot.langue_fr;
                }
                
                MotATraduire.Location = new Point(marginLeft * 1 + labelWidth * 0, marginLeft + 40 * i);
                MotATraduire.Size = size;

                // Label traduction (réponse à donner)
                Label traduction = new Label();
                this.Controls.Add(traduction);
                if (playlist.versFr)
                {
                    traduction.Text = currentResult.mot.langue_fr;
                }
                else
                {
                    traduction.Text = currentResult.mot.traduction;
                }
                traduction.Location = new Point(marginLeft * 2 + labelWidth * 1, marginLeft + 40 * i);
                traduction.Size = size;

                // Label réponse
                Label reponse = new Label();
                this.Controls.Add(reponse);
                reponse.Text = currentResult.reponse;
                reponse.Location = new Point(marginLeft * 3 + labelWidth * 2, marginLeft + 40 * i);
                reponse.Size = size;
                if (currentResult.answeredRight)
                {
                    reponse.ForeColor = Color.Green;
                } else
                {
                    reponse.ForeColor = Color.Red;
                }

                // Label resultat
                Label resultat = new Label();
                this.Controls.Add(resultat);
                if (currentResult.answeredRight)
                {
                    resultat.ForeColor = Color.Green;
                    resultat.Text = "Correct";
                } else
                {
                    resultat.ForeColor = Color.Red;
                    resultat.Text = "Incorrect";
                }
                
                resultat.Location = new Point(marginLeft * 4 + labelWidth * 3, marginLeft + 40 * i);
                resultat.Size = size;

                this.Size = new Size( resultat.Right + marginLeft, resultat.Bottom + marginLeft + 20);
                
            }
        }

        
    }
}
