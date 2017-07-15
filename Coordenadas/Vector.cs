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
	}
}
