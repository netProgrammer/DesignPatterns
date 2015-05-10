using System;

namespace Labyrinth.Entity
{
    public class Door : MapSite
    {
        private readonly Room _roomFrst;
        private readonly Room _roomScnd;
        private bool _isOpen;

        public Door(Room room1, Room room2)
        {
            _roomFrst = room1;
            _roomScnd = room2;
        }

        public override void Enter()
        {
            Console.WriteLine("Door");
        }

        public Room OtherSide(Room room)
        {
            return room == _roomFrst ? _roomScnd : _roomFrst;
        }
    }
}