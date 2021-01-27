using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPWinForm
{
    public partial class Form2 : Form
    {
        private string Corect = "Corect";
        private string Gresit = "Gresit";

        public Form2()
        {
            InitializeComponent();
            button_Creaza.Enabled = false;
            ClearLabels();
        }

        private void button_Verifica_Click(object sender, EventArgs e)
        {
            if (Utilities.VerificaSexCNP(textBox_Sex_Input.Text))
            {
                label_Sex_Output.Text = Corect;
            }
            else
            {
                label_Sex_Output.Text = Gresit;
            }

            if(Utilities.VerificaAnCNP(textBox_An_Input.Text))
            {
                label_An_Output.Text = Corect;
            }
            else
            {
                label_An_Output.Text = Gresit;
            }

            if(Utilities.VerificaLunaCNP(textBox_Luna_Input.Text))
            {
                label_Luna_Output.Text = Corect;
            }
            else
            {
                label_Luna_Output.Text = Gresit;
            }

            if (Utilities.VerificaZiCNP(textBox_Zi_Input.Text, textBox_Luna_Input.Text, textBox_An_Input.Text))
            {
                label_Zi_Output.Text = Corect;
            }
            else
            {
                label_Zi_Output.Text = Gresit;
            }

            if (label_Sex_Output.Text == Corect &&
                label_An_Output.Text == Corect &&
                label_Luna_Output.Text == Corect &&
                label_Zi_Output.Text == Corect)
            {
                button_Creaza.Enabled = true;
            }
            else
            {
                button_Creaza.Enabled = false;
            }
        }

        private void button_Creaza_Click(object sender, EventArgs e)
        {
                ClearLabels();
                TextBoxesEnable(false);
                button_Verifica.Enabled = false;

                var Human = new CNPnew();

                Human.SEX = Utilities.GetSexCNP(textBox_Sex_Input.Text);
                Human.AN = Utilities.GetAnCNP(textBox_An_Input.Text);
                Human.LUNA = Utilities.GetLunaCNP(textBox_Luna_Input.Text);
                Human.ZI = Utilities.GetZiCNP(textBox_Zi_Input.Text);
                Human.JUDET = Utilities.GetJudet();
                Human.NNN = Utilities.GetNNN();
                Human.CC = Utilities.GetCC(Human);

                label_CNP_Output.Text = Human.GetCNP();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearLabels();
            ClearTextBox();
            TextBoxesEnable(true);
            button_Creaza.Enabled = false;
            button_Verifica.Enabled = true;
        }

        private void ClearLabels()
        {
            label_Sex_Output.Text = string.Empty;
            label_An_Output.Text = string.Empty;
            label_Luna_Output.Text = string.Empty;
            label_Zi_Output.Text = string.Empty;
            label_Judet_Output.Text = string.Empty;
            label_CNP_Output.Text = string.Empty;
        }

        private void ClearTextBox()
        {
            textBox_Sex_Input.Text = string.Empty;
            textBox_An_Input.Text = string.Empty;
            textBox_Luna_Input.Text = string.Empty;
            textBox_Zi_Input.Text = string.Empty;
            textBox_Judet_Input.Text = string.Empty;
        }

        private void TextBoxesEnable(bool value)
        {
            textBox_Sex_Input.Enabled = value;
            textBox_An_Input.Enabled = value;
            textBox_Luna_Input.Enabled = value;
            textBox_Zi_Input.Enabled = value;
            textBox_Judet_Input.Enabled = value;
        }
    }
}