using Labyrinth.Entity;

namespace Labyrinth.DesignLPatterns.Builder
{
    public interface IMazeBuider
    {
        void BuildMaze();
        void BuildRoom(int roomNo);
        void BuildDoor(int roomFrom, int roomTo);
        Maze GetMaze();
    }
}