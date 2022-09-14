using PeopleLibrary.Enum;
using static System.Console;

namespace PeopleLibrary.Shared
{
    public partial class Person
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavouriteAncientWonder;
        public List<Person> Children = new();
        /// <summary>
        /// To get the value of a Constant field, you must write the name of
        /// the class, not the name of an instance of the class.
        /// </summary>
        public const string Species = "Homo Sapiens";
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        // Methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }
        //Tuples without names
        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        //Named Tuples
        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        // Deconstructing Types
        public void Deconstruct(out string name, out DateTime dob)
        {
            name = Name;
            dob = DateOfBirth;
        }

        public void Deconstruct(out string name, out DateTime dob, out WondersOfTheAncientWorld fav)
        {
            name = Name;
            dob = DateOfBirth;
            fav = FavouriteAncientWonder;
        }

        // Optional Parameters
        public string OptionalParameters(string command = "Run", double number = 0.0, bool active = true)
        {
            return string.Format(
            format: "command is {0}, number is {1}, active is {2}",
            arg0: command,
            arg1: number,
            arg2: active);
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            //out parameters cannot have a default
            //And must be intitialized inside the method
            z = 99;

            // increment each parameter
            x++;
            y++;
            z++;
        }


    }
}
