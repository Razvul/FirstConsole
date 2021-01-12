using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorulMeu
{
    class Program
    {
        static void Main()
        {
            double numar1 = 14;
            double numar2 = 5;
            string operatie = "-";

            Operatii Calculator = new Operatii(numar1, numar2, operatie);

            Console.WriteLine($"{Calculator.Operatie(numar1, numar2, operatie)}");

            //    while (ok)
            //    {
            //        Console.WriteLine("Alegeti o operatie: + - * /");
            //        var op = Console.ReadLine();
            //        switch (op)
            //        {
            //            case "+":
            //                Console.WriteLine($"Suma dintre {numar1} si {numar2} este {Adunare(numar1, numar2)}");
            //                ok = false;
            //                break;
            //            case "-":
            //                Console.WriteLine($"Diferenta dintre {numar1} si {numar2} este {Scadere(numar1, numar2)}");
            //                ok = false;
            //                break;
            //            case "*":
            //                Console.WriteLine($"Produsul dintre {numar1} si {numar2} este {Inmultire(numar1, numar2)}");
            //                ok = false;
            //                break;
            //            case "/":
            //                if (numar2 != 0)
            //                {
            //                    Console.WriteLine($"Catul dintre {numar1} si {numar2} este {Impartire(numar1, numar2)}");
            //                    ok = false;
            //                    break;
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Nu poti imparti la 0");
            //                    ok = false;
            //                    break;
            //                }
            //            default:
            //                Console.WriteLine("Ati ales o operatie gresita");
            //                break;
            //        }
            //    }
            //}
            //private static double PrimulNumar()
            //{
            //    double numar1 = 0;
            //    bool ok = true;
            //    while (ok)
            //    {
            //        Console.WriteLine("Introduceti primul numer:");
            //        string numar = Console.ReadLine();
            //        if (IsNumber(numar))
            //        {
            //            string temp = numar.Replace(',', '.');
            //            numar1 = double.Parse(temp);
            //            ok = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{numar} nu este un numar. Mai incercati o data");
            //        }
            //    }
            //    return numar1;
            //}
            //private static double AlDoileaNumar()
            //{
            //    double numar2 = 0;
            //    bool ok = true;
            //    while (ok)
            //    {
            //        Console.WriteLine("Introduceti al doilea numer:");
            //        string numar = Console.ReadLine();
            //        if (IsNumber(numar))
            //        {
            //            string temp = numar.Replace(',', '.');
            //            numar2 = double.Parse(temp);
            //            ok = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{numar} nu este un numar. Mai incercati o data");
            //        }
            //    }
            //    return numar2;
            //}

            //private static bool IsNumber(string cuvant)
            //{
            //    int count = 0;
            //    string temp = cuvant.Replace(',', '.');

            //    for(int i=0;i<temp.Length;i++)
            //    {
            //        var x = temp.Substring(i, 1);

            //        if (x == ".")
            //        {
            //            count++;
            //        }
            //    }

            //    if(count >1)
            //    {
            //        return false;
            //    }

            //    var result = double.TryParse(cuvant, out double corect);
            //    return result;
            //}
            //private static double Adunare(double numar1, double numar2)
            //{
            //    return numar1 + numar2;
            //}
            //private static double Scadere(double numar1, double numar2)
            //{
            //    return numar1 - numar2;
            //}
            //private static double Inmultire(double numar1, double numar2)
            //{

            //    return numar1 * numar2;
            //}
            //private static double Impartire(double numar1, double numar2)
            //{
            //    return numar1 / numar2;
            //}
        }
    }
}