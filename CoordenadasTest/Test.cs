using NUnit.Framework;
using System;
using Coordenadas;
namespace CoordenadasTest
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void PrimeiroCaso()
		{
			//Coordinate coord = new Coordinate(new char[] { 'N', '1' });
			Position position = new Position(new Coordinate(8, 12));
			Position finalPosition = new Position(new Coordinate(34, 10));

			// inicializa posição final
			Vector vector1 = new Vector(new string[] { "N", "23" });
			Vector vector2 = new Vector(new string[] { "O", "7" });
			Vector vector3 = new Vector(new string[] { "S", "40" });
			Vector vector4 = new Vector(new string[] { "L", "33" });
			Vector vector5 = new Vector(new string[] { "N", "15" });

			// deslocamento
			position.Move(vector1);
			position.Move(vector2);
			position.Move(vector3);
			position.Move(vector4);
			position.Move(vector5);

			Assert.AreEqual(finalPosition.Coordinates(), position.Coordinates(),
							"precisam ser iguais");

		}
	}
}
