using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPWinForm
{
    class CreateCNP
    {
        private string _sex;
        private string _an;
        private string _luna;
        private string _zi;

        #region Data Nastere

        public string SEX { get; private set; }
        public string AN { get; private set; }
        public string LUNA { get; private set; }
        public string ZI { get; private set; }
        public string JUDET { get; private set; }
        public string Rezultat { get; set; }

        #endregion

        public CreateCNP(string sex, string an, string luna, string zi)
        {
            _sex = sex;
            _an = an;
            _luna = luna;
            _zi = zi;
            Populate();
        }

        private void Populate()
        {
            SEX = GetSex();
            AN = GetYear();
            LUNA = GetMonth();
            ZI = GetDay();
            JUDET = GetJudet();
            Rezultat = CreazaCNP();
        }

        private string GetSex()
        {
            string sex;
            var x = _sex.ToLower().Trim();
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

        private string GetYear()
        {
            string result;
            //var numar = int.Parse(_an);
            //int temp = numar - 1900;
            result = _an.Substring(2, 2);
            //result = temp.ToString();
            return result;
        }

        private string GetMonth()
        {
            string result;
            switch (_luna.ToLower())
            {
                case "ianuarie":
                    result = "01";
                    break;
                case "februarie":
                    result = "02";
                    break;
                case "martie":
                    result = "03";
                    break;
                case "aprilie":
                    result = "04";
                    break;
                case "mai":
                    result = "05";
                    break;
                case "iunie":
                    result = "06";
                    break;
                case "iulie":
                    result = "07";
                    break;
                case "august":
                    result = "08";
                    break;
                case "septembrie":
                    result = "09";
                    break;
                case "octombrie":
                    result = "10";
                    break;
                case "noiembrie":
                    result = "11";
                    break;
                case "decembrie":
                    result = "12";
                    break;
                default:
                    result = "Wrong imput";
                    break;
            }
            return result;
        }

        private string GetDay()
        {
            string result;
            if (IsInteger(_zi))
            {
                var numar = int.Parse(_zi);
                if (numar > 31)
                {
                    result = "Wrong Input";
                }
                else
                {
                    result = numar.ToString();
                }
            }
            else
            {
                result = null;
            }
            return result;
        }

        private string GetJudet()
        {
            //string result = "Botosani";
            //if (cuvant == "Botosani")
            //{
            //    result = "07";
            //}
            //else
            //{
            //    result = null;
            //}
            return "07";
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


        public string CreazaCNP()
        {
            string temp, result;
            int[] constanta = new int[12] { 2, 7, 9, 1, 4, 6, 3, 5, 8, 2, 7, 9 };
            temp = $"{GetSex()}{GetYear()}{GetMonth()}{GetDay()}{GetJudet()}{GetNNN()}";

            var cifra = 0;
            string cifraControl;
            var suma = 0;

            for (int i = 0; i < constanta.Length; i++)
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
            return result;
        }

        public static bool IsInteger(string a)
        {
            var result = int.TryParse(a, out int cifra);
            return result;
        }
    }
}