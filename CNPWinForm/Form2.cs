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
        private CreateCNP Person;

        public Form2()
        {
            InitializeComponent();

        }

        // ceea ce ai facut aici este bine doar ca in clasa CreateCNP ai foarte multe functii 
        // noi avem nevoie de o clasa simpla doar cu datele de CNP cum este clasa "CNPnew"


        //private void button_Verifica_Click(object sender, EventArgs e)
        //{
        //    Person = new CreateCNP(textBox_Sex_Input.Text, textBox_An_Input.Text, textBox_Luna_Input.Text, textBox_Zi_Input.Text);

        //    label_Sex_Output.Text = Person.SEX;
        //    label_An_Output.Text = Person.AN;
        //    label_Luna_Output.Text = Person.LUNA;
        //    label_Zi_Output.Text = Person.ZI;
        //    label_Judet_Output.Text = Person.JUDET;
        //    label_CNP_Output.Text = Person.Rezultat;

        //    // verifica daca toate sunt corecte
        //    // daca nu sunt corecte => mesaj eroare


        //    Om.AN = Person.AN;
        //    //GetYear(textBox_An_Input.Text);
        //    Om.SEX = Person.SEX;
        //    //textBox_Sex_Input.Text;
        //    Om.LUNA = Person.LUNA;
        //    //textBox_Luna_Input.Text;
        //    Om.ZI = Person.ZI;
        //    //textBox_Zi_Input.Text;
        //    Om.JUDET = Person.JUDET;
        //    Om.NNN = GetNNN();
        //    Om.CC = GetCC(Om);
        //    label_CNP_Output.Text = Om.GetCNP();
        //}

        private void button_Verifica_Click(object sender, EventArgs e)
        {
            bool sex = true; // verifica sex

            var an = Utilities.VerificaAnCNP(textBox_An_Input.Text);

            bool luna = false; // verifica luna;

            // continua cu verificarile

            if (sex && an && luna) // adaua toate conditiile necesare. conditiile sa fie verificate 
            {
                // disable button verifica
                // disable textbox
                // enable button calculeaza
                return;
            }

            // afiseaza mesaj de eroare 
            

        }


        // in loc de functia asta trebuie sa fie un buton
        private void CreaareCNP()
        {
            CNPnew Om = new CNPnew();

            // Om.SEX = creaza functie in utilities

            //return $"{SEX}{AN}{LUNA}{ZI}{JUDET}{NNN}{CC}";
            //Om.SEX = "1";

            Om.AN = Utilities.GetAnCNP(textBox_An_Input.Text);

            // Om.LUNA = creaza functie in utilities
            // Om.ZI = creaza functie in utilities
            // creaza functiile in continuare 

            // creaza functiile NNN si CC in utilities
            // functiile astea le ai mai jos trebuie doar sa le muti in utilities
            // Om.NNN = GetNNN();
            // Om.CC = GetCC(Om);


        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClearLabels();
            ClearTextBox();
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

        private string GetNNN()
        {
            string nnn;
            var rnd = new Random();
            var x = rnd.Next(1, 1000);

            if (x < 10)
            {
                nnn = $"00{x}";
            }
            else if (x < 100)
            {
                nnn = $"0{x}";
            }
            else
            {
                nnn = x.ToString();
            }
            return nnn;
        }

        private string GetCC(CNPnew Om)
        {
            string temp, result;
            int[] constanta = new int[12] { 2, 7, 9, 1, 4, 6, 3, 5, 8, 2, 7, 9 };
            temp = $"{Om.SEX}{Om.AN}{Om.LUNA}{Om.ZI}{Om.JUDET}{Om.NNN}";

            var cifra = 0;
            string cifraControl;
            var suma = 0;

            for (
                int i = 0; i < constanta.Length; i++)
            {
                cifra = int.Parse(temp.Substring(i, 1));
                suma = suma + cifra + constanta[i];
            }

            if (suma % 11 == 10)
            {
                cifraControl = "1";
            }
            else
            {
                cifraControl = (suma % 11).ToString();
            }

            result = $"{temp}{cifraControl}";
            return cifraControl;
        }


    }
}