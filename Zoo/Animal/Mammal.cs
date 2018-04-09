using System;
using System.Collections.Generic;
using System.Text;


namespace Zoo
{
    public abstract class Mammal : Animal
    {
        public int ChildrenInWomb { get; set; }
    }

    // Interface almost like abstract class, but can inherit multiple interfaces
    // access interface IName
    public interface IHerbivore
    {
        void EatGrass();
    }
    
    public interface ICarnivore
    {
        void EatMeat();
    }

    public interface IFishEater
    {
        void EatFish();
    }
    

    class Gorilla : Mammal
    {
        // Constructor: Access, Type, (Paramters: type, name)
        public Gorilla(string Name, string Sex)
        {
            // Same for every Gorilla
            NumberOfLegs = 2;
            Sound = "Gorilla sound";
        }

        // Custom constructor: Access, Type, (Paramters: type, property name)
        public Gorilla(string Name, string Sex, int ChildrenInWomb)

        {
            //Same for every Gorilla
            NumberOfLegs = 2;
            Sound = "Gorilla sound";
        }

        //To override, need to set Eat method in Animal class to virtual
        //Method access canOverrideEatMethodInAnimalClass noReturnValueType Name
        public override void Eat()
        {
            Console.WriteLine("Eating plants and insects");
        }
        
        
    }


    class PandaBear : Mammal
    {
        //Custom constructor
        public PandaBear(string Name, string M)
        {
            M = Sex;
            Sex = "Male";
            NumberOfLegs = 2;
            Sound = "Panda bear sound";
        }

        //Custom Constructor
        public PandaBear(string Name, string F, int ChildrenInWomb)
        {
            F = Sex;
            Sex = "Female";
            NumberOfLegs = 2;
            Sound = "Panda bear sound";
        }
    }

    class Dolphin : Mammal
    {
        
    }

    class IceBear : Mammal
    { }

    class Zebra : Mammal
    { }

    class Lion : Mammal
    { }

    class Rhino : Mammal
    { }

    class Antilope: Mammal
    { }

    class Elephant : Mammal
    { }

    class Giraffe : Mammal
    { }

}
