using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNP
{
    public class CnpTest
    {
        private readonly string _cnp;

        public CnpTest(string cnp)
        {
            _cnp = cnp;
        }

        public string Verifica()
        {
            string msg = $"{_cnp} -> CNP valid";

            int[] c = new int[13];

            if (string.IsNullOrEmpty(_cnp) || _cnp.Trim().Length != 13)
            {
                msg = "Codul numeric personal nu are 13 cifre!";
                return msg;
            }

            if (_cnp.Trim() == "0000000000000")
            {
                msg = "Cod numeric personal eronat. Verificati CNP-ul persoanei!";
                return msg;
            }

            for (int i = 0; i <= 12; i++)
            {
                try
                {
                    c[i] = Convert.ToInt32(_cnp.Substring(i, 1));
                }
                catch (Exception)
                {
                    return "Codul numeric personal eronat. Verificati CNP-ul persoanei!";
                }

            }

            // constanta de control este 279146358279

            int sum =
                c[0] * 2 +
                c[1] * 7 +
                c[2] * 9 +
                c[3] * 1 +
                c[4] * 4 +
                c[5] * 6 +
                c[6] * 3 +
                c[7] * 5 +
                c[8] * 8 +
                c[9] * 2 +
                c[10] * 7 +
                c[11] * 9;

            int control = sum % 11;

            if (control == 10)
            {
                control = 1;
            }

            if (control != c[12])
            {
                msg = "Cod numeric personal eronat. Verificati CNP-ul persoanei!";

                return msg;
            }

            return msg;
        }
    }
}
