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
    public partial class AddLanguageForm : Form
    {
        public AddLanguageForm()
        {
            InitializeComponent();
        }

        private void ButtonValidate_Click(object sender, EventArgs e)
        {
            string nomCourt = TextboxNomShort.Text;
            string nomLong = TextboxNomLong.Text;
            DBConnector.addLangue(nomCourt, nomLong);

            LanguagesForm newLanguagesForm = new LanguagesForm();
            newLanguagesForm.Show();
            this.Close();
        }
    }
}
