using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorulMeu
{
    public static class Operatii
    {
        private static double _numar1;
        private static double _numar2;

        //public Operatii(double numar1, double numar2)
        //{
        //    _numar1 = numar1;
        //    _numar2 = numar2;
        //}

        //public double Operatie(string operatie)
        //{
        //    bool ok = true;
        //    double expresie = 0;
        //    while (ok)
        //    {
        //        switch (operatie)
        //        {
        //            case "+":
        //                ok = false;
        //                expresie = _numar1 + _numar2;
        //                Console.WriteLine($"Suma dintre {_numar1} si {_numar2} este:");
        //                break;
        //            case "-":
        //                expresie = _numar1 - _numar2;
        //                Console.WriteLine($"Diferenta dintre {_numar1} si {_numar2} este:");
        //                ok = false;
        //                break;
        //            case "*":
        //                expresie = _numar1 * _numar2;
        //                Console.WriteLine($"Produsul dintre {_numar1} si {_numar2} este:");
        //                ok = false;
        //                break;
        //            case "/":
        //                if (_numar2 != 0)
        //                {
        //                    expresie = _numar1 / _numar2;
        //                    Console.WriteLine($"Catul dintre {_numar1} si {_numar2} este:");
        //                    ok = false;
        //                    break;
        //                }
        //                else
        //                {
        //                    expresie = 0;
        //                    Console.WriteLine("Nu poti imparti la 0");
        //                    ok = false;
        //                    break;
        //                }
        //            default:
        //                Console.WriteLine("Ati ales o operatie gresita");
        //                break;
        //        }
        //    }
        //    return expresie;
        //}


        public static double Adunare(double _numar1, double _numar2)
        {
            return _numar1 + _numar2;
        }

        public static double Scadere(double _numar1, double _numar2)
        {
            return _numar1 - _numar2;
        }

        public static double Inmultire(double _numar1, double _numar2)
        {
            return _numar1 * _numar2;
        }

        public static double Impartire(double _numar1, double _numar2)
        {
            if (_numar2 == 0)
            {
                return 0;
            }
            return _numar1 / _numar2;
        }

        private static bool IsNumber(string cuvant)
        {
            var result = double.TryParse(cuvant, out double corect);
            return result;
        }
    }
}
