using System;
namespace Coordenadas
{
	public class Vector
	{
		private char direction;
		private int units;

		public char Direction() { return this.direction; }
		public void Direction(char direction) { this.direction = direction; }

		public int Units() { return this.units; }
		public void Units(int units) { this.units = units; }

		public Vector(String[] coords)
		{
			this.direction = Convert.ToChar(coords[0]);
			this.units = Int32.Parse(coords[1]);
		}

		//public void ParseCoordFromString(String coord)
		//{
		//	String[] arrayCoord = coord.Split(',');
		//	this.direction = arrayCoord[0].ToCharArray(0, 1)[0];
		//	this.units = Int32.Parse(arrayCoord[1]);
		//}

		public void Show()
		{
			Console.WriteLine("direction: " + direction + " units: " + units);
		}
	}
}
