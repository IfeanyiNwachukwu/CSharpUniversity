using ClassLibrary1.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Shared
{
    public class Person
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavouriteAncientWonder;
        //generics
        public List<Person> Children = new List<Person>();
        /// <summary>
        /// To get the value of a Constant field, you must write the name of
        /// the class, not the name of an instance of the class.
        /// </summary>
        public const string Species = "Homo Sapiens";

    }
}
