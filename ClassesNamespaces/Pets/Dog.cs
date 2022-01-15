using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesNamespaces.Pets
{   
    //class
    //blueprint to describe something in the real world
    //A PIE - abstraction, polymorphism, inheritance, encapsulation
    //below is an example of encapsulation - everything about a dog is encapsulated in this
    class Dog
    {  
        //properties - TitleCase/PascalCase - define things about dogs
        //auto property - has a plain getter/setter
        //first - the public part is an access modifier (public or private) - public means it can be accessed from outside the class it's in - private is default and you can't access it elsewhere
        //then type, then name, then the getter and setter
        public string FurType { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public double Weight { get; set; }

        //calculated property or read-only property
        public DateTime DateOfBirth { get; private set; }
        public int Age
        {
            get
            {
                return (DateTime.Now - DateOfBirth).Days / 365;
            }
        }

        //fields - more or less private properties but not technically properties
        //best practice is to start with underscore then camelCase the rest
        //only stuff inside of this class can affect this bc it's private
        //private values needed by the class but not needed ouside the class
        //access modifier of private | type | name
        private bool _isFertile;


        //methods - functions that are part of a class- use TitleCase/PascalCase - need to define behavior - things that dogs can do
        //access modifier then return type then name then code
        //if method does not return anything - it does something but does not return anything - use void
        public void Bark()
        {
            Console.WriteLine($"{Name} barks loudly.");
        }

        public void SetDateOfBirth(DateTime dob)
        {
            DateOfBirth = dob;
        }

        public int GiveBirth()
        {
            int numOfPuppies = new Random().Next();
            return numOfPuppies;
        }

    }
}
