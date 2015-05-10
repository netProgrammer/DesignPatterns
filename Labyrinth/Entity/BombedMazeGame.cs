namespace Labyrinth.Entity
{
    public class BombedMazeGame : MazeGame
    {
        public BombedMazeGame()
        {
            
        }

        public override MapSite MakeWall()
        {
            return new BombedWall();
        }

        public override Room MakeRoom(int number)
        {
            return new RoomWithBomb(number);
        }
    }
}