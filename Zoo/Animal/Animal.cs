using System;
using System.Collections.Generic;
using System.Text;
// Can create namespace to group classes
// namespace Zoo.Animals in every class file that is grouped in that namespace
// In Program.cs have to write: using Zoo.Animals

namespace Zoo
{
    // public class Animal; now you can make a object of type Animal while that actually doesn't exist
    // public abstract class Animal; Making the class abstract doesn't allow you to make a object from it, but you can inherit from it.
    // abstract class forces the class that inherit from it to use the methods that were defined in the base abstract class
    public abstract class Animal
    {
        // Setting properties
        public int Weight { get; set; }
        public int NumberOfLegs { get; set; }
        public int NumberOfFins { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Sound { get; set; }



        // Default Constructor
        public Animal()
        {
            
        }

         //// Method: access canBeChanged noReturnValueType
        //public virtual void Eat()
        //{
        //    Console.WriteLine("Eating");
        //}

        // Abstract method must be implemented in all classes that derive from base class
        // Access abstract noReturnType Name () ;; No {} because not implemented in Animals class but in the other classes
        public abstract void Eat();

    }
}
