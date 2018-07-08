using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***Prototype Pattern Demo***\n");
            BasicCar nanoBase = new Nano("Green Nano") {Price = 10000};
            BasicCar fordBase = new Ford("Ford Yellow") {Price = 5000};
            
            BasicCar bc1 = nanoBase.Clone();
            bc1.Price = nanoBase.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1}", bc1.ModelName, bc1.Price);
            
            bc1= fordBase.Clone();
            bc1.Price = fordBase.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1}", bc1.ModelName, bc1.Price);
            
            Console.ReadLine();
        }
    }

    internal class Ford : BasicCar
    {
        public Ford(string name)
        {
            ModelName = name;
        }

        public override BasicCar Clone()
        {
            return (Ford)MemberwiseClone();
        }
    }

    internal class Nano : BasicCar
    {
        public Nano(string name)
        {
            ModelName = name;
        }

        public override BasicCar Clone()
        {
            return (Nano)MemberwiseClone();
        }
    }

    public abstract class BasicCar
    {
        public string ModelName { get; protected set; }
        public int Price { get; set; }

        public static int SetPrice()
        {
            Random r = new Random();
            return r.Next(20000, 50000);
        }

        public abstract BasicCar Clone();
    }
}