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
    // Ce formulaire est présenté lorsque l'utilisateur souhaite ajouter une langue à l'application
    public partial class AddLanguageForm : Form
    {
        public AddLanguageForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ButtonValidate_Click(object sender, EventArgs e)
        {
            // Ajout de la langue à la BDD
            string nomCourt = TextboxNomShort.Text;
            string nomLong = TextboxNomLong.Text;
            DBConnector.addLangue(nomCourt, nomLong);

            // On représente ensuite le formulaire listant les langues
            LanguagesForm newLanguagesForm = new LanguagesForm();
            newLanguagesForm.Show();
            this.Close();
        }
    }
}
