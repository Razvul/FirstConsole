using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirsrtWinForm
{
    public class Operatii
    {
        public double Numar1 { get; set; }
        public double Numar2 { get; set; }


        public double Adunare()
        {
            return Numar1 + Numar2;
        }

    }
}
