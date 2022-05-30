using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSQL
{
    public static class ClassStockage
    {
        public static TimeSpan time = new TimeSpan(05, 00, 00);
        public static List<(string, string)> listArret = new List<(string, string)>();
        public static List<string> arretCree = new List<string>();
    }
}
