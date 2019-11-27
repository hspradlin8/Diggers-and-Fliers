using System;

namespace DiggersAndFliers.Animals
{
    public class Earthworms : Interfaces.IAnimal, Interfaces.IDigging, Interfaces.IGroundMovers
    {
        public void CleanCage()
        {
            Console.WriteLine("Earthworms clean their own cage");
        }

        public void Crawl()
        {
            Console.WriteLine("Earthworms call through dirt");
        }

        public void Dig()
        {
            Console.WriteLine("They dig into the ground deeper to find more nutrient rich soil.");
        }
        public string InchBy { get; set; }
    }
}