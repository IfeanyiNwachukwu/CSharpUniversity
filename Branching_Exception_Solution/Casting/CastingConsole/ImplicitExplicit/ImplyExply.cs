using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingConsole.ImplicitExplicit
{
    public static class ImplyExply
    {
        public static void SafeImplicit()
        {
            int a = 10;
            double b = a; // an int can be safely cast into a double
            Console.WriteLine(b);
        }

        //public static void UnsafeImplicit()
        //{
        //    double c = 9.8;
        //    int d = c; // compiler gives an error for this line
        //    Console.WriteLine(d);
        //}

        public static void ExplicitCasting()
        {
            double c = 9.8;
            int d = (int)c;
            Console.WriteLine(d); // d is 9 losing the .8 par
        }

        public static void SafeCast()
        {
            long e = 10;
            int f = (int)e;
            Console.WriteLine($"e is {e:N0} and f is {f:N0}");
        }

        public static void UnSafeCast()
        {
            long e; int f;
            e = long.MaxValue;
            f = (int)e;
            Console.WriteLine($"e is {e:N0} and f is {f:N0}");
        }
    }

    
}
