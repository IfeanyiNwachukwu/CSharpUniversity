namespace IterationConsole.Fors
{
    public static class Forss
    {
        public static void SimpleFor()
        {
            for (int y = 1; y <= 10; y++)
            {
                Console.WriteLine(y);
            }
        }

        public static void SimpleForEach()
        {
            string[] names = { "Adam", "Barry", "Charlie" };

            foreach (string name in names)
            {
                Console.WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}
