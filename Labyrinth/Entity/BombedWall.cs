using System;

namespace Labyrinth.Entity
{
    public class BombedWall : Wall
    {
        public BombedWall()
        {
            
        }
        public override void Enter()
        {
            Console.WriteLine("BombedWall");
        }
    }
}