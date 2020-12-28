using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace FirstConsole
{
    class Program
    {
        static int NumarPrim(int numar)
        {
            if (numar < 1)
                return 0;
            int temp = numar - 1;
           while(temp>1)
            {
                if (numar % temp == 0)
                    return 0;
                temp--;
            } 
            return 1;
        }
        static void Main()
        {
            //Console.WriteLine("Bun venit la curs, Razvan!");
            Console.WriteLine("{0}", NumarPrim(18));
            Console.ReadKey();
        }
    }
}
