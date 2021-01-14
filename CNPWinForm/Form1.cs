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

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Verifica_CNP_Click(object sender, EventArgs e)
        {
            if(CNP.VerificaCNP(textBox_CNP.Text))
            {
                label_CNP_value.Text = Corect;
            }
            else
            {
                label_CNP_value.Text = Gresit;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            ClearLabels();
        }

        private void ClearLabels()
        {
            label_CNP_value.Text = string.Empty;
        }
        private void ClearTextBox()
        {
            textBox_CNP.Text = string.Empty;
        }
    }
}
