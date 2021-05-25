using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeTimesFive
{
    class Program
    {
        static void Main()
        {
            var listMea = Functie1(30);
            for (int i = 0; i < listMea.Count; i++)
            {
                Console.WriteLine(listMea[i]);
            }
            Functie2(15);
        }

        public static List<string> Functie1(int numar)
        {
            List<string> buzz = new List<string>();

            for (int i = 1; i <= numar; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    buzz.Add("threefive");
                else if (i % 3 == 0)
                    buzz.Add("three");
                else if (i % 5 == 0)
                    buzz.Add("five");
                else
                    buzz.Add(i.ToString());
            }

            return buzz;
        }

        public static void Functie2(int numar)
        {
            List<string> buzz = new List<string>();

            for (int i = 1; i <= numar; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    buzz.Add("threefive");
                else if (i % 3 == 0)
                    buzz.Add("three");
                else if (i % 5 == 0)
                    buzz.Add("five");
                else
                    buzz.Add(i.ToString());
            }

            for (int i = 0; i < numar; i++)
            {
                Console.WriteLine(buzz[i]);
            }
        }
    }
}