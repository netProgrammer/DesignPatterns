using System;

namespace Labyrinth.Entity
{
    public class Wall : MapSite
    {
        public Wall()
        {
            
        }
        public override void Enter()
        {
            Console.WriteLine("Wall");
        }
    }
}