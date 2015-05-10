using Labyrinth.DesignLPatterns.AbstractFactory;
using Labyrinth.DesignLPatterns.Builder;
using Labyrinth.Enum;

namespace Labyrinth.Entity
{
    public class MazeGame
    {
        //TODO 1
        /*public Maze CreateMaze()
        {
            Maze maze = new Maze();
            Room room1 = new Room(1);
            Room room2 = new Room(2);
            Door door = new Door(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, new Wall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, new Wall());
            room1.SetSide(Direction.West, new Wall());

            room2.SetSide(Direction.North, new Wall());
            room2.SetSide(Direction.East, new Wall());
            room2.SetSide(Direction.South, new Wall());
            room2.SetSide(Direction.West, door);

            return maze;
        }*/

        //TODO 2
        /*private IMazeFactory _factory;

        public Maze CreateMaze(IMazeFactory factory)
        {
            _factory = factory;
            Maze maze = _factory.MakeMaze();
            Room room1 = _factory.MakeRoom(1);
            Room room2 = _factory.MakeRoom(2);
            Door door = _factory.MakeDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, _factory.MakeWall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, _factory.MakeWall());
            room1.SetSide(Direction.West, _factory.MakeWall());

            room2.SetSide(Direction.North, _factory.MakeWall());
            room2.SetSide(Direction.East, _factory.MakeWall());
            room2.SetSide(Direction.South, _factory.MakeWall());
            room2.SetSide(Direction.West, door);

            return maze;
        }*/

        public Maze CreateMaze(IMazeBuider buider)
        {
            buider.BuildMaze();
            buider.BuildRoom(1);
            buider.BuildRoom(2);
            buider.BuildDoor(1,2);

            return buider.GetMaze();
        }
    }
}