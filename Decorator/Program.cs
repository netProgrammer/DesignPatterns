using System;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            Component component = new Component();
            DecoratorImplA decoratorA = new DecoratorImplA();
            DecoratorImplB decoratorB = new DecoratorImplB();

            decoratorA.SetComponent(component);
            decoratorB.SetComponent(decoratorA);

            decoratorA.DoSomething();
            decoratorB.DoSomething();

            Console.ReadLine();
        }
    }

    interface IComponent
    {
        void DoSomething();
    }

    class Component : IComponent
    {
        public void DoSomething()
        {
           Console.WriteLine("Component");    
        }
    }

    abstract class Decorator : IComponent
    {
        private IComponent _component;

        public void SetComponent(IComponent component)
        {
            _component = component;
        }

        public virtual void DoSomething()
        {
            if (_component != null)
            {
                _component.DoSomething();
            }
        }
    }

    class DecoratorImplA : Decorator
    {
        
    }

    class DecoratorImplB : Decorator
    {
        public override void DoSomething()
        {
            base.DoSomething();
            Console.WriteLine("DecoratorImplB");
        }
    }
}
