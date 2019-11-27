using System;
using System.Collections.Generic;
using System.Linq;

namespace DiggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Interfaces.IDigging> digAnimals = new List<Interfaces.IDigging>();
            List<Interfaces.IFlying> flyAnimals = new List<Interfaces.IFlying>();
            List<Interfaces.IGroundMovers> groundAnimals = new List<Interfaces.IGroundMovers>();
            List<Interfaces.ISwimming> swimAnimals = new List<Interfaces.ISwimming>();
            List<Interfaces.IAnimal> animals = new List<Interfaces.IAnimal>();

            var myAnts = new Animals.Ants();
            var myBettaFish = new Animals.BettaFish();
            var myCopperheadSanke = new Animals.CooperheadSnake();
            var myEarthworms = new Animals.Earthworms();
            var myFinches = new Animals.Finches();
            var myGerbils = new Animals.Gerbils();
            var myMice = new Animals.Mice();
            var myParakeets = new Animals.Parakeets();
            var myTerrapins = new Animals.Terrapins();
            var myTimberRattlesnake = new Animals.TimberRattlesnake();

            digAnimals.Add(myAnts);
            digAnimals.Add(myEarthworms);
            digAnimals.Add(myGerbils);
            digAnimals.Add(myTerrapins);

            flyAnimals.Add(myFinches);
            flyAnimals.Add(myParakeets);

            groundAnimals.Add(myAnts);
            groundAnimals.Add(myEarthworms);
            groundAnimals.Add(myCopperheadSanke);
            groundAnimals.Add(myGerbils);
            groundAnimals.Add(myMice);
            groundAnimals.Add(myTerrapins);
            groundAnimals.Add(myTimberRattlesnake);

            swimAnimals.Add(myBettaFish);
            swimAnimals.Add(myMice);

            animals.Add(myAnts);
            animals.Add(myBettaFish);
            animals.Add(myCopperheadSanke);
            animals.Add(myEarthworms);
            animals.Add(myFinches);
            animals.Add(myGerbils);
            animals.Add(myMice);
            animals.Add(myParakeets);
            animals.Add(myTerrapins);
            animals.Add(myTimberRattlesnake);

            foreach (var bird in flyAnimals)
            {
                bird.Fly();
            }
            foreach (var digger in digAnimals)
            {
                digger.Dig();
            }
            foreach (var fish in swimAnimals)
            {
                fish.Swim();
            }
            foreach (var animal in groundAnimals)
            {
                animal.Crawl();
                animal.Dig();
            }
            foreach (var animal in animals)
            {
                animal.CleanCage();
            }
        }
    }
}