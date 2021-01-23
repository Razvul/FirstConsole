using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPWinForm
{
    public class CNPnew
    {
        public string SEX { get; set; }
        public string AN { get; set; }
        public string LUNA { get; set; }
        public string ZI { get; set; }
        public string JUDET { get; set; }
        public string  NNN { get; set; }
        public string  CC { get; set; }

        public string GetCNP()
        {
            return $"{SEX}{AN}{LUNA}{ZI}{JUDET}{NNN}{CC}";
        }
    }
}
