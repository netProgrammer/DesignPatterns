using System;

namespace NullObject
{
    class Program
    {
        static void Main()
        {
            ISomeObject realObject = new SomeObject();
            realObject.DoSomething();

            ISomeObject nullObject = new NullObject();
            nullObject.DoSomething();

            Console.ReadLine();
        }
    }

    interface ISomeObject
    {
        void DoSomething();
    }

    class NullObject : ISomeObject
    {
        public void DoSomething()
        {
            //Nothing
        }
    }

    class SomeObject : ISomeObject
    {
        public void DoSomething()
        {
            Console.WriteLine("Just do It !");
        }
    }
}
