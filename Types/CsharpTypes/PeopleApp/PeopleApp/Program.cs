using ClassLibrary1.Enum;
using ClassLibrary1.Shared;
using static System.Console;

Person bob = new();

bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.FavouriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

OutputPersonInfo(bob);

//Object Initializer syntax
Person alice = new()
               {
                   Name = "Alice Jones",
                   DateOfBirth = new DateTime(1998, 3, 7) // C# 9.0 or Later
               };

OutputPersonInfo(alice);

static void OutputPersonInfo(Person bob)
{
    WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy} and {0}'s favourite ancient wonder is {2}. It's integer is ",
        arg0: bob.Name,
        arg1: bob.DateOfBirth,
        arg2: bob.FavouriteAncientWonder);
        
}