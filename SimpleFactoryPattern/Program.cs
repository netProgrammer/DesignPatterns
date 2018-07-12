using System;

namespace SimpleFactoryPattern
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("*** Simple Factory Pattern Demo***\n");
            IAnimal preferredType = null;
            ISimpleFactory simpleFactory = new SimpleFactory();

            #region The code region that will vary based on users preference
                preferredType = simpleFactory.CreateAnimal();
            #endregion

            #region The codes that do not change frequently

            preferredType.Speak();
            preferredType.Action();

            #endregion

            Console.ReadKey();
        }
    }

    internal class SimpleFactory : ISimpleFactory
    {
        public IAnimal CreateAnimal()
        {
            IAnimal intendedAnimal=null;
            Console.WriteLine("Enter your choice(0 for Dog, 1 for Tiger)");
            string b1 = Console.ReadLine();
            int input;
            if (int.TryParse(b1, out input))
            {
                Console.WriteLine("You have entered {0}", input);
                switch (input)
                {
                    case 0:
                        intendedAnimal = new Dog();
                        break;
                    case 1:
                        intendedAnimal = new Tiger();
                        break;
                    default:
                        Console.WriteLine("You must enter either 0 or 1");
                        throw new ApplicationException(" Unknown Animal cannot be instantiated");
                }
            }
            return intendedAnimal;
        }
    }

    internal interface ISimpleFactory
    {
        IAnimal CreateAnimal();
    }

    internal interface IAnimal
    {
        void Speak();
        void Action();
    }
    
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Dog says: Bow-Wow.");
        }
        public void Action()
        {
            Console.WriteLine("Dogs prefer barking...");
        }
    }
    public class Tiger : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Tiger says: Halum.");
        }
        public void Action()
        {
            Console.WriteLine("Tigers prefer hunting...");
        }
    }
}