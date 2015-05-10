using System;
using System.Collections.Generic;
using Labyrinth.Enum;

namespace Labyrinth.Entity
{
    public class Room : MapSite{
	    Dictionary<Direction, MapSite> _sides;

		public Room(int roomNo){
			RoomNumber = roomNo;
			_sides = new Dictionary<Direction, MapSite>();
		}
		
		public override void Enter(){
			Console.WriteLine("Room");
		}
		
		public MapSite GetSide(Direction direction){
			return _sides[direction];
		}
		
		public void SetSide(Direction direction, MapSite mapSide){
			_sides.Add(direction, mapSide);
		}

	    public int RoomNumber { get; set; }
	}
}