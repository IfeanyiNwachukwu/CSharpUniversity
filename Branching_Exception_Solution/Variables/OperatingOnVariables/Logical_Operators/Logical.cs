using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingOnVariables.Logical_Operators
{
    public static class Logical
    {
        public static void LogicRun()
        {
            bool a = true;
            bool b = false;
            Console.WriteLine($"AND | a | b ");
            Console.WriteLine($"a | {a & a,-5} | {a & b,-5} ");
            Console.WriteLine($"b | {b & a,-5} | {b & b,-5} ");
            Console.WriteLine();
            Console.WriteLine($"OR | a | b ");
            Console.WriteLine($"a | {a | a,-5} | {a | b,-5} ");
            Console.WriteLine($"b | {b | a,-5} | {b | b,-5} ");
            Console.WriteLine();
            Console.WriteLine($"XOR | a | b ");
            Console.WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
            Console.WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} ");
        }
    }
}
