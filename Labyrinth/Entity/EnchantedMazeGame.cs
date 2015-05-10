namespace Labyrinth.Entity
{
    public class EnchantedMazeGame: MazeGame
    {
        public EnchantedMazeGame()
        {
            
        }

        public override Room MakeRoom(int number)
        {
            return new EnchantedRoom(number, CastSpell());
        }

        private Spell CastSpell()
        {
            return new Spell();
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            return new DoorNeedingSpell(room1, room2);
        }
    }
}