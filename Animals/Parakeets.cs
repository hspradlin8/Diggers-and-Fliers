using System;
// using System.Collections.Generic;
// using System.Linq;

namespace DiggersAndFliers.Animals
{
    public class Parakeets : Interfaces.IFlying, Interfaces.IAnimal
    {
        public void Fly()
        {
            Console.WriteLine("Parakeets flew high");
        }

        public void CleanCage()
        {
            Console.WriteLine("Cages are clean.");
        }

        public string Talk { get; set; }

    }
}