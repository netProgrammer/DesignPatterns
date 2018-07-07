using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Singleton Pattern Demo***\n");
            Console.WriteLine("Try to create instance s1.");
            Singleton s1 = Singleton.Instance;
            Console.WriteLine("Try to create instance s2.");
            Singleton s2 = Singleton.Instance;
            if (s1 == s2)
            {
                Console.WriteLine("only one exists.");
            }
            else
            {
                Console.WriteLine("diffent instance exist.");
            }
            Console.ReadLine();
        }
    }

    internal class Singleton
    {
        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("We already have a instance now. Use it.");
                return SingletonInstance;
            }
        }

        private static readonly Singleton SingletonInstance = new Singleton();
        private int _numberOfInstances;

        private Singleton()
        {
            Console.WriteLine("Init inside private constructor.");
            _numberOfInstances++;
            Console.WriteLine("Number of instances = {0}", _numberOfInstances);
        }
    }
}