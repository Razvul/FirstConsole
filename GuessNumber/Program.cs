using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ghiceste un numar de la 1 la 10.");
            Random rnd = new Random();
            int random = rnd.Next(1, 11);

            for (int i = 4; i > 0; i--)
            {
                var cuvant = Console.ReadLine();
                var esteNumar = int.TryParse(cuvant, out int numar);

                if (esteNumar == false)
                {
                    Console.WriteLine("N-ai introdus un numar. Mai incearca o data.");
                    i++;
                }
                else
                {
                    if (numar < 1 || numar > 10)
                    {
                        Console.WriteLine($"Numarul nu este in intervalul 1-10. Mai ai {i} incercari.");
                        i++;
                        continue;
                    }
                    else
                    {
                        if (numar == random)
                        {
                            Console.WriteLine($"Bravo! Numarul este {numar}!");
                            break;
                        }
                        else
                        {
                            if (i == 1)
                            {
                                Console.WriteLine($"Nu mai ai incercari. Numarul este {random}.");
                            }
                            else
                            {
                                Console.WriteLine($"Gresit! Mai ai {i - 1} incercari");

                            }
                        }
                    }
                }
            }
        }
    }
}