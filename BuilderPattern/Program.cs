using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***Builder Pattern Demo***\n");
            Director director = new Director();

            IBuilder b1 = new Car("Ford");
            IBuilder b2 = new MotorCycle("Honda");

            director.Construct(b1);
            Product p1 = b1.GetVehicle();
            p1.Show();
            
            director.Construct(b2);
            Product p2 = b2.GetVehicle();
            p2.Show();
            
            Console.ReadLine();
        }
    }

    internal class MotorCycle : IBuilder
    {
        private readonly Product _product;
        private readonly string _brandname;

        public MotorCycle(string name)
        {
            _product = new Product();
            _brandname = name;
        }

        public void StartUpOperation()
        {
           //Nothing in this case
        }

        public void BuildBody()
        {
            _product.Add("This is body of a Motorcycle");
        }

        public void InsertWheels()
        {
            _product.Add("2 wheels are added");
        }

        public void AddHeadlights()
        {
            _product.Add("1 Headlights are added");
        }

        public void EndOperations()
        {
            _product.Add(string.Format("Motocycle Model name:{0}", _brandname));
        }

        public Product GetVehicle()
        {
            return _product;
        }
    }

    internal class Car : IBuilder
    {
        private readonly Product _product;
        private readonly string _brandname;
        
        public Car(string name)
        {
            _product = new Product();
            _brandname = name;
        }

        public void StartUpOperation()
        {
            _product.Add(string.Format("Car Model name:{0}", _brandname));
        }

        public void BuildBody()
        {
            _product.Add("This is body of a Car");
        }

        public void InsertWheels()
        {
            _product.Add("4 wheels are added");
        }

        public void AddHeadlights()
        {
            _product.Add("2 Headlights are added");
        }

        public void EndOperations()
        {
            //Nothing in this case           
        }

        public Product GetVehicle()
        {
            return _product;
        }
    }

    internal class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.StartUpOperation();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadlights();
            builder.EndOperations();
        }
    }

    interface IBuilder
    {
        void StartUpOperation();
        void BuildBody();
        void InsertWheels();
        void AddHeadlights();
        void EndOperations();
        Product GetVehicle();
    }

    internal class Product
    {
        private readonly LinkedList<string> _parts;

        public Product()
        {
            _parts = new LinkedList<string>();
        }

        public void Add(string part)
        {
            _parts.AddLast(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct completed as below:");
            foreach (var part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}