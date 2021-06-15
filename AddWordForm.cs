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
    // Ce formulaire est présenté lorsque l'utilisateur souhaite ajouter un mot à une série
    public partial class AddWordForm : Form
    {
        Serie serie;
        public AddWordForm(Serie serie)
        {
            this.serie = serie;
            InitializeComponent();
        }

        private void button_valider_Click(object sender, EventArgs e)
        {
            // Insertion du mot dans la BDD via DBConnector
            string mot_fr = textbox_motFR.Text;
            string mot_traduction = textbox_traduction.Text;
            DBConnector.addWord(serie, mot_fr, mot_traduction);
            this.Close();
        }
    }
}
