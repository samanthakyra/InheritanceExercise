using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            Legs = 2;
            Alive = true;
            twoEyes = true;
            layEggs = true;
        }
        public bool oldestAnimals { get; set; } = true;
        public string Teeth { get; set; } = "Turtles don't have any teeth at all!";

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Can turtles live for 100 years? {oldestAnimals}");
            Console.WriteLine($"Do turtles have teeth? {Teeth}");
        }
    }
}