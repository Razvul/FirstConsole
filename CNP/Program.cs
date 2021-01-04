using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNP
{
    class Program
    {
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
            }

            if (Gender(cuvant) == "Male")
            {
                Console.WriteLine("Persoana este de sexul masculin");
            }
            else
            {
                Console.WriteLine("Persoana este de sexul feminin");
            }

            Console.WriteLine($"Persoana este nascuta in anul {AnulNasterii(cuvant)}");
            Console.WriteLine($"Persoana este nascuta in luna {LunaNasterii(cuvant)}");
            Console.WriteLine($"Persoana este nascuta in ziua {ZiuaNasterii(cuvant)}");
        }

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
        private static string LunaNasterii(string cuvant)
        {
            var x = cuvant.Substring(3, 2);
            int luna_numar = int.Parse(x);
            string luna_cuvant;
            switch(luna_numar)
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