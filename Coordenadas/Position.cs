using System;
namespace Coordenadas
{
	public class Position
	{
		private Coordinate currentCoordinate;

		public Position(Coordinate coordinate)
		{
			this.currentCoordinate = coordinate;
		}

		public char[] Coordinates()
		{
			return this.currentCoordinate.Coordinates();
		}

		public void GoTo(Coordinate coord)
		{
			currentCoordinate.Units(currentCoordinate.Units() + coord.Units());
		}
	}
}
