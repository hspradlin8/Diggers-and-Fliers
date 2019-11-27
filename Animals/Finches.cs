using System;

namespace DiggersAndFliers.Animals
{
    public class Finches : Interfaces.IAnimal, Interfaces.IFlying
    {
        public void CleanCage()
        {
            Console.WriteLine("Clean that Finche shit.");
        }

        public void Fly()
        {
            Console.WriteLine("Finches can soar high.");
        }
        public string Chrip { get; set; }
    }
}