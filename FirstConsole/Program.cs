using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsole
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduceti un numar natural:");
            var number = Console.ReadLine();

            if (IsNaturalNumber(number))
            {
                var isNumberPrime = IsPrime(int.Parse(number));

                Console.WriteLine(isNumberPrime
                    ? $"Numarul '{number}' ESTE un numar prim!"
                    : $"Numarul '{number}' NU ESTE un numar prim!");
            }
            else
            {
                Console.WriteLine($"Valoarea '{number}' nu este un numar natural!");
            }

            Console.ReadKey();
        }


        /// <summary>
        /// Cerifica daca un numar este prim
        /// </summary>
        /// <param name="numar">Numarul de verificat</param>
        /// <returns>Returneaza 0 daca numarule este prim, 1 daca nu</returns>
        private static int NumarPrim(int numar)
        {
            if (numar < 1)
            {
                return 0;
            }

            int temp = numar - 1;

            while (temp > 1)
            {
                if (numar % temp == 0)
                {
                    return 0;
                }

                temp--;
            }

            return 1;
        }

        /// <summary>
        /// Check if a number is prime
        /// </summary>
        /// <param name="number">Number to be checked</param>
        /// <returns>True if number is prime</returns>
        private static bool IsPrime(int number)
        {
            switch (number)
            {
                case 0:
                    return false;
                case 1:
                    return true;
                case 2:
                    return false;

            }

            var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

            for (var i = 2; i < limit; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
           
            return true;
        }


        /// <summary>
        /// Check if a string is a natural number
        /// </summary>
        /// <param name="value">Value to be checked</param>
        /// <returns>True if value is a natural number</returns>
        private static bool IsNaturalNumber(string value)
        {
            var result = int.TryParse(value, out var number);

            if (result)
            {
                if (number < 2)
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
