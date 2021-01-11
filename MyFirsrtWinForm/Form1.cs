using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirsrtWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button_Calculeaza_Click(object sender, EventArgs e)
        {
            label_Adunare.Text = Adunare(Numar(textBox_Numar1.Text), Numar(textBox_Numar2.Text)).ToString();

            label_Scadere.Text = Scadere(Numar(textBox_Numar1.Text), Numar(textBox_Numar2.Text)).ToString();

            label_Inmultire.Text = Inmultire(Numar(textBox_Numar1.Text), Numar(textBox_Numar2.Text)).ToString();

            label_Impartire.Text = Impartire(Numar(textBox_Numar1.Text), Numar(textBox_Numar2.Text)).ToString();
        }

        private void button_Verifica_Click(object sender, EventArgs e)
        {
            if (IsNumber(textBox_Numar1.Text))
            {
                label_Check1.Text = "Corect";
            }
            else
            {
                label_Check1.Text = "What the !@#$ is this? This ain't no number!";
            }

            if (IsNumber(textBox_Numar2.Text))
            {
                label_Check2.Text = "Corect";
            }
            else
            {
                label_Check2.Text = "What the !@#$ is this? This ain't no number!";
            }
        }

        private static string Adunare(double numar1, double numar2)
        {
            var suma = numar1 + numar2;
            return $"Suma este: {suma.ToString()}";
        }

        private static string Scadere(double numar1, double numar2)
        {
            var diferenta = numar1 - numar2;
            return $"Diferenta este: {diferenta.ToString()}";
        }

        private static string Inmultire(double numar1, double numar2)
        {
            var produs = numar1 * numar2;
            return $"Produsul este: {produs.ToString()}";
        }

        private static string Impartire(double numar1, double numar2)
        {
            if(numar2==0)
            {
                return "Nu poti imparti la 0";
            }
            var cat = numar1 / numar2;
            return $"Catul este: {cat.ToString()}";
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Numar1.Text = string.Empty;
            textBox_Numar2.Text = string.Empty;
            label_Adunare.Text = string.Empty;
            label_Scadere.Text = string.Empty;
            label_Inmultire.Text = string.Empty;
            label_Impartire.Text = string.Empty;
            label_Check1.Text = string.Empty;
            label_Check2.Text = string.Empty;
        }

        private bool IsNumber(string cuvant)
        {
            int count = 0;
            string temp = cuvant.Replace(',', '.');

            for (int i = 0; i < temp.Length; i++)
            {
                var x = temp.Substring(i, 1);

                if (x == ".")
                {
                    count++;
                }
            }

            if (count > 1)
            {
                return false;
            }

            var result = double.TryParse(cuvant, out double corect);
            return result;
        }

        private double Numar(string cuvant)
        {
            var corect = double.TryParse(cuvant, out double numar);
            return numar;
        }
    }
}
