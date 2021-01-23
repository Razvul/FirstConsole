using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPWinForm
{
    public static class Utilities
    {
        public static bool VerificaCNP(string cnp_cuvant)
        {
            int[] cnp_numar = new int[13];
            int[] constanta = new int[12] { 2, 7, 9, 1, 4, 6, 3, 5, 8, 2, 7, 9 };

            if (string.IsNullOrEmpty(cnp_cuvant))
            {
                return false;
            }
            if (cnp_cuvant.Length != 13)
            {
                return false;
            }

            for (int i = 0; i < cnp_cuvant.Length; i++)
            {
                var x = cnp_cuvant.Substring(i, 1);

                if (IsInteger(x))
                {
                    cnp_numar[i] = int.Parse(x);
                }
                else
                {
                    return false;
                }
            }

            int suma = 0;
            int cifraControl = cnp_numar[cnp_numar.Length - 1];
            int result;

            for (int i = 0; i < constanta.Length; i++)
            {
                suma = suma + cnp_numar[i] * constanta[i];
            }
            if (suma % 11 == 10)
            {
                result = 1;
            }
            else
            {
                result = suma % 11;
            }

            if (result == cifraControl)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsInteger(string a)
        {
            var result = int.TryParse(a, out int cifra);
            return result;
        }

        public static bool VerificaAnCNP(string an)
        {
            var test = int.TryParse(an, out int anResult);

            if (test)
            {
                var currentYear = DateTime.Today.Year;

                if (anResult >= 1800 && anResult <= currentYear)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        public static string GetAnCNP(string an)
        {
            return an.Substring(2, 2);
        }
    }
}