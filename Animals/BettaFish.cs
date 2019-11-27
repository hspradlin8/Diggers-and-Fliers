using System;

namespace DiggersAndFliers.Animals
{
    public class BettaFish : Interfaces.IAnimal, Interfaces.ISwimming
    {
        public void CleanCage()
        {
            Console.WriteLine("The fish bowl has been cleaned");
        }

        public void Swim()
        {
            Console.WriteLine("Betta fish swim and sometimes float.");
        }

        public string FighterFish { get; set; }
    }
}