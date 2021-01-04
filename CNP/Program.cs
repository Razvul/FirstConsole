using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNP
{
    class Program
    {
        // TODO: LASA SPATII INTRE FUNCTII !!!

        static void Main()
        {
            Console.WriteLine("Introduceti CNP:");
            string cuvant = Console.ReadLine();

            if(VerificaCNP(cuvant))
            {
                Console.WriteLine("CNP este valid");
            }
            else
            {
                Console.WriteLine("CNP nu este valid");

                // punem return aici ca sa nu mergem mai departe

                return;

            }

            // in punctul asta stii sigur ca CNP introus este valid
            // si eset facut doar di numere intregi 
            // deci in functia "Gender" nu trebuie sa mai calculezi nimic
            if (Gender(cuvant) == "Male")
            {
                Console.WriteLine("Persoana este de sexul masculin");
            }
            else
            {
                Console.WriteLine("Persoana este de sexul feminin");
            }

            // nu trebuie sa calculezi nimic nici pt celelalte functii pentru
            // doar trebuie sa iei substring corect si sa il transferi in "int" pentru a face switch 

            Console.WriteLine($"Persoana este nascuta in anul {AnulNasterii(cuvant)}");
            Console.WriteLine($"Persoana este nascuta in luna {LunaNasterii(cuvant)}");
            Console.WriteLine($"Persoana este nascuta in ziua {ZiuaNasterii(cuvant)}");


            Console.WriteLine("\n\n");
            Console.WriteLine("*****************");
            Console.WriteLine($"Persoana este de sexul {Gender1(cuvant)}");
            Console.WriteLine($"Persoana este nascuta in anul {AnulNasterii1(cuvant)}");
            Console.WriteLine($"Persoana este nascuta in luna {LunaNasterii1(cuvant)}");
            Console.WriteLine($"Persoana este nascuta in ziua {ZiuaNasterii(cuvant)}");


            #region Solutie Andrei
            //if (string.IsNullOrEmpty(cuvant))
            //{
            //    NotValidCNPError();
            //}
            //else
            //{
            //    CnpTest2 cnp = new CnpTest2(cuvant);

            //    if (cnp.IsValidCnp)
            //    {
            //        Console.WriteLine("\n\n");
            //        Console.WriteLine("*****************");
            //        Console.WriteLine(cnp.ToString());
            //    }
            //    else
            //    {
            //        NotValidCNPError();
            //    }
            //}

            Console.ReadKey();

            #endregion

        }

        #region Solutie Andrei
        private static void NotValidCNPError()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("*****************");
            Console.WriteLine("CNP nu este valid");
        }
        #endregion


        private static bool VerificaCNP(string cuvant)
        {
            if (string.IsNullOrEmpty(cuvant))
            {
                return false;
            }

            if (cuvant.Length != 13)
            {
                return false;
            }

            int[] cnp = new int[13];

            for (int i = 0; i < cuvant.Length; i++)
            {
                var x = cuvant.Substring(i, 1);

                if (IsNumber(x))
                {
                    cnp[i] = int.Parse(x);
                }
                else
                {
                    return false;
                }
            }

            int[] constanta = new int[12] { 2, 7, 9, 1, 4, 6, 3, 5, 8, 2, 7, 9 };
            int suma = 0;
            int cifraControl = cnp[cnp.Length - 1];
            int result = 0;
            Console.WriteLine(cifraControl);

            for (int i = 0; i < constanta.Length; i++)
            {
                suma = suma + cnp[i] * constanta[i];
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
        public static bool IsNumber(string cuvant)
        {
            //for (int i = 0; i < cuvant.Length; i++)
            //{
            //    var x = cuvant.Substring(i, 1);

            //    if (IsNumber(x))
            //    {
            //        cnp[i] = int.Parse(x);
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            var result = int.TryParse(cuvant, out int corect);
            return result;
        }

        private static int Numeric(string cuvant)
        {
            var result = int.TryParse(cuvant, out int corect);
            return corect;
        }

        private static string Gender(string cuvant)
        {
            int[] cnp = new int[13];
            for (int i = 0; i < cuvant.Length; i++)
            {
                var x = cuvant.Substring(i, 1);
                cnp[i] = int.Parse(x);
            }
            string gender;
            switch(cnp[0])
            {
                case 1:
                case 5: return gender = "Male";
                case 2:
                case 6: return gender = "Female";
                default: return "False";
            }
        }

        private static string Gender1(string cuvant)
        {
            // cum ziceam, in momentul cand funcia asta este chiamata 
            // in "cuvant" am un o string fromata din 13 int 

            // luam prima cifra din CNP si trasformam in int
            // in modul asta o sa ne ajute in switch
            int sex = int.Parse(cuvant.Substring(0, 1));

            
            string gender;

            // deoarece stim ca in "cuvant" avem doar numere corecte
            // putem sa folosim "default" din switch ca si un else (nu este consiliat)

            switch (sex)
            {
                case 1:
                case 3:
                case 5: 
                case 7:
                    gender = "masculin";
                    break;
                default:
                    gender = "feminin";
                    break;
            }

            // METHOD 2

            //if (sex == 1 || sex == 3 || sex == 5 || sex == 7)
            //{
            //    gender = "masculin";
            //}
            //else
            //{
            //    gender = "feminin";
            //}

            return gender;
        }

        private static int AnulNasterii(string cuvant)
        {
            var x = cuvant.Substring(1, 2);
            int deceniu = int.Parse(x);
            int an = 1900 + deceniu;
            return an;
            //int[] cnp = new int[13];
            //for (int i = 0; i < cuvant.Length; i++)
            //{
            //    
            //    cnp[i] = int.Parse(x);
            //}

        }

        private static string AnulNasterii1(string cuvant)
        {
            // anul nasterii se calculeaza in functie de 2 parametri
            // prima cifra (sex) si anul propriuzis (cifra 2 si 3)

            // COPIAT DE PE WIKIPEDIA

            /*
            Componenta S reprezintă sexul și secolul în care s-a născut persoana 
            și poate avea una dintre următoarele valori:

            1 pentru persoanele de sex masculin născute între anii 1900 - 1999
            2 pentru persoanele de sex feminin născute între anii 1900 - 1999
            3 pentru persoanele de sex masculin născute între anii 1800 - 1899
            4 pentru persoanele de sex feminin născute între anii 1800 - 1899
            5 pentru persoanele de sex masculin născute între anii 2000 - 2099
            6 pentru persoanele de sex feminin născute între anii 2000 - 2099
            7 pentru persoanele rezidente, de sex masculin
            8 pentru persoanele rezidente, de sex feminin

            */


            int sex = int.Parse(cuvant.Substring(0, 1));
            int an = int.Parse(cuvant.Substring(1, 2));


            string anulNasterii = "n/a";

            switch (sex)
            {
                case 1:
                case 2:
                    // nascut intre 1 ianuarie 1900 si 31 decembrie 1999
                    anulNasterii = $"19{an}";
                    break;
                case 3:
                case 4:
                    // nascut intre 1 ianuarie 1800 si 31 decembrie 1899
                    anulNasterii = $"18{an}";
                    break;
                case 5:
                case 6:
                    // nascut intre 1 ianuarie 2000 si 31 decembrie 2099
                    anulNasterii = $"20{an}";
                    break;
                case 7:
                case 8:
                    anulNasterii = "Persoana straina rezidenta in Romania";
                    break;
            }

            return anulNasterii;
        }

        private static string LunaNasterii(string cuvant)
        {
            var x = cuvant.Substring(3, 2);
            int luna_numar = int.Parse(x);
            string luna_cuvant;

            switch(luna_numar)
            {
                case 1:
                    luna_cuvant = "ianuarie";
                    break;
                case 2:
                    luna_cuvant = "februarie";
                    break;
                case 3:
                    luna_cuvant = "martie";
                    break;
                case 4:
                    luna_cuvant = "aprilie";
                    break;
                case 5:
                    luna_cuvant = "mai";
                    break;
                case 6:
                    luna_cuvant = "iunie";
                    break;
                case 7:
                    luna_cuvant = "iulie";
                    break;
                case 8:
                    luna_cuvant = "august";
                    break;
                case 9:
                    luna_cuvant = "septembrie";
                    break;
                case 10:
                    luna_cuvant = "octombrie";
                    break;
                case 11:
                    luna_cuvant = "noiembrie";
                    break;
                case 12:
                    luna_cuvant = "decembrie";
                    break;
                default:
                    luna_cuvant = "luna necunoscuta";
                    break;
            }

            return luna_cuvant;
        }

        private static string LunaNasterii1(string cuvant)
        {
            var x = cuvant.Substring(3, 2);
            int luna_numar = int.Parse(x);
            string luna_cuvant;
            switch (luna_numar)
            {
                case 1: return luna_cuvant = "Ianuarie";
                case 2: return luna_cuvant = "Februarie";
                case 3: return luna_cuvant = "Martie";
                case 4: return luna_cuvant = "Aprilie";
                case 5: return luna_cuvant = "Mai";
                case 6: return luna_cuvant = "Iunie";
                case 7: return luna_cuvant = "Iulie";
                case 8: return luna_cuvant = "August";
                case 9: return luna_cuvant = "Septembrie";
                case 10: return luna_cuvant = "Octombrie";
                case 11: return luna_cuvant = "Noiembrie";
                case 12: return luna_cuvant = "Decembrie";
                default: return luna_cuvant = "Luna gresita";
            }
        }

        private static int ZiuaNasterii(string cuvant)
        {
            var x = cuvant.Substring(5, 2);
            int ziua = int.Parse(x);
            return ziua;
        }

        //private static string Judetul(int numar)
        //{
        //    enum judete={"Alba"=1,"Arad","Arges","Bacau","Bihor"}
        //}
    }
}