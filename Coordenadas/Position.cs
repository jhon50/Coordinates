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

		/**
		 * Apply vector to position, by doing so we are moving
		 * the current position depending on vector direction
		 * and units to move.
		 * 
		 * @param Vector vector 
		 **/
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
				default :
					throw new Exception();
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
