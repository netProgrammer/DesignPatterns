using Labyrinth.Entity;
using Labyrinth.Enum;

namespace Labyrinth.DesignLPatterns.Builder
{
    public class MazeBuilder: IMazeBuider
    {
        private Maze _currentMaze;

        public MazeBuilder()
        {
            _currentMaze = null;
        }

        public void BuildMaze()
        {
            _currentMaze = new Maze();
        }

        public void BuildRoom(int roomNo)
        {
            if (_currentMaze.RoomNo(roomNo) == null)
            {
                Room room = new Room(roomNo);
                _currentMaze.AddRoom(room);

                room.SetSide(Direction.North, new Wall());
                room.SetSide(Direction.East, new Wall());
                room.SetSide(Direction.South, new Wall());
                room.SetSide(Direction.West, new Wall());
            }
        }

        public void BuildDoor(int roomFrom, int roomTo)
        {
            Room room1 = _currentMaze.RoomNo(roomFrom);
            Room room2 = _currentMaze.RoomNo(roomTo);
            Door door = new Door(room1, room2);

            room1.SetSide(CommonWall(room1, room2), door);
            room1.SetSide(CommonWall(room2, room1), door);
        }

        private Direction CommonWall(Room room1, Room room2)
        {
            if (room1.GetSide(Direction.West) is Wall &&
                room1.GetSide(Direction.East) is Wall &&
                room1.GetSide(Direction.South) is Wall &&
                room1.GetSide(Direction.North) is Wall &&
                room2.GetSide(Direction.West) is Wall &&
                room2.GetSide(Direction.East) is Wall &&
                room2.GetSide(Direction.South) is Wall &&
                room2.GetSide(Direction.North) is Wall)
            {
                return Direction.East;
            }
            else
            {
                return Direction.West;
            }
        }

        public Maze GetMaze()
        {
            return _currentMaze;
        }
    }
}