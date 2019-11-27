using System;

namespace DiggersAndFliers.Animals
{
    public class TimberRattlesnake : Interfaces.IAnimal, Interfaces.IGroundMovers
    {
        public void CleanCage()
        {
            Console.WriteLine("Clean the cage");
        }

        public void Crawl()
        {
            Console.WriteLine("slither around on their stomach.");
        }

        public void Dig()
        {
            Console.WriteLine("dig holes to hang out in.");
        }

        public string Bite { get; set; }
    }
}