using Labyrinth.Entity;

namespace Labyrinth.DesignLPatterns.AbstractFactory
{
    public interface IMazeFactory
    {
        Maze MakeMaze();
        Wall MakeWall();
        Room MakeRoom(int number);
        Door MakeDoor(Room room1, Room room2);
    }
}