namespace Labyrinth.Entity
{
    public class EnchantedRoom : Room
    {
        private Spell _spell;

        public EnchantedRoom(int roomNo) : base(roomNo)
        {
        }

        public EnchantedRoom(int roomNo, Spell spell) : base(roomNo)
        {
            _spell = spell;
        }
    }
}