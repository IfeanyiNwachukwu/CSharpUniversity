using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.Console;

namespace CastingConsole.SystemConvert
{
    public static class SysConvert
    {
        public static void RunSysConvert()
        {
            double g = 9.8;
            int h = ToInt32(g); // a method of System.Convert
            WriteLine($"g is {g} and h is {h}");
        }
    }
}
