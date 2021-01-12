using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirsrtWinForm
{
    public static class Utilities
    {
        public static bool IsNumber(string cuvant)
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

        public static double Numar(string cuvant)
        {
            var corect = double.TryParse(cuvant, out double numar);
            return numar;
        }


    }
}
