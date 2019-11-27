using System;

namespace DiggersAndFliers.Animals
{
    public class Terrapins : Interfaces.IAnimal, Interfaces.ISwimming, Interfaces.IDigging, Interfaces.IGroundMovers
    {
        public void CleanCage()
        {
            Console.WriteLine("Turtle cage is clean.");
        }

        public void Crawl()
        {
            Console.WriteLine("Terrapin crawled through his cage.");
        }

        public void Dig()
        {
            Console.WriteLine("Terrapin dug a hole to get away from the sun.");
        }

        public void Swim()
        {
            Console.WriteLine("Terrapins paddle quickly to get their food.");

        }

        public string CannotWalkBackwards { get; set; }
    }

}