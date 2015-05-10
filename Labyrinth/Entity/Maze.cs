using System.Collections.Generic;

namespace Labyrinth.Entity
{
    public class Maze
    {
        private Dictionary<int, Room> _rooms;

        public Maze()
        {
            _rooms = new Dictionary<int, Room>();
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room.RoomNumber, room);
        }

        public Room RoomNo(int number)
        {
            return _rooms[number];
        }
    }
}