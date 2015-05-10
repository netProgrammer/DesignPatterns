using Labyrinth.Entity;

namespace Labyrinth.DesignLPatterns.AbstractFactory
{
    public class BombedMazeFactory : MazeFactory
    {
        public virtual Wall MakeWall()
        {
            return new BombedWall();
        }

        public virtual Room MakeRoom(int number)
        {
            return new RoomWithBomb(number);
        }
    }
}