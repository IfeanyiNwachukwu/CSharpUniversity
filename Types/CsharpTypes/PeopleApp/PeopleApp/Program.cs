
using PatternMatchingLib;
using PatternMatchingLib.Recording.Recording;
using PeopleLibrary.Shared;
using static System.Console;
using Person = PeopleLibrary.Shared.Person;

//Person bob = new();

//bob.Name = "Bob Smith";
//bob.DateOfBirth = new DateTime(1965, 12, 22);
//bob.FavouriteAncientWonder = (PeopleLibrary.Enum.WondersOfTheAncientWorld)WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

//OutputPersonInfo(bob);

////Object Initializer syntax
//PeopleLibrary.Shared.Person alice = new()
//               {
//                   Name = "Alice Jones",
//                   DateOfBirth = new DateTime(1998, 3, 7) // C# 9.0 or Later
//               };

//OutputPersonInfo(alice);

//static void OutputPersonInfo(PeopleLibrary.Shared.Person bob)
//{
//    WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy} and {0}'s favourite ancient wonder is {1}. It's integer is {2}",
//        arg0: bob.Name,
//        arg1: bob.DateOfBirth,
//        arg2: (int)bob.FavouriteAncientWonder);

//}

//// Using Generics

//bob.Children.Add(new PeopleLibrary.Shared.Person { Name = "Alfred"});
//bob.Children.Add(new() { Name = "Zoe" });

//for(int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
//{
//    WriteLine($"{bob.Children[childIndex].Name}");
//}

//// Static and Instance Members

//BankAccount.InterestRate = 0.012M;

//BankAccount JonesAccount = new();
//JonesAccount.AccountName = "Mrs. Jones";
//JonesAccount.Balance = 2400;

//WriteLine(format: "{0} earned {1:C} interest.",
// arg0: JonesAccount.AccountName,
// arg1: JonesAccount.Balance * BankAccount.InterestRate);

//BankAccount gerrierAccount = new();
//gerrierAccount.AccountName = "Ms. Gerrier";
//gerrierAccount.Balance = 98;

//WriteLine(format: "{0} earned {1:C} interest.",
// arg0: gerrierAccount.AccountName,
// arg1: gerrierAccount.Balance * BankAccount.InterestRate);

//WriteLine($"{bob.Name} is a {Person.Species}");
//WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

////Using Constructors to Instantiate fields
//Person blankPerson = new();
//WriteLine(format:
// "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
// arg0: blankPerson.Name,
// arg1: blankPerson.HomePlanet,
// arg2: blankPerson.Instantiated);

//Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
//WriteLine(format:
// "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
// arg0: gunny.Name,
// arg1: gunny.HomePlanet,
// arg2: gunny.Instantiated);

//bob.WriteToConsole();
//WriteLine(bob.GetOrigin());

////Tuples without Names
//(string,int) fruit = bob.GetFruit();

//WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

////Named Tuples
//var fruitNamed = bob.GetNamedFruit();
//WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

////Inferring Tuple Names
//var thing1 = ("Neville", 4);
//WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
//var thing2 = (bob.Name, bob.Children.Count);
//WriteLine($"{thing2.Name} has {thing2.Count} children.");

//// Deconstructing TUples

//// Store return value in a tuple variable
//(string TheName, int TheNumber) tupleWithNamedFields = bob.GetNamedFruit();
//WriteLine(tupleWithNamedFields.TheName);
//WriteLine(tupleWithNamedFields.TheNumber);

//// Deconstrucr return value into two seperate variables
//(string name, int number) = bob.GetNamedFruit();
//WriteLine(name);
//WriteLine(number);

//// Deconstrucing a Person

//var (name1, dob1) = bob;
//WriteLine($"Deconstructed: {name1}, {dob1}");

//var(name2, dob2,fav2) = bob;
//WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

////Optional Parameters
//WriteLine(bob.OptionalParameters());

//WriteLine(bob.OptionalParameters("Jump!", 98.5));

//// Named Parameters
//WriteLine(bob.OptionalParameters(
// number: 52.7, command: "Hide!"));

//// COntrolling the Value of Parameters Passed
//int a = 10;
//int b = 20;
//int c = 30;

//WriteLine($"Before: a = {a}, b = {b}, c = {c}");

//bob.PassingParameters(a, ref b, out c);

//WriteLine($"After: a = {a}, b = {b}, c = {c}");



//Person Sam = new()
//{
//    Name = "Sam",
//    DateOfBirth = new(1972, 1, 27)
//};

//WriteLine(Sam.Origin);
//WriteLine(Sam.Greeting);
//WriteLine(Sam.Age);

//Sam.FavouriteIceCream = "Chocolate Fudge";
//WriteLine($"Sam's favorite ice-cream flavor is {Sam.FavouriteIceCream}.");
//Sam.FavouritePrimaryColor = "Green";
//WriteLine($"Sam's favorite primary color is {Sam.FavouritePrimaryColor}.");

////Indexers

//Sam.Children.Add(new() { Name = "Charlie" });
//Sam.Children.Add(new() { Name = "Ella" });

//WriteLine($"Sam's first child is {Sam.Children[0].Name}");
//WriteLine($"Sam's second child is {Sam.Children[1].Name}");
//WriteLine($"Sam's first child is {Sam[0].Name}");
//WriteLine($"Sam's second child is {Sam[1].Name}");

////PATTERN MATCHING

//object[] passengers =
//{
//    new FirstClassPassenger{AirMiles = 1_419},
//    new FirstClassPassenger{AirMiles = 16_562},
//    new BusinessClassPassenger(),
//    new CoachClassPassenger{CarryOnKG = 25.7},
//    new CoachClassPassenger{CarryOnKG = 0},

//};

//foreach(object passenger in passengers)
//{
//    decimal flightCost = passenger switch
//    {
//        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
//        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
//        FirstClassPassenger _ => 2000M,
//        BusinessClassPassenger => 1000M,
//        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
//        CoachClassPassenger _ => 650M,
//        _ => 800M   //default branch
//    };
//    WriteLine($"Flight costs {flightCost:C} for {passenger}");
//}


//RECORDS

//ImmutableVehicle car = new()
//{
//    Brand = "Mazda MX-5 RF",
//    Color = "Soul Red Crystal Metallic",
//    Wheels = 4
//};

//ImmutableVehicle repaintedCar = car with { Color = "Polymetal Grey Metallic" };

//WriteLine($"Original car color was {car.Color}");
//WriteLine($"New car color is {repaintedCar.Color}");

ImmutableAnimal Oscar = new("Oscar", "Labrador");
var (who, what) = Oscar;

WriteLine($"{who} is a {what}");




