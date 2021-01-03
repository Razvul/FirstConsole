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
            int[] cnp = new int[13];

            for (int i = 0; i < cuvant.Length; i++)
            {
                var x = cuvant.Substring(i, 1);

                if (IsNumber(x))
                {
                    cnp[i] = int.Parse(x);
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
                Console.WriteLine("CNP este corect");
            }
            else
            {
                Console.WriteLine("CNP nu este corect");
            }
        }
        public static bool IsNumber(string numar)
        {
            var result = double.TryParse(numar, out double corect);
            return result;
        }
    }
}