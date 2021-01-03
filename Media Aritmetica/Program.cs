using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Aritmetica
{
    class Program
    {
        static void Main()
        {
            int count = CountNumbers();
            double suma = Suma(count);

            Console.WriteLine($"Media aritmetica este {MediaAritmetica(suma, count)}");
        }

        private static int CountNumbers()
        {
            Console.WriteLine("How many numbers do you want to use?");
            int count = 0; bool ok = true;

            while (ok)
            {
                string cuvant = Console.ReadLine();
                if (IsNumber(cuvant))
                {
                    count = int.Parse(cuvant);
                    Console.WriteLine($"Count is {count}");
                    ok = false;
                }
                else
                {
                    Console.WriteLine($"{cuvant} is not a number!");
                }
            }
            return count;
        }

        private static double Suma(int count)
        {
            double suma = 0;
            string[] numere = new string[count];
            double termen = 0;

            Console.WriteLine($"Write the {count} numbers:");
            for (int i = 0; i < count; i++)
            {
                bool ok = true;
                while (ok)
                {
                    numere[i] = Console.ReadLine();
                    if (IsNumber(numere[i]))
                    {
                        termen = double.Parse(numere[i]);
                        ok = false;
                    }
                    else
                    {
                        Console.WriteLine($"{numere[i]} is not a number!");
                    }
                }
                suma += termen;
            }
            return suma;
        }

        public static bool IsNumber(string numar)
        {
            var result = double.TryParse(numar, out double corect);
            return result;
        }

        private static double MediaAritmetica(double suma, int count)
        {
            double media = suma / count;
            return media;
        }
    }
}