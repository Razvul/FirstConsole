using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPWinForm
{
    public partial class Form1 : Form
    {
        private const string Corect = "CNP-ul este valid.";
        private const string Gresit = "CNP-ul este invalid.";
        private CNP Person;


        public Form1()
        {
            InitializeComponent();
            EnableAfiseazaButton(false);
        }

        private void button_Verifica_CNP_Click(object sender, EventArgs e)
        {
            if(Utilities.VerificaCNP(textBox_CNP.Text))
            {
                label_CNP_value.Text = Corect;
                EnableAfiseazaButton(true);
                Person = new CNP(textBox_CNP.Text);
            }
            else
            {
                label_CNP_value.Text = Gresit;
                EnableAfiseazaButton(false);
            }
        }

        private void button_Afiseaza_Click(object sender, EventArgs e)
        {
            label_Sex.Text = Person.Sex;
            label_An.Text = Person.An;
            label_Luna.Text = Person.Luna;
            label_Zi.Text = Person.Zi;
            EnableAfiseazaButton(false);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            ClearLabels();
        }

        private void ClearLabels()
        {
            label_CNP_value.Text = string.Empty;
            label_Sex.Text = string.Empty;
            label_An.Text = string.Empty;
            label_Luna.Text = string.Empty;
            label_Zi.Text = string.Empty;
        }
        private void ClearTextBox()
        {
            textBox_CNP.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearLabels();
        }

        private void EnableAfiseazaButton(bool value)
        {
            button_Afiseaza.Enabled = value;
        }

        private void textBox_CNP_MouseHover(object sender, EventArgs e)
        {
            ClearLabels();
        }
    }
}