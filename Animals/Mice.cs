using System;

namespace DiggersAndFliers.Animals
{
    public class Mice : Interfaces.IAnimal, Interfaces.IGroundMovers, Interfaces.ISwimming
    {
        public void CleanCage()
        {
            Console.WriteLine("Clean all the mice poop.");
        }

        public void Crawl()
        {
            Console.WriteLine("Mice crawl through their cage");
        }

        public void Dig()
        {
            Console.WriteLine("Mice dig a hole to bury their food.");
        }

        public void Swim()
        {
            Console.WriteLine("Mice can swim pretty well.");
        }
        public string MiceWheel { get; set; }
    }
}