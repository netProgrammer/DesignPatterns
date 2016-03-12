using System;
using System.Collections.Generic;

namespace Component
{
    internal class Program
    {
        private static void Main()
        {
            IMapComponent city = BuidCity();
            DrawArea(city);

            IMapComponent road = city.FindChild("Main Street");
            DrawArea(road);

            IMapComponent house = city.FindChild("House 2");
            DrawArea(house);

            Console.ReadLine();
        }

        public static void DrawArea(IMapComponent component)
        {
            if (component == null)
            {
                throw  new ArgumentNullException();
            }

            Console.WriteLine("Drawing ...");
            component.Draw(0,0);
            Console.WriteLine("===========");
        }

        public static IMapComponent BuidCity()
        {
            IMapComposite road = new MapComposite {Title = "Main Street"};
            road.AddComponent(new MapRoad {Title = road.Title});
            road.AddComponent(new MapRoad {Title = road.Title});
            road.AddComponent(new MapLeftTurn {Title = road.Title});
            road.AddComponent(new MapRoad {Title = road.Title});
            road.AddComponent(new MapRightTurn {Title = road.Title});

            IMapComposite district = new MapComposite {Title = "District"};
            district.AddComponent(new MapHouse {Title = "House 1"});
            district.AddComponent(new MapHouse {Title = "House 2"});
            district.AddComponent(new MapHouse {Title = "House 3"});
            district.AddComponent(road);

            IMapComposite city = new MapComposite {Title = "New City"};
            city.AddComponent(district);

            return city;
        }
    }

    public interface IMapComponent
    {
        IMapComponent Parent { get; set; }
        string Title { get; set; }

        void Draw(int x, int y);
        IMapComponent FindChild(string title);
    }

    public abstract class MapComponent : IMapComponent
    {
        protected int X, Y;
        public IMapComponent Parent { get; set; }
        public string Title { get; set; }
        public abstract void Draw(int x, int y);

        public virtual IMapComponent FindChild(string title)
        {
            return (Title == title) ? this : null;
        }
    }

    public interface IMapComposite : IMapComponent
    {
        void AddComponent(IMapComponent component);
    }

    public class MapComposite : MapComponent, IMapComposite
    {
        private readonly List<IMapComponent> _components = new List<IMapComponent>();

        public override void Draw(int x, int y)
        {
            Console.WriteLine(Title);

            foreach (var component in _components)
            {
                component.Draw(X + x, Y + y);
            }
        }

        public void AddComponent(IMapComponent component)
        {
            _components.Add(component);
            component.Parent = this;
        }

        public override IMapComponent FindChild(string title)
        {
            var result = base.FindChild(title);
            if (result != null)
            {
                return result;
            }

            foreach (var component in _components)
            {
                result = component.FindChild(title);
                if (result != null)
                {
                    return result;
                }
            }

            return null;
        }
    }

    public class MapHouse : MapComponent
    {
        public override void Draw(int x, int y)
        {
            Console.WriteLine("{0} House", Title);
        }
    }

    public class MapRoad : MapComponent
    {
        public override void Draw(int x, int y)
        {
            Console.WriteLine("{0} Road", Title);
        }
    }

    public class MapLeftTurn : MapComponent
    {
        public override void Draw(int x, int y)
        {
            Console.WriteLine("{0} Left turn", Title);
        }
    }

    public class MapRightTurn : MapComponent
    {
        public override void Draw(int x, int y)
        {
            Console.WriteLine("{0} Right turn", Title);
        }
    }
}