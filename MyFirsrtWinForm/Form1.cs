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


        private void button_Send_Click(object sender, EventArgs e)
        {
            label_message.Text = CiaoMessage(textBox_name.Text);
        }

        private string CiaoMessage(string name)
        {
            return $"Ciao {name}";
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            label_message.Text = string.Empty;
            textBox_name.Text = string.Empty;
        }
    }
}
