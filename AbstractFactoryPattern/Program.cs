using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***Abstract Factory Pattern***\n");
            
            IAnimalFactory wildAnimalFactory = new WildAnimalFactory();
            IDog wilDog = wildAnimalFactory.GetDog();
            wilDog.Speak();
            wilDog.Action();

            ITiger wildTiger = wildAnimalFactory.GetTiger();
            wildTiger.Speak();
            wildTiger.Action();
            
            
        }
    }

    internal interface ITiger
    {
        void Speak();
        void Action();
    }

    internal interface IDog
    {
        void Speak();
        void Action();
    }

    internal class WildAnimalFactory : IAnimalFactory
    {
        public IDog GetDog()
        {
            return new Dog();
        }

        public ITiger GetTiger()
        {
            return new Tiger();
        }
    }

    internal class Tiger : ITiger
    {
        public void Speak()
        {
            Console.WriteLine("Wild Tiger says: Halum.");
        }
        public void Action()
        {
            Console.WriteLine("Wild Tigers prefer hunting in jungles.\n");
        }
    }

    internal class Dog : IDog
    {
        public void Speak()
        {
            Console.WriteLine("Wild Dog says: Bow-Wow.");
        }
        public void Action()
        {
            Console.WriteLine("Wild Dogs prefer to roam freely in jungles.\n");
        }
    }

    internal interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();
    }
}