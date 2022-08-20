using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements.SwitchStatements
{
    public static class Switching
    {
        public static void RunSwitch()
        {
            int number = (new Random()).Next(1,7);
            Console.WriteLine($"My random number is {number}");

            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break; //jumps to the end of the switch statement
                case 2:
                    Console.WriteLine("Two");
                    goto case 1;
                case 3: // multiple case section
                case 4:
                    Console.WriteLine("Three or Four");
                    goto case 1;
                case 5:
                    goto A_label;
                default:
                    Console.WriteLine("Default");
                    break;
            } // end of switch statement

            Console.WriteLine("After end of Switch statement");

        A_label:
            Console.WriteLine($"After A_label");

           
        }

        public static void RunSwitchPattern()
        {
            string path = @"C:\Users\Wisdom.Nwachukwu\Desktop\SelfEducation\CharpUniversity\Branching_Exception_Solution\Selection\SelectionStatements\SwitchStatements";

            Console.WriteLine("Press R for read-only or W for Writeable: ");
            ConsoleKeyInfo key = Console.ReadKey(true);
            Console.WriteLine();

            Stream? s;

            if(key.Key == ConsoleKey.R)
            {
                s = File.Open(
                    Path.Combine(path, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Read
                    );
            }
            else
            {
                s = File.Open(
                   Path.Combine(path, "file.txt"),
                   FileMode.OpenOrCreate,
                   FileAccess.Write
                   );
            }

            string message;
            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                    message = "The stram is a file I can write to.";
                    break;
                case FileStream readOnlyFile:
                    message = "The stram is a read-only file.";
                    break;
                case MemoryStream ms:
                    message = "The stram is a memory address.";
                    break;
                default: // always evaluated last despite its current position
                    message = "The stram is some other type.";
                    break;
                case null:
                    message = "The stram is null.";
                    break;

            }

            Console.WriteLine(message);
        }
    }
}
