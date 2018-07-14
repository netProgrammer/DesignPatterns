using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***Proxy Pattern Demo***\n");
            ISubject px = new Proxy();
            px.DoSomeWork();
            Console.ReadKey();
        }
    }

    internal class Proxy: ISubject
    {
        private ISubject _subject;
        public void DoSomeWork()
        {
            Console.WriteLine("Proxy call happening");
            if (_subject == null)
            {
                _subject = new ConcreteSubject();                
            }
            
            _subject.DoSomeWork();
        }
    }

    interface ISubject
    {
        void DoSomeWork();
    } 
    
    internal class ConcreteSubject: ISubject
    {
        public void DoSomeWork()
        {
            Console.WriteLine("ConcreteSubject.DoSomeWork");
        }
    }
}