using System;

namespace DiggersAndFliers.Animals
{
    public class CooperheadSnake : Interfaces.IAnimal, Interfaces.IGroundMovers
    {
        public void CleanCage()
        {
            Console.WriteLine("Cage is clean.");
        }

        public void Crawl()
        {
            Console.WriteLine("The snake crawls across the ground.");
        }

        public void Dig()
        {
            Console.WriteLine("Snakes dig holes to hang out in.");
        }

        public string Slither { get; set; }
    }
}