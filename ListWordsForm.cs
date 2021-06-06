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
        }

        private void createWordsLabels(object sender, EventArgs e)
        {
            List<Mot> mots = DBConnector.getWords(serie);

            int labelWidth = 100;
            int marginLeft = 10;
            Size size = new Size(labelWidth, 30);

            for (int i = 0; i < mots.Count; i++)
            {
                // Label langue fr
                Label langueFR = new Label();
                this.Controls.Add(langueFR);
                langueFR.Text = mots[i].langue_fr;
                langueFR.Location = new Point(marginLeft * 1 + labelWidth * 0, 40 * i);
                langueFR.Size = size;

                // Label traduction
                Label langueTrad = new Label();
                this.Controls.Add(langueTrad);
                langueTrad.Text = mots[i].traduction;
                langueTrad.Location = new Point(marginLeft * 2 + labelWidth * 1, 40 * i);
                langueTrad.Size = size;

                // Label stat
                Label stat = new Label();
                this.Controls.Add(stat);
                stat.Text = mots[i].getStats().ToString();
                stat.Location = new Point(marginLeft * 2 + labelWidth * 2, 40 * i);
                stat.Size = size;
            }
        }
    }
}
