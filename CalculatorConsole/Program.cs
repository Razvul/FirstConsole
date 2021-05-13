using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    class Program
    {
        static void Main()
        {
            

            // adunare
            // scadere
            // imultire
            //impartire


            Console.WriteLine("alegeti operatia +, -, *, /");

            ConsoleKeyInfo key = Console.ReadKey();

            Console.WriteLine();

            bool ok = true;

            while (ok)
            {
                if (key.KeyChar == '+')
                {
                    Adunare();
                    ok = false;
                }
                else if (key.KeyChar == '-')
                {
                    Scadere();
                    ok = false;
                }
                else if (key.KeyChar == '*')
                {

                }
                else if (key.KeyChar == '/')
                {

                }
                else
                {
                    Console.WriteLine("You have used the wrong operation");
                    continue;
                }
            }

            Console.WriteLine("Finish!!!");
            Console.ReadKey();
        }

        private static bool IsNumber(string a)
        {
            /*var result = double.TryParse(a, out double corect);
            return result;*/
            return double.TryParse(a, out double corect);
        }

        private static Tuple<bool, double> IsNumber2(string a)
        {
            /*var result = double.TryParse(a, out double corect);
            return result;12.5 15.5,4 */

            bool isDouble = double.TryParse(a, out double number);
            
            bool resultTest;
            double numberD;

            try
            {
                numberD = double.Parse(a);
                resultTest = true;
            }
            catch (Exception)
            {
                resultTest = false;
                numberD = 0;
            }

            var result = new Tuple<bool, double>(resultTest, numberD);


            //var result = new Tuple<bool, double>(isDouble, number);

            return result;
        }
        private static void Adunare()
        {
            bool ok = true;
            double primul_numar = 0;
            double aldoilea_numar = 0;

            while (ok)
            {
                Console.WriteLine("Introduceti primul numar: ");

                string val = Console.ReadLine();
                //if(IsNumber(val))
                //{
                //    primul_numar = double.Parse(val);
                //    ok = false;
                //}
                //else
                //{
                //    Console.WriteLine($"Valoare {val} nu este un numar");
                //}


                var (isDouble, numberDouble) = IsNumber2(val);

                var tuple = IsNumber2(val);

                if (tuple.Item1)
                {
                    primul_numar = tuple.Item2;
                    ok = false;
                }
                else
                {
                    Console.WriteLine($"Valoare {val} nu este un numar");
                }
            }

            ok = true;

            while (ok)
            {
                Console.WriteLine("Introduceti al doilea numar: ");

                string val = Console.ReadLine();
                if (IsNumber(val))
                {
                    aldoilea_numar = double.Parse(val);
                    ok = false;
                }
                else
                {
                    Console.WriteLine($"Valoare {val} nu este un numar");
                }
            }


            double rezultatAdunare = Adunare(primul_numar, aldoilea_numar);

            Console.WriteLine($"Rezultatul adunarii dintre {primul_numar} si {aldoilea_numar} este {rezultatAdunare}");

        }
        private static double Adunare(double a, double b)
        {
            return a + b;
        }


        private static void Scadere()
        {
            bool ok = true;
            double primul_numar = 0;
            double aldoilea_numar = 0;

            while (ok)
            {
                Console.WriteLine("Introduceti primul numar: ");

                string val = Console.ReadLine();


                var tuple = IsNumber2(val);

                if (tuple.Item1)
                {
                    primul_numar = tuple.Item2;
                    ok = false;
                }
                else
                {
                    Console.WriteLine($"Valoare {val} nu este un numar");
                }
            }

            ok = true;

            while (ok)
            {
                Console.WriteLine("Introduceti al doilea numar: ");

                string val = Console.ReadLine();
                if (IsNumber(val))
                {
                    aldoilea_numar = double.Parse(val);
                    ok = false;
                }
                else
                {
                    Console.WriteLine($"Valoare {val} nu este un numar");
                }
            }


            double rezultatScadere = Scadere(primul_numar, aldoilea_numar);

            Console.WriteLine($"Rezultatul sacderii dintre {primul_numar} si {aldoilea_numar} este {rezultatScadere}");

        }

        private static double Scadere (double a, double b)
        {
            return a - b;
        }

        //private void AddXNumber (int x)
        //{
        //    var testArray = new Array[](x);


        //    for (int i = 0; i < testArray.lenght; i++)
        //    {

        //    }
        //}
    }
}
