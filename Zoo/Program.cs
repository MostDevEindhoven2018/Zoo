using System;
//Using list need this namespace System.Collections.Generic to be used
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {



        static void Main(string[] args)
        {
            Zebra Zebra1 = new Zebra();
            Zebra1.Name = "Stripes";
            Zebra1.NumberOfLegs = 4;
            Zebra1.Sound = "Zebra sound";

            // Object initializer

            Zebra Zebra2 = new Zebra()
            {
                Name = "Stripes",
                NumberOfLegs = 4,
                Sound = "Zebra sound",
            };

            PandaBear Pandabear1 = new PandaBear("Peter", "M");
            Console.WriteLine(Pandabear1.Sex);
        


            Gorilla Gorilla1 = new Gorilla("George", "male");
            Gorilla Gorilla2 = new Gorilla("Grace", "female",0);

            //Testting if ouputs Gorilla sound
            // Console.WriteLine(Gorilla1.Sound);


            //List<Type>
            List<Animal> ListOfAnimals = new List<Animal>();
            //Adding excisting animals
            ListOfAnimals.Add( Gorilla1);
            ListOfAnimals.Add(Gorilla2);
            ListOfAnimals.Add(Zebra1);
            ListOfAnimals.Add(Zebra2);
            //Adding new animals, cannot input name of object
            ListOfAnimals.Add(new Zebra());
            

            //Console.WriteLine(ListOfAnimals); or else only output is Zoo.animal
            //Console.WriteLine(ListOfAnimals[0]) Seeing certain Animal in list
            //Console.WriteLine(ListOfAnimals[1].Name); Ouptuts the name of second animal in list




            // (Type newNameForeach in List)
            foreach (Animal animal in ListOfAnimals)
            {
                Console.WriteLine($"{animal.GetType()} {animal.NumberOfLegs} {animal.Sound}");

                //Need animal from the list to refer to the method, not from the class
                animal.Eat();
            }

            Console.ReadKey();
        }
    }
}
