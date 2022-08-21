using static System.Console;
using Functions.ActFunction;

//Functioning.TimesTable(9);

decimal taxToPay = Functioning.CalculateTax(amount: 149, twoLetterRegionCode: "FR");
WriteLine($"You must pay {taxToPay:C} in taxes");

Functioning.CardinalToOrdinal(23);


//static void RunCardinalToOrdinal()
//{
//    for(int number = 1; number <= 40; number++)
//    {
//        Write($"{Functioning.CardinalToOrdinal(number)}");
//    }
//    WriteLine();
//}
int count = Functioning.Factorial(5);
Console.WriteLine(count);
