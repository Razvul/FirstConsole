using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNP
{
    public class CnpTest2
    {
        #region Properties

        private readonly string _cnp;
        private const string ControlConstant = "279146358279";

        public int S { get; private set; }
        public int AA { get; private set; }
        public int LL { get; private set; }
        public int ZZ { get; private set; }
        public int JJ { get; private set; }
        public int NNN { get; private set; }
        public int C { get; private set; }
        private int CRecalculat { get; set; }

        public string Sex { get; private set; }
        public string An { get; private set; }
        public string Luna { get; private set; }
        public string Zi { get; private set; }
        public string Judet { get; private set; }

        public bool IsValidCnp { get; }

        #endregion


        #region Constructor

        public CnpTest2(string cnp)
        {
            _cnp = cnp.Trim();
            IsValidCnp = Verify();
        }


        #endregion



        private bool Verify()
        {
            // verifica lungime CNP
            if (_cnp.Length != 13) 
            {
                return false;
            }

            // variable for given control number
            int controlNumber;

            try
            {

                // METHOD 1
                controlNumber = Convert.ToInt32(_cnp.Substring(12), 10);

                // METHOD 2
                //CDat = int.Parse(cnp.Substring(12, 1));


                var sum = 0;
                for (var i = 0; i < 12; ++i)
                {
                    // METHOD 1
                    //This works because each character is internally represented by a number.
                    //The characters '0' to '9' are represented by consecutive numbers,
                    //so finding the difference between the characters '0' and '2' results in the number 2.
                    int cifra1 = _cnp[i] - '0';
                    int cifra2 = ControlConstant[i] - '0';

                    // METHOD 2
                    //int cifra1 = int.Parse(_cnp[i].ToString());
                    //int cifra2 = int.Parse(_controlConstant[i].ToString());

                    // METHOD 3
                    //int cifra1 = int.Parse(_cnp.Substring(i, 1));
                    //int cifra2 = int.Parse(_controlConstant.Substring(i, 1));

                    int produs = cifra1 * cifra2;
                    sum += produs;
                }

                if (sum % 11 == 10)
                {
                    CRecalculat = 1;
                }
                else
                {
                    CRecalculat = sum % 11;
                }

                // Acelsi lucru scris mai sus
                //if (CRecalculat == CDat)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            if (CRecalculat == controlNumber)
            {
                PopulateCnp();
                PopulateCnpString();
                return true;
            }

            return false;
        }



        private void PopulateCnp()
        {
            S = Convert.ToInt32(_cnp.Substring(0, 1));
            AA = Convert.ToInt32(_cnp.Substring(1, 2));
            LL = Convert.ToInt32(_cnp.Substring(3, 2));
            ZZ = Convert.ToInt32(_cnp.Substring(5, 2));
            JJ = Convert.ToInt32(_cnp.Substring(7, 2));
            NNN = Convert.ToInt32(_cnp.Substring(9, 3));
            C = Convert.ToInt32(_cnp.Substring(12, 1));
        }


        private void PopulateCnpString()
        {
            Sex = GetSexFromNumber(S);
            An = GetAnFromNumber(S,AA);
            Luna = GetLunaFromNumber(LL);
            Zi = ZZ.ToString();
            Judet = GetJudetFromNumber(JJ);
        }



        private static string GetSexFromNumber(int sexNumber)
        {
            string sex;

            if (sexNumber == 1 || sexNumber == 3 || sexNumber == 5 || sexNumber == 7)
            {
                sex = "masculin";
            }
            else
            {
                sex = "feminin";
            }

            return sex;
        }

        private static string GetAnFromNumber(int sexNumber, int anNumber)
        {
            string anulNasterii = "n/a";

            switch (sexNumber)
            {
                case 1:
                case 2:
                    // nascut intre 1 ianuarie 1900 si 31 decembrie 1999
                    anulNasterii = $"19{anNumber}";
                    break;
                case 3:
                case 4:
                    // nascut intre 1 ianuarie 1800 si 31 decembrie 1899
                    anulNasterii = $"18{anNumber}";
                    break;
                case 5:
                case 6:
                    // nascut intre 1 ianuarie 2000 si 31 decembrie 2099
                    anulNasterii = $"20{anNumber}";
                    break;
                case 7:
                case 8:
                    anulNasterii = "Persoana straina rezidenta in Romania";
                    break;
            }

            return anulNasterii;
        }


        private static string GetLunaFromNumber(int lunaNumber)
        {
            string luna;
            switch (lunaNumber)
            {
                case 1:
                    luna = "ianuarie";
                    break;
                case 2:
                    luna = "februarie";
                    break;
                case 3:
                    luna = "martie";
                    break;
                case 4:
                    luna = "aprilie";
                    break;
                case 5:
                    luna = "mai";
                    break;
                case 6:
                    luna = "iunie";
                    break;
                case 7:
                    luna = "iulie";
                    break;
                case 8:
                    luna = "august";
                    break;
                case 9:
                    luna = "septembrie";
                    break;
                case 10:
                    luna = "octombrie";
                    break;
                case 11:
                    luna = "noiembrie";
                    break;
                case 12:
                    luna = "decembrie";
                    break;
                default:
                    luna = "luna necunoscuta";
                    break;
            }
            return luna;
        }



        private static string GetJudetFromNumber(int judetNumber)
        {
            string cod = judetNumber >= 10
                ? judetNumber.ToString()
                : $"0{judetNumber}";

            // Copy-Paste la tabelul din pagina Wikipedia CNP
            string coduri = @"
                  01  Alba
                  02  Arad
                  03  Argeș
                  04  Bacău
                  05  Bihor
                  06  Bistrița – Năsăud
                  07  Botoșani
                  08  Brașov
                  09  Brăila
                  10  Buzău
                  11  Caraș – Severin
                  12  Cluj
                  13  Constanța
                  14  Covasna
                  15  Dâmbovița
                  16  Dolj
                  17  Galați
                  18  Gorj
                  19  Harghita
                  20  Hunedoara
                  21  Ialomița
                  22  Iași
                  23  Ilfov
                  24  Maramureș
                  25  Mehedinți
                  26  Mureș
                  27  Neamț
                  28  Olt
                  29  Prahova
                  30  Satu Mare
                  31  Sălaj
                  32  Sibiu
                  33  Suceava
                  34  Teleorman
                  35  Timiș
                  36  Tulcea
                  37  Vaslui
                  38  Vâlcea
                  39  Vrancea
                  40  București
                  41  București – Sector 1
                  42  București – Sector 2
                  43  București – Sector 3
                  44  București – Sector 4
                  45  București – Sector 5
                  46  București – Sector 6
                  51  Călărași
                  52  Giurgiu";

            try
            {
                // split imi divide string intr-un array de string dupa separator "\n"
                // vezi in debug ce vine salvat in arrayCoduri
                string[] arrayCoduri = coduri.Split('\n');

                // aici selectez pozitia in arrayCoduri si o salvez in judetComplet
                // rezultatu este ceva de genul => "07 Botosani"
                string judetComplet = arrayCoduri[judetNumber];

                // split imi divide string "judetComplet" intr-un array de string dupa separator " " (spatiu)
                // vezi in debug ce vine salvat in judetSelectionatArray
                // trebuie sa fie ceva de genul:
                // [0] 07
                // [1] Botosani\r
                string[] judetSelectionatArray = judetComplet.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);

                // selectionez array pozitie 1 pentru a salva judetul
                // fuctia Trim() de la sfarsit imi sterge toate spatiile daca sunt prezente 
                // in cazul nostru \r
                string judet = judetSelectionatArray[1].Trim();


                // acelasi lucru scris intr-o singura linie

                //string judet = coduri.Split('\n')[judetNumber].Split(new string[] { "  " },
                //        StringSplitOptions.RemoveEmptyEntries)[1].Trim();
                
                return judet;
            }
            catch (Exception)
            {
                return "";
            }
        }



        public override string ToString()
        {
            CnpTest2 a = this;

            return a.IsValidCnp
                ? $@"
                    CNP: { a._cnp}
                    S: { a.S}
                    AA:: { a.AA}
                    LL: { a.LL}
                    ZZ: { a.ZZ}
                    JJ: { a.JJ}
                    NNN: { a.NNN}
                    C dat: { a.C}, C recalculat: { a.CRecalculat}
                    Sex: { a.Sex}
                    Anul Nasterii: { a.An}
                    Luna: { a.Luna}
                    Judet: { a.Judet}"
                : "CNP invalid.";
        }
    }
}
