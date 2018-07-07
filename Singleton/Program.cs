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
                if (SingletonInstance == null)
                {
                    lock (lockObject)
                    {
                        if (SingletonInstance == null)
                            SingletonInstance = new Singleton();
                    }
                }
                return SingletonInstance;
            }
        }

        private static volatile Singleton SingletonInstance;
        private int _numberOfInstances;
        private static object lockObject= new Object();

        private Singleton()
        {
            Console.WriteLine("Init inside private constructor.");
            _numberOfInstances++;
            Console.WriteLine("Number of instances = {0}", _numberOfInstances);
        }
    }
}