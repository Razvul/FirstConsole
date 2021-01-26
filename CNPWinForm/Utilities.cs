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
        public static bool VerificaSexCNP(string sex)
        {
            bool result;
            switch (sex)
            {
                case "1":
                case "5":
                case "7":
                    result = true;
                    break;
                case "2":
                case "6":
                case "8":
                    result = true;
                    break;
                default:
                    result = false;
                    break;
            }
            return result;
        }

        public static string GetSexCNP(string sex)
        {
            string result;
            var ok = int.TryParse(sex, out int numar);

            if(ok)
            {
                if (numar >= 1 && numar <= 8)
                {
                    result = sex;
                }
                else
                {
                    result = null;
                }
            }
            else
            {
                result = null;
            }
            return result;
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

        public static bool VerificaLunaCNP(string luna)
        {
            bool result;
            var ok = int.TryParse(luna, out int numar);

            if (ok)
            {
                if (numar >= 1 && numar <= 12)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }
            
            return result;
        }

        public static string GetLunaCNP(string luna)
        {
            string result;
            var numar = int.Parse(luna);

            if (numar >= 1 && numar < 10)
            {
                var temp = numar.ToString();
                result = $"0{temp}";
            }
            else if (numar == 11 || numar == 12)
            {
                result = numar.ToString();
            }
            else
            {
                result = null;
            }
            return result;
        }

        public static bool VerificaZiCNP(string zi, string luna, string an)
        {
            bool result;
            var ok = int.TryParse(zi, out int ziNumar);
            var lunaNumar = int.Parse(luna);
            var anNumar = int.Parse(an);
            int zimax = 0;

            if(ok)
            {
                if(lunaNumar == 1 || lunaNumar == 3 || lunaNumar == 5 || lunaNumar == 7 || lunaNumar == 8 || lunaNumar == 10 || lunaNumar == 12)
                {
                    zimax = 31;
                }
                else if(lunaNumar == 4 || lunaNumar == 6 || lunaNumar == 9 || lunaNumar == 11)
                {
                    zimax = 30;
                }
                else
                {
                    if (anNumar % 4 == 0)
                    {
                        zimax = 29;
                    }
                    else
                    {
                        zimax = 28;
                    }
                }
                if (ziNumar >= 1 && ziNumar <= zimax)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static string GetZiCNP(string zi)
        {
            var numar = int.Parse(zi);

            if (numar > 0 && numar < 10)
            {
                return $"0{zi}";
            }
            else
            {
                return zi;
            }
        }

        public static string GetJudet()
        {
            return "07";
        }

        public static string GetNNN()
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

        public static string GetCC(CNPnew Om)
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