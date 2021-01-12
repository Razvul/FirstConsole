using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorulMeu
{
    public class Operatii
    {
        double _numar1;
        double _numar2;
        string _operatie;

        public Operatii(double numar1, double numar2, string operatie)
        {
            _numar1 = numar1;
            _numar2 = numar2;
            _operatie = operatie;
        }

        public double Operatie(double numar1, double numar2, string operatie)
        {
            bool ok = true;
            double expresie = 0;
            while (ok)
            {
                switch (operatie)
                {
                    case "+":
                        ok = false;
                        expresie = numar1 + numar2;
                        Console.WriteLine($"Suma dintre {numar1} si {numar2} este:");
                        break;
                    case "-":
                        expresie = numar1 - numar2;
                        Console.WriteLine($"Diferenta dintre {numar1} si {numar2} este:");
                        ok = false;
                        break;
                    case "*":
                        expresie = numar1 * numar2;
                        Console.WriteLine($"Produsul dintre {numar1} si {numar2} este:");
                        ok = false;
                        break;
                    case "/":
                        if (numar2 != 0)
                        {
                            expresie = numar1 / numar2;
                            Console.WriteLine($"Catul dintre {numar1} si {numar2} este:");
                            ok = false;
                            break;
                        }
                        else
                        {
                            expresie = 0;
                            Console.WriteLine("Nu poti imparti la 0");
                            ok = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Ati ales o operatie gresita");
                        break;
                }
            }
            return expresie;
        }

        private static bool IsNumber(string cuvant)
        {
            var result = double.TryParse(cuvant, out double corect);
            return result;
        }
    }
}
