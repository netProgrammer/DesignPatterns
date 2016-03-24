using System;

namespace EventSample
{
    class Program
    {
        static void Main()
        {
            Counter counter = new Counter();
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();

            counter.OnCount += handler1.Message;
            counter.OnCount += handler2.Message;

            counter.Count();
            Console.ReadLine();
        }
    }

    class Counter
    {
        public delegate void MethodContainer();

        public event MethodContainer OnCount;

        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 71)
                {
                    if (OnCount != null) OnCount();
                }
            }
        }
    }

    class Handler1
    {
        public void Message()
        {
            Console.WriteLine("It's time, counter is 71");
        }
    }

    class Handler2
    {
        public void Message()
        {
            Console.WriteLine("Exactly, counter is 71");
        }
    }
}
