using static System.Console;
namespace ExceptionHandling
{
    public static class ExceptionHandler
    {

      
      
        public static void SwallowException()
        {
            AskQuestion();
            string? input = ReadLine();
            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch (Exception)
            {
                // Never use an empty Catch block because it swallows up Exceptions

            }

            WriteLine("After Parsing");
        }

        public static void CatchAllExceptions()
        {
            AskQuestion();
            string? input = ReadLine();
            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch (Exception ex)
            {

                WriteLine($"{ex.GetType()} says {ex.Message}");
            }

            WriteLine("After Parsing");
        }

        public static void CatchSpecificExceptions()
        {
            AskQuestion();
            string? input = ReadLine();
            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your age is a in a valid number format but it is either too big or too small");
            }
            catch (FormatException)
            {

                WriteLine($"The age you entered is not in a valid format");
            }

            WriteLine("After Parsing");
        }

        public static void CatchExceptionsWithFilters()
        {
            AskQuestion();
            string? input = ReadLine();
            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your age is a in a valid number format but it is either too big or too small");
            }
            catch (FormatException)
            {

                WriteLine($"The age you entered is not in a valid format");
            }

            WriteLine("After Parsing");
        }

        public static void CatchExceptionWithFilters()
        {
            Write("Enter an amount: ");
            string? amount = ReadLine();
            try
            {
                decimal amountValue = decimal.Parse(amount);
            }
            catch (FormatException) when (amount.Contains("$"))
            {
                WriteLine("Amounts cannot use the dollar sign!");
            }
        }

        public static void UncheckedOverflow()
        {
            int x = int.MaxValue - 1;
            WriteLine($"Initial value: {x}");
            x++;
            WriteLine($"After incrementing: {x}");
            x++;
            WriteLine($"After incrementing: {x}");
            x++;
            WriteLine($"After incrementing: {x}");
        }

        public static void CheckedOverflow()
        {
            checked
            {
                int x = int.MaxValue - 1;
                WriteLine($"Initial value: {x}");
                x++;
                WriteLine($"After incrementing: {x}");
                x++;
                WriteLine($"After incrementing: {x}");
                x++;
                WriteLine($"After incrementing: {x}");
            }
            
        }

        private static void AskQuestion()
        {
            WriteLine("Before parsing");
            Write("What is your age? ");
        }

      

    }
}
