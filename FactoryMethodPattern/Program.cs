using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***Factory Pattern Demo***\n");
            
            IAnimalFactory tigerFactory = new TigerFactory();
            IAnimal aTiger = tigerFactory.CreateAnimal();
            aTiger.Speak();
            aTiger.Action();
            
            IAnimalFactory dogFactory = new DogFactory();
            IAnimal aDog = dogFactory.CreateAnimal();
            aDog.Speak();
            aDog.Action();
            
            Console.ReadLine();
        }
    }

    internal interface IAnimal
    {
        void Speak();
        void Action();
    }

    internal interface IAnimalFactory
    {
        IAnimal CreateAnimal();
    }

    internal class DogFactory: IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }

    internal class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog says: Bow-Wow.");
        }

        public void Action()
        {
            Console.WriteLine("Dogs prefer barking...\n");
        }
    }

    internal class TigerFactory: IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            return new Tiger();
        }
    }

    internal class Tiger : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Tiger says: Halum.");
        }

        public void Action()
        {
            Console.WriteLine("Tigers prefer hunting...\n");
        }
    }
}