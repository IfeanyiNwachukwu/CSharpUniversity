namespace SelectionStatements.IFStatements
{
    public static class IF
    {
        public static void RunIf()
        {
            string password = "ninja";

            if (password.Length < 8)
            {
                Console.WriteLine("Your password is too short. Use at least 8 characters.");

            }
            else
            {
                Console.WriteLine("Your password is strong");
            }
        }

        public static void RunPattern()
        {
            object o = "3";
            int j = 4;

            if(o is int i)
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
            }
            else
            {
                Console.WriteLine($"o is not an int so it cannot multiply!");
            }
        }
    }
}
