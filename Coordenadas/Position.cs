using System;
namespace Coordenadas
{
	public class Position
	{
		private Coordinate coordinates;

		public Position(Coordinate coordinates)
		{
			this.coordinates = coordinates;
		}

		public String Coordinates()
		{
			return "(" + coordinates.X().ToString() + ","+ coordinates.Y().ToString() + ")";
		}

		public void Move(Vector vector)
		{
			switch (vector.Direction())
			{
				case 'N':
					MoveNorth(vector.Units());
					break;

				case 'S':
					MoveSouth(vector.Units());
					break;

				case 'L':
					MoveEast(vector.Units());
					break;
				case 'O':
					MoveWest(vector.Units());
					break;
			}
		}

		private void MoveWest(int units)
		{
			coordinates.X(coordinates.X() - units);
		}

		private void MoveEast(int units)
		{
			coordinates.X(coordinates.X() + units);
		}

		private void MoveSouth(int units)
		{
			coordinates.Y(coordinates.Y() - units);
		}

		private void MoveNorth(int units)
		{
			coordinates.Y(coordinates.Y() + units);
		}
	}
}
