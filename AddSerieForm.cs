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
    // Ce formulaire est présenté à l'utilisateur pour introduire une nouvelle série dans une langue
    public partial class AddSerieForm : Form
    {
        Langue langue;
        public AddSerieForm(Langue langue)
        {
            this.langue = langue;
            InitializeComponent();
        }

        private void ButtonValidate_Click(object sender, EventArgs e)
        {
            // Insertion de la série dans la BDD via le DBConnector
            string nomSerie = TextboxSerieName.Text;
            DBConnector.addSerie(langue, nomSerie);
            this.Close();
        }
    }
}
