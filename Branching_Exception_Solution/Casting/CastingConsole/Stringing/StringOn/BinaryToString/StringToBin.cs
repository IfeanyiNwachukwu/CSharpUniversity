//using static System.Console;
//using static System.Convert;

namespace StringOn.BinaryToString
{
    public static class StringToBin
    {
        public static void BinToString()
        {
            // allocate array of 128 bytes
            byte[] binaryObject = new byte[128];

            //populate array with random bytes
            (new Random()).NextBytes(binaryObject);

            Console.WriteLine("Binary Object as bytes:");

            for (int index = 0; index < binaryObject.Length; index++)
            {
                Console.WriteLine(binaryObject[index]);
            }
            Console.WriteLine();


            //Convert to Base64 string and output as text
            string encoded =  Convert.ToBase64String(binaryObject);

            Console.WriteLine($"Binary Object as Base64: {encoded}");

        }

    }
}
