using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Legs = 2;
            Alive = true;
            twoEyes = true;
            layEggs = true;
        }
        public bool itCanFly { get; set; } = true;
        public bool HasWings { get; set; } = true;
        public bool itCanChirp { get; set; } = true;

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Do birds fly? {itCanFly}");
            Console.WriteLine($"Do birds chirp? {itCanChirp}");
        }
    }
}

