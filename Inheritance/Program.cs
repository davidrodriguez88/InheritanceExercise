using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBird = new Bird
            {
                Legs = 2,
                Eyes = 2,
                Heterotrophic = true,
                Multicellular = true
            }
            ;
            var myReptile = new Reptile()
            {
                Legs = 4,
                Eyes = 2,
                Heterotrophic = true,
                Multicellular = true,
            }
            ;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bird Characteristics:");
            Console.WriteLine($"Legs: {myBird.Legs}");
            Console.WriteLine($"Eyes: {myBird.Eyes}");
            Console.WriteLine($"Has Feathers? {myBird.Feathers}");
            Console.WriteLine($"Lays Eggs? {myBird.LayEggs}");
            Console.WriteLine($"Has Beak? {myBird.Beak}");
            Console.WriteLine($"Bipedal? {myBird.Bipedal}");
            Console.ResetColor();
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Reptile Characteristics:");
            Console.WriteLine($"Legs: {myReptile.Legs}");
            Console.WriteLine($"Eyes: {myReptile.Eyes}");
            Console.WriteLine($"Cold Blooded? {myReptile.ColdBlooded}");
            Console.WriteLine($"Has Scales? {myReptile.Scales}");
            Console.WriteLine($"Fertilizes Internally? {myReptile.InternalFertilization}");
            Console.WriteLine($"Three or more Heart Chambers? {myReptile.ThreeOrMoreHeartChambers}");
            
            
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *
             * Creatively display the class member values
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
        }
    }
}
