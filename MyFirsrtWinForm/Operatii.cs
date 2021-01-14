using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirsrtWinForm
{
    public class Operatii
    {
        static double _numar1;
        static double _numar2;

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

    }
}
