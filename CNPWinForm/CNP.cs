using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPWinForm
{
    public class CNP
    {
        private string _cnp;

        #region Proprietati

        private int SS;
        private int AA;
        private int LL;
        private int ZZ;
        private int JJ;
        private int NNN;
        private int CC;

        public string Sex { get; private set; }
        public string An { get; private set; }
        public string Luna { get; private set; }
        public string Zi { get; private set; }
        public string Judet { get; private set; }

        #endregion


        #region Constructor
        public CNP(string cnp)
        {
            _cnp = cnp;
            Populate();
            Populate2();
        }
        #endregion

        private void Populate()
        {
            SS = int.Parse(_cnp.Substring(0, 1));

            AA = int.Parse(_cnp.Substring(1, 2));

            LL = int.Parse(_cnp.Substring(3, 2));

            ZZ = int.Parse(_cnp.Substring(5, 2));

            JJ = int.Parse(_cnp.Substring(7, 2));

            NNN = int.Parse(_cnp.Substring(9, 3));

            CC = int.Parse(_cnp.Substring(12, 1));
        }

        private void Populate2()
        {
            Sex = GetSexFromNumber(SS);
            An = GetYearFromNumber(SS,AA);
            Luna = GetMonthFromNumber(LL);
            Zi = GetDayFromNumber(ZZ);
        }

        private string GetSexFromNumber(int sexNumber)
        {
            string result;
            switch(sexNumber)
            {
                case 1:
                case 3:
                case 5:
                case 7: 
                    result = "Masculin";
                    break;
                case 2:
                case 4:
                case 6:
                case 8: 
                    result = "Feminin";
                    break;
                default:
                    result = "Sex necunoscut";
                    break;
            }
            return result;
        }

        private string GetYearFromNumber(int sexNumber, int yearNumber)
        {
            string result;
            switch(sexNumber)
            {
                case 1:
                case 2:
                    result = $"19{yearNumber}";
                    break;
                case 5:
                case 6:
                    result = $"20{yearNumber}";
                    break;
                case 3:
                case 4:
                    result = $"18{yearNumber}";
                    break;
                default:
                    result = "Nu se stie cand s-a nascut";
                    break;
            }
            return result;
        }

        private string GetMonthFromNumber(int monthNumber)
        {
            string result;
            switch(monthNumber)
            {
                case 1:
                    result = "Ianuarie";
                    break;
                case 2:
                    result = "Februarie";
                    break;
                case 3:
                    result = "Martie";
                    break;
                case 4:
                    result = "Aprilie";
                    break;
                case 5:
                    result = "Mai";
                    break;
                case 6:
                    result = "Iunie";
                    break;
                case 7:
                    result = "Iulie";
                    break;
                case 8:
                    result = "August";
                    break;
                case 9:
                    result = "Septembrie";
                    break;
                case 10:
                    result = "Octombrie";
                    break;
                case 11:
                    result = "Noiembrie";
                    break;
                case 12:
                    result = "Decembrie";
                    break;
                default:
                    result = "Wrong input";
                    break;
            }
            return result;
        }

        private string GetDayFromNumber(int dayNumber)
        {
            string result = dayNumber.ToString();
            return result;
        }


    }
}