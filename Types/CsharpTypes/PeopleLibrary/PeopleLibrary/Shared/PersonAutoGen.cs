using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleLibrary.Shared
{
    public partial class Person
    {
        private string _favouritePrimaryColour;
        /// <summary>
        /// readonly property b/c it only has a GET implementation
        /// </summary>
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        public string Greeting => $"{Name} says 'Hello!'";

        public int Age => DateTime.Today.Year - DateOfBirth.Year;

        public string FavouriteIceCream { get; set; }

        public string FavouritePrimaryColor
        {
            get { return _favouritePrimaryColour; }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        _favouritePrimaryColour = value;
                        break;
                    default:
                        throw new ArgumentException($"{value} is not a primary colour" +
                            $"Choose from: red, green, blue.");
                }

            }
        }

        //Indexers
        public Person this[int index]
        {
            get => Children[index];
            set => Children[index] = value;
        }
    }
}
