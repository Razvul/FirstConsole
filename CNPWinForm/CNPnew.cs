using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPWinForm
{
    public class CNPnew
    {
        public string SEX { get; set; } // 1
        public string AN { get; set; } // 93
        public string LUNA { get; set; } // 07
        public string ZI { get; set; } // 29
        public string JUDET { get; set; } // 07
        public string  NNN { get; set; } // 005
        public string  CC { get; set; } // 5

        public string GetCNP()
        {
            return $"{SEX}{AN}{LUNA}{ZI}{JUDET}{NNN}{CC}";
            // 1 93 07 29 07 NNN CC
        }

        // SEX = 1
        // AN = 93
        // LUNA = 07
        // ZI = 29
        // JUDET = 07
        // NNN = trebuie sa il calculez. e un random de la 1 la 999
        // CC = cifra de control calculata


    }
}
