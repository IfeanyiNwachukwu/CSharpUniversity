using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CastingConsole.Rounding
{
    public static class Rounded
    {
        public static void RunRounding()
        {
            double[] doubles = new[]
            { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
            foreach (double n in doubles)
            {
                WriteLine($"ToInt32({n}) is {ToInt32(n)}");
            }
        }
    }
}
