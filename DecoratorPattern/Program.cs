using System;

namespace DecoratorPattern
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("***Decorator pattern***\n");
            ConcreteComponent cc = new ConcreteComponent();

            ConcreteDecoratorEx1 dc1 = new ConcreteDecoratorEx1();
            dc1.SetTheComponent(cc);
            dc1.MakeHouse();

            ConcreteDecoratorEx2 dc2 = new ConcreteDecoratorEx2();
            dc2.SetTheComponent(dc1);
            dc2.MakeHouse();

            Console.ReadLine();
        }
    }

    internal class ConcreteDecoratorEx2: Decorator
    {
        public override void MakeHouse()
        {
            base.MakeHouse();
            PaintTheHouse();
        }

        private void PaintTheHouse()
        {
            Console.WriteLine("Now I am painting the house.");
        }
    }

    internal class ConcreteDecoratorEx1: Decorator
    {
        public override void MakeHouse()
        {
            base.MakeHouse();
            AddFloor();
        }

        private void AddFloor()
        {
            Console.WriteLine("I am making an additional floor.");
        }
    }

    abstract class Decorator: IComponent
    {
        private IComponent _component;

        public void SetTheComponent(IComponent com)
        {
            _component = com;
        }
        
        public virtual void MakeHouse()
        {
            _component?.MakeHouse();
        }
    }

    internal class ConcreteComponent: IComponent
    {
        public void MakeHouse()
        {
            Console.WriteLine("Original house is complete. It is closed for modification.");
        }
    }

    interface IComponent
    {
        void MakeHouse();
    }
}