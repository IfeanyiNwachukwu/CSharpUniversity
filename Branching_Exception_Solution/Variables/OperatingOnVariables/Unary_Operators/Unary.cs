using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingOnVariables.Unary
{
    public static class Unary
    {
      
        public static void RunUnary()
        {
            // post fix operation because ++ executes after the assignment
            int a = 3;
            int b = a++;

            Console.WriteLine($"a is {a}, b is {b}");

            // Pre fix operation because ++ executes before the assignment

            int c = 3;
            int d = c++;
            Console.WriteLine($"c is {c}, d is {d}");

            //Good Practice is CancellationToken never combine the use of
            //++ and -- operators with an assignment operator


        }

       

    }

}
