using System;
using System.Windows.Forms;

namespace CS161_Translator
{
    public partial class CS161_Translator : Form
    {
        public CS161_Translator()
        {
            InitializeComponent();
        }

        private void translateItalianButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buongiorno";
        }

        private void translateSpanishButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buenos Dias";
        }

        private void translateGermanButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Guten Morgen";
        }
    }
}
