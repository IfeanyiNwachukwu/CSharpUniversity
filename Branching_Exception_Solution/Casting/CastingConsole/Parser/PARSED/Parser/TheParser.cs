using static System.Console;
namespace PARSED.Parser
{
    public static class TheParser
    {
        public static void ParseAge()
        {
            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");
            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}.");
            WriteLine($"My birthday is {birthday:D}.");
        }

        public static void ParseTry()
        {
            Write("How many eggs are there? ");
            string? input = ReadLine(); 

            if(int.TryParse(input, out int count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("I could not parse the input.");
            }
        }
    }
}
