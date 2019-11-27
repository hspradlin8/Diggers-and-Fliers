using System;
// using System.Collections.Generic;
// using System.Linq;

namespace DiggersAndFliers.Animals
{
    public class Ants : Interfaces.IGroundMovers, Interfaces.IDigging, Interfaces.IAnimal
    {

        public void Crawl()
        {
            Console.WriteLine("Ants crawled over the hill.");
        }

        public void Dig()
        {
            Console.WriteLine("Ants dig a hole to live in.");
        }

        public void CleanCage()
        {
            Console.WriteLine("Cages are clean");
        }

        public string CarryHeavyThings { get; set; }
    }
}