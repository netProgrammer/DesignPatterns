using System;

namespace HelloDI
{
    class Program
    {
        static void Main()
        {
            IMessageWriter writer = new ConsoleMessageWriter();
            var salutation = new Salutation(writer);
            salutation.Exclaim();
        }
    }

    internal class Salutation
    {
        private readonly IMessageWriter _messageWriter;
        public Salutation(IMessageWriter messageWriter)
        {
            _messageWriter = messageWriter;
        }

        public void Exclaim()
        {
            _messageWriter.Write("Hello DI!");
        }
    }

    internal class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }

    internal interface IMessageWriter
    {
        void Write(string message);
    }
}
