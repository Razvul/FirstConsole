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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string GetSex(string cuvant)
        {
            GetNNN();
            string sex;
            var x = cuvant.ToLower().Trim();
            if (x == "masculin")
            {
                sex = "1";
            }
            else if (x == "feminin")
            {
                sex = "2";
            }
            else
            {
                sex = null;
            }
            return sex;
        }

        //private string GetYear(string cuvant)
        //{
        //    // substring(1987)
        //    // 2001
        //}

        //private string GetMonth(string cuvant)
        //{

        //}

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

        private void button_Creaza_Click(object sender, EventArgs e)
        {            
            label_Debug.Text = GetSex(textBox_Sex_Input.Text);
        }

    }
}
