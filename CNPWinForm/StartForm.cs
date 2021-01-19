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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

        }

        private void button_Verifica_Click(object sender, EventArgs e)
        {
            var x = new Form1();
            x.Show();
        }

        private void button_Calculeaza_Click(object sender, EventArgs e)
        {
            var x = new Form2();
            x.Show();
        }
    }
}