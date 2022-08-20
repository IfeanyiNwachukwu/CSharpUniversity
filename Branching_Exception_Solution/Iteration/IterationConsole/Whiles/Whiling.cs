using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationConsole.Whiles
{
    public static class Whiling
    {
        public static void RunSimpleWhile()
        {
            int x = 0;

            while(x < 10)
            {
                Console.WriteLine(x);
                x++;
            }
        }

        public static void RunDoWhile()
        {
            string? password;

            int count = 0;

            do
            {
                Console.Write("ENter your password: ");
                password = Console.ReadLine();
                count++;
            }
            while(password != "pa$$w0rd" && count <= 9);

            if(password != "pa$$w0rd")
            {
                Console.WriteLine("After ten tries, you have been barred from making any other entry");
              
            }
            else
            {

                Console.WriteLine("Correct!");
            }
        }
    }
}
