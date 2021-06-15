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
            string nomSerie = TextboxSerieName.Text;
            DBConnector.addSerie(langue, nomSerie);
            this.Close();
        }
    }
}
