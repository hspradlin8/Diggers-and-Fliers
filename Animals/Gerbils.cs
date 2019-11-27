using System;

namespace DiggersAndFliers.Animals
{
    public class Gerbils : Interfaces.IAnimal, Interfaces.IDigging, Interfaces.IGroundMovers
    {
        public void CleanCage()
        {
            Console.WriteLine("Put new hay shreds in the cage.");
        }

        public void Crawl()
        {
            Console.WriteLine("Gerbils crawl through their cage.");
        }

        public void Dig()
        {
            Console.WriteLine("Gerbils like to dig to make a comfy burrow to sleep in.");
        }

        public string GerbilWheel { get; set; }
    }
}